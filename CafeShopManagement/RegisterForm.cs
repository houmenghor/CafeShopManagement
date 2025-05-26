using System.Data;
using System.Data.SqlClient;
namespace CafeShopManagement
{
    public partial class RegisterForm : Form
    {

        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-E3574KG\DBSERVER;Initial Catalog=""CafeShop Management"";Integrated Security=True;");
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();

            this.Hide();
        }

        private void register_loginBtn_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();

            this.Hide();
        }

        private void txtshowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtpassword.PasswordChar = txtshowPass.Checked ? '\0' : '*';
            txtCpassword.PasswordChar = txtshowPass.Checked ? '\0' : '*';
        }

        public bool emptyFields()
        {
            if (txt_username.Text == "" || txtpassword.Text == "" || txtCpassword.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("All fiedls are required to be filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    connect.Open();
                    string selectUsername = "SELECT * FROM users WHERE username = @usern"; //check if the username is already taken
                    using (SqlCommand checkUsername = new SqlCommand(selectUsername, connect))
                    {
                        checkUsername.Parameters.AddWithValue("@usern", txt_username.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(checkUsername);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count >= 1)
                        {
                            string usern = txt_username.Text.Substring(0, 1).ToUpper() + txt_username.Text.Substring(1); //capitalize the first letter of the username
                            MessageBox.Show(usern+"is already taken", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (txtpassword.Text != txtCpassword.Text)
                        {
                            MessageBox.Show("Password does not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (txtpassword.Text.Length < 8)
                        {
                            MessageBox.Show("Invalid password, at least 8 characters are needed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string insertData = "INSERT INTO users (username, password, profile_image, role, status, date_reg) " +
                                       "VALUES(@usern, @pass, @image, @role, @status, @date)";
                            DateTime today = DateTime.Today;

                            using (SqlCommand cmd = new SqlCommand(insertData, connect))
                            {
                                cmd.Parameters.AddWithValue("@usern", txt_username.Text.Trim());
                                cmd.Parameters.AddWithValue("@pass", txtpassword.Text.Trim());
                                cmd.Parameters.AddWithValue("@image", DBNull.Value);
                                cmd.Parameters.AddWithValue("@role", "Cashier");
                                cmd.Parameters.AddWithValue("@status", "Approval");
                                cmd.Parameters.AddWithValue("@date", today);

                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Registered successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // SWITCH FORM INTO LOGIN FORM
                                Form1 loginForm = new Form1();
                                loginForm.Show();

                                this.Hide();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (connect.State == ConnectionState.Open)
                    {
                        connect.Close();
                    }
                }
            }
        }
    }
}
