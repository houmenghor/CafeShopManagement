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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static CafeShopManagement.AdminAddProducts; // Assuming this is needed for other parts of OrderForm

namespace CafeShopManagement
{
    public partial class OrderForm : UserControl
    {
        SqlConnection connect = Connection.GetConnection();
        private SaleForm saleForm; // Private field to hold the reference to SaleForm

        public OrderForm()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = true;
            DisplayData();
            LoadProductToComboBox();
            RefreshComboBox(); // You might want to review if RefreshComboBox is still needed after LoadProductToComboBox
            LoadStaffToComboBox();
            txtOrderDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        // Public method to set the SaleForm reference from the main form
        public void SetSaleFormReference(SaleForm saleForm)
        {
            this.saleForm = saleForm;
        }

        public class StockItem
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public override string ToString()
            {
                return Name;
            }
        }

        public void LoadProductToComboBox()
        {
            try
            {
                connect.Open();
                string query = "SELECT id, name FROM stocks WHERE status = 1"; // Assuming status 1 means active
                using (SqlCommand cmd = new SqlCommand(query, connect))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    txtPName.Items.Clear(); // Clear existing items before loading
                    while (reader.Read())
                    {
                        StockItem stock = new StockItem
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            Name = reader["name"].ToString()
                        };
                        txtPName.Items.Add(stock);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message);
            }
            finally
            {
                connect.Close();
            }
        }

        public void RefreshComboBox()
        {
            txtPName.Items.Clear(); // This line clears it. LoadProductToComboBox adds them.
            LoadProductToComboBox(); // This duplicates, consider calling LoadProductToComboBox directly
                                     // or ensuring it handles clearing internally.
        }

        public class StaffItem
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public override string ToString()
            {
                return Name;
            }
        }

        public void LoadStaffToComboBox()
        {
            try
            {
                txtStaffName.Items.Clear();
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading staff: " + ex.Message);
            }
            finally
            {
                connect.Close();
            }
        }

        public void DisplayData()
        {
            OrderData orderData = new OrderData();
            List<OrderData> orderList = orderData.GetOrderList();
            dataGridView1.DataSource = orderList;

            if (dataGridView1.Columns["Id"] != null)
                dataGridView1.Columns["Id"].Visible = false;

            if (dataGridView1.Columns["Status"] != null)
                dataGridView1.Columns["Status"].Visible = false;

            if (dataGridView1.Columns["StatusText"] != null)
            {
                dataGridView1.Columns["StatusText"].HeaderText = "Status";
                // Ensure StatusText has a valid DisplayIndex. If Status is hidden, we can assign an index.
                // A safer way for DisplayIndex for auto-generated columns is often to not explicitly set it
                // unless you know the column order precisely, or set it after all columns are generated.
                // For simplicity, for now, we'll keep the direct assignment.
                if (dataGridView1.Columns["Status"] != null)
                {
                    dataGridView1.Columns["StatusText"].DisplayIndex = dataGridView1.Columns["Status"].DisplayIndex;
                }
                else // If Status column doesn't exist for some reason, place it at the end
                {
                    dataGridView1.Columns["StatusText"].DisplayIndex = dataGridView1.Columns.Count - 1;
                }
            }

            if (dataGridView1.Columns["Total"] != null)
            {
                dataGridView1.Columns["Total"].DefaultCellStyle.Format = "N2";
            }
        }

        private void txtPName_SelectedIndexChanged(object sender, EventArgs e) { }
        private void OrderForm_Load(object sender, EventArgs e) { }

        public bool emptyFields()
        {
            return string.IsNullOrWhiteSpace(txtCName.Text) ||
                   string.IsNullOrWhiteSpace(txtPName.Text) ||
                   string.IsNullOrWhiteSpace(txtQty.Text) ||
                   string.IsNullOrWhiteSpace(txtPrice.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("All fields are required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                connect.Open();
                string insertQuery = @"INSERT INTO orders
                                     (customer_name, stock_id, quantity, unit_price, discount, order_date, staff_id, status)
                                     VALUES
                                     (@customer_name, @stock_id, @quantity, @unit_price, @discount, @order_date, @staff_id, @status)";

                using (SqlCommand cmd = new SqlCommand(insertQuery, connect))
                {


                    cmd.Parameters.AddWithValue("@customer_name", txtCName.Text.Trim());
                    cmd.Parameters.AddWithValue("@staff_id", ((StaffItem)txtStaffName.SelectedItem).Id);
                    cmd.Parameters.AddWithValue("@quantity", int.Parse(txtQty.Text));
                    cmd.Parameters.AddWithValue("@unit_price", decimal.Parse(txtPrice.Text));
                    cmd.Parameters.AddWithValue("@order_date", DateTime.Now);
                    cmd.Parameters.AddWithValue("@stock_id", ((StockItem)txtPName.SelectedItem).Id);
                    cmd.Parameters.AddWithValue("@status", true); // Active status
                                                                  // Discount
                    if (string.IsNullOrWhiteSpace(txtDiscount.Text))
                        cmd.Parameters.AddWithValue("@discount", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@discount", decimal.Parse(txtDiscount.Text.Trim()));


                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearField();
                    DisplayData(); // Refresh the grid
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connect.Close();
            }
        }

        private void txtStaffName_SelectedIndexChanged(object sender, EventArgs e) { }

        private int id = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                id = (int)row.Cells["Id"].Value; // Access by column name for safety
                txtCName.Text = row.Cells["CustomerName"].Value.ToString();
                txtPName.Text = row.Cells["ProductName"].Value.ToString();
                txtQty.Text = row.Cells["Quantity"].Value.ToString();
                txtPrice.Text = row.Cells["Price"].Value.ToString(); // Use Price
                txtDiscount.Text = row.Cells["Discount"].Value == DBNull.Value ? "" : row.Cells["Discount"].Value.ToString();
                txtStaffName.Text = row.Cells["ConfirmOrderBy"].Value.ToString(); // Use ConfirmOrderBy

                DateTime orderDate = Convert.ToDateTime(row.Cells["OrderDate"].Value);
                txtOrderDate.Text = orderDate.ToString("yyyy-MM-dd");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                MessageBox.Show("Please select an order to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to update this order?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    connect.Open();
                    string updateQuery = @"UPDATE orders
                                           SET customer_name = @customer_name,
                                               stock_id = @stock_id,
                                               quantity = @quantity,
                                               unit_price = @unit_price,
                                               discount = @discount,
                                               order_date = @order_date,
                                               staff_id = @staff_id
                                           WHERE id = @id";
                    using (SqlCommand cmd = new SqlCommand(updateQuery, connect))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@customer_name", txtCName.Text.Trim());
                        cmd.Parameters.AddWithValue("@stock_id", ((StockItem)txtPName.SelectedItem).Id);
                        cmd.Parameters.AddWithValue("@quantity", int.Parse(txtQty.Text));
                        cmd.Parameters.AddWithValue("@unit_price", decimal.Parse(txtPrice.Text));
                        cmd.Parameters.AddWithValue("@order_date", DateTime.Parse(txtOrderDate.Text));
                        cmd.Parameters.AddWithValue("@staff_id", ((StaffItem)txtStaffName.SelectedItem).Id);
                        if (string.IsNullOrWhiteSpace(txtDiscount.Text))
                            cmd.Parameters.AddWithValue("@discount", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@discount", decimal.Parse(txtDiscount.Text.Trim()));
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Order updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearField();
                        DisplayData(); // Refresh the grid
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                MessageBox.Show("Please select an order to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Added return here
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this order?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    connect.Open();
                    string deleteQuery = "UPDATE orders SET status=0 WHERE id=@id";
                    using (SqlCommand cmd = new SqlCommand(deleteQuery, connect))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Order deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DisplayData(); // Refresh the data grid view to remove the deleted product
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        public void ClearField()
        {
            txtCName.Text = "";
            txtQty.Text = "";
            txtPrice.Text = "";
            txtDiscount.Text = "";
            txtOrderDate.Text = DateTime.Now.ToString("yyyy-MM-dd");

            txtPName.SelectedIndex = -1;
            txtStaffName.SelectedIndex = -1;

            id = 0;
            DisplayData();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearField();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();

                string customerName = txtCName.Text.Trim();
                string orderDate = txtOrderDate.Text.Trim();

                // Start with the base query, always filtering for active orders
                string query = @"SELECT o.id, o.customer_name, s.name AS product_name, o.quantity,
                                o.unit_price, o.discount, o.total, o.status,
                                st.name AS staff_name, o.order_date,
                                o.stock_id, o.staff_id
                         FROM orders o
                         JOIN stocks s ON o.stock_id = s.id
                         JOIN staffs st ON o.staff_id = st.id
                         WHERE o.status = 1"; // Always filter by status = 1 for pending orders

                bool isSearchingByCustomerName = !string.IsNullOrEmpty(customerName);
                bool isSearchingByOrderDate = !string.IsNullOrEmpty(orderDate);

                if (isSearchingByCustomerName)
                {
                    query += " AND o.customer_name LIKE @customerName";
                }
                if (isSearchingByOrderDate)
                {
                    // Ensure the date format matches your DB's date format, or convert explicitly
                    query += " AND CONVERT(date, o.order_date) = @orderDate";
                }

                // If neither field is used for search, we should display all active orders
                // This scenario is already handled by the initial query if no 'AND' clauses are added.
                // However, if the user clicks search with empty fields, they expect a full list.
                // If they expect to see all orders when no search criteria are entered,
                // you might want to call DisplayData() or ensure the initial query is just "WHERE o.status = 1"
                // without any dynamic additions. For this specific request, we'll keep the current logic
                // that filters based on what's entered.
                if (!isSearchingByCustomerName && !isSearchingByOrderDate)
                {
                    // If both fields are empty, show all active orders (same as initial DisplayData logic)
                    DisplayData(); // This will show all pending orders
                    MessageBox.Show("Please enter a customer name or order date to search.", "Search Criteria Missing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return; // Exit the method
                }

                SqlCommand cmd = new SqlCommand(query, connect);
                if (isSearchingByCustomerName)
                {
                    cmd.Parameters.AddWithValue("@customerName", "%" + customerName + "%");
                }
                if (isSearchingByOrderDate)
                {
                    if (DateTime.TryParse(orderDate, out DateTime parsedOrderDate))
                    {
                        cmd.Parameters.AddWithValue("@orderDate", parsedOrderDate.Date);
                    }
                    else
                    {
                        MessageBox.Show("Invalid Order Date format. Please use YYYY-MM-DD.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // Exit if date format is invalid
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;

                // Check if any rows were returned
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No orders found matching your search criteria.", "Order Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }
        }


        private void btndelivery_Click(object sender, EventArgs e)
        {
            if (id == 0) // 'id' is the selected order ID from CellClick
            {
                MessageBox.Show("Please select an order to deliver.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Ensure saleForm reference is set
            if (saleForm == null)
            {
                MessageBox.Show("SaleForm reference is not set. Cannot deliver order.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult confirmation = MessageBox.Show("Are you sure you want to mark this order as delivered and move to sales?", "Confirm Delivery", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmation == DialogResult.No)
            {
                return;
            }

            SqlTransaction transaction = null; // Declare transaction outside try-catch
            try
            {
                connect.Open();
                transaction = connect.BeginTransaction(); // Start the transaction

                // Fetch the complete order data including stock_id and staff_id
                string getOrderQuery = @"SELECT o.id, o.customer_name, s.name AS product_name, o.quantity,
                                 o.unit_price, o.discount, o.subtotal, o.total, o.order_date, st.name AS staff_name, o.status,
                                 o.stock_id, o.staff_id
                            FROM orders o
                            JOIN stocks s ON o.stock_id = s.id
                            JOIN staffs st ON o.staff_id = st.id
                            WHERE o.id = @id";

                OrderData orderToDeliver = null;
                using (SqlCommand cmd = new SqlCommand(getOrderQuery, connect, transaction)) // Pass transaction to command
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            orderToDeliver = new OrderData()
                            {
                                Id = (int)reader["id"],
                                CustomerName = reader["customer_name"].ToString(),
                                ProductName = reader["product_name"].ToString(),
                                Quantity = (int)reader["quantity"],
                                Price = (decimal)reader["unit_price"],
                                Discount = reader["discount"] == DBNull.Value ? 0 : (decimal)reader["discount"],
                                SubTotal = (decimal)reader["subtotal"],
                                Total = (decimal)reader["total"],
                                OrderDate = (DateTime)reader["order_date"],
                                ConfirmOrderBy = reader["staff_name"].ToString(),
                                Status = (bool)reader["status"],
                                StockId = (int)reader["stock_id"],
                                StaffId = (int)reader["staff_id"]
                            };
                        }
                    } // reader.Close() is implicitly called by using statement
                }

                if (orderToDeliver != null)
                {
                    // 1. Add the order as a sale in the SalesForm/SalesData
                    SalesData salesHandler = new SalesData();
                    salesHandler.AddSale(orderToDeliver, transaction); // Pass the transaction

                    // 2. Update the status of the order in the 'orders' table
                    string updateOrderStatusQuery = "UPDATE orders SET status = 0 WHERE id = @id";
                    using (SqlCommand updateCmd = new SqlCommand(updateOrderStatusQuery, connect, transaction)) // Pass transaction
                    {
                        updateCmd.Parameters.AddWithValue("@id", id);
                        updateCmd.ExecuteNonQuery();
                    }

                    // 3. Deduct the quantity from the 'stocks' table
                    string updateStockQuery = "UPDATE stocks SET qty = qty - @deliveredQuantity WHERE id = @stockId";
                    using (SqlCommand updateStockCmd = new SqlCommand(updateStockQuery, connect, transaction)) // Pass transaction
                    {
                        updateStockCmd.Parameters.AddWithValue("@deliveredQuantity", orderToDeliver.Quantity);
                        updateStockCmd.Parameters.AddWithValue("@stockId", orderToDeliver.StockId);
                        updateStockCmd.ExecuteNonQuery();
                    }

                    transaction.Commit(); // Commit the transaction if all operations succeed
                    MessageBox.Show("Order marked as delivered and stock updated!", "Delivery Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearField(); // Clear selected fields
                    DisplayData(); // Refresh the orders grid (delivered order will disappear if status=0 is filtered)
                }
                else
                {
                    MessageBox.Show("Selected order details not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                if (transaction != null)
                {
                    try
                    {
                        transaction.Rollback(); // Rollback the transaction on error
                    }
                    catch (Exception rbEx)
                    {
                        MessageBox.Show("Rollback failed: " + rbEx.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                MessageBox.Show("Error processing delivery: " + ex.Message, "Delivery Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connect.State == System.Data.ConnectionState.Open)
                {
                    connect.Close();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // dataGridView1.AutoGenerateColumns = true; // This line is redundant here. It's best in constructor.
        }
    }
}