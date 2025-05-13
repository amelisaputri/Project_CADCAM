using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Threading;

namespace ServerProgram
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }

        private TcpListener server;
        private List<TcpClient> clients = new List<TcpClient>();
        private List<string> messageHistory = new List<string>();
        private readonly object lockObj = new object();

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
                lock (clients) clients.Add(client);
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
            var writer = new StreamWriter(stream, Encoding.UTF8) { AutoFlush = true };

            string username = "Unknown";

            try
            {
                // 🔐 Expect first line to be username
                string firstLine = reader.ReadLine();
                if (firstLine.StartsWith("__username__:"))
                {
                    username = firstLine.Substring("__username__:".Length).Trim();
                    AppendLog($"Client identified as '{username}'");
                }
            }
            catch
            {
                AppendLog("Failed to read username");
            }

            // 🧠 Send today's history
            lock (lockObj)
            {
                foreach (var msg in messageHistory)
                {
                    writer.WriteLine(msg);
                }
            }

            // 🔄 Main message loop
            while (client.Connected)
            {
                try
                {
                    string line = reader.ReadLine();
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    string timestamped = $"[{DateTime.Now:HH:mm:ss}] {username}: {line}";
                    AppendLog(timestamped);

                    lock (lockObj) messageHistory.Add(timestamped);
                    BroadcastMessage(timestamped);
                }
                catch
                {
                    break;
                }
            }

            lock (clients) clients.Remove(client);
            client.Close();
            AppendLog($"Client '{username}' disconnected.");
        }


        private void BroadcastMessage(string msg)
        {
            lock (clients)
            {
                foreach (var client in clients)
                {
                    try
                    {
                        var writer = new StreamWriter(client.GetStream(), Encoding.UTF8) { AutoFlush = true };
                        writer.WriteLine(msg);
                    }
                    catch { }
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
                //ListServer.Items.Add(text);
                //ListServer.TopIndex.ListSer.Items.Count - 1;
                
            }
        }
    }

}
