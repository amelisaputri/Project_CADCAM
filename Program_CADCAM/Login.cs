using System.Data;
using System.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using Program_CADCAM.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Program_CADCAM
{
    public partial class Login : Form
    {
        string userId;
        string userName;
        string userDepartment;
        string connectionString;



        public Login()
        {
            InitializeComponent();
            this.Size = new Size(520, 920);
        }

        private System.Windows.Forms.Label lblResult;

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtBoxUser.Text == "NIK")
            {
                txtBoxUser.Text = "";
                txtBoxUser.ForeColor = Color.Black;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxUser.Text))
            {
                txtBoxUser.Text = "NIK";
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
            string UserNIK = txtBoxUser.Text.Trim();
            string UserPass = txtBoxPass.Text.Trim();

            if (string.IsNullOrEmpty(UserNIK) || string.IsNullOrEmpty(UserPass))
            {
                lblResult.Text = "Mohon Masukkan NIK dan Password!";
                lblResult.ForeColor = System.Drawing.Color.Red;
                return;
            }
            try
            {
                // Connect to the database
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Query to get user information (username and password, and role)
                    string query = "SELECT USER_NIK, USER_PASS, USER_NAME, USER_DEPART FROM MASTER_USER WHERE USER_NIK = @USER_NIK ";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@USER_NIK", UserNIK);
                        cmd.Parameters.AddWithValue("@USER_PASS", UserPass);

                        // Execute the query
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {

                            string dbPassword = reader["USER_PASS"].ToString();
                            string userNIK = reader["USER_NIK"].ToString();
                            string Name = reader["USER_NAME"].ToString();
                            string Depart = reader["USER_DEPART"].ToString();

                            // Check if password matches
                            if (UserPass == dbPassword)
                            {
                                userName = Name;
                                userId = UserNIK;
                                userDepartment = Depart;

                                this.Hide();
                                MessageBox.Show("Selamat Datang "+userName, "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Main main = new Main();
                                main.Load_Data(userId,userName,userDepartment);
                                main.ShowDialog();
                                this.Show();
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("User not found. Please register.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                // Clear input
                txtBoxUser.Text = "";
                txtBoxPass.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        // Move to Page Daftar_login
        private void LinkCreateAcc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Daftar_Login registerForm = new Daftar_Login();
            registerForm.ShowDialog();
            this.Show();
        }

        private void LinkCreateAcc_MouseEnter(object sender, EventArgs e)
        {
            LinkCreateAcc.ForeColor = Color.Blue;
        }

        private void LinkCreateAcc_MouseLeave(object sender, EventArgs e)
        {
            LinkCreateAcc.ForeColor = Color.Black;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Connection.LoadConnectionString();
            connectionString = Connection.ConnectionString;
        }
    }
}
