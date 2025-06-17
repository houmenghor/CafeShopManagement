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
    public partial class AdminMainForm : Form
    {

        SqlConnection connect = Connection.GetConnection();

        private string fullName;
        private string profileImagePath;
        private string userRole;

        public AdminMainForm(string? name, string? imagePath, string? role)
        {
            InitializeComponent();
            // Pass saleForm1 reference to orderForm1
            orderForm1.SetSaleFormReference(saleForm1);
            adminDashboardForm1.BringToFront();
            staffInformation1.SendToBack();
            adminAddProducts1.SendToBack();
            orderForm1.SendToBack();
            saleForm1.SendToBack();

            fullName = name;
            profileImagePath = imagePath;
            userRole = role;

        }

        private void close_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void adminAddUser1_Load(object sender, EventArgs e)
        {

        }

        private void logout_btn_Click_1(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to Sign out?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();

                this.Hide();
            }
        }

        private void staffInformation1_Load(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            adminDashboardForm1.BringToFront();
            staffInformation1.SendToBack();
            adminAddProducts1.SendToBack();
            orderForm1.SendToBack();
            saleForm1.SendToBack();
            // 👉 Refresh total staff count when going back to dashboard
            adminDashboardForm1.LoadTotalStaff();
            adminDashboardForm1.LoadTotalStock();
            adminDashboardForm1.LoadTotalOrder();
        }

        private void btnStockInformation_Click(object sender, EventArgs e)
        {
            adminDashboardForm1.SendToBack();
            adminAddProducts1.BringToFront();
            staffInformation1.SendToBack();
            orderForm1.SendToBack();
            saleForm1.SendToBack();
            adminAddProducts1.RefreshStaffComboBox(); // 👉 Force reload staff list when opening stock
            adminAddProducts1.DisplayData(); // 👉 Refresh stock data when going to stock information
        }

        private void btnStaffInformation_Click(object sender, EventArgs e)
        {
            adminDashboardForm1.SendToBack();
            adminAddProducts1.SendToBack();
            staffInformation1.BringToFront();
            orderForm1.SendToBack();
            saleForm1.SendToBack();
        }

        private void staffInformation1_Load_1(object sender, EventArgs e)
        {

        }

        private void txtUsername_Click(object sender, EventArgs e)
        {

        }

        private void txtImageUser_Click(object sender, EventArgs e)
        {

        }

        private void AdminMainForm_Load(object sender, EventArgs e)
        {
            if (userRole.ToLower() == "admin")
            {
                txtUsername.Text = "Welcome admin: " + fullName;
            }
            else if (userRole.ToLower() == "staff")
            {
                txtUsername.Text = "Welcome staff: " + fullName;
            }

            if (!string.IsNullOrEmpty(profileImagePath) && File.Exists(profileImagePath))
            {
                txtImageUser.Image = Image.FromFile(profileImagePath);
            }
            else
            {
                txtImageUser.Image = null;
            }
        }



        private void btnOrder_Click(object sender, EventArgs e)
        {
            adminDashboardForm1.SendToBack();
            adminAddProducts1.SendToBack();
            staffInformation1.SendToBack();
            saleForm1.SendToBack();
            orderForm1.BringToFront();
            orderForm1.DisplayData(); // 👉 Refresh order data when going to order form
            orderForm1.LoadStaffToComboBox();

            orderForm1.RefreshComboBox(); // 👉 Force reload product list when opening order form

        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            adminDashboardForm1.SendToBack();
            adminAddProducts1.SendToBack();
            staffInformation1.SendToBack();
            saleForm1.BringToFront();
            orderForm1.SendToBack();
            saleForm1.DisplayData();

        }
    }
}
