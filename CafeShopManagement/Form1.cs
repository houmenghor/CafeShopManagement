namespace CafeShopManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();

            this.Hide();
        }

        private void login_registerBtn_Click(object sender, EventArgs e)
        {

        }

        private void login_registerBtn_Click_1(object sender, EventArgs e)
        {
            RegisterForm RegForm = new RegisterForm();
            RegForm.Show();

            this.Hide();
        }

        private void txtshowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtpassword.PasswordChar = txtshowPass.Checked ? '\0' : '*';
        }
    }
}
