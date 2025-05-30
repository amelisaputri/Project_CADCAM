using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Design.AxImporter;

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
            //this.Dock = DockStyle.Top;
            this.BackColor = Color.Transparent;

            //LbText.MaximumSize = new Size(340, 0); // Fix max width to 340px
            //LbText.AutoSize = true;

            //Panel_Typing.AutoSize = true;
            //Panel_Typing.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            //this.AutoSize = true;
            //this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            if (isSender)
            {
                //bubble chat Pengirim
                this.Dock = DockStyle.None;
                this.Margin = new Padding(170, 5, 0, 5);
                //this.Padding = new Padding(50, 5, 10, 5);  // Right align
                this.Anchor = AnchorStyles.Top | AnchorStyles.Right;

                //Untuk Panel_Typing 
                Panel_Typing.AutoSize = true;
                Panel_Typing.Dock = DockStyle.None;

                LbText.BackColor = Color.LightBlue;
                LbText.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                LbText.TextAlign = ContentAlignment.MiddleRight;
                LbText.Width = Panel_Typing.Width;

                LbTime.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
                LbTime.TextAlign = ContentAlignment.BottomLeft;
                LbTime.AutoSize = true;
                LbTime.Location = new Point(0, Panel_Typing.Height - LbTime.Height);

                LbName.Anchor = AnchorStyles.Right;

                picProfile.Visible = false;

            }
            else
            {
                //bubble chat Penerima
                //this.Padding = new Padding(10, 5, 50, 5);  // Left align
                this.Dock = DockStyle.None;
                this.Margin = new Padding(0, 5, 170, 5);

                LbTime.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
                LbTime.TextAlign = ContentAlignment.MiddleRight;
                LbTime.AutoSize = true;
                //LbTime.Location = new Point(LbText.Width - LbTime.Width, Panel_Typing.Height - LbTime.Height);

                LbText.BackColor = Color.LightYellow;
                LbText.TextAlign = ContentAlignment.MiddleLeft;
                LbText.Width = Panel_Typing.Width;


            }
        }

        private void ControlChat_Load(object sender, EventArgs e)
        {
            
        }
    }
}
