namespace CafeShopManagement
{
    partial class StaffInformation
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
            dataGridView1 = new DataGridView();
            txtHiredDate = new TextBox();
            label8 = new Label();
            txtEmail = new TextBox();
            label6 = new Label();
            browser_btn = new Button();
            label1 = new Label();
            panel3 = new Panel();
            txtImageView = new PictureBox();
            panel2 = new Panel();
            btnUpdate = new Button();
            btnAdd = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            txtGender = new ComboBox();
            txtPosition = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            txtPhone = new TextBox();
            label3 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtImageView).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
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
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtHiredDate
            // 
            txtHiredDate.BorderStyle = BorderStyle.FixedSingle;
            txtHiredDate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHiredDate.Location = new Point(674, 191);
            txtHiredDate.Name = "txtHiredDate";
            txtHiredDate.Size = new Size(266, 30);
            txtHiredDate.TabIndex = 22;
            txtHiredDate.TextChanged += txtHiredDate_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 13.8F);
            label8.Location = new Point(514, 195);
            label8.Name = "label8";
            label8.Size = new Size(142, 27);
            label8.TabIndex = 21;
            label8.Text = "Hired_date:";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(674, 88);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(266, 30);
            txtEmail.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 13.8F);
            label6.Location = new Point(576, 91);
            label6.Name = "label6";
            label6.Size = new Size(80, 27);
            label6.TabIndex = 17;
            label6.Text = "Email:";
            // 
            // browser_btn
            // 
            browser_btn.BackColor = Color.FromArgb(7, 99, 102);
            browser_btn.FlatStyle = FlatStyle.Flat;
            browser_btn.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            browser_btn.ForeColor = Color.White;
            browser_btn.Location = new Point(971, 286);
            browser_btn.Name = "browser_btn";
            browser_btn.Size = new Size(159, 47);
            browser_btn.TabIndex = 16;
            browser_btn.Text = "Browser";
            browser_btn.UseVisualStyleBackColor = false;
            browser_btn.Click += browser_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(494, 13);
            label1.Name = "label1";
            label1.Size = new Size(318, 43);
            label1.TabIndex = 0;
            label1.Text = "Staff Information";
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkGray;
            panel3.Controls.Add(txtImageView);
            panel3.Location = new Point(971, 77);
            panel3.Name = "panel3";
            panel3.Size = new Size(159, 173);
            panel3.TabIndex = 15;
            // 
            // txtImageView
            // 
            txtImageView.Location = new Point(0, 0);
            txtImageView.Name = "txtImageView";
            txtImageView.Size = new Size(159, 173);
            txtImageView.SizeMode = PictureBoxSizeMode.StretchImage;
            txtImageView.TabIndex = 16;
            txtImageView.TabStop = false;
            txtImageView.Click += txtImageView_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(17, 405);
            panel2.Name = "panel2";
            panel2.Size = new Size(1222, 319);
            panel2.TabIndex = 3;
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
            // txtGender
            // 
            txtGender.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGender.FormattingEnabled = true;
            txtGender.Items.AddRange(new object[] { "Male", "Female" });
            txtGender.Location = new Point(214, 143);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(266, 37);
            txtGender.TabIndex = 10;
            // 
            // txtPosition
            // 
            txtPosition.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPosition.FormattingEnabled = true;
            txtPosition.Items.AddRange(new object[] { "Admin", "Staff" });
            txtPosition.Location = new Point(214, 191);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(266, 37);
            txtPosition.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 13.8F);
            label4.Location = new Point(98, 143);
            label4.Name = "label4";
            label4.Size = new Size(103, 27);
            label4.TabIndex = 8;
            label4.Text = "Gender:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 13.8F);
            label5.Location = new Point(93, 195);
            label5.Name = "label5";
            label5.Size = new Size(108, 27);
            label5.TabIndex = 6;
            label5.Text = "Position:";
            // 
            // txtPhone
            // 
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(674, 140);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(266, 30);
            txtPhone.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 13.8F);
            label3.Location = new Point(566, 143);
            label3.Name = "label3";
            label3.Size = new Size(90, 27);
            label3.TabIndex = 4;
            label3.Text = "Phone:";
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(214, 91);
            txtName.Name = "txtName";
            txtName.Size = new Size(266, 30);
            txtName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 13.8F);
            label2.Location = new Point(119, 91);
            label2.Name = "label2";
            label2.Size = new Size(84, 27);
            label2.TabIndex = 2;
            label2.Text = "Name:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(txtHiredDate);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(browser_btn);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(txtGender);
            panel1.Controls.Add(txtPosition);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtPhone);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(17, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(1222, 368);
            panel1.TabIndex = 2;
            // 
            // StaffInformation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "StaffInformation";
            Size = new Size(1254, 748);
            Load += StaffInformation_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txtImageView).EndInit();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtHiredDate;
        private Label label8;
        private TextBox txtEmail;
        private Label label6;
        private Button browser_btn;
        private Label label1;
        private Panel panel3;
        private PictureBox txtImageView;
        private Panel panel2;
        private Button btnUpdate;
        private Button btnAdd;
        private Button btnClear;
        private Button btnDelete;
        private ComboBox txtGender;
        private ComboBox txtPosition;
        private Label label4;
        private Label label5;
        private TextBox txtPhone;
        private Label label3;
        private TextBox txtName;
        private Label label2;
        private Panel panel1;
    }
}
