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
using System.IO;
using static CafeShopManagement.OrderForm;

namespace CafeShopManagement
{
    public partial class SaleForm : UserControl
    {
        private int id = 0;
        private int oldQuantity = 0;
        private int oldProductId = 0;

        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private PrintDialog printDialog1;
        private SalesData _saleToPrint;

        public SaleForm()
        {
            InitializeComponent();

            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new PrintPreviewDialog();
            this.printDialog1 = new PrintDialog();

            dataGridView1.AutoGenerateColumns = true;
            DisplayData();
            LoadProductToComboBox();
            LoadStaffToComboBox();
            txtSaleDate.Text = DateTime.Now.ToString("yyyy-MM-dd");

            printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printDocument1_PrintPage);
            printPreviewDialog1.Document = printDocument1;
            printDialog1.Document = printDocument1;
        }

        public void DisplayData(string customerName = null, DateTime? saleDate = null)
        {
            SalesData salesData = new SalesData();
            List<SalesData> salesList;

            if (!string.IsNullOrWhiteSpace(customerName) || saleDate.HasValue)
            {
                salesList = salesData.GetFilteredSalesList(customerName, saleDate);
            }
            else
            {
                salesList = salesData.GetSalesList();
            }

            dataGridView1.DataSource = salesList;

            if (dataGridView1.Columns["Id"] != null)
                dataGridView1.Columns["Id"].Visible = false;
            if (dataGridView1.Columns["Status"] != null)
                dataGridView1.Columns["Status"].Visible = false;
            if (dataGridView1.Columns["StatusText"] != null)
            {
                dataGridView1.Columns["StatusText"].HeaderText = "Status";
                if (dataGridView1.Columns["Status"] != null)
                {
                    dataGridView1.Columns["StatusText"].DisplayIndex = dataGridView1.Columns["Status"].DisplayIndex;
                }
            }
            if (dataGridView1.Columns["Total"] != null)
            {
                dataGridView1.Columns["Total"].DefaultCellStyle.Format = "N2";
            }
            if (dataGridView1.Columns["Price"] != null)
            {
                dataGridView1.Columns["Price"].DefaultCellStyle.Format = "N2";
            }
            if (dataGridView1.Columns["SubTotal"] != null)
            {
                dataGridView1.Columns["SubTotal"].DefaultCellStyle.Format = "N2";
            }
            if (dataGridView1.Columns["ProductId"] != null)
            {
                dataGridView1.Columns["ProductId"].Visible = false;
            }
            if (dataGridView1.Columns["StaffId"] != null)
            {
                dataGridView1.Columns["StaffId"].Visible = false;
            }
        }

