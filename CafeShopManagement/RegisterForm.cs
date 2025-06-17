using System.Data;
using System.Data.SqlClient;
namespace CafeShopManagement
{
    public partial class RegisterForm : Form
    {

        SqlConnection connect = Connection.GetConnection();
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
            if (txt_username.Text == "" || txtpassword.Text == "" 
                || txtCpassword.Text == "" || txtStatus.Text == "" 
                || txtRole.Text == "" || txtImageView.Image == null)
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
            }
            else
            {
                try
                {
                    if (connect.State == ConnectionState.Closed)
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
                            MessageBox.Show(usern + "is already taken", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                            string insertData = "INSERT INTO users (username, password, profile_image,role, status, date_reg) " +
                                       "VALUES(@usern, @pass, @image, @role, @status, @date)";

                            string relativePath = Path.Combine(@"C:\\Users\\Menghor\\source\\repos\\CafeShopManagement\\CafeShopManagement\\Admin_Images\\", txt_username.Text.Trim() + ".jpg");
                            string path = Path.Combine(baseDirectory, relativePath);

                            string directoryPath = Path.GetDirectoryName(path);

                            if (!Directory.Exists(directoryPath))
                            {
                                Directory.CreateDirectory(directoryPath);
                            }

                            File.Copy(txtImageView.ImageLocation, path, true);
                            DateTime today = DateTime.Today;

                            using (SqlCommand cmd = new SqlCommand(insertData, connect))
                            {
                                cmd.Parameters.AddWithValue("@usern", txt_username.Text.Trim());
                                cmd.Parameters.AddWithValue("@pass", txtpassword.Text.Trim());
                                cmd.Parameters.AddWithValue("@image", path);
                                cmd.Parameters.AddWithValue("@role", txtRole.Text.Trim());
                                cmd.Parameters.AddWithValue("@status", txtStatus.Text.Trim());
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

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void txtImageView_Click(object sender, EventArgs e)
        {

        }

        private void browser_btn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg; *.png; *.webp|*.jpg;*.png; *.webp)";
                string imagePath = "";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    txtImageView.ImageLocation = imagePath;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
