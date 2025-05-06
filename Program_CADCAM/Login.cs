using System.Data;
using System.Data.SqlClient;

namespace Program_CADCAM
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private System.Windows.Forms.Label lblResult;

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtBoxUser.Text == "Username")
            {
                txtBoxUser.Text = "";
                txtBoxUser.ForeColor = Color.Black;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxUser.Text))
            {
                txtBoxUser.Text = "Username";
                txtBoxUser.ForeColor = Color.Gray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtBoxPass.Text == "Password")
            {
                txtBoxPass.Text = "";
                txtBoxPass.UseSystemPasswordChar = true;
                txtBoxPass.ForeColor = Color.Black;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxPass.Text))
            {
                txtBoxPass.UseSystemPasswordChar = false;
                txtBoxPass.Text = "Password";
                txtBoxPass.ForeColor = Color.Gray;
            }
        }
        private void btn_Login(object sender, EventArgs e)
        {
            string UserId = txtBoxUser.Text.Trim();
            string UserPass = txtBoxPass.Text.Trim();

            if (string.IsNullOrEmpty(UserId) || string.IsNullOrEmpty(UserPass))
            {
                lblResult.Text = "Mohon Masukkan NIK dan Password!";
                lblResult.ForeColor = System.Drawing.Color.Red;
                return;
            }

            if (UserId == "User" && UserPass == "1234")
            {
                this.Hide();
                MessageBox.Show("Welcome, User!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Main Main_Menu = new Main();
                Main_Menu.ShowDialog();
                this.Show();
                return;
            }

            // Clear input
            txtBoxUser.Text = "";
            txtBoxPass.Text = "";

        }


        // Move to Page Daftar_login
        private void LinkCreateAcc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Create and show the daftar_login form
            Daftar_Login registerForm = new Daftar_Login();
            registerForm.Show();
        }
    }
}
