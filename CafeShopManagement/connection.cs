using System.Data;
using System.Data.SqlClient;

namespace CafeShopManagement
{
    internal class Connection
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = @"Data Source=DESKTOP-E3574KG\DBSERVER;Initial Catalog=CafeShop Management;Integrated Security=True;";
            return new SqlConnection(connectionString);
        }
    }
}
