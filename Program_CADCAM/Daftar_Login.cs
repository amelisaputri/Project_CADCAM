using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_CADCAM
{
    public partial class Daftar_Login : Form
    {
        public Daftar_Login()
        {
            InitializeComponent();

        }
        private System.Windows.Forms.Label lblResult;

        // Perintah saat klik text box Username
        private void txtBoxUsername_Enter(object sender, EventArgs e)
        {
            if (txtBoxUser.Text == "Username")
            {
                txtBoxUser.Text = "";
                txtBoxUser.ForeColor = Color.Black;
            }
        }

        private void txtBoxUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxUser.Text))
            {
                txtBoxUser.Text = "Username";
                txtBoxUser.ForeColor = Color.Gray;
            }
        }

        // Perintah saat klik text box Password
        private void txtBoxPassword_Enter(object sender, EventArgs e)
        {
            if (txtBoxPass.Text == "Password")
            {
                txtBoxPass.Text = "";
                txtBoxPass.UseSystemPasswordChar = true;
                txtBoxPass.ForeColor = Color.Black;
            }
        }

        private void txtBoxPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxPass.Text))
            {
                txtBoxPass.UseSystemPasswordChar = false;
                txtBoxPass.Text = "Password";
                txtBoxPass.ForeColor = Color.Gray;
            }
        }

        // Perintah saat klik text box Nama Karyawan
        private void txtBoxNama_Enter(object sender, EventArgs e)
        {
            if (txtBoxName.Text == "Nama Karyawan")
            {
                txtBoxName.Text = "";
                txtBoxName.ForeColor = Color.Black;
            }
        }

        private void txtBoxNama_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxName.Text))
            {
                txtBoxName.Text = "Nama Karyawan";
                txtBoxName.ForeColor = Color.Gray;
            }
        }

        // Perintah saat klik text box Nomor Handphone
        private void txtBoxPhone_Enter(object sender, EventArgs e)
        {
            if (txtBoxPhone.Text == "Nomor Handphone")
            {
                txtBoxPhone.Text = "";
                txtBoxPhone.ForeColor = Color.Black;
            }
        }

        private void txtBoxPhone_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxPhone.Text))
            {
                txtBoxPhone.Text = "Nomor Handphone";
                txtBoxPhone.ForeColor = Color.Gray;
            }
        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            string IdUser = txtBoxUser.Text.Trim();
            string PassUser = txtBoxPass.Text.Trim();
            string User_name = txtBoxName.Text.Trim();
            string UserPhone = txtBoxPhone.Text.Trim();

            if (string.IsNullOrEmpty(IdUser) || string.IsNullOrEmpty(PassUser))
            {
                lblResult.Text = "Lengkapi kolom Berikut!";
                lblResult.ForeColor = System.Drawing.Color.Red;
                return;
            }

            //if (UserId == "User" && UserPass == "1234")
            //{
            //    this.Hide();
            //    MessageBox.Show("Welcome, User!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    Main Main_Menu = new Main();
            //    Main_Menu.ShowDialog();
            //    this.Show();
            //    return;
            //}

            // Clear input
            txtBoxUser.Text = "";
            txtBoxPass.Text = "";
            txtBoxName.Text = "";
            txtBoxPhone.Text = "";
        }
    }
}
