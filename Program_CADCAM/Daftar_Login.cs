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

namespace Program_CADCAM
{
    public partial class Daftar_Login : Form
    {
        string connectionString = "Server=10.10.92.41;Database=CADCAM;User ID=sa;Password=vision2028;";

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


        // button Daftar Login
        private void btnDaftar_Click(object sender, EventArgs e)
        {
            //string IdUser = txtBoxUser.Text.Trim();
            //string PassUser = txtBoxPass.Text.Trim();
            //string User_name = txtBoxName.Text.Trim();
            //string UserPhone = txtBoxPhone.Text.Trim();
            //string Depart = cmbBoxDepart.Text.Trim();
            //string Team = cmbBoxTeam.Text.Trim();

            //if (string.IsNullOrEmpty(IdUser) || string.IsNullOrEmpty(PassUser))
            //{
            //    lblResult.Text = "Lengkapi kolom Berikut!";
            //    lblResult.ForeColor = System.Drawing.Color.Red;
            //    return;
            //}

            //// Validate inputs
            //if (string.IsNullOrWhiteSpace(txtBoxUser.Text) ||
            //    string.IsNullOrWhiteSpace(txtBoxPass.Text) ||
            //    string.IsNullOrWhiteSpace(txtBoxName.Text) ||
            //    string.IsNullOrWhiteSpace(txtBoxPhone.Text) ||
            //    string.IsNullOrWhiteSpace(cmbBoxDepart.Text) ||
            //    string.IsNullOrWhiteSpace(cmbBoxTeam.Text))
            //{
            //    MessageBox.Show("Harap isi semua kolom!", "Validasi Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //try
            //{
            //    using (SqlConnection conn = new SqlConnection(connectionString))
            //    {
            //        conn.Open();

            //        string woodenID = txtWID.Text.Trim();
            //        bool isNewEntry = false;

            //        if (string.IsNullOrEmpty(woodenID))
            //        {
            //            // Generate new Wooden_ID
            //            int newWoodenID = 1;
            //            string queryMaxID = "SELECT ISNULL(MAX(CAST(SUBSTRING(WOODEN_ID, 2, LEN(WOODEN_ID) - 1) AS INT)), 0) FROM MASTER_WOODEN";

            //            using (SqlCommand cmdMax = new SqlCommand(queryMaxID, conn))
            //            {
            //                object result = cmdMax.ExecuteScalar();
            //                newWoodenID = (result != DBNull.Value) ? Convert.ToInt32(result) + 1 : 1;
            //            }

            //            woodenID = "W" + newWoodenID.ToString("D5"); // Format W00001
            //            isNewEntry = true;
            //        }

            //        // Check if Wooden_ID exists
            //        string checkExistenceQuery = "SELECT COUNT(*) FROM MASTER_WOODEN WHERE WOODEN_ID = @WOODEN_ID";
            //        using (SqlCommand cmdCheck = new SqlCommand(checkExistenceQuery, conn))
            //        {
            //            cmdCheck.Parameters.AddWithValue("@WOODEN_ID", woodenID);
            //            int count = Convert.ToInt32(cmdCheck.ExecuteScalar());

            //            if (count > 0)
            //            {
            //                // UPDATE Existing Record
            //                string updateQuery = @"UPDATE MASTER_WOODEN
            //                               SET MODEL_NAME = @MODEL_NAME,
            //                                   TOOLCODE = @TOOLCODE,
            //                                   MOLD_TYPE = @MOLD_TYPE,
            //                                   MOLD_TYPE_DETAIL = @MOLD_TYPE_DETAIL,
            //                                   MOLD_GENDER = @MOLD_GENDER,
            //                                   SIZE_MIN = @SIZE_MIN,
            //                                   SIZE_MAX = @SIZE_MAX,
            //                                   PIM = @PIM,
            //                                   MOLD_ORIGIN = @MOLD_ORIGIN,
            //                                   CREATE_DATE = @CREATE_DATE
            //                               WHERE WOODEN_ID = @WOODEN_ID";

            //                using (SqlCommand cmdUpdate = new SqlCommand(updateQuery, conn))
            //                {
            //                    cmdUpdate.Parameters.AddWithValue("@WOODEN_ID", woodenID);
            //                    cmdUpdate.Parameters.AddWithValue("@MODEL_NAME", textBoxNM.Text);
            //                    cmdUpdate.Parameters.AddWithValue("@TOOLCODE", textBoxTC.Text);
            //                    cmdUpdate.Parameters.AddWithValue("@MOLD_TYPE", textBoxJM.Text);
            //                    cmdUpdate.Parameters.AddWithValue("@MOLD_TYPE_DETAIL", DetailMold.Text);
            //                    cmdUpdate.Parameters.AddWithValue("@MOLD_GENDER", textBoxG.Text);
            //                    cmdUpdate.Parameters.AddWithValue("@SIZE_MIN", MinSize.Text);
            //                    cmdUpdate.Parameters.AddWithValue("@SIZE_MAX", MaxSize.Text);
            //                    cmdUpdate.Parameters.AddWithValue("@PIM", Pim.Text);
            //                    cmdUpdate.Parameters.AddWithValue("@MOLD_ORIGIN", Origin.Text);
            //                    cmdUpdate.Parameters.AddWithValue("@CREATE_DATE", Convert.ToDateTime(dateIn.Text));
            //                    cmdUpdate.ExecuteNonQuery();
            //                }

            //                MessageBox.Show("Data berhasil diperbarui!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            }
            //            else
            //            {
            //                // INSERT New Record
            //                string insertQuery = @"INSERT INTO MASTER_WOODEN 
            //                              (WOODEN_ID, MODEL_NAME, TOOLCODE, MOLD_TYPE, MOLD_TYPE_DETAIL, MOLD_GENDER, SIZE_MIN, SIZE_MAX, PIM, MOLD_ORIGIN, CREATE_DATE)
            //                              VALUES 
            //                              (@WOODEN_ID, @MODEL_NAME, @TOOLCODE, @MOLD_TYPE, @MOLD_TYPE_DETAIL, @MOLD_GENDER, @SIZE_MIN, @SIZE_MAX, @PIM, @MOLD_ORIGIN, @CREATE_DATE)";

            //                using (SqlCommand cmdInsert = new SqlCommand(insertQuery, conn))
            //                {
            //                    cmdInsert.Parameters.AddWithValue("@WOODEN_ID", woodenID);
            //                    cmdInsert.Parameters.AddWithValue("@MODEL_NAME", textBoxNM.Text);
            //                    cmdInsert.Parameters.AddWithValue("@TOOLCODE", textBoxTC.Text);
            //                    cmdInsert.Parameters.AddWithValue("@MOLD_TYPE", textBoxJM.Text);
            //                    cmdInsert.Parameters.AddWithValue("@MOLD_TYPE_DETAIL", DetailMold.Text);
            //                    cmdInsert.Parameters.AddWithValue("@MOLD_GENDER", textBoxG.Text);
            //                    cmdInsert.Parameters.AddWithValue("@SIZE_MIN", MinSize.Text);
            //                    cmdInsert.Parameters.AddWithValue("@SIZE_MAX", MaxSize.Text);
            //                    cmdInsert.Parameters.AddWithValue("@PIM", Pim.Text);
            //                    cmdInsert.Parameters.AddWithValue("@MOLD_ORIGIN", Origin.Text);
            //                    cmdInsert.Parameters.AddWithValue("@CREATE_DATE", Convert.ToDateTime(dateIn.Text));
            //                    cmdInsert.ExecuteNonQuery();
            //                }

            //                MessageBox.Show("Data berhasil ditambahkan ke database!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            }
            //        }

            //        // Insert into HISTORY_WOODEN (only for new records)
            //        if (isNewEntry)
            //        {
            //            string insertHistoryQuery = @"INSERT INTO HISTORY_WOODEN (WOODEN_ID, RACK_ID, DATE, STATUS)
            //                                  VALUES (@WOODEN_ID, @RACK_ID, GETDATE(), 'NEW')";

            //            using (SqlCommand cmdInsertHistory = new SqlCommand(insertHistoryQuery, conn))
            //            {
            //                cmdInsertHistory.Parameters.AddWithValue("@WOODEN_ID", woodenID);
            //                cmdInsertHistory.Parameters.AddWithValue("@RACK_ID", cmbBoxRak.SelectedValue?.ToString() ?? ""); // Prevent Null Reference
            //                cmdInsertHistory.ExecuteNonQuery();
            //            }
            //        }

            //        // Update RACK_STATUS to "Y" in MASTER_RACK
            //        string updateRackQuery = "UPDATE MASTER_RACK SET RACK_STATUS = 'Y' WHERE RACK_ID = @RACK_ID";
            //        using (SqlCommand cmdUpdateRack = new SqlCommand(updateRackQuery, conn))
            //        {
            //            cmdUpdateRack.Parameters.AddWithValue("@RACK_ID", cmbBoxRak.SelectedValue?.ToString() ?? "");
            //            cmdUpdateRack.ExecuteNonQuery();
            //        }

            //        // Clear and refresh after success
            //        ClearAll();
            //        GetData();
            //        GetDataRack();
            //    }
            //}
            //catch (SqlException sqlEx)
            //{
            //    MessageBox.Show("SQL Error: " + sqlEx.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //catch (FormatException formatEx)
            //{
            //    MessageBox.Show("Format Error: " + formatEx.Message, "Data Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Unexpected Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}

