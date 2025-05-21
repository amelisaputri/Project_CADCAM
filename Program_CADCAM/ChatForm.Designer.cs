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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatForm));
            txtBoxMessage = new TextBox();
            txtBoxChat = new TextBox();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnSend = new Button();
            lblNama = new Label();
            panel2 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnLogout = new Button();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
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
            txtBoxMessage.Size = new Size(445, 78);
            txtBoxMessage.TabIndex = 0;
            // 
            // txtBoxChat
            // 
            txtBoxChat.BackColor = SystemColors.ControlLightLight;
            tableLayoutPanel1.SetColumnSpan(txtBoxChat, 2);
            txtBoxChat.Dock = DockStyle.Fill;
            txtBoxChat.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxChat.Location = new Point(1, 106);
            txtBoxChat.Margin = new Padding(1, 3, 1, 3);
            txtBoxChat.Multiline = true;
            txtBoxChat.Name = "txtBoxChat";
            txtBoxChat.ReadOnly = true;
            txtBoxChat.Size = new Size(512, 714);
            txtBoxChat.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            tableLayoutPanel1.SetColumnSpan(panel1, 2);
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(1, 826);
            panel1.Margin = new Padding(1, 3, 1, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(512, 84);
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
            tableLayoutPanel2.Size = new Size(512, 84);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // btnSend
            // 
            btnSend.Anchor = AnchorStyles.None;
            btnSend.BackgroundImage = Properties.Resources.message__1_;
            btnSend.BackgroundImageLayout = ImageLayout.Stretch;
            btnSend.Location = new Point(454, 17);
            btnSend.Margin = new Padding(1, 3, 1, 3);
            btnSend.Name = "btnSend";
            tableLayoutPanel2.SetRowSpan(btnSend, 2);
            btnSend.Size = new Size(50, 50);
            btnSend.TabIndex = 4;
            btnSend.UseVisualStyleBackColor = true;
            // 
            // lblNama
            // 
            lblNama.Dock = DockStyle.Fill;
            lblNama.Font = new Font("Microsoft Sans Serif", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblNama.ImageAlign = ContentAlignment.MiddleLeft;
            lblNama.Location = new Point(1, 0);
            lblNama.Margin = new Padding(1, 0, 1, 0);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(260, 103);
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
            panel2.Size = new Size(514, 913);
            panel2.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.03857F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.9614258F));
            tableLayoutPanel1.Controls.Add(txtBoxChat, 0, 1);
            tableLayoutPanel1.Controls.Add(lblNama, 0, 0);
            tableLayoutPanel1.Controls.Add(btnLogout, 1, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.3910189F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 78.97043F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.748083F));
            tableLayoutPanel1.Size = new Size(514, 913);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Right;
            btnLogout.BackgroundImage = Properties.Resources.logout__1_;
            btnLogout.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogout.Location = new Point(461, 26);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(50, 50);
            btnLogout.TabIndex = 3;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // ChatForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 913);
            ControlBox = false;
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(1, 3, 1, 3);
            Name = "ChatForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += ChatForm_Load;
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
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
    }
}