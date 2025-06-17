namespace CafeShopManagement
{
    partial class OrderForm
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            txtQty = new TextBox();
            label8 = new Label();
            txtPrice = new TextBox();
            label6 = new Label();
            label1 = new Label();
            btnUpdate = new Button();
            btnAdd = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            txtPName = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            txtDiscount = new TextBox();
            label3 = new Label();
            txtCName = new TextBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            panel1 = new Panel();
            txtStaffName = new ComboBox();
            label7 = new Label();
            btnSearch = new Button();
            btndelivery = new Button();
            txtOrderDate = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtQty
            // 
            txtQty.BorderStyle = BorderStyle.FixedSingle;
            txtQty.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQty.Location = new Point(287, 195);
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(266, 30);
            txtQty.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 13.8F);
            label8.Location = new Point(740, 195);
            label8.Name = "label8";
            label8.Size = new Size(141, 27);
            label8.TabIndex = 21;
            label8.Text = "Order date:";
            // 
            // txtPrice
            // 
            txtPrice.BorderStyle = BorderStyle.FixedSingle;
            txtPrice.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(287, 242);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(266, 30);
            txtPrice.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 13.8F);
            label6.Location = new Point(199, 245);
            label6.Name = "label6";
            label6.Size = new Size(78, 27);
            label6.TabIndex = 17;
            label6.Text = "Price:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(450, 3);
            label1.Name = "label1";
            label1.Size = new Size(340, 43);
            label1.TabIndex = 0;
            label1.Text = "Order Information";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(7, 99, 102);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(246, 303);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(133, 47);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(7, 99, 102);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(98, 303);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(133, 47);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(7, 99, 102);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(545, 303);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(133, 47);
            btnClear.TabIndex = 12;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(7, 99, 102);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(395, 303);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(133, 47);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtPName
            // 
            txtPName.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPName.FormattingEnabled = true;
            txtPName.Location = new Point(287, 143);
            txtPName.Name = "txtPName";
            txtPName.Size = new Size(266, 37);
            txtPName.TabIndex = 10;
            txtPName.SelectedIndexChanged += txtPName_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 13.8F);
            label4.Location = new Point(98, 147);
            label4.Name = "label4";
            label4.Size = new Size(179, 27);
            label4.TabIndex = 8;
            label4.Text = "Product Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 13.8F);
            label5.Location = new Point(164, 195);
            label5.Name = "label5";
            label5.Size = new Size(113, 27);
            label5.TabIndex = 6;
            label5.Text = "Qauntity:";
            // 
            // txtDiscount
            // 
            txtDiscount.BorderStyle = BorderStyle.FixedSingle;
            txtDiscount.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDiscount.Location = new Point(904, 88);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(266, 30);
            txtDiscount.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 13.8F);
            label3.Location = new Point(763, 91);
            label3.Name = "label3";
            label3.Size = new Size(118, 27);
            label3.TabIndex = 4;
            label3.Text = "Discount:";
            // 
            // txtCName
            // 
            txtCName.BorderStyle = BorderStyle.FixedSingle;
            txtCName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCName.Location = new Point(287, 91);
            txtCName.Name = "txtCName";
            txtCName.Size = new Size(266, 30);
            txtCName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 13.8F);
            label2.Location = new Point(80, 88);
            label2.Name = "label2";
            label2.Size = new Size(199, 27);
            label2.TabIndex = 2;
            label2.Text = "Customer Name:";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(7, 99, 102);
            dataGridViewCellStyle1.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(19, 18);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1180, 284);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(16, 408);
            panel2.Name = "panel2";
            panel2.Size = new Size(1222, 319);
            panel2.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(txtStaffName);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(btndelivery);
            panel1.Controls.Add(txtOrderDate);
            panel1.Controls.Add(txtQty);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtPrice);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(txtPName);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtDiscount);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtCName);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(16, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(1222, 368);
            panel1.TabIndex = 4;
            // 
            // txtStaffName
            // 
            txtStaffName.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStaffName.FormattingEnabled = true;
            txtStaffName.Location = new Point(904, 143);
            txtStaffName.Name = "txtStaffName";
            txtStaffName.Size = new Size(266, 37);
            txtStaffName.TabIndex = 27;
            txtStaffName.SelectedIndexChanged += txtStaffName_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 13.8F);
            label7.Location = new Point(678, 147);
            label7.Name = "label7";
            label7.Size = new Size(203, 27);
            label7.TabIndex = 26;
            label7.Text = "ConfirmOrderBy:";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(7, 99, 102);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(695, 303);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(133, 47);
            btnSearch.TabIndex = 25;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btndelivery
            // 
            btndelivery.BackColor = Color.FromArgb(7, 99, 102);
            btndelivery.FlatStyle = FlatStyle.Flat;
            btndelivery.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btndelivery.ForeColor = Color.White;
            btndelivery.Location = new Point(846, 303);
            btndelivery.Name = "btndelivery";
            btndelivery.Size = new Size(133, 47);
            btndelivery.TabIndex = 24;
            btndelivery.Text = "DELIVERY";
            btndelivery.UseVisualStyleBackColor = false;
            btndelivery.Click += btndelivery_Click;
            // 
            // txtOrderDate
            // 
            txtOrderDate.BorderStyle = BorderStyle.FixedSingle;
            txtOrderDate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtOrderDate.Location = new Point(904, 205);
            txtOrderDate.Name = "txtOrderDate";
            txtOrderDate.Size = new Size(266, 30);
            txtOrderDate.TabIndex = 23;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "OrderForm";
            Size = new Size(1254, 748);
            Load += OrderForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtQty;
        private Label label8;
        private TextBox txtPrice;
        private Label label6;
        private Label label1;
        private Button btnUpdate;
        private Button btnAdd;
        private Button btnClear;
        private Button btnDelete;
        private ComboBox txtPName;
        private Label label4;
        private Label label5;
        private TextBox txtDiscount;
        private Label label3;
        private TextBox txtCName;
        private Label label2;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Panel panel1;
        private TextBox txtOrderDate;
        private Button btndelivery;
        private Button btnSearch;
        private ComboBox txtStaffName;
        private Label label7;
    }
}