        public void AddSaleFromOrder(OrderData order, SqlTransaction transaction)
        {
            SalesData salesHandler = new SalesData();
            try
            {
                salesHandler.AddSale(order, transaction);
                MessageBox.Show("Order delivered and added to sales!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisplayData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding sale from order: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void SaleForm_Load(object sender, EventArgs e)
        {

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
            using (SqlConnection connect = Connection.GetConnection())
            {
                try
                {
                    connect.Open();
                    string query = "SELECT id, name FROM stocks WHERE status = 1";
                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        txtPName.Items.Clear();
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
            }
        }

        public void RefreshComboBox()
        {
            LoadProductToComboBox();
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
            using (SqlConnection connect = Connection.GetConnection())
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
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                id = (int)row.Cells["Id"].Value;
                oldQuantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                oldProductId = Convert.ToInt32(row.Cells["ProductId"].Value);

                txtCName.Text = row.Cells["CustomerName"].Value.ToString();
                txtPName.Text = row.Cells["ProductName"].Value.ToString();
                txtQty.Text = row.Cells["Quantity"].Value.ToString();
                txtPrice.Text = row.Cells["Price"].Value.ToString();

                if (row.Cells["Discount"].Value == DBNull.Value || Convert.ToDecimal(row.Cells["Discount"].Value) == 0)
                {
                    txtDiscount.Text = "0";
                }
                else
                {
                    txtDiscount.Text = Convert.ToDecimal(row.Cells["Discount"].Value).ToString();
                }

                txtStaffName.Text = row.Cells["ConfirmOrderBy"].Value.ToString();
                DateTime orderDate = Convert.ToDateTime(row.Cells["SaleDate"].Value);
                txtSaleDate.Text = orderDate.ToString("yyyy-MM-dd");

                foreach (StockItem item in txtPName.Items)
                {
                    if (item.Id == oldProductId)
                    {
                        txtPName.SelectedItem = item;
                        break;
                    }
                }
                int currentStaffId = Convert.ToInt32(row.Cells["StaffId"].Value);
                foreach (StaffItem item in txtStaffName.Items)
                {
                    if (item.Id == currentStaffId)
                    {
                        txtStaffName.SelectedItem = item;
                        break;
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                MessageBox.Show("Please select a Sale to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCName.Text) || txtPName.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtQty.Text) || string.IsNullOrWhiteSpace(txtPrice.Text) ||
                txtStaffName.SelectedItem == null || string.IsNullOrWhiteSpace(txtSaleDate.Text))
            {
                MessageBox.Show("Please fill in all required fields (Customer Name, Product, Quantity, Price, Staff Name, Sale Date).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int newQuantity;
            decimal newPrice;
            decimal newDiscount = 0;

            if (!int.TryParse(txtQty.Text, out newQuantity) || newQuantity <= 0)
            {
                MessageBox.Show("Please enter a valid positive quantity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(txtPrice.Text, out newPrice) || newPrice <= 0)
            {
                MessageBox.Show("Please enter a valid positive price.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!string.IsNullOrWhiteSpace(txtDiscount.Text) && !decimal.TryParse(txtDiscount.Text, out newDiscount))
            {
                MessageBox.Show("Please enter a valid discount amount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to update this Sale?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int newProductId = ((StockItem)txtPName.SelectedItem).Id;
                int quantityDifference = newQuantity - oldQuantity;

                using (SqlConnection connect = Connection.GetConnection())
                {
                    SqlTransaction transaction = null;

                    try
                    {
                        connect.Open();
                        transaction = connect.BeginTransaction();

                        string updateSaleQuery = @"UPDATE sales
                                                    SET customer_name = @customer_name,
                                                        stock_id = @stock_id,
                                                        quantity = @quantity,
                                                        unit_price = @unit_price,
                                                        discount = @discount,
                                                        sale_date = @sale_date,
                                                        staff_id = @staff_id
                                                    WHERE id = @id";
                        using (SqlCommand cmd = new SqlCommand(updateSaleQuery, connect, transaction))
                        {
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.Parameters.AddWithValue("@customer_name", txtCName.Text.Trim());
                            cmd.Parameters.AddWithValue("@stock_id", newProductId);
                            cmd.Parameters.AddWithValue("@quantity", newQuantity);
                            cmd.Parameters.AddWithValue("@unit_price", newPrice);
                            cmd.Parameters.AddWithValue("@sale_date", DateTime.Parse(txtSaleDate.Text));
                            cmd.Parameters.AddWithValue("@staff_id", ((StaffItem)txtStaffName.SelectedItem).Id);
                            cmd.Parameters.AddWithValue("@discount", newDiscount == 0 ? (object)DBNull.Value : newDiscount);
                            cmd.ExecuteNonQuery();
                        }

                        if (oldProductId != newProductId)
                        {
                            string addOldStockQuery = "UPDATE stocks SET qty = qty + @qty_to_add WHERE id = @old_product_id";
                            using (SqlCommand cmdOld = new SqlCommand(addOldStockQuery, connect, transaction))
                            {
                                cmdOld.Parameters.AddWithValue("@qty_to_add", oldQuantity);
                                cmdOld.Parameters.AddWithValue("@old_product_id", oldProductId);
                                cmdOld.ExecuteNonQuery();
                            }

                            string deductNewStockQuery = "UPDATE stocks SET qty = qty - @qty_to_deduct WHERE id = @new_product_id";
                            using (SqlCommand cmdNew = new SqlCommand(deductNewStockQuery, connect, transaction))
                            {
                                cmdNew.Parameters.AddWithValue("@qty_to_deduct", newQuantity);
                                cmdNew.Parameters.AddWithValue("@new_product_id", newProductId);
                                cmdNew.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            string updateStockQuery;
                            if (quantityDifference < 0)
                            {
                                updateStockQuery = "UPDATE stocks SET qty = qty + @quantity_change WHERE id = @product_id";
                            }
                            else if (quantityDifference > 0)
                            {
                                updateStockQuery = "UPDATE stocks SET qty = qty - @quantity_change WHERE id = @product_id";
                            }
                            else
                            {
                                updateStockQuery = null;
                            }

                            if (updateStockQuery != null)
                            {
                                using (SqlCommand cmdStock = new SqlCommand(updateStockQuery, connect, transaction))
                                {
                                    cmdStock.Parameters.AddWithValue("@quantity_change", Math.Abs(quantityDifference));
                                    cmdStock.Parameters.AddWithValue("@product_id", newProductId);
                                    cmdStock.ExecuteNonQuery();
                                }
                            }
                        }

                        transaction.Commit();
                        MessageBox.Show("Sale updated successfully and stock adjusted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearField();
                        DisplayData();
                    }
                    catch (SqlException sqlEx)
                    {
                        if (transaction != null)
                        {
                            transaction.Rollback();
                        }
                        if (sqlEx.Number == 547)
                        {
                            MessageBox.Show("Database constraint violation. Perhaps insufficient stock or invalid IDs.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Database error: " + sqlEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        if (transaction != null)
                        {
                            transaction.Rollback();
                        }
                        MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                MessageBox.Show("Please select a sale to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this Sale? This will return the quantity to stock.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                using (SqlConnection connect = Connection.GetConnection())
                {
                    SqlTransaction transaction = null;

                    try
                    {
                        connect.Open();
                        transaction = connect.BeginTransaction();

                        string deleteSaleQuery = "UPDATE sales SET status=0 WHERE id=@id";
                        using (SqlCommand cmdDeleteSale = new SqlCommand(deleteSaleQuery, connect, transaction))
                        {
                            cmdDeleteSale.Parameters.AddWithValue("@id", id);
                            cmdDeleteSale.ExecuteNonQuery();
                        }

                        string returnStockQuery = "UPDATE stocks SET qty = qty + @quantity WHERE id = @product_id";
                        using (SqlCommand cmdReturnStock = new SqlCommand(returnStockQuery, connect, transaction))
                        {
                            cmdReturnStock.Parameters.AddWithValue("@quantity", oldQuantity);
                            cmdReturnStock.Parameters.AddWithValue("@product_id", oldProductId);
                            cmdReturnStock.ExecuteNonQuery();
                        }

                        transaction.Commit();

                        MessageBox.Show("Sale deleted successfully and quantity returned to stock!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearField();
                        DisplayData();
                    }
                    catch (SqlException sqlEx)
                    {
                        if (transaction != null)
                        {
                            transaction.Rollback();
                        }
                        MessageBox.Show("Database error during deletion: " + sqlEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        if (transaction != null)
                        {
                            transaction.Rollback();
                        }
                        MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string customerName = txtCName.Text.Trim();
            string saleDateText = txtSaleDate.Text.Trim();
            DateTime? saleDate = null;

            if (!string.IsNullOrWhiteSpace(saleDateText))
            {
                if (!DateTime.TryParse(saleDateText, out DateTime parsedDate))
                {
                    MessageBox.Show("Invalid Sale Date format. Please use YYYY-MM-DD.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                saleDate = parsedDate;
            }

            if (string.IsNullOrWhiteSpace(customerName) && !saleDate.HasValue)
            {
                MessageBox.Show("Please enter a Customer Name or Sale Date to search.", "Search Criteria Missing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisplayData();
                return;
            }

            DisplayData(customerName, saleDate);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                MessageBox.Show("Please select a sale from the table to print.", "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SalesData salesDataHandler = new SalesData();
            _saleToPrint = salesDataHandler.GetSaleById(id);

            if (_saleToPrint == null)
            {
                MessageBox.Show("Could not retrieve sale details for printing. It might have been deleted.", "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printPreviewDialog1.ShowDialog();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (_saleToPrint == null)
            {
                e.HasMorePages = false;
                return;
            }

            Graphics graphics = e.Graphics;
            Font fontRegular = new Font("Arial", 10);
            Font fontBold = new Font("Arial", 10, FontStyle.Bold);
            Font fontTitle = new Font("Arial", 18, FontStyle.Bold);
            float fontHeight = fontRegular.GetHeight(graphics);
            int startX = 50;
            int startY = 50;
            int currentY = startY;

            graphics.DrawString("SALE RECEIPT", fontTitle, Brushes.Black, startX, currentY);
            currentY += (int)fontTitle.GetHeight(graphics) + 20;

            graphics.DrawString("Date: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), fontRegular, Brushes.Black, startX, currentY);
            currentY += (int)fontHeight + 5;
            graphics.DrawString("Sale ID: " + _saleToPrint.Id.ToString(), fontRegular, Brushes.Black, startX, currentY);
            currentY += (int)fontHeight + 20;

            graphics.DrawString("Customer Name: " + _saleToPrint.CustomerName, fontRegular, Brushes.Black, startX, currentY);
            currentY += (int)fontHeight + 5;
            graphics.DrawString("Confirmed By: " + _saleToPrint.ConfirmOrderBy, fontRegular, Brushes.Black, startX, currentY);
            currentY += (int)fontHeight + 5;
            graphics.DrawString("Sale Date: " + _saleToPrint.SaleDate.ToString("yyyy-MM-dd"), fontRegular, Brushes.Black, startX, currentY);
            currentY += (int)fontHeight + 20;

            int colProductX = startX;
            int colQtyX = colProductX + 200;
            int colPriceX = colQtyX + 70;
            int colDiscountX = colPriceX + 70;
            int colItemTotalX = colDiscountX + 70;

            graphics.DrawString("Product", fontBold, Brushes.Black, colProductX, currentY);
            graphics.DrawString("Qty", fontBold, Brushes.Black, colQtyX, currentY);
            graphics.DrawString("Price", fontBold, Brushes.Black, colPriceX, currentY);
            graphics.DrawString("Discount", fontBold, Brushes.Black, colDiscountX, currentY);
            graphics.DrawString("Item Total", fontBold, Brushes.Black, colItemTotalX, currentY);
            currentY += (int)fontHeight + 5;

            graphics.DrawLine(Pens.Black, startX, currentY, startX + 500, currentY);
            currentY += 5;

            graphics.DrawString(_saleToPrint.ProductName, fontRegular, Brushes.Black, colProductX, currentY);
            graphics.DrawString(_saleToPrint.Quantity.ToString(), fontRegular, Brushes.Black, colQtyX, currentY);
            graphics.DrawString(_saleToPrint.Price.ToString("N2"), fontRegular, Brushes.Black, colPriceX, currentY);
            graphics.DrawString(_saleToPrint.Discount.ToString("N2"), fontRegular, Brushes.Black, colDiscountX, currentY);
            graphics.DrawString(_saleToPrint.SubTotal.ToString("N2"), fontRegular, Brushes.Black, colItemTotalX, currentY);
            currentY += (int)fontHeight + 20;

            graphics.DrawLine(Pens.Black, startX + 350, currentY, startX + 500, currentY);
            currentY += 5;

            graphics.DrawString("Total Discount:", fontRegular, Brushes.Black, startX + 350, currentY);
            graphics.DrawString(_saleToPrint.Discount.ToString("N2"), fontRegular, Brushes.Black, startX + 450, currentY);
            currentY += (int)fontHeight + 5;

            graphics.DrawString("SubTotal:", fontRegular, Brushes.Black, startX + 350, currentY);
            graphics.DrawString(_saleToPrint.SubTotal.ToString("N2"), fontRegular, Brushes.Black, startX + 450, currentY);
            currentY += (int)fontHeight + 5;

            graphics.DrawString("GRAND TOTAL:", fontBold, Brushes.Black, startX + 350, currentY);
            graphics.DrawString(_saleToPrint.Total.ToString("N2"), fontBold, Brushes.Black, startX + 450, currentY);
            currentY += (int)fontHeight + 30;

            graphics.DrawString("Thank you for your purchase!", fontRegular, Brushes.Black, startX, currentY);

            e.HasMorePages = false;
        }

        private void ClearField()
        {
            id = 0;
            oldQuantity = 0;
            oldProductId = 0;
            txtCName.Clear();
            txtPName.SelectedIndex = -1;
            txtQty.Clear();
            txtPrice.Clear();
            txtDiscount.Clear();
            txtStaffName.SelectedIndex = -1;
            txtSaleDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearField();
            DisplayData();
        }
    }
}