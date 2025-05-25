using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ServerProgram
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }

        private TcpListener server;
        private readonly List<ClientSession> clients = new List<ClientSession>();
        private List<string> messageHistory = new List<string>();
        private readonly object lockObj = new object();

        string username = "";
        string userNIK = "";

        private void ServerForm_Load(object sender, EventArgs e)
        {
            Thread serverThread = new Thread(StartServer);
            serverThread.IsBackground = true;
            serverThread.Start();
        }

        private void StartServer()
        {
            server = new TcpListener(IPAddress.Any, 5000);
            server.Start();
            AppendLog("Server started on port 5000...");

            while (true)
            {
                TcpClient client = server.AcceptTcpClient();
                AppendLog("Client connected.");

                Thread clientThread = new Thread(() => HandleClient(client));
                clientThread.IsBackground = true;
                clientThread.Start();
            }
        }

        private void HandleClient(TcpClient client)
        {
            var stream = client.GetStream();
            var reader = new StreamReader(stream, Encoding.UTF8);
            var writer = new StreamWriter(stream) { AutoFlush = true };

            string localUserNIK = null;
            string localUsername = null;

            try
            {
                // Wait for LOGIN message only once, block until login received
                while (string.IsNullOrEmpty(localUsername))
                {
                    string loginLine = reader.ReadLine();
                    if (string.IsNullOrWhiteSpace(loginLine)) continue;

                    if (loginLine.StartsWith("LOGIN|"))
                    {
                        var parts = loginLine.Split('|');
                        if (parts.Length >= 3)
                        {
                            localUserNIK = parts[1];
                            localUsername = parts[2];
                            AppendLog($"User logged in: {localUserNIK} - {localUsername}");
                        }
                    }
                    else
                    {
                        // Ignore any message before login
                        AppendLog("Expected LOGIN message, got: " + loginLine);
                    }
                }
            }
            catch (Exception ex)
            {
                AppendLog("Error reading login info: " + ex.Message);
                client.Close();
                return;
            }

            var session = new ClientSession
            {
                Client = client,
                Reader = reader,
                Writer = writer,
                UserNIK = localUserNIK,
                Username = localUsername
            };

            lock (lockObj)
            {
                clients.Add(session);
            }

            // Send chat history to new client (optional)
            lock (lockObj)
            {
                foreach (var msg in messageHistory)
                {
                    try { writer.WriteLine(msg); }
                    catch { }
                }
            }

            try
            {
                while (client.Connected)
                {
                    string line = reader.ReadLine();
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    if (line.StartsWith("LOGOUT|"))
                    {
                        AppendLog($"User {localUsername} logged out.");
                        break;
                    }
                    else if (line.StartsWith("PING"))
                    {
                        // Handle ping to prevent disconnect
                        AppendLog($"PING received from {localUsername}");
                    }
                    else if (line.StartsWith("CHAT|"))
                    {
                        // Format: CHAT|senderNIK|receiverNIK|message
                        var parts = line.Split('|');
                        if (parts.Length >= 4)
                        {
                            string senderNIK = parts[1];
                            string receiverNIK = parts[2];
                            string messageText = string.Join('|', parts, 3, parts.Length - 3);

                            string timestamped = $"[{DateTime.Now:HH:mm:ss}] {localUsername}: {messageText}";
                            AppendLog(timestamped);

                            lock (lockObj)
                            {
                                messageHistory.Add(timestamped);
                            }

                            SendMessageToUsers(timestamped, senderNIK, receiverNIK);
                        }
                        else
                        {
                            AppendLog("Invalid CHAT message format received.");
                        }
                    }
                    else
                    {
                        AppendLog($"Unknown message received: {line}");
                    }
                }
            }
            catch (Exception ex)
            {
                AppendLog($"Connection lost with {localUsername}: {ex.Message}");
            }
            finally
            {
                lock (lockObj)
                {
                    clients.Remove(session);
                }
                client.Close();
                AppendLog($"User {localUsername} disconnected.");
            }
        }



        private void SendMessageToUsers(string message, string senderNIK, string receiverNIK)
        {
            lock (lockObj)
            {
                foreach (var client in clients)
                {
                    try
                    {
                        if (client.UserNIK == senderNIK || client.UserNIK == receiverNIK)
                        {
                            client.Writer.WriteLine(message);
                        }
                    }
                    catch
                    {
                        // Handle disconnected clients if needed
                    }
                }
            }
        }

        private void AppendLog(string text)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => AppendLog(text)));
            }
            else
            {
                ListUser.Items.Add(text);
                ListUser.TopIndex = ListUser.Items.Count - 1;

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ListUser.Items.Clear();
        }
    }

    public class ClientSession
    {
        public TcpClient Client { get; set; }
        public string Username { get; set; }
        public string UserNIK { get; set; }
        public StreamReader Reader { get; set; }
        public StreamWriter Writer { get; set; }
    }


}
