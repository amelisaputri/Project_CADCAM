using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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
            this.Size = new Size(520, 920);

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

                    string query = "SELECT USER_NIK, USER_NAME FROM MASTER_USER WHERE USER_NIK != @USER_NIK"; // Adjust table name and columns if needed

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Add the parameter value
                        cmd.Parameters.AddWithValue("@USER_NIK", userId);

                        // Use the command in the adapter
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        /// Clear existing node
                        ListUser.Nodes.Clear();

                        // Add each USER_NAME as a root node
                        foreach (DataRow row in dt.Rows)
                        {
                            string userName = row["USER_NAME"].ToString();
                            ListUser.Nodes.Add(new TreeNode(userName));
                        }

                        ListUser.ExpandAll(); // Optional: show all nodes
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadUserList()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT USER_NIK, USER_NAME FROM MASTER_USER WHERE USER_NIK != @USER_NIK";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@USER_NIK", userId); // userId = user yang login

                        SqlDataReader reader = cmd.ExecuteReader();

                        ListUser.Nodes.Clear();

                        while (reader.Read())
                        {
                            string userNik = reader["USER_NIK"].ToString();
                            string userName = reader["USER_NAME"].ToString();

                            TreeNode node = new TreeNode(userName); // shown in the tree
                            node.Tag = userNik; // store the NIK as value

                            ListUser.Nodes.Add(node);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat user: " + ex.Message);
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
            LoadUserList();

        }

        private void ListUser_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode selectedNode = e.Node;
            if (selectedNode != null)
            {
                string selectedUserNik = selectedNode.Tag.ToString();
                string selectedUserName = selectedNode.Text;

                this.Hide();
                ChatForm form = new ChatForm();
                form.Load_DataContact(selectedUserNik, selectedUserName, "");
                form.ShowDialog();
                this.Show();
            }
        }
    }
}
