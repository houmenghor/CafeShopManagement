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
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // register_btn
            // 
            register_btn.BackColor = Color.FromArgb(7, 99, 102);
            register_btn.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_btn.ForeColor = Color.White;
            register_btn.Location = new Point(378, 400);
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
            txtshowPass.Location = new Point(378, 344);
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
            txtpassword.Location = new Point(378, 227);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.Size = new Size(273, 34);
            txtpassword.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(372, 199);
            label4.Name = "label4";
            label4.Size = new Size(104, 21);
            label4.TabIndex = 14;
            label4.Text = "Password:";
            // 
            // txt_username
            // 
            txt_username.BorderStyle = BorderStyle.FixedSingle;
            txt_username.Font = new Font("Segoe UI", 12F);
            txt_username.Location = new Point(378, 148);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(273, 34);
            txt_username.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(372, 120);
            label3.Name = "label3";
            label3.Size = new Size(108, 21);
            label3.TabIndex = 12;
            label3.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(372, 77);
            label2.Name = "label2";
            label2.Size = new Size(107, 27);
            label2.TabIndex = 11;
            label2.Text = "SIGN UP";
            // 
            // close
            // 
            close.AutoSize = true;
            close.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            close.Location = new Point(661, 3);
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
            panel1.Size = new Size(337, 484);
            panel1.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(12, 163);
            label6.Name = "label6";
            label6.Size = new Size(320, 23);
            label6.TabIndex = 9;
            label6.Text = "Cafe Shop Management System";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(118, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 109);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 10F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(59, 407);
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
            register_loginBtn.Location = new Point(23, 430);
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
            txtCpassword.Location = new Point(378, 309);
            txtCpassword.Name = "txtCpassword";
            txtCpassword.PasswordChar = '*';
            txtCpassword.Size = new Size(273, 34);
            txtCpassword.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(372, 281);
            label7.Name = "label7";
            label7.Size = new Size(179, 21);
            label7.TabIndex = 18;
            label7.Text = "Confirm Password:";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 484);
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
    }
}