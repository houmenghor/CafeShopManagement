namespace CafeShopManagement
{
    partial class RegisterForm
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
            register_btn = new Button();
            txtshowPass = new CheckBox();
            txtpassword = new TextBox();
            label4 = new Label();
            txt_username = new TextBox();
            label3 = new Label();
            label2 = new Label();
            close = new Label();
            panel1 = new Panel();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            register_loginBtn = new Button();
            txtCpassword = new TextBox();
            label7 = new Label();
            browser_btn = new Button();
            panel3 = new Panel();
            txtImageView = new PictureBox();
            txtStatus = new ComboBox();
            label1 = new Label();
            txtRole = new ComboBox();
            label8 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtImageView).BeginInit();
            SuspendLayout();
            // 
            // register_btn
            // 
            register_btn.BackColor = Color.FromArgb(7, 99, 102);
            register_btn.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_btn.ForeColor = Color.White;
            register_btn.Location = new Point(475, 534);
            register_btn.Name = "register_btn";
            register_btn.Size = new Size(128, 42);
            register_btn.TabIndex = 17;
            register_btn.Text = "SIGNUP";
            register_btn.UseVisualStyleBackColor = false;
            register_btn.Click += register_btn_Click;
            // 
            // txtshowPass
            // 
            txtshowPass.AutoSize = true;
            txtshowPass.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtshowPass.Location = new Point(475, 336);
            txtshowPass.Name = "txtshowPass";
            txtshowPass.Size = new Size(174, 25);
            txtshowPass.TabIndex = 16;
            txtshowPass.Text = "Show Password";
            txtshowPass.UseVisualStyleBackColor = true;
            txtshowPass.CheckedChanged += txtshowPass_CheckedChanged;
            // 
            // txtpassword
            // 
            txtpassword.BorderStyle = BorderStyle.FixedSingle;
            txtpassword.Font = new Font("Segoe UI", 12F);
            txtpassword.Location = new Point(475, 219);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.Size = new Size(273, 34);
            txtpassword.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(469, 191);
            label4.Name = "label4";
            label4.Size = new Size(104, 21);
            label4.TabIndex = 14;
            label4.Text = "Password:";
            // 
            // txt_username
            // 
            txt_username.BorderStyle = BorderStyle.FixedSingle;
            txt_username.Font = new Font("Segoe UI", 12F);
            txt_username.Location = new Point(475, 140);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(273, 34);
            txt_username.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(469, 112);
            label3.Name = "label3";
            label3.Size = new Size(108, 21);
            label3.TabIndex = 12;
            label3.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(469, 69);
            label2.Name = "label2";
            label2.Size = new Size(107, 27);
            label2.TabIndex = 11;
            label2.Text = "SIGN UP";
            // 
            // close
            // 
            close.AutoSize = true;
            close.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            close.Location = new Point(1017, 3);
            close.Name = "close";
            close.Size = new Size(22, 23);
            close.TabIndex = 10;
            close.Text = "X";
            close.Click += close_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(7, 99, 102);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(register_loginBtn);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(375, 623);
            panel1.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(20, 197);
            label6.Name = "label6";
            label6.Size = new Size(320, 23);
            label6.TabIndex = 9;
            label6.Text = "Cafe Shop Management System";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(135, 94);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 10F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(79, 468);
            label5.Name = "label5";
            label5.Size = new Size(220, 20);
            label5.TabIndex = 9;
            label5.Text = "Already have an account?";
            // 
            // register_loginBtn
            // 
            register_loginBtn.BackColor = Color.FromArgb(7, 99, 102);
            register_loginBtn.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_loginBtn.ForeColor = Color.White;
            register_loginBtn.Location = new Point(43, 491);
            register_loginBtn.Name = "register_loginBtn";
            register_loginBtn.Size = new Size(287, 42);
            register_loginBtn.TabIndex = 9;
            register_loginBtn.Text = "SIGN IN";
            register_loginBtn.UseVisualStyleBackColor = false;
            register_loginBtn.Click += register_loginBtn_Click;
            // 
            // txtCpassword
            // 
            txtCpassword.BorderStyle = BorderStyle.FixedSingle;
            txtCpassword.Font = new Font("Segoe UI", 12F);
            txtCpassword.Location = new Point(475, 301);
            txtCpassword.Name = "txtCpassword";
            txtCpassword.PasswordChar = '*';
            txtCpassword.Size = new Size(273, 34);
            txtCpassword.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(469, 273);
            label7.Name = "label7";
            label7.Size = new Size(179, 21);
            label7.TabIndex = 18;
            label7.Text = "Confirm Password:";
            // 
            // browser_btn
            // 
            browser_btn.BackColor = Color.FromArgb(7, 99, 102);
            browser_btn.FlatStyle = FlatStyle.Flat;
            browser_btn.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            browser_btn.ForeColor = Color.White;
            browser_btn.Location = new Point(813, 376);
            browser_btn.Name = "browser_btn";
            browser_btn.Size = new Size(178, 43);
            browser_btn.TabIndex = 21;
            browser_btn.Text = "Browser";
            browser_btn.UseVisualStyleBackColor = false;
            browser_btn.Click += browser_btn_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkGray;
            panel3.Location = new Point(813, 140);
            panel3.Name = "panel3";
            panel3.Size = new Size(178, 230);
            panel3.TabIndex = 20;
            // 
            // txtImageView
            // 
            txtImageView.Location = new Point(813, 137);
            txtImageView.Name = "txtImageView";
            txtImageView.Size = new Size(178, 233);
            txtImageView.SizeMode = PictureBoxSizeMode.StretchImage;
            txtImageView.TabIndex = 16;
            txtImageView.TabStop = false;
            txtImageView.Click += txtImageView_Click;
            // 
            // txtStatus
            // 
            txtStatus.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStatus.FormattingEnabled = true;
            txtStatus.Items.AddRange(new object[] { "Active", "Inactive", "Approval" });
            txtStatus.Location = new Point(475, 478);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(273, 37);
            txtStatus.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(475, 454);
            label1.Name = "label1";
            label1.Size = new Size(72, 21);
            label1.TabIndex = 23;
            label1.Text = "Status:";
            // 
            // txtRole
            // 
            txtRole.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRole.FormattingEnabled = true;
            txtRole.Items.AddRange(new object[] { "Admin", "Staff" });
            txtRole.Location = new Point(475, 401);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(273, 37);
            txtRole.TabIndex = 27;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(475, 377);
            label8.Name = "label8";
            label8.Size = new Size(56, 21);
            label8.TabIndex = 26;
            label8.Text = "Role:";
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 623);
            Controls.Add(txtRole);
            Controls.Add(label8);
            Controls.Add(txtImageView);
            Controls.Add(txtStatus);
            Controls.Add(label1);
            Controls.Add(browser_btn);
            Controls.Add(panel3);
            Controls.Add(txtCpassword);
            Controls.Add(label7);
            Controls.Add(register_btn);
            Controls.Add(txtshowPass);
            Controls.Add(txtpassword);
            Controls.Add(label4);
            Controls.Add(txt_username);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(close);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtImageView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button register_btn;
        private CheckBox txtshowPass;
        private TextBox txtpassword;
        private Label label4;
        private TextBox txt_username;
        private Label label3;
        private Label label2;
        private Label close;
        private Panel panel1;
        private Label label6;
        private PictureBox pictureBox1;
        private Label label5;
        private Button register_loginBtn;
        private TextBox txtCpassword;
        private Label label7;
        private Button browser_btn;
        private Panel panel3;
        private PictureBox txtImageView;
        private ComboBox txtStatus;
        private Label label1;
        private ComboBox txtRole;
        private Label label8;
    }
}