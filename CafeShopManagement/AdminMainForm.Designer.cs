namespace CafeShopManagement
{
    partial class AdminMainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtImageUser = new PictureBox();
            txtUsername = new Label();
            btnDashboard = new Button();
            btnStockInformation = new Button();
            btnStaffInformation = new Button();
            btnSale = new Button();
            logout_btn = new Button();
            btnOrder = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            close = new Label();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            adminDashboardForm1 = new AdminDashboardForm();
            staffInformation1 = new StaffInformation();
            adminAddProducts1 = new AdminAddProducts();
            orderForm1 = new OrderForm();
            saleForm1 = new SaleForm();
            ((System.ComponentModel.ISupportInitialize)txtImageUser).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtImageUser
            // 
            txtImageUser.Location = new Point(0, 0);
            txtImageUser.Name = "txtImageUser";
            txtImageUser.Size = new Size(82, 88);
            txtImageUser.SizeMode = PictureBoxSizeMode.StretchImage;
            txtImageUser.TabIndex = 11;
            txtImageUser.TabStop = false;
            txtImageUser.Click += txtImageUser_Click;
            // 
            // txtUsername
            // 
            txtUsername.AutoSize = true;
            txtUsername.Font = new Font("Arial Rounded MT Bold", 12F);
            txtUsername.ForeColor = Color.White;
            txtUsername.Location = new Point(31, 165);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(0, 23);
            txtUsername.TabIndex = 14;
            txtUsername.Click += txtUsername_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = SystemColors.Control;
            btnDashboard.Location = new Point(28, 231);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(242, 45);
            btnDashboard.TabIndex = 15;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnStockInformation
            // 
            btnStockInformation.FlatStyle = FlatStyle.Flat;
            btnStockInformation.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStockInformation.ForeColor = SystemColors.Control;
            btnStockInformation.Location = new Point(28, 292);
            btnStockInformation.Name = "btnStockInformation";
            btnStockInformation.Size = new Size(242, 45);
            btnStockInformation.TabIndex = 16;
            btnStockInformation.Text = "Stock Management";
            btnStockInformation.UseVisualStyleBackColor = true;
            btnStockInformation.Click += btnStockInformation_Click;
            // 
            // btnStaffInformation
            // 
            btnStaffInformation.FlatStyle = FlatStyle.Flat;
            btnStaffInformation.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStaffInformation.ForeColor = SystemColors.Control;
            btnStaffInformation.Location = new Point(28, 354);
            btnStaffInformation.Name = "btnStaffInformation";
            btnStaffInformation.Size = new Size(242, 45);
            btnStaffInformation.TabIndex = 17;
            btnStaffInformation.Text = "Staff Information";
            btnStaffInformation.UseVisualStyleBackColor = true;
            btnStaffInformation.Click += btnStaffInformation_Click;
            // 
            // btnSale
            // 
            btnSale.FlatStyle = FlatStyle.Flat;
            btnSale.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSale.ForeColor = SystemColors.Control;
            btnSale.Location = new Point(28, 480);
            btnSale.Name = "btnSale";
            btnSale.Size = new Size(242, 45);
            btnSale.TabIndex = 18;
            btnSale.Text = "Sales";
            btnSale.UseVisualStyleBackColor = true;
            btnSale.Click += btnSale_Click;
            // 
            // logout_btn
            // 
            logout_btn.FlatStyle = FlatStyle.Flat;
            logout_btn.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logout_btn.ForeColor = SystemColors.Control;
            logout_btn.Location = new Point(28, 653);
            logout_btn.Name = "logout_btn";
            logout_btn.Size = new Size(242, 45);
            logout_btn.TabIndex = 19;
            logout_btn.Text = "Logout";
            logout_btn.UseVisualStyleBackColor = true;
            logout_btn.Click += logout_btn_Click_1;
            // 
            // btnOrder
            // 
            btnOrder.FlatStyle = FlatStyle.Flat;
            btnOrder.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOrder.ForeColor = SystemColors.Control;
            btnOrder.Location = new Point(28, 416);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(242, 45);
            btnOrder.TabIndex = 20;
            btnOrder.Text = "Orders";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(7, 99, 102);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(btnOrder);
            panel2.Controls.Add(logout_btn);
            panel2.Controls.Add(btnSale);
            panel2.Controls.Add(btnStaffInformation);
            panel2.Controls.Add(btnStockInformation);
            panel2.Controls.Add(btnDashboard);
            panel2.Controls.Add(txtUsername);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 64);
            panel2.Name = "panel2";
            panel2.Size = new Size(299, 726);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(txtImageUser);
            panel3.Location = new Point(99, 42);
            panel3.Name = "panel3";
            panel3.Size = new Size(82, 88);
            panel3.TabIndex = 21;
            // 
            // close
            // 
            close.AutoSize = true;
            close.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            close.Location = new Point(1532, 9);
            close.Name = "close";
            close.Size = new Size(22, 23);
            close.TabIndex = 11;
            close.Text = "X";
            close.Click += close_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(7, 99, 102);
            label1.Location = new Point(1104, 19);
            label1.Name = "label1";
            label1.Size = new Size(366, 27);
            label1.TabIndex = 12;
            label1.Text = "Cafe Shop Management System";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(close);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1559, 64);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logo;
            pictureBox2.Location = new Point(123, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(58, 58);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            // 
            // adminDashboardForm1
            // 
            adminDashboardForm1.Location = new Point(305, 65);
            adminDashboardForm1.Name = "adminDashboardForm1";
            adminDashboardForm1.Size = new Size(1254, 714);
            adminDashboardForm1.TabIndex = 2;
            // 
            // staffInformation1
            // 
            staffInformation1.Location = new Point(303, 64);
            staffInformation1.Name = "staffInformation1";
            staffInformation1.Size = new Size(1254, 714);
            staffInformation1.TabIndex = 3;
            staffInformation1.Load += staffInformation1_Load_1;
            // 
            // adminAddProducts1
            // 
            adminAddProducts1.Location = new Point(302, 66);
            adminAddProducts1.Name = "adminAddProducts1";
            adminAddProducts1.Size = new Size(1254, 714);
            adminAddProducts1.TabIndex = 4;
            // 
            // orderForm1
            // 
            orderForm1.Location = new Point(302, 64);
            orderForm1.Name = "orderForm1";
            orderForm1.Size = new Size(1568, 935);
            orderForm1.TabIndex = 5;
            // 
            // saleForm1
            // 
            saleForm1.Location = new Point(302, 67);
            saleForm1.Name = "saleForm1";
            saleForm1.Size = new Size(1568, 935);
            saleForm1.TabIndex = 6;
            // 
            // AdminMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1559, 790);
            Controls.Add(saleForm1);
            Controls.Add(orderForm1);
            Controls.Add(adminAddProducts1);
            Controls.Add(staffInformation1);
            Controls.Add(adminDashboardForm1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminMainForm";
            Load += AdminMainForm_Load;
            ((System.ComponentModel.ISupportInitialize)txtImageUser).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox txtImageUser;
        private Label txtUsername;
        private Button btnDashboard;
        private Button btnStockInformation;
        private Button btnStaffInformation;
        private Button btnSale;
        private Button logout_btn;
        private Button btnOrder;
        private Panel panel2;
        private Label close;
        private Label label1;
        private Panel panel1;
        private AdminDashboardForm adminDashboardForm1;
        private StaffInformation staffInformation1;
        private PictureBox pictureBox2;
        private AdminAddProducts adminAddProducts1;
        private Panel panel3;
        private OrderForm orderForm1;
        private SaleForm saleForm1;
    }
}