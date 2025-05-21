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
        public void Load_DataContact(string userId, string userName, string contactId, string contactName, string department)
        {
            this.userId = userId;
            this.username = userName;
            this.contactId = contactId;
            this.contactName = contactName;

            lblNama.Text = username; 
        }

        private void ChatForm_Load(object sender, EventArgs e)
        {
            lblNama.Text = username;
            connectionString = Connection.ConnectionString;

            try
            {
                client = new TcpClient(Connection.IPAddress, 5000);
                var stream = client.GetStream();
                reader = new StreamReader(stream, Encoding.UTF8);
                writer = new StreamWriter(stream, Encoding.UTF8) { AutoFlush = true };

                // Send username to identify
                writer.WriteLine($"__username__:{username}");

                // Start background thread to receive messages
                Thread receiveThread = new Thread(ReceiveMessages);
                receiveThread.IsBackground = true;
                receiveThread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect to chat server: " + ex.Message);
                this.Close();
            }

        }

        private void SendMessageToContact(string senderId, string receiverId, string message)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO MASTER_CHAT (USER_ID, SENDER_ID, RECEIVER_ID, MESSAGE_TEXT, CHAT_DATE) " +
                               "VALUES (@USER_ID, @SENDER_ID, @RECEIVER_ID, @MESSAGE_TEXT, @CHAT_DATE)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@USER_ID", senderId); // atau bisa receiverId, tergantung desain tabel kamu
                cmd.Parameters.AddWithValue("@SENDER_ID", senderId);
                cmd.Parameters.AddWithValue("@RECEIVER_ID", receiverId);
                cmd.Parameters.AddWithValue("@MESSAGE_TEXT", message);
                cmd.Parameters.AddWithValue("@CHAT_DATE", DateTime.Now);

                conn.Open();
                cmd.ExecuteNonQuery();
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
                                    WHERE (SENDER_ID = @USER_ID AND RECEIVER_ID = @ RECEIVER_ID) 
                                        OR (SENDER_ID = @ RECEIVER_ID AND RECEIVER_ID = @USER_ID)
                                    ORDER BY CHAT_DATE";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@USER_ID", userId);
                    cmd.Parameters.AddWithValue("@RECEIVER_ID", contactId);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string sender = reader["SENDER_ID"].ToString();
                        string msg = reader["MESSAGE_TEXT"].ToString();
                        DateTime time = Convert.ToDateTime(reader["CHAT_DATE"]);

                        string display = sender == userId ? $"You: {msg}" : $"Them: {msg}";
                        txtBoxChat.AppendText($"{display} ({time.ToShortTimeString()})\r\n");
                    }
                    try
                    {
                        conn.Open();
                        int result = cmd.ExecuteNonQuery();
                        if (result == 0)
                        {
                            MessageBox.Show("Gagal menyimpan pesan.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error saat mengirim pesan: " + ex.Message);
                    }

                }
            }

        }

        private void ReceiveMessages()
        {
            while (client.Connected)
            {
                try
                {
                    string line = reader.ReadLine();
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        AppendToChatBox(line);
                    }
                }
                catch
                {
                    break;
                }
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

                // Send to chat server
                writer.WriteLine(message);

                // Save to DB
                SendMessageToContact(userId, contactId, message);

                txtBoxMessage.Clear();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
