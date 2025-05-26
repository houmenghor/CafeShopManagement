namespace CafeShopManagement
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            login_registerBtn = new Button();
            close = new Label();
            label2 = new Label();
            label3 = new Label();
            txtusername = new TextBox();
            txtpassword = new TextBox();
            label4 = new Label();
            txtshowPass = new CheckBox();
            login_btn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(7, 99, 102);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(login_registerBtn);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(337, 484);
            panel1.TabIndex = 0;
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
            label5.Location = new Point(89, 407);
            label5.Name = "label5";
            label5.Size = new Size(161, 20);
            label5.TabIndex = 9;
            label5.Text = "Create an Account";
            // 
            // login_registerBtn
            // 
            login_registerBtn.BackColor = Color.FromArgb(7, 99, 102);
            login_registerBtn.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_registerBtn.ForeColor = Color.White;
            login_registerBtn.Location = new Point(27, 430);
            login_registerBtn.Name = "login_registerBtn";
            login_registerBtn.Size = new Size(287, 42);
            login_registerBtn.TabIndex = 9;
            login_registerBtn.Text = "SIGN UP";
            login_registerBtn.UseVisualStyleBackColor = false;
            login_registerBtn.Click += login_registerBtn_Click_1;
            // 
            // close
            // 
            close.AutoSize = true;
            close.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            close.Location = new Point(660, 3);
            close.Name = "close";
            close.Size = new Size(22, 23);
            close.TabIndex = 1;
            close.Text = "X";
            close.Click += close_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(371, 77);
            label2.Name = "label2";
            label2.Size = new Size(99, 27);
            label2.TabIndex = 2;
            label2.Text = "SIGN IN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(371, 120);
            label3.Name = "label3";
            label3.Size = new Size(108, 21);
            label3.TabIndex = 3;
            label3.Text = "Username:";
            // 
            // txtusername
            // 
            txtusername.BorderStyle = BorderStyle.FixedSingle;
            txtusername.Font = new Font("Segoe UI", 12F);
            txtusername.Location = new Point(377, 148);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(273, 34);
            txtusername.TabIndex = 4;
            // 
            // txtpassword
            // 
            txtpassword.BorderStyle = BorderStyle.FixedSingle;
            txtpassword.Font = new Font("Segoe UI", 12F);
            txtpassword.Location = new Point(377, 227);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.Size = new Size(273, 34);
            txtpassword.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(371, 199);
            label4.Name = "label4";
            label4.Size = new Size(104, 21);
            label4.TabIndex = 5;
            label4.Text = "Password:";
            // 
            // txtshowPass
            // 
            txtshowPass.AutoSize = true;
            txtshowPass.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtshowPass.Location = new Point(377, 267);
            txtshowPass.Name = "txtshowPass";
            txtshowPass.Size = new Size(174, 25);
            txtshowPass.TabIndex = 7;
            txtshowPass.Text = "Show Password";
            txtshowPass.UseVisualStyleBackColor = true;
            txtshowPass.CheckedChanged += txtshowPass_CheckedChanged;
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.FromArgb(7, 99, 102);
            login_btn.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_btn.ForeColor = Color.White;
            login_btn.Location = new Point(377, 324);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(128, 42);
            login_btn.TabIndex = 8;
            login_btn.Text = "LOGIN";
            login_btn.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(685, 484);
            Controls.Add(login_btn);
            Controls.Add(txtshowPass);
            Controls.Add(txtpassword);
            Controls.Add(label4);
            Controls.Add(txtusername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(close);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label close;
        private Label label2;
        private Label label3;
        private TextBox txtusername;
        private TextBox txtpassword;
        private Label label4;
        private CheckBox txtshowPass;
        private Label label5;
        private Button login_registerBtn;
        private Button login_btn;
        private Label label6;
        private PictureBox pictureBox1;
    }
}
