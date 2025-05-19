using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.VisualBasic.ApplicationServices;
using Program_CADCAM.Configuration;

namespace Program_CADCAM
{
    public partial class Daftar_Login : Form
    {
        string connectionString;


        public Daftar_Login()
        {
            InitializeComponent();
            this.Size = new Size(520, 920);
        }

        private System.Windows.Forms.Label lblResult;

        // Perintah saat klik text box Username
        private void txtBoxUsername_Enter(object sender, EventArgs e)
        {
            if (txtBoxUser.Text == "NIK")
            {
                txtBoxUser.Text = "";
                txtBoxUser.ForeColor = Color.Black;
            }
        }

        private void txtBoxUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxUser.Text))
            {
                txtBoxUser.Text = "NIK";
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


        // button Daftar Login
        private void btnDaftar_Click(object sender, EventArgs e)
        {
            string UserId = "";
            string UserNIK = txtBoxUser.Text.Trim();
            string UserPass = txtBoxPass.Text.Trim();
            string UserName = txtBoxName.Text.Trim();
            string UserPhone = txtBoxPhone.Text.Trim();
            string Depart = cmbBoxDepart.Text.Trim();
            string Team = cmbBoxTeam.Text.Trim();

            // Validasi input kosong
            if (string.IsNullOrWhiteSpace(UserNIK) || string.IsNullOrWhiteSpace(UserPass) ||
                string.IsNullOrWhiteSpace(UserName) || string.IsNullOrWhiteSpace(UserPhone) ||
                string.IsNullOrWhiteSpace(Depart) || string.IsNullOrWhiteSpace(Team))
            {
                MessageBox.Show("Harap isi semua kolom!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Generate USER_ID otomatis (format U00001, U00002, dst)
                    string queryMaxID = "SELECT ISNULL(MAX(CAST(SUBSTRING(USER_ID, 2, LEN(USER_ID) - 1) AS INT)), 0) FROM MASTER_USER";
                    using (SqlCommand cmdMax = new SqlCommand(queryMaxID, conn))
                    {
                        object result = cmdMax.ExecuteScalar();
                        int nextID = (result != DBNull.Value) ? Convert.ToInt32(result) + 1 : 1;
                        UserId = "U" + nextID.ToString("D3"); // Format: U001
                    }

                    // Cek apakah USER_NIK sudah terdaftar
                    string checkQuery = "SELECT COUNT(*) FROM MASTER_USER WHERE USER_NIK = @USER_NIK";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@USER_NIK", UserNIK);
                        int exists = Convert.ToInt32(checkCmd.ExecuteScalar());
                        if (exists > 0)
                        {
                            MessageBox.Show("NIK sudah terdaftar. Gunakan NIK lain.", "Registrasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Masukkan data ke database
                    string insertQuery = @"INSERT INTO MASTER_USER 
                    (USER_ID,USER_NIK, USER_PASS, USER_NAME, USER_PHONE, USER_DEPART, USER_TEAM)
                    VALUES (@USER_ID,@USER_NIK, @USER_PASS, @USER_NAME, @USER_PHONE, @USER_DEPART, @USER_TEAM)";

                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@USER_ID", UserId);
                        insertCmd.Parameters.AddWithValue("@USER_NIK", UserNIK);
                        insertCmd.Parameters.AddWithValue("@USER_PASS", UserPass); // Recommended: hash in production
                        insertCmd.Parameters.AddWithValue("@USER_NAME", UserName);
                        insertCmd.Parameters.AddWithValue("@USER_PHONE", UserPhone);
                        insertCmd.Parameters.AddWithValue("@USER_DEPART", Depart);
                        insertCmd.Parameters.AddWithValue("@USER_TEAM", Team);

                        insertCmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Registrasi berhasil! Silakan login.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear form input
                txtBoxUser.Text = "";
                txtBoxPass.Text = "";
                txtBoxName.Text = "";
                txtBoxPhone.Text = "";
                cmbBoxDepart.SelectedIndex = -1;
                cmbBoxTeam.SelectedIndex = -1;

                this.Close(); // Tutup form registrasi setelah login
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Daftar_Login_Load(object sender, EventArgs e)
        {
            connectionString = Connection.ConnectionString;
        }
    }
}

