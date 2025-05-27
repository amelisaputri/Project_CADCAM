    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using System.IO;
    using System.Net.Sockets;
    using System.Threading;
    using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
    using Microsoft.VisualBasic.ApplicationServices;
    using System.Data.SqlClient;
    using System.Runtime.Serialization.DataContracts;
    using Program_CADCAM.Configuration;

    namespace Program_CADCAM
    {
    public partial class ChatForm : Form
    {

        public ChatForm()
        {
            InitializeComponent();
            this.Size = new Size(520, 920);
        }

        string userId;
        string username;
        string depart;
        string contactId;      // Lawan bicara
        string contactName;    // Nama lawan bicara
        string connectionString;

        private TcpClient client;
        private StreamReader reader;
        private StreamWriter writer;


        // Method untuk memuat data kontak
        public void Load_DataContact(string _userId, string _userName, string _contactId, string _contactName, string _department)
        {
            userId = _userId;
            username = _userName;

            contactId = _contactId;
            contactName = _contactName;
            
        }

        public Action OnChatFinised;


        private void ChatForm_Load(object sender, EventArgs e)
        {
            lblNama.Text = contactName;

            connectionString = Connection.ConnectionString;

            LoadChatWithContact(contactId);

            Thread receiveThread = new Thread(ReceiveMessages);
            receiveThread.IsBackground = true;
            receiveThread.Start();

            pollTimer.Enabled = true;
            pollTimer.Start();

            this.Text = "Login as " + username;
        }

        private void SendMessageToContact(string userId, string contactId, string message)
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "INSERT INTO MASTER_CHAT (SENDER_ID, RECEIVER_ID, MESSAGE_TEXT, CHAT_DATE) " +
                               "VALUES (@SENDER_ID, @RECEIVER_ID, @MESSAGE_TEXT, @CHAT_DATE)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SENDER_ID", userId);
                    cmd.Parameters.AddWithValue("@RECEIVER_ID", contactId);
                    cmd.Parameters.AddWithValue("@MESSAGE_TEXT", message);
                    cmd.Parameters.AddWithValue("@CHAT_DATE", DateTime.Now); // Bisa juga dihapus agar pakai DEFAULT GETDATE()


                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void LoadChatWithContact(string contactId)
        {
            txtBoxChat.Clear();  // Clear previous chat

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                                SELECT SENDER_ID, MESSAGE_TEXT, CHAT_DATE 
                                FROM MASTER_CHAT 
                                WHERE (SENDER_ID = @USER_ID AND RECEIVER_ID = @RECEIVER_ID) 
                                   OR (SENDER_ID = @RECEIVER_ID AND RECEIVER_ID = @USER_ID)
                                ORDER BY CHAT_DATE";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@USER_ID", userId);         // Your own ID
                    cmd.Parameters.AddWithValue("@RECEIVER_ID", contactId);  // The person you're chatting with

                    try
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string sender = reader["SENDER_ID"].ToString();
                                string msg = reader["MESSAGE_TEXT"].ToString();
                                DateTime time = Convert.ToDateTime(reader["CHAT_DATE"]);

                                // Format: [HH:mm:ss] username: message
                                string senderName = sender == userId ? username : contactName;
                                string formatted = $"[{time:HH:mm:ss}] {senderName}: {msg}";

                                txtBoxChat.AppendText(formatted + Environment.NewLine);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Gagal memuat chat: " + ex.Message);
                    }
                }
            }
        }


        private void ReceiveMessages()
        {
            try
            {
                while (GlobalClient.Client != null && GlobalClient.Client.Connected)
                {
                    string line = GlobalClient.Reader.ReadLine();
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        AppendToChatBox(line);
                    }
                }
            }
            catch (Exception ex)
            {
                // Optionally log or show the error
                MessageBox.Show("Connection lost: " + ex.Message);
            }
        }

        private void AppendToChatBox(string msg)
        {
            if (txtBoxChat.InvokeRequired)
            {
                txtBoxChat.Invoke(new Action<string>(AppendToChatBox), msg);
            }
            else
            {
                txtBoxChat.AppendText(msg + Environment.NewLine);
            }
        }


        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBoxMessage.Text))
            {
                string message = txtBoxMessage.Text;
                string formatted = $"CHAT|{GlobalClient.UserId}|{contactId}|{message}";

                if (GlobalClient.IsConnected())
                {
                    GlobalClient.Writer.WriteLine(formatted);
                    SendMessageToContact(GlobalClient.UserId, contactId, message);
                    txtBoxMessage.Clear();
                }
                else
                {
                    MessageBox.Show("Not connected to server.");
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pollTimer_Tick(object sender, EventArgs e)
        {
            while (GlobalClient.IncomingMessages.TryDequeue(out string msg))
            {
                AppendToChatBox(msg);  // Already thread-safe
            }
        }

        private void txtBoxMesaage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnSend.PerformClick(); // bantu panggil button send
                
            }
        }
    }
}
