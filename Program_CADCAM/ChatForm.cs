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

namespace Program_CADCAM
{
    public partial class ChatForm : Form
    {

        public ChatForm()
        {
            InitializeComponent();
            //ConnectToServer("10.10.92.41", 5000);
        }


        TcpClient client;
        StreamReader reader;
        StreamWriter writer;
        string username;


        //private void Chat_Load(object sender, EventArgs e) {

        //    username = Prompt.ShowDialog("Enter your name:", "Username");
        //    ConnectToServer("10.10.92.41",5000); // 
        //}

        private void ConnectToServer(string ip, int port)
        {
            try
            {
                client = new TcpClient(ip, port);
                var stream = client.GetStream();
                reader = new StreamReader(stream, Encoding.UTF8);
                writer = new StreamWriter(stream, Encoding.UTF8) { AutoFlush = true };

                writer.WriteLine($"__username__:{username}");

                Thread listenThread = new Thread(ListenForMessages);
                listenThread.IsBackground = true;
                listenThread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect: " + ex.Message);
            }
        }

        private void ListenForMessages()
        {
            while (client.Connected)
            {
                try
                {
                    string line = reader.ReadLine();
                    if (!string.IsNullOrEmpty(line))
                    {
                        AppendChat(line);
                    }
                }
                catch { break; }
            }
        }

        private void AppendChat(string msg)
        {
            if (txtBoxChat.InvokeRequired)
            {
                txtBoxChat.Invoke(new Action(() => AppendChat(msg)));
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
                writer.WriteLine(txtBoxMessage.Text);
                txtBoxMessage.Clear();
            }
        }
    }
    public static class Prompt
    {
        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form() { Width = 300, Height = 150, Text = caption };
            TextBox input = new TextBox() { Left = 20, Top = 20, Width = 240 };
            Button ok = new Button() { Text = "OK", Left = 190, Width = 70, Top = 60 };
            ok.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(input); prompt.Controls.Add(ok); prompt.ShowDialog();
            return input.Text;
        }
    }
}
