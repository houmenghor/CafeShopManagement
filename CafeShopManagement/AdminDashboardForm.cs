using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeShopManagement
{
    public partial class AdminDashboardForm : UserControl
    {
        SqlConnection connect = Connection.GetConnection();
        public AdminDashboardForm()
        {
            InitializeComponent();
        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            int totalStock = GetTotalStock();
            txtTotalStock.Text = totalStock.ToString(); // txtTotalStock គឺជា Label ឬ TextBox

            int totalStaff = GetTotalStaff();
            txtTotal.Text = totalStaff.ToString(); // txtTotal គឺជា Label ឬ TextBox

            int totalOrder = GetTotalOrder();
            txtTotalOrder.Text = totalOrder.ToString(); // txtTotalOrder គឺជា Label ឬ TextBox
        }

        private int GetTotalStaff()
        {
            int total = 0;

            try
            {
                if (connect.State != ConnectionState.Open)
                    connect.Open();

                string query = "SELECT COUNT(*) FROM staffs WHERE status = '1'"; // បន្ទាត់នេះរាប់តែបុគ្គលិកសកម្ម

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    total = (int)cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to get total staff: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                    connect.Close();
            }

            return total;
        }

        public void LoadTotalStaff()
        {
            try
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM staffs WHERE status=1", connect);
                int total = (int)cmd.ExecuteScalar();
                txtTotal.Text = total.ToString(); // Use the correct label name
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading total staff: " + ex.Message);
                connect.Close();
            }
        }

        private int GetTotalStock()
        {
            int totalStock = 0;

            try
            {
                connect.Open();

                string query = "SELECT SUM(qty) FROM stocks WHERE status = '1'"; // Change table/field as needed

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        totalStock = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to get total stock: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }

            return totalStock;
        }

        public void LoadTotalStock()
        {
            try
            {
                int total = GetTotalStock();
                txtTotalStock.Text = total.ToString(); // Make sure txtTotalStock is defined
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading total stock: " + ex.Message);
            }
        }

        private int GetTotalOrder()
        {
            int totalOrder = 0;
            try
            {
                connect.Open();

                string query = "SELECT COUNT(*) FROM orders WHERE status = '1'"; // Assuming 'status' indicates active orders

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        totalOrder = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading total orders: " + ex.Message);
            }
            finally
            {
                connect.Close();
            }
            return totalOrder;
        }

        public void LoadTotalOrder()
        {
            try
            {

                int totalOrder = GetTotalOrder();
                txtTotalOrder.Text = totalOrder.ToString(); // Make sure txtTotalOrder is defined
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading total orders: " + ex.Message);
            }
        }

        private void txtTotalOrder_Click(object sender, EventArgs e)
        {

        }
    }
}
