using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace CafeShopManagement
{
    public class SalesData
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Total { get; set; }
        public string ConfirmOrderBy { get; set; }
        public DateTime SaleDate { get; set; }
        public bool Status { get; set; }
        public string StatusText => Status ? "Sold" : "Canceled";
        public int ProductId { get; set; }
        public int StaffId { get; set; }

        public List<SalesData> GetSalesList()
        {
            List<SalesData> salesList = new List<SalesData>();
            using (SqlConnection localConnect = Connection.GetConnection())
            {
                try
                {
                    localConnect.Open();
                    string selectData = @"
                        SELECT s.id, s.customer_name, p.name AS product_name, s.quantity, s.unit_price, s.discount, s.subtotal, s.total,
                                st.name AS staff_name, s.sale_date, s.status,
                                s.stock_id, s.staff_id
                        FROM sales s
                        JOIN stocks p ON s.stock_id = p.id
                        JOIN staffs st ON s.staff_id = st.id
                        WHERE s.status = 1";

                    using (SqlCommand cmd = new SqlCommand(selectData, localConnect))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            SalesData salesdata = new SalesData
                            {
                                Id = (int)reader["id"],
                                CustomerName = reader["customer_name"].ToString(),
                                ProductName = reader["product_name"].ToString(),
                                Quantity = (int)reader["quantity"],
                                Price = Convert.ToDecimal(reader["unit_price"]),
                                Discount = reader["discount"] == DBNull.Value ? 0.0m : Convert.ToDecimal(reader["discount"]),
                                SubTotal = Convert.ToDecimal(reader["subtotal"]),
                                Total = Convert.ToDecimal(reader["total"]),
                                ConfirmOrderBy = reader["staff_name"].ToString(),
                                SaleDate = Convert.ToDateTime(reader["sale_date"]),
                                Status = Convert.ToBoolean(reader["status"]),
                                ProductId = (int)reader["stock_id"],
                                StaffId = (int)reader["staff_id"]
                            };
                            salesList.Add(salesdata);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error getting sales data: " + ex.Message);
                    MessageBox.Show("Error loading sales data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return salesList;
        }

        public SalesData GetSaleById(int saleId)
        {
            SalesData sale = null;
            using (SqlConnection connect = Connection.GetConnection())
            {
                try
                {
                    connect.Open();
                    string query = @"
                        SELECT s.id, s.customer_name, p.name AS product_name, s.quantity, s.unit_price, s.discount, s.subtotal, s.total,
                               st.name AS staff_name, s.sale_date, s.status,
                               s.stock_id, s.staff_id
                        FROM sales s
                        JOIN stocks p ON s.stock_id = p.id
                        JOIN staffs st ON s.staff_id = st.id
                        WHERE s.id = @saleId AND s.status = 1";

                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@saleId", saleId);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                sale = new SalesData
                                {
                                    Id = (int)reader["id"],
                                    CustomerName = reader["customer_name"].ToString(),
                                    ProductName = reader["product_name"].ToString(),
                                    Quantity = (int)reader["quantity"],
                                    Price = Convert.ToDecimal(reader["unit_price"]),
                                    Discount = reader["discount"] == DBNull.Value ? 0.0m : Convert.ToDecimal(reader["discount"]),
                                    SubTotal = Convert.ToDecimal(reader["subtotal"]),
                                    Total = Convert.ToDecimal(reader["total"]),
                                    ConfirmOrderBy = reader["staff_name"].ToString(),
                                    SaleDate = Convert.ToDateTime(reader["sale_date"]),
                                    Status = Convert.ToBoolean(reader["status"]),
                                    ProductId = (int)reader["stock_id"],
                                    StaffId = (int)reader["staff_id"]
                                };
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving sale by ID: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return sale;
        }

        public List<SalesData> GetFilteredSalesList(string customerName, DateTime? saleDate)
        {
            List<SalesData> salesList = new List<SalesData>();
            using (SqlConnection connect = Connection.GetConnection())
            {
                try
                {
                    connect.Open();
                    StringBuilder queryBuilder = new StringBuilder();
                    queryBuilder.Append(@"
                        SELECT s.id, s.customer_name, s.stock_id, p.name AS product_name,
                               s.quantity, s.unit_price, s.discount, s.subtotal, s.total,
                               st.name AS staff_name, s.sale_date, s.status,
                               s.staff_id
                        FROM sales AS s
                        JOIN stocks AS p ON s.stock_id = p.id
                        JOIN staffs AS st ON s.staff_id = st.id
                        WHERE s.status = 1");

                    List<SqlParameter> parameters = new List<SqlParameter>();

                    if (!string.IsNullOrWhiteSpace(customerName))
                    {
                        queryBuilder.Append(" AND s.customer_name LIKE @customerName");
                        parameters.Add(new SqlParameter("@customerName", "%" + customerName + "%"));
                    }

                    if (saleDate.HasValue)
                    {
                        queryBuilder.Append(" AND CAST(s.sale_date AS DATE) = @saleDate");
                        parameters.Add(new SqlParameter("@saleDate", saleDate.Value.Date));
                    }

                    using (SqlCommand cmd = new SqlCommand(queryBuilder.ToString(), connect))
                    {
                        cmd.Parameters.AddRange(parameters.ToArray());

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                salesList.Add(new SalesData
                                {
                                    Id = Convert.ToInt32(reader["id"]),
                                    CustomerName = reader["customer_name"].ToString(),
                                    ProductId = Convert.ToInt32(reader["stock_id"]),
                                    ProductName = reader["product_name"].ToString(),
                                    Quantity = Convert.ToInt32(reader["quantity"]),
                                    Price = Convert.ToDecimal(reader["unit_price"]),
                                    Discount = reader["discount"] == DBNull.Value ? 0.0m : Convert.ToDecimal(reader["discount"]),
                                    SaleDate = Convert.ToDateTime(reader["sale_date"]),
                                    StaffId = Convert.ToInt32(reader["staff_id"]),
                                    ConfirmOrderBy = reader["staff_name"].ToString(),
                                    Status = Convert.ToBoolean(reader["status"]),
                                    SubTotal = Convert.ToDecimal(reader["subtotal"]),
                                    Total = Convert.ToDecimal(reader["total"])
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error getting filtered sales list: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return salesList;
        }

        public void AddSale(OrderData order, SqlTransaction transaction)
        {
            SqlConnection con = transaction.Connection;
            try
            {
                string insertQuery = @"INSERT INTO sales
                                       (customer_name, stock_id, quantity, unit_price, discount, sale_date, staff_id, status)
                                       VALUES
                                       (@customer_name, @stock_id, @quantity, @unit_price, @discount, @sale_date, @staff_id, @status)";

                using (SqlCommand cmd = new SqlCommand(insertQuery, con, transaction))
                {
                    cmd.Parameters.AddWithValue("@customer_name", order.CustomerName);
                    cmd.Parameters.AddWithValue("@stock_id", order.StockId);
                    cmd.Parameters.AddWithValue("@quantity", order.Quantity);
                    cmd.Parameters.AddWithValue("@unit_price", order.Price);
                    cmd.Parameters.AddWithValue("@discount", order.Discount == 0.0m ? DBNull.Value : (object)order.Discount);
                    cmd.Parameters.AddWithValue("@sale_date", DateTime.Now);
                    cmd.Parameters.AddWithValue("@staff_id", order.StaffId);
                    cmd.Parameters.AddWithValue("@status", true);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error adding sale to database: " + ex.Message, ex);
            }
        }
    }
}