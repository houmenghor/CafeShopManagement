using System.Data;
using System.Data.SqlClient;
namespace CafeShopManagement
{
    public partial class Form1 : Form
    {
        SqlConnection connect = Connection.GetConnection();
        public Form1()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();

            this.Hide();
        }

        private void login_registerBtn_Click(object sender, EventArgs e)
        {

        }

        private void login_registerBtn_Click_1(object sender, EventArgs e)
        {
            RegisterForm RegForm = new RegisterForm();
            RegForm.Show();

            this.Hide();
        }

        private void txtshowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtpassword.PasswordChar = txtshowPass.Checked ? '\0' : '*';
        }

        public bool emptyFields()
        {
            if (txtusername.Text == "" || txtpassword.Text == "" || txtRole.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("All fiedls are required to be filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                    try
                    {
                        connect.Open();
                        string selectAccount = "SELECT * FROM users WHERE username = @usern AND password = @pass AND status = @status AND @role = role";

                        using (SqlCommand cmd = new SqlCommand(selectAccount, connect))
                        {
                            cmd.Parameters.AddWithValue("@usern", txtusername.Text.Trim());
                            cmd.Parameters.AddWithValue("@pass", txtpassword.Text.Trim());
                            cmd.Parameters.AddWithValue("@role", txtRole.Text.Trim()); // Assuming you want to check role as well
                            cmd.Parameters.AddWithValue("@status", "Active");

                            //int rowCount = (int)cmd.ExecuteScalar();
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                string name = table.Rows[0]["username"].ToString(); // Adjust to your actual DB column
                                string imagePath = table.Rows[0]["profile_image"].ToString();   // Adjust if needed (e.g., filepath or base64)
                                string role = table.Rows[0]["role"].ToString(); // Assuming you have a 'role' column

                                MessageBox.Show("Login successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                AdminMainForm adminForm = new AdminMainForm(name, imagePath, role); // <-- Pass name & image
                                adminForm.Show();
                                this.Hide();
                            }

                            else
                            {
                                MessageBox.Show("Incorrect Username/Password/Role or there's no Admin's approval.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection failed: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtusername.Focus();
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
