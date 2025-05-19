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
            this.Size = new Size(520, 920);
    
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
