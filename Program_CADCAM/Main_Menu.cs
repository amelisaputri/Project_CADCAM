using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Program_CADCAM.Configuration;

namespace Program_CADCAM
{
    public partial class Main : Form
    {
        public Main()
        {

            InitializeComponent();
            this.Size = new Size(627, 1106);

        }

        string userId;
        string username;
        string depart;
        string connectionString;

        public void Load_Data(string id, string name, string department)
        {
            userId = id;
            username = name;
            depart = department;
        }

        private void Load_DataContact()
        {
            try
            {
                
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT USER_NAME FROM MASTER_USER WHERE USER_NIK != @USER_NIK"; // Adjust table name and columns if needed

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Add the parameter value
                        cmd.Parameters.AddWithValue("@USER_NIK", userId);

                        // Use the command in the adapter
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        DataContact.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            LblNama_Karyawan.Text = username;
            LblDepart.Text = depart;
            connectionString = Connection.ConnectionString;
            Load_DataContact();


        }

    }
}
