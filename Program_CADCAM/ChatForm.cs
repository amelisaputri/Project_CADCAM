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
        string connectionString;

        public void Load_DataContact(string id, string name, string department)
        {
            userId = id;
            username = name;
            depart = department;
        }

        private void ChatForm_Load(object sender, EventArgs e)
        {
            lblNama.Text = username;
        }

        //private void treeViewUsers_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        //{
        //    string selectedUserName = e.Node.Tag?.ToString();

        //    if (!string.IsNullOrEmpty(selectedUserName))
        //    {
        //        // Buka ChatForm dan kirim user name
        //        ChatForm chatForm = new ChatForm();
        //        chatForm.ShowDialog();
        //        chatForm.Show();
        //    }
        //}

    }
}
