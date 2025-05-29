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
            Panel_Sender = new Panel();
            LayoutPanel_Sender = new TableLayoutPanel();
            btnSend = new Button();
            Panel_ChatForm = new Panel();
            LayoutPanelChat = new TableLayoutPanel();
            LayoutPanelUser = new TableLayoutPanel();
            btnMenu = new Button();
            lblNama = new Label();
            btnLogout = new Button();
            Panel_Chat = new FlowLayoutPanel();
            Panel_Sender.SuspendLayout();
            LayoutPanel_Sender.SuspendLayout();
            Panel_ChatForm.SuspendLayout();
            LayoutPanelChat.SuspendLayout();
            LayoutPanelUser.SuspendLayout();
            SuspendLayout();
            // 
            // txtBoxMessage
            // 
            txtBoxMessage.Dock = DockStyle.Fill;
            txtBoxMessage.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxMessage.Location = new Point(1, 2);
            txtBoxMessage.Margin = new Padding(1, 2, 1, 2);
            txtBoxMessage.Multiline = true;
            txtBoxMessage.Name = "txtBoxMessage";
            LayoutPanel_Sender.SetRowSpan(txtBoxMessage, 2);
            txtBoxMessage.Size = new Size(343, 60);
            txtBoxMessage.TabIndex = 0;
            txtBoxMessage.KeyDown += txtBoxMesaage_KeyDown;
            // 
            // Panel_Sender
            // 
            Panel_Sender.BackColor = SystemColors.ControlLightLight;
            Panel_Sender.Controls.Add(LayoutPanel_Sender);
            Panel_Sender.Dock = DockStyle.Fill;
            Panel_Sender.Location = new Point(1, 625);
            Panel_Sender.Margin = new Padding(1, 2, 1, 2);
            Panel_Sender.Name = "Panel_Sender";
            Panel_Sender.Size = new Size(396, 64);
            Panel_Sender.TabIndex = 2;
            // 
            // LayoutPanel_Sender
            // 
            LayoutPanel_Sender.ColumnCount = 2;
            LayoutPanel_Sender.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 87.30469F));
            LayoutPanel_Sender.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.6953125F));
            LayoutPanel_Sender.Controls.Add(btnSend, 1, 0);
            LayoutPanel_Sender.Controls.Add(txtBoxMessage, 0, 0);
            LayoutPanel_Sender.Dock = DockStyle.Fill;
            LayoutPanel_Sender.Location = new Point(0, 0);
            LayoutPanel_Sender.Margin = new Padding(3, 4, 3, 4);
            LayoutPanel_Sender.Name = "LayoutPanel_Sender";
            LayoutPanel_Sender.RowCount = 2;
            LayoutPanel_Sender.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            LayoutPanel_Sender.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            LayoutPanel_Sender.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            LayoutPanel_Sender.Size = new Size(396, 64);
            LayoutPanel_Sender.TabIndex = 5;
            // 
            // btnSend
            // 
            btnSend.Anchor = AnchorStyles.None;
            btnSend.BackgroundImage = Properties.Resources.message__1_;
            btnSend.BackgroundImageLayout = ImageLayout.Stretch;
            btnSend.Location = new Point(350, 12);
            btnSend.Margin = new Padding(1, 2, 1, 2);
            btnSend.Name = "btnSend";
            LayoutPanel_Sender.SetRowSpan(btnSend, 2);
            btnSend.Size = new Size(40, 40);
            btnSend.TabIndex = 4;
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // Panel_ChatForm
            // 
            Panel_ChatForm.Controls.Add(LayoutPanelChat);
            Panel_ChatForm.Dock = DockStyle.Fill;
            Panel_ChatForm.Location = new Point(0, 0);
            Panel_ChatForm.Margin = new Padding(3, 4, 3, 4);
            Panel_ChatForm.Name = "Panel_ChatForm";
            Panel_ChatForm.Size = new Size(398, 691);
            Panel_ChatForm.TabIndex = 5;
            // 
            // LayoutPanelChat
            // 
            LayoutPanelChat.ColumnCount = 1;
            LayoutPanelChat.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            LayoutPanelChat.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 16F));
            LayoutPanelChat.Controls.Add(LayoutPanelUser, 0, 0);
            LayoutPanelChat.Controls.Add(Panel_Chat, 0, 1);
            LayoutPanelChat.Controls.Add(Panel_Sender, 0, 2);
            LayoutPanelChat.Dock = DockStyle.Fill;
            LayoutPanelChat.Location = new Point(0, 0);
            LayoutPanelChat.Margin = new Padding(3, 4, 3, 4);
            LayoutPanelChat.Name = "LayoutPanelChat";
            LayoutPanelChat.RowCount = 3;
            LayoutPanelChat.RowStyles.Add(new RowStyle(SizeType.Percent, 11.3785553F));
            LayoutPanelChat.RowStyles.Add(new RowStyle(SizeType.Percent, 78.8840256F));
            LayoutPanelChat.RowStyles.Add(new RowStyle(SizeType.Percent, 9.737417F));
            LayoutPanelChat.Size = new Size(398, 691);
            LayoutPanelChat.TabIndex = 0;
            // 
            // LayoutPanelUser
            // 
            LayoutPanelUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LayoutPanelUser.ColumnCount = 3;
            LayoutPanelUser.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.153796F));
            LayoutPanelUser.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 83.6924057F));
            LayoutPanelUser.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.153796F));
            LayoutPanelUser.Controls.Add(btnMenu, 2, 0);
            LayoutPanelUser.Controls.Add(lblNama, 1, 0);
            LayoutPanelUser.Controls.Add(btnLogout, 0, 0);
            LayoutPanelUser.Location = new Point(2, 2);
            LayoutPanelUser.Margin = new Padding(2);
            LayoutPanelUser.Name = "LayoutPanelUser";
            LayoutPanelUser.RowCount = 1;
            LayoutPanelUser.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            LayoutPanelUser.Size = new Size(394, 74);
            LayoutPanelUser.TabIndex = 0;
            // 
            // btnMenu
            // 
            btnMenu.Anchor = AnchorStyles.Right;
            btnMenu.BackgroundImage = Properties.Resources.menu;
            btnMenu.BackgroundImageLayout = ImageLayout.Stretch;
            btnMenu.Location = new Point(364, 22);
            btnMenu.Margin = new Padding(2);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(28, 29);
            btnMenu.TabIndex = 3;
            btnMenu.UseVisualStyleBackColor = true;
            // 
            // lblNama
            // 
            lblNama.Dock = DockStyle.Fill;
            lblNama.Font = new Font("Microsoft Sans Serif", 12F);
            lblNama.ImageAlign = ContentAlignment.MiddleLeft;
            lblNama.Location = new Point(33, 0);
            lblNama.Margin = new Padding(1, 0, 1, 0);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(327, 74);
            lblNama.TabIndex = 2;
            lblNama.Text = "Nama Karyawan";
            lblNama.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Right;
            btnLogout.BackgroundImage = Properties.Resources.back;
            btnLogout.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogout.Location = new Point(3, 22);
            btnLogout.Margin = new Padding(2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(27, 29);
            btnLogout.TabIndex = 4;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // Panel_Chat
            // 
            Panel_Chat.AutoScroll = true;
            Panel_Chat.BackColor = Color.White;
            Panel_Chat.Dock = DockStyle.Fill;
            Panel_Chat.Location = new Point(2, 80);
            Panel_Chat.Margin = new Padding(2);
            Panel_Chat.Name = "Panel_Chat";
            Panel_Chat.Size = new Size(394, 541);
            Panel_Chat.TabIndex = 4;
            // 
            // ChatForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 691);
            Controls.Add(Panel_ChatForm);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(1, 2, 1, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ChatForm";
            StartPosition = FormStartPosition.CenterScreen;
            FormClosing += ChatForm_FormClosing;
            Load += ChatForm_Load;
            Panel_Sender.ResumeLayout(false);
            LayoutPanel_Sender.ResumeLayout(false);
            LayoutPanel_Sender.PerformLayout();
            Panel_ChatForm.ResumeLayout(false);
            LayoutPanelChat.ResumeLayout(false);
            LayoutPanelUser.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtBoxMessage;
        private Panel Panel_Sender;
        private PictureBox pictureBox1;
        private Button btnSend;
        private Panel Panel_ChatForm;
        private TableLayoutPanel LayoutPanelChat;
        private TableLayoutPanel LayoutPanel_Sender;
        private Button btnMenu;
        private FlowLayoutPanel Panel_Chat;
        private TableLayoutPanel LayoutPanelUser;
        private Label lblNama;
        private Button btnLogout;
    }
}