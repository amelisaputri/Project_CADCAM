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


        private System.Windows.Forms.Label lblResult;
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

            // Contoh validasi login manual (bisa diganti dengan validasi database)
            if (UserId == "User" && UserPass == "1234")
            {
                lblResult.Text = "Login successful!";
                lblResult.ForeColor = System.Drawing.Color.Green;

                // Clear input
                txtBoxUser.Text = "";
                txtBoxPass.Text = "";

            }
            
        }
    }
}
