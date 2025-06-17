using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;


namespace CafeShopManagement
{
    public partial class StaffInformation : UserControl
    {
        SqlConnection connect = Connection.GetConnection();
        public StaffInformation()
        {
            InitializeComponent();
            DisplayData(); // Load staff data when the control is initialized
        }

        private void StaffInformation_Load(object sender, EventArgs e)
        {
            txtHiredDate.Text = DateTime.Now.ToString("yyyy-MM-dd"); // format as you like
        }

        public void DisplayData()
        {
            StaffData staffData = new StaffData();
            List<StaffData> list = staffData.GetStaffList();
            dataGridView1.DataSource = list;

            // Hide the Id column so users don't see it
            if (dataGridView1.Columns["Id"] != null)
                dataGridView1.Columns["Id"].Visible = false;

            // Hide raw boolean Status column
            if (dataGridView1.Columns["Status"] != null)
                dataGridView1.Columns["Status"].Visible = false;

            // Rename and show readable status
            if (dataGridView1.Columns["StatusText"] != null)
                dataGridView1.Columns["StatusText"].HeaderText = "Status";
            dataGridView1.DataSource = list;
        }

        public bool emptyFields()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtGender.Text) ||
                string.IsNullOrWhiteSpace(txtPosition.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                txtImageView.Image == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void browser_btn_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog dialog = new OpenFileDialog())
                {
                    dialog.Filter = "Image Files (*.jpg; *.png; *.webp)|*.jpg;*.png;*.webp";
                    dialog.Title = "Select an Image";

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        string imagePath = dialog.FileName;
                        txtImageView.ImageLocation = imagePath;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtImageView_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("All fields are required to be filled", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                
                    try
                    {
                        connect.Open();


                        // Check if staff email already exists (you can change to other unique field)
                        string checkEmailQuery = "SELECT * FROM staffs WHERE email = @Email AND status = 1";
                        using (SqlCommand checkCmd = new SqlCommand(checkEmailQuery, connect))
                        {
                            checkCmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(checkCmd);
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            if (dt.Rows.Count >= 1)
                            {
                                string email = txtEmail.Text.Substring(0, 1).ToUpper() + txtEmail.Text.Substring(1);
                                MessageBox.Show(email + "Email is already taken.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

                                string insertQuery = @"INSERT INTO staffs (name, gender, position, email, phone, hired_date, profile_image) " +
                                   "VALUES(@Name, @Gender, @Position, @Email, @Phone, @hire_date, @imagePath)";
                                DateTime today = DateTime.Today;

                                string relativePath = Path.Combine(@"C:\Users\Menghor\source\repos\CafeShopManagement\CafeShopManagement\Staff_Images\", txtName.Text.Trim() + ".jpg");
                                string path = Path.Combine(baseDirectory, relativePath);

                                string directoryPath = Path.GetDirectoryName(path);

                                if (!Directory.Exists(directoryPath))
                                {
                                    Directory.CreateDirectory(directoryPath);
                                }

                                File.Copy(txtImageView.ImageLocation, path, true);



                                using (SqlCommand cmd = new SqlCommand(insertQuery, connect))
                                {
                                    cmd.Parameters.AddWithValue("@Name", txtName.Text.Trim());
                                    cmd.Parameters.AddWithValue("@Gender", txtGender.Text.Trim());
                                    cmd.Parameters.AddWithValue("@Position", txtPosition.Text.Trim());
                                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                                    cmd.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim());

                                    string now = DateTime.Now.ToString("yyyy-MM-dd");
                                    cmd.Parameters.AddWithValue("@hire_date", now);  // note: @hire_date matches SQL query

                                    cmd.Parameters.AddWithValue("@imagePath", path);

                                    cmd.ExecuteNonQuery();
                                }


                                MessageBox.Show("Staff added successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                clearFields();
                                DisplayData();  // Reload staff data in grid
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

        private void clearFields()
        {
            txtName.Clear();
            txtGender.SelectedIndex = -1; // Clears selection
            txtPosition.SelectedIndex = -1; // Clears selection
            txtEmail.Clear();
            txtPhone.Clear();
            txtImageView.Image = null;
            txtImageView.ImageLocation = null;

            // ✅ Refresh hired date to now
            txtHiredDate.Text = DateTime.Now.ToString("yyyy-MM-dd");

        }

        private void txtHiredDate_TextChanged(object sender, EventArgs e)
        {

        }


        private int id = 0;


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            id = (int)row.Cells[0].Value;
            txtName.Text = row.Cells[1].Value.ToString();
            txtGender.Text = row.Cells[2].Value.ToString();
            txtPosition.Text = row.Cells[3].Value.ToString();
            txtEmail.Text = row.Cells[4].Value.ToString();
            txtPhone.Text = row.Cells[5].Value.ToString();
            DateTime hiredDate = Convert.ToDateTime(row.Cells[6].Value);
            txtHiredDate.Text = hiredDate.ToString("yyyy-MM-dd");
            

            string imagePath = row.Cells[7].Value.ToString();

            try
            {
                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                {
                    txtImageView.Image = Image.FromFile(imagePath);
                }
                else
                {
                    txtImageView.Image = null;
                    MessageBox.Show("Image file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("No Image :3", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                MessageBox.Show("Please select a staff to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            DialogResult result = MessageBox.Show("Are you sure you want to update?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    if (connect.State != ConnectionState.Open)
                        connect.Open();

                    string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                    string imagePath = null;

                    // Optional image update
                    if (!string.IsNullOrEmpty(txtImageView.ImageLocation) && File.Exists(txtImageView.ImageLocation))
                    {
                        string relativePath = Path.Combine("Staff_Images", txtName.Text.Trim() + ".jpg");
                        imagePath = Path.Combine(baseDirectory, relativePath);

                        Directory.CreateDirectory(Path.GetDirectoryName(imagePath));
                        File.Copy(txtImageView.ImageLocation, imagePath, true);
                    }

                    // Update only selected fields
                    string updateQuery = @"
                                            UPDATE staffs 
                                            SET 
                                            name = @Name,
                                            gender = @Gender,
                                            position = @Position,
                                            email = @Email,
                                            phone = @Phone
                                          ";

                    if (imagePath != null)
                        updateQuery += ", profile_image = @imagePath";

                    updateQuery += " WHERE id = @id";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, connect))
                    {
                        cmd.Parameters.AddWithValue("@Name", string.IsNullOrWhiteSpace(txtName.Text) ? (object)DBNull.Value : txtName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Gender", string.IsNullOrWhiteSpace(txtGender.Text) ? (object)DBNull.Value : txtGender.Text.Trim());
                        cmd.Parameters.AddWithValue("@Position", string.IsNullOrWhiteSpace(txtPosition.Text) ? (object)DBNull.Value : txtPosition.Text.Trim());
                        cmd.Parameters.AddWithValue("@Email", string.IsNullOrWhiteSpace(txtEmail.Text) ? (object)DBNull.Value : txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@Phone", string.IsNullOrWhiteSpace(txtPhone.Text) ? (object)DBNull.Value : txtPhone.Text.Trim());

                        if (imagePath != null)
                            cmd.Parameters.AddWithValue("@imagePath", imagePath);

                        cmd.Parameters.AddWithValue("@id", id);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Staff updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearFields();
                    DisplayData();
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







        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("All fields are required to be filled.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to Delete Name: " + txtImageView.Text.Trim()
                    + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                        try
                        {
                            connect.Open();

                            string deleteData = "UPDATE staffs SET status = '0' WHERE id = @id";

                            using (SqlCommand cmd = new SqlCommand(deleteData, connect))
                            {
                                cmd.Parameters.AddWithValue("@id", id);

                                cmd.ExecuteNonQuery();
                                clearFields();

                                MessageBox.Show("Deleted successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                DisplayData();
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
        }
    }
}
