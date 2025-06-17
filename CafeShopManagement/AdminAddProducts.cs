using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace CafeShopManagement
{
    public partial class AdminAddProducts : UserControl
    {
        SqlConnection connect = Connection.GetConnection();
        public AdminAddProducts()
        {
            InitializeComponent();
            DisplayData();
        }
        public void DisplayData()
        {
            StockData stockData = new StockData();
            List<StockData> list = stockData.GetStockList();
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


        private void label7_Click(object sender, EventArgs e)
        {

        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminAddProducts_Load(object sender, EventArgs e)
        {
            LoadStaffToComboBox();
            RefreshStaffComboBox(); // Refresh the staff combo box to ensure it's populated
            txtEDate.Text = DateTime.Now.ToString("yyyy-MM-dd"); // Set default date to today
        }

        public bool emptyFields()
        {
            if (string.IsNullOrWhiteSpace(txtPName.Text) ||
                string.IsNullOrWhiteSpace(txtPQty.Text) ||
                string.IsNullOrWhiteSpace(txtEDate.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public class StaffItem
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public override string ToString()
            {
                return Name; // This is what shows in ComboBox
            }
        }

        private void LoadStaffToComboBox()
        {
            if (connect.State == ConnectionState.Closed)
                connect.Open();

            string query = "SELECT id, name FROM staffs WHERE status = 1";

            using (SqlCommand cmd = new SqlCommand(query, connect))
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    StaffItem staff = new StaffItem
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        Name = reader["name"].ToString()
                    };

                    txtStaffName.Items.Add(staff);
                }
            }

            connect.Close();
        }


        public void RefreshStaffComboBox()
        {
            txtStaffName.Items.Clear(); // Clear old list
            LoadStaffToComboBox();      // Reload staff from DB
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
                    connect.Open();
                try
                {
                    string selectQuery = "SELECT * FROM stocks WHERE name = @productName";
                    using (SqlCommand checkName = new SqlCommand(selectQuery, connect))
                    {
                        checkName.Parameters.AddWithValue("@productName", txtPName.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(checkName);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count >= 1)
                        {
                            string usern = txtPName.Text.Substring(0, 1).ToUpper() + txtPName.Text.Substring(1); //capitalize the first letter of the username
                            MessageBox.Show(usern + "is already have in stocks", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string insertQuery = "INSERT INTO stocks (name, qty, created_at, staff_id) " +
                                                 "VALUES (@name, @qty, @created_at, @staff_id)";

                            using (SqlCommand cmd = new SqlCommand(insertQuery, connect))
                            {
                                // Get the selected staff ID from the combo box
                                cmd.Parameters.AddWithValue("@staff_id", ((StaffItem)txtStaffName.SelectedItem).Id);
                                cmd.Parameters.AddWithValue("@name", txtPName.Text.Trim());
                                cmd.Parameters.AddWithValue("@qty", txtPQty.Text.Trim());
                                string now = DateTime.Now.ToString("yyyy-MM-dd");
                                cmd.Parameters.AddWithValue("@created_at", now);

                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Product added to stock successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                ClearFields(); // Clear the fields after successful addition
                                DisplayData(); // Refresh the data grid view to show the new product
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
                        connect.Close();
                }
            }
        }


        public void ClearFields()
        {
            txtStaffName.SelectedIndex = -1; // Clear the selected index of the combo box
            txtPName.Clear();
            txtPQty.Clear();
            txtEDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void txtStaffName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }



        private int id = 0;

        //private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
        //    id = (int)row.Cells[0].Value;
        //    txtPName.Text = row.Cells[1].Value.ToString();
        //    txtPQty.Text = row.Cells[2].Value.ToString();
        //    DateTime entryDate = Convert.ToDateTime(row.Cells[3].Value);
        //    txtEDate.Text = entryDate.ToString("yyyy-MM-dd");

        //    txtStaffName.Text = row.Cells[4].Value.ToString();
        //}

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                id = Convert.ToInt32(row.Cells[0].Value);
                txtPName.Text = row.Cells[1].Value.ToString();
                txtPQty.Text = row.Cells[2].Value.ToString();
                DateTime entryDate = Convert.ToDateTime(row.Cells[3].Value);
                txtEDate.Text = entryDate.ToString("yyyy-MM-dd");

                // Find staff ID from the row (assuming 4th cell is staff_id or staff name)
                int staffIdFromRow = 0;
                if (int.TryParse(row.Cells[4].Value.ToString(), out int sid))
                {
                    staffIdFromRow = sid;
                }
                else
                {
                    // If your 4th cell is staff name, find staff by name:
                    string staffNameFromRow = row.Cells[4].Value.ToString();

                    for (int i = 0; i < txtStaffName.Items.Count; i++)
                    {
                        StaffItem staff = (StaffItem)txtStaffName.Items[i];
                        if (staff.Name == staffNameFromRow)
                        {
                            txtStaffName.SelectedIndex = i;
                            return;
                        }
                    }
                    return;
                }

                // Select StaffItem in combo box by matching id
                for (int i = 0; i < txtStaffName.Items.Count; i++)
                {
                    StaffItem staff = (StaffItem)txtStaffName.Items[i];
                    if (staff.Id == staffIdFromRow)
                    {
                        txtStaffName.SelectedIndex = i;
                        break;
                    }
                }
            }
        }




        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                MessageBox.Show("Please select a product to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to update this product?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();
                        string updateQuery = "UPDATE stocks SET name = @name, qty = @qty, created_at = @created_at, staff_id = @staff_id WHERE id = @id";
                        using (SqlCommand cmd = new SqlCommand(updateQuery, connect))
                        {
                            // Get the selected staff ID from the combo box
                            cmd.Parameters.AddWithValue("@staff_id", ((StaffItem)txtStaffName.SelectedItem).Id);
                            cmd.Parameters.AddWithValue("@name", txtPName.Text.Trim());
                            cmd.Parameters.AddWithValue("@qty", txtPQty.Text.Trim());
                            string now = DateTime.Now.ToString("yyyy-MM-dd");
                            cmd.Parameters.AddWithValue("@created_at", now);
                            cmd.Parameters.AddWithValue("@id", id);

                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Product updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ClearFields(); // Clear the fields after successful update
                                DisplayData(); // Refresh the data grid view to show the updated product
                            }
                            else
                            {
                                MessageBox.Show("No product found with the specified ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                MessageBox.Show("Please select a product to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();
                        string deleteQuery = "UPDATE stocks SET status = 0 WHERE id = @id";
                        using (SqlCommand cmd = new SqlCommand(deleteQuery, connect))
                        { 
                            cmd.Parameters.AddWithValue("@id", id);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Product deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DisplayData(); // Refresh the data grid view to remove the deleted product
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
