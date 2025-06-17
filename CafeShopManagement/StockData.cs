using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeShopManagement
{
    internal class StockData
    {
        SqlConnection connect = Connection.GetConnection();

        public int Id { get; set; }

        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public DateTime EntryDate { get; set; }

        public string AddedBy { get; set; }
        public bool Status { get; set; }

        public List<StockData> GetStockList()
        {
            List<StockData> stocklist = new List<StockData>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    //string selectData = "SELECT * FROM stocks WHERE status ='1' ";

                    //join with staffs table to get staff name
                    string selectData = "SELECT s.id, s.name, s.qty, s.created_at, s.status, st.name AS staff_name FROM stocks s JOIN staffs st ON s.staff_id = st.id WHERE s.status = 1";


                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {

                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            StockData stockData = new StockData();
                            stockData.Id = (int)reader["id"];
                            stockData.ProductName = reader["name"].ToString();
                            stockData.Quantity = (int)reader["qty"];
                            stockData.EntryDate = Convert.ToDateTime(reader["created_at"]);
                            stockData.Status = Convert.ToBoolean(reader["status"]);
                            stockData.AddedBy = reader["staff_name"].ToString();
                            stocklist.Add(stockData);

                        }

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Connection Failed: " + ex);
                }
                finally
                {
                    connect.Close();
                }
            }
            return stocklist;
        }
    }
}
