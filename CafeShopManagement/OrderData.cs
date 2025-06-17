using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeShopManagement
{
    // Change 'internal' to 'public' here
    public class OrderData
    {
        SqlConnection connect = Connection.GetConnection();

        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; } // Corresponds to unit_price
        public decimal Discount { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Total { get; set; }

        // NEW: Add properties to hold the foreign key IDs
        public int StockId { get; set; } // Will store the stock_id (or product_id, ensure consistency with DB)
        public int StaffId { get; set; } // Will store the staff_id

        public string ConfirmOrderBy { get; set; } // Staff name for display
        public DateTime OrderDate { get; set; }
        public bool Status { get; set; }
        public string StatusText => Status ? "Pending" : "Canceled";

        public List<OrderData> GetOrderList()
        {
            List<OrderData> orderList = new List<OrderData>();

            try
            {
                connect.Open();
                string selectData = @"
            SELECT o.id, o.customer_name, s.name AS product_name, o.quantity, o.unit_price, o.discount, o.subtotal, o.total,
                   st.name AS staff_name, o.order_date, o.status,
                   o.stock_id, o.staff_id -- Now selecting stock_id and staff_id
            FROM orders o
            JOIN stocks s ON o.stock_id = s.id
            JOIN staffs st ON o.staff_id = st.id
            WHERE o.status = 1"; // Assuming status 1 means pending orders

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        OrderData orderdata = new OrderData();
                        orderdata.Id = (int)reader["id"];
                        orderdata.CustomerName = reader["customer_name"].ToString();
                        orderdata.ProductName = reader["product_name"].ToString();
                        orderdata.Quantity = (int)reader["quantity"];
                        orderdata.Price = Convert.ToDecimal(reader["unit_price"]);
                        orderdata.Discount = reader["discount"] == DBNull.Value ? 0 : Convert.ToDecimal(reader["discount"]);
                        orderdata.SubTotal = Convert.ToDecimal(reader["subtotal"]);
                        orderdata.Total = Convert.ToDecimal(reader["total"]);
                        orderdata.ConfirmOrderBy = reader["staff_name"].ToString();
                        orderdata.OrderDate = Convert.ToDateTime(reader["order_date"]);
                        orderdata.Status = Convert.ToBoolean(reader["status"]);

                        // Populate StockId and StaffId
                        orderdata.StockId = (int)reader["stock_id"];
                        orderdata.StaffId = (int)reader["staff_id"];

                        orderList.Add(orderdata);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Connection Failed: " + ex.Message);
            }
            finally
            {
                connect.Close();
            }

            return orderList;
        }
    }
}