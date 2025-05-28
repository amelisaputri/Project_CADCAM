using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_CADCAM
{
    public partial class ControlChat : UserControl
    {
        public ControlChat()
        {
            InitializeComponent();
        }
         
        public void SetMessage(string name, string time, string message, bool isSender)
        {
            LbName.Text = name;
            LbTime.Text = time;
            LbText.Text = message;

            // Atur align dan background berdasarkan pengirim/penerima
            this.Dock = DockStyle.Top;
            this.BackColor = Color.Transparent;

            if (isSender)
            {
                //bubble chat Pengirim
                this.Padding = new Padding(50, 5, 10, 5);  // Right align
                LbText.BackColor = Color.LightBlue;
            }
            else
            {
                //bubble chat Penerima
                this.Padding = new Padding(10, 5, 50, 5);  // Left align
                LbText.BackColor = Color.LightYellow;
            }
        }
    }
}
