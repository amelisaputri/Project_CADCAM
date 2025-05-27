namespace Program_CADCAM
{
    partial class ChatForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatForm));
            txtBoxMessage = new TextBox();
            txtBoxChat = new TextBox();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnSend = new Button();
            lblNama = new Label();
            panel2 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel3 = new Panel();
            btnLogout = new Button();
            pollTimer = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // txtBoxMessage
            // 
            txtBoxMessage.Dock = DockStyle.Fill;
            txtBoxMessage.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxMessage.Location = new Point(1, 3);
            txtBoxMessage.Margin = new Padding(1, 3, 1, 3);
            txtBoxMessage.Multiline = true;
            txtBoxMessage.Name = "txtBoxMessage";
            tableLayoutPanel2.SetRowSpan(txtBoxMessage, 2);
            txtBoxMessage.Size = new Size(431, 73);
            txtBoxMessage.TabIndex = 0;
            txtBoxMessage.KeyDown += txtBoxMesaage_KeyDown;
            // 
            // txtBoxChat
            // 
            txtBoxChat.BackColor = SystemColors.ControlLightLight;
            tableLayoutPanel1.SetColumnSpan(txtBoxChat, 2);
            txtBoxChat.Dock = DockStyle.Fill;
            txtBoxChat.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxChat.Location = new Point(1, 101);
            txtBoxChat.Margin = new Padding(1, 3, 1, 3);
            txtBoxChat.Multiline = true;
            txtBoxChat.Name = "txtBoxChat";
            txtBoxChat.ReadOnly = true;
            txtBoxChat.Size = new Size(496, 675);
            txtBoxChat.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            tableLayoutPanel1.SetColumnSpan(panel1, 2);
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(1, 782);
            panel1.Margin = new Padding(1, 3, 1, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(496, 79);
            panel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 87.30469F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.6953125F));
            tableLayoutPanel2.Controls.Add(btnSend, 1, 0);
            tableLayoutPanel2.Controls.Add(txtBoxMessage, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel2.Size = new Size(496, 79);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // btnSend
            // 
            btnSend.Anchor = AnchorStyles.None;
            btnSend.BackgroundImage = Properties.Resources.message__1_;
            btnSend.BackgroundImageLayout = ImageLayout.Stretch;
            btnSend.Location = new Point(439, 14);
            btnSend.Margin = new Padding(1, 3, 1, 3);
            btnSend.Name = "btnSend";
            tableLayoutPanel2.SetRowSpan(btnSend, 2);
            btnSend.Size = new Size(50, 50);
            btnSend.TabIndex = 4;
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // lblNama
            // 
            lblNama.Font = new Font("Microsoft Sans Serif", 12F);
            lblNama.ImageAlign = ContentAlignment.MiddleLeft;
            lblNama.Location = new Point(1, 0);
            lblNama.Margin = new Padding(1, 0, 1, 0);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(252, 98);
            lblNama.TabIndex = 2;
            lblNama.Text = "Nama Karyawan";
            lblNama.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(498, 864);
            panel2.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.03857F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.9614258F));
            tableLayoutPanel1.Controls.Add(lblNama, 0, 0);
            tableLayoutPanel1.Controls.Add(txtBoxChat, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 2);
            tableLayoutPanel1.Controls.Add(panel3, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.3910189F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 78.97043F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.748083F));
            tableLayoutPanel1.Size = new Size(498, 864);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnLogout);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(258, 5);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(236, 88);
            panel3.TabIndex = 3;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Right;
            btnLogout.BackgroundImage = Properties.Resources.logout__1_;
            btnLogout.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogout.Location = new Point(149, 20);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(50, 50);
            btnLogout.TabIndex = 3;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // pollTimer
            // 
            pollTimer.Enabled = true;
            pollTimer.Interval = 500;
            pollTimer.Tick += pollTimer_Tick;
            // 
            // ChatForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 864);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(1, 3, 1, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ChatForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += ChatForm_Load;
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtBoxMessage;
        private TextBox txtBoxChat;
        private Panel panel1;
        private Label lblNama;
        private PictureBox pictureBox1;
        private Button btnSend;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnLogout;
        private Panel panel3;
        private System.Windows.Forms.Timer pollTimer;
    }
}