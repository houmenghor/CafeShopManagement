namespace CafeShopManagement
{
    partial class AdminAddProducts
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
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            txtPName = new TextBox();
            txtStaffName = new ComboBox();
            label5 = new Label();
            txtEDate = new TextBox();
            label3 = new Label();
            txtPQty = new TextBox();
            label6 = new Label();
            label1 = new Label();
            btnUpdate = new Button();
            btnAdd = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(16, 399);
            panel1.Name = "panel1";
            panel1.Size = new Size(1226, 337);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
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
            dataGridView1.Location = new Point(23, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1180, 284);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(txtPName);
            panel2.Controls.Add(txtStaffName);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtEDate);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtPQty);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(btnClear);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(16, 19);
            panel2.Name = "panel2";
            panel2.Size = new Size(1222, 360);
            panel2.TabIndex = 3;
            // 
            // txtPName
            // 
            txtPName.BorderStyle = BorderStyle.FixedSingle;
            txtPName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPName.Location = new Point(293, 169);
            txtPName.Name = "txtPName";
            txtPName.Size = new Size(266, 30);
            txtPName.TabIndex = 24;
            // 
            // txtStaffName
            // 
            txtStaffName.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStaffName.FormattingEnabled = true;
            txtStaffName.Location = new Point(293, 101);
            txtStaffName.Name = "txtStaffName";
            txtStaffName.Size = new Size(266, 37);
            txtStaffName.TabIndex = 23;
            txtStaffName.SelectedIndexChanged += txtStaffName_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 13.8F);
            label5.Location = new Point(134, 101);
            label5.Name = "label5";
            label5.Size = new Size(143, 27);
            label5.TabIndex = 21;
            label5.Text = "Staff Name:";
            // 
            // txtEDate
            // 
            txtEDate.BorderStyle = BorderStyle.FixedSingle;
            txtEDate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEDate.Location = new Point(771, 169);
            txtEDate.Name = "txtEDate";
            txtEDate.Size = new Size(266, 30);
            txtEDate.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 13.8F);
            label3.Location = new Point(628, 169);
            label3.Name = "label3";
            label3.Size = new Size(137, 27);
            label3.TabIndex = 19;
            label3.Text = "Entry Date:";
            // 
            // txtPQty
            // 
            txtPQty.BorderStyle = BorderStyle.FixedSingle;
            txtPQty.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPQty.Location = new Point(771, 101);
            txtPQty.Name = "txtPQty";
            txtPQty.Size = new Size(266, 30);
            txtPQty.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 13.8F);
            label6.Location = new Point(652, 101);
            label6.Name = "label6";
            label6.Size = new Size(113, 27);
            label6.TabIndex = 17;
            label6.Text = "Quantity:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(494, 13);
            label1.Name = "label1";
            label1.Size = new Size(317, 43);
            label1.TabIndex = 0;
            label1.Text = "Stock of Product";
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 13.8F);
            label2.Location = new Point(98, 169);
            label2.Name = "label2";
            label2.Size = new Size(179, 27);
            label2.TabIndex = 2;
            label2.Text = "Product Name:";
            // 
            // AdminAddProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AdminAddProducts";
            Size = new Size(1254, 748);
            Load += AdminAddProducts_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox txtPQty;
        private Label label6;
        private Label label1;
        private Button btnUpdate;
        private Button btnAdd;
        private Button btnClear;
        private Button btnDelete;
        private Label label2;
        private TextBox txtEDate;
        private Label label3;
        private DataGridView dataGridView1;
        private Label label5;
        private ComboBox txtStaffName;
        private TextBox txtPName;
    }
}
