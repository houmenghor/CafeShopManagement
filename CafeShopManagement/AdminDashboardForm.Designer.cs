namespace CafeShopManagement
{
    partial class AdminDashboardForm
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
            panel1 = new Panel();
            panel5 = new Panel();
            txtTotalOrder = new Label();
            label4 = new Label();
            pictureBox4 = new PictureBox();
            panel6 = new Panel();
            txtTotalSale = new Label();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            panel4 = new Panel();
            txtTotal = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            txtTotalStock = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(16, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(1222, 240);
            panel1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(7, 99, 102);
            panel5.Controls.Add(txtTotalOrder);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(pictureBox4);
            panel5.Location = new Point(620, 32);
            panel5.Name = "panel5";
            panel5.Size = new Size(284, 172);
            panel5.TabIndex = 3;
            // 
            // txtTotalOrder
            // 
            txtTotalOrder.AutoSize = true;
            txtTotalOrder.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotalOrder.ForeColor = Color.White;
            txtTotalOrder.Location = new Point(232, 127);
            txtTotalOrder.Name = "txtTotalOrder";
            txtTotalOrder.Size = new Size(21, 21);
            txtTotalOrder.TabIndex = 5;
            txtTotalOrder.Text = "0";
            txtTotalOrder.Click += txtTotalOrder_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(126, 31);
            label4.Name = "label4";
            label4.Size = new Size(143, 21);
            label4.TabIndex = 4;
            label4.Text = "Total of Orders";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.order;
            pictureBox4.Location = new Point(14, 31);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(91, 91);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(7, 99, 102);
            panel6.Controls.Add(txtTotalSale);
            panel6.Controls.Add(label3);
            panel6.Controls.Add(pictureBox3);
            panel6.Location = new Point(921, 32);
            panel6.Name = "panel6";
            panel6.Size = new Size(284, 172);
            panel6.TabIndex = 2;
            // 
            // txtTotalSale
            // 
            txtTotalSale.AutoSize = true;
            txtTotalSale.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotalSale.ForeColor = Color.White;
            txtTotalSale.Location = new Point(232, 127);
            txtTotalSale.Name = "txtTotalSale";
            txtTotalSale.Size = new Size(21, 21);
            txtTotalSale.TabIndex = 4;
            txtTotalSale.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(135, 31);
            label3.Name = "label3";
            label3.Size = new Size(130, 21);
            label3.TabIndex = 3;
            label3.Text = "Total of Sales";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.total_sales_1;
            pictureBox3.Location = new Point(14, 31);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(91, 91);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(7, 99, 102);
            panel4.Controls.Add(txtTotal);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(pictureBox2);
            panel4.Location = new Point(319, 32);
            panel4.Name = "panel4";
            panel4.Size = new Size(284, 172);
            panel4.TabIndex = 1;
            // 
            // txtTotal
            // 
            txtTotal.AutoSize = true;
            txtTotal.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotal.ForeColor = Color.White;
            txtTotal.Location = new Point(232, 127);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(21, 21);
            txtTotal.TabIndex = 3;
            txtTotal.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(131, 31);
            label2.Name = "label2";
            label2.Size = new Size(132, 21);
            label2.TabIndex = 2;
            label2.Text = "Total of Staffs";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.staff;
            pictureBox2.Location = new Point(15, 31);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(91, 91);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(7, 99, 102);
            panel3.Controls.Add(txtTotalStock);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(19, 32);
            panel3.Name = "panel3";
            panel3.Size = new Size(284, 172);
            panel3.TabIndex = 0;
            // 
            // txtTotalStock
            // 
            txtTotalStock.AutoSize = true;
            txtTotalStock.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotalStock.ForeColor = Color.White;
            txtTotalStock.Location = new Point(229, 127);
            txtTotalStock.Name = "txtTotalStock";
            txtTotalStock.Size = new Size(21, 21);
            txtTotalStock.TabIndex = 2;
            txtTotalStock.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(132, 31);
            label1.Name = "label1";
            label1.Size = new Size(141, 21);
            label1.TabIndex = 1;
            label1.Text = "Total of Stocks";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.stock;
            pictureBox1.Location = new Point(15, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(91, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(16, 282);
            panel2.Name = "panel2";
            panel2.Size = new Size(1222, 442);
            panel2.TabIndex = 1;
            // 
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AdminDashboardForm";
            Size = new Size(1254, 748);
            Load += AdminDashboardForm_Load;
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Panel panel5;
        private Panel panel6;
        private Panel panel4;
        private PictureBox pictureBox1;
        private Label label4;
        private PictureBox pictureBox4;
        private Label label3;
        private PictureBox pictureBox3;
        private Label label2;
        private PictureBox pictureBox2;
        private Label label1;
        private Label txtTotalOrder;
        private Label txtTotalSale;
        private Label txtTotal;
        private Label txtTotalStock;
    }
}
