namespace Program_CADCAM
{
    partial class Main
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
            TreeNode treeNode1 = new TreeNode("Contact User");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            Main_Menu = new Panel();
            tblLytPnl_MainMenu = new TableLayoutPanel();
            Profil = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            User = new PictureBox();
            LblNama_Karyawan = new Label();
            LblDepart = new Label();
            btnSetting = new Button();
            btnLogout = new Button();
            tabControl_ListContact = new TabControl();
            tabPage_ListContact = new TabPage();
            panel_ListContact = new Panel();
            ListUser = new TreeView();
            tabPage_Chat = new TabPage();
            tableLayoutPanel_Chat = new TableLayoutPanel();
            panel1 = new Panel();
            lbKaryawan = new Label();
            Main_Menu.SuspendLayout();
            tblLytPnl_MainMenu.SuspendLayout();
            Profil.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)User).BeginInit();
            tabControl_ListContact.SuspendLayout();
            tabPage_ListContact.SuspendLayout();
            panel_ListContact.SuspendLayout();
            tabPage_Chat.SuspendLayout();
            tableLayoutPanel_Chat.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Main_Menu
            // 
            Main_Menu.BackColor = SystemColors.ControlLightLight;
            Main_Menu.Controls.Add(tblLytPnl_MainMenu);
            Main_Menu.Dock = DockStyle.Fill;
            Main_Menu.Location = new Point(0, 0);
            Main_Menu.Name = "Main_Menu";
            Main_Menu.Size = new Size(360, 548);
            Main_Menu.TabIndex = 0;
            // 
            // tblLytPnl_MainMenu
            // 
            tblLytPnl_MainMenu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tblLytPnl_MainMenu.ColumnCount = 1;
            tblLytPnl_MainMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblLytPnl_MainMenu.Controls.Add(Profil, 0, 0);
            tblLytPnl_MainMenu.Controls.Add(tabControl_ListContact, 0, 1);
            tblLytPnl_MainMenu.Location = new Point(-1, 0);
            tblLytPnl_MainMenu.Margin = new Padding(2, 2, 2, 2);
            tblLytPnl_MainMenu.Name = "tblLytPnl_MainMenu";
            tblLytPnl_MainMenu.RowCount = 2;
            tblLytPnl_MainMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 18.59956F));
            tblLytPnl_MainMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 81.40044F));
            tblLytPnl_MainMenu.RowStyles.Add(new RowStyle(SizeType.Absolute, 12F));
            tblLytPnl_MainMenu.Size = new Size(360, 548);
            tblLytPnl_MainMenu.TabIndex = 3;
            // 
            // Profil
            // 
            Profil.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Profil.Controls.Add(tableLayoutPanel1);
            Profil.Location = new Point(3, 3);
            Profil.Name = "Profil";
            Profil.Size = new Size(354, 95);
            Profil.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.5907631F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.26387739F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.4348545F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.44988871F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.2449884F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 7F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 37F));
            tableLayoutPanel1.Controls.Add(User, 2, 1);
            tableLayoutPanel1.Controls.Add(LblNama_Karyawan, 0, 1);
            tableLayoutPanel1.Controls.Add(LblDepart, 0, 2);
            tableLayoutPanel1.Controls.Add(btnSetting, 4, 1);
            tableLayoutPanel1.Controls.Add(btnLogout, 6, 1);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(2, 2, 2, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 21.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 78.3333359F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.Size = new Size(354, 95);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // User
            // 
            User.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            User.Image = Properties.Resources.icon_2;
            User.Location = new Point(182, 10);
            User.Name = "User";
            tableLayoutPanel1.SetRowSpan(User, 2);
            User.Size = new Size(85, 71);
            User.SizeMode = PictureBoxSizeMode.StretchImage;
            User.TabIndex = 0;
            User.TabStop = false;
            // 
            // LblNama_Karyawan
            // 
            LblNama_Karyawan.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            LblNama_Karyawan.AutoSize = true;
            LblNama_Karyawan.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            LblNama_Karyawan.ImageAlign = ContentAlignment.TopLeft;
            LblNama_Karyawan.Location = new Point(3, 15);
            LblNama_Karyawan.Name = "LblNama_Karyawan";
            LblNama_Karyawan.Size = new Size(124, 20);
            LblNama_Karyawan.TabIndex = 3;
            LblNama_Karyawan.Text = "Nama Karyawan";
            // 
            // LblDepart
            // 
            LblDepart.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LblDepart.AutoSize = true;
            LblDepart.Font = new Font("Microsoft Sans Serif", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 129);
            LblDepart.ImageAlign = ContentAlignment.TopLeft;
            LblDepart.Location = new Point(3, 35);
            LblDepart.Name = "LblDepart";
            LblDepart.Size = new Size(166, 17);
            LblDepart.TabIndex = 4;
            LblDepart.Text = "Department";
            // 
            // btnSetting
            // 
            btnSetting.Anchor = AnchorStyles.Left;
            btnSetting.BackgroundImage = Properties.Resources.settings1;
            btnSetting.BackgroundImageLayout = ImageLayout.Stretch;
            btnSetting.ImageAlign = ContentAlignment.MiddleLeft;
            btnSetting.Location = new Point(278, 33);
            btnSetting.Margin = new Padding(1, 2, 1, 2);
            btnSetting.Name = "btnSetting";
            tableLayoutPanel1.SetRowSpan(btnSetting, 2);
            btnSetting.Size = new Size(28, 24);
            btnSetting.TabIndex = 5;
            btnSetting.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Left;
            btnLogout.BackgroundImage = Properties.Resources.logout__1_;
            btnLogout.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(316, 30);
            btnLogout.Margin = new Padding(1, 2, 1, 2);
            btnLogout.Name = "btnLogout";
            tableLayoutPanel1.SetRowSpan(btnLogout, 2);
            btnLogout.Size = new Size(35, 30);
            btnLogout.TabIndex = 6;
            btnLogout.TextAlign = ContentAlignment.TopCenter;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // tabControl_ListContact
            // 
            tabControl_ListContact.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl_ListContact.Controls.Add(tabPage_ListContact);
            tabControl_ListContact.Controls.Add(tabPage_Chat);
            tabControl_ListContact.Location = new Point(1, 103);
            tabControl_ListContact.Margin = new Padding(1, 2, 1, 2);
            tabControl_ListContact.Name = "tabControl_ListContact";
            tabControl_ListContact.SelectedIndex = 0;
            tabControl_ListContact.Size = new Size(358, 443);
            tabControl_ListContact.TabIndex = 1;
            // 
            // tabPage_ListContact
            // 
            tabPage_ListContact.Controls.Add(panel_ListContact);
            tabPage_ListContact.Font = new Font("Malgun Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            tabPage_ListContact.Location = new Point(4, 24);
            tabPage_ListContact.Margin = new Padding(1, 2, 1, 2);
            tabPage_ListContact.Name = "tabPage_ListContact";
            tabPage_ListContact.Padding = new Padding(1, 2, 1, 2);
            tabPage_ListContact.Size = new Size(350, 415);
            tabPage_ListContact.TabIndex = 0;
            tabPage_ListContact.Text = "List Contact ";
            tabPage_ListContact.UseVisualStyleBackColor = true;
            // 
            // panel_ListContact
            // 
            panel_ListContact.Controls.Add(ListUser);
            panel_ListContact.Dock = DockStyle.Fill;
            panel_ListContact.Location = new Point(1, 2);
            panel_ListContact.Margin = new Padding(1, 2, 1, 2);
            panel_ListContact.Name = "panel_ListContact";
            panel_ListContact.Size = new Size(348, 411);
            panel_ListContact.TabIndex = 3;
            // 
            // ListUser
            // 
            ListUser.Dock = DockStyle.Fill;
            ListUser.Font = new Font("Malgun Gothic", 10F, FontStyle.Bold);
            ListUser.ItemHeight = 20;
            ListUser.Location = new Point(0, 0);
            ListUser.Margin = new Padding(2, 2, 2, 2);
            ListUser.Name = "ListUser";
            treeNode1.Name = "Contact_User";
            treeNode1.Text = "Contact User";
            ListUser.Nodes.AddRange(new TreeNode[] { treeNode1 });
            ListUser.Size = new Size(348, 411);
            ListUser.TabIndex = 0;
            ListUser.NodeMouseDoubleClick += ListUser_NodeMouseDoubleClick;
            // 
            // tabPage_Chat
            // 
            tabPage_Chat.Controls.Add(tableLayoutPanel_Chat);
            tabPage_Chat.Location = new Point(4, 24);
            tabPage_Chat.Margin = new Padding(1, 2, 1, 2);
            tabPage_Chat.Name = "tabPage_Chat";
            tabPage_Chat.Padding = new Padding(1, 2, 1, 2);
            tabPage_Chat.Size = new Size(350, 415);
            tabPage_Chat.TabIndex = 1;
            tabPage_Chat.Text = "Chat";
            tabPage_Chat.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel_Chat
            // 
            tableLayoutPanel_Chat.ColumnCount = 1;
            tableLayoutPanel_Chat.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel_Chat.Controls.Add(panel1, 0, 0);
            tableLayoutPanel_Chat.Dock = DockStyle.Fill;
            tableLayoutPanel_Chat.Location = new Point(1, 2);
            tableLayoutPanel_Chat.Margin = new Padding(2, 2, 2, 2);
            tableLayoutPanel_Chat.Name = "tableLayoutPanel_Chat";
            tableLayoutPanel_Chat.RowCount = 8;
            tableLayoutPanel_Chat.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel_Chat.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel_Chat.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel_Chat.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel_Chat.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel_Chat.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel_Chat.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel_Chat.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel_Chat.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel_Chat.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel_Chat.Size = new Size(348, 411);
            tableLayoutPanel_Chat.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(lbKaryawan);
            panel1.Location = new Point(2, 2);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(344, 47);
            panel1.TabIndex = 0;
            // 
            // lbKaryawan
            // 
            lbKaryawan.AutoSize = true;
            lbKaryawan.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbKaryawan.Location = new Point(22, 17);
            lbKaryawan.Margin = new Padding(2, 0, 2, 0);
            lbKaryawan.Name = "lbKaryawan";
            lbKaryawan.Size = new Size(107, 17);
            lbKaryawan.TabIndex = 0;
            lbKaryawan.Text = "Nama Karyawan";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(360, 548);
            Controls.Add(Main_Menu);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Main_Load;
            Main_Menu.ResumeLayout(false);
            tblLytPnl_MainMenu.ResumeLayout(false);
            Profil.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)User).EndInit();
            tabControl_ListContact.ResumeLayout(false);
            tabPage_ListContact.ResumeLayout(false);
            panel_ListContact.ResumeLayout(false);
            tabPage_Chat.ResumeLayout(false);
            tableLayoutPanel_Chat.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Main_Menu;
        private Panel Profil;
        private Label LblNama_Karyawan;
        private Button btnLogout;
        private Button btnSetting;
        private Panel panel_ListContact;
        private TabControl tabControl_ListContact;
        private TabPage tabPage_ListContact;
        private TabPage tabPage_Chat;
        private TreeView ListUser;
        private TableLayoutPanel tableLayoutPanel_Chat;
        private Panel panel1;
        private TableLayoutPanel tblLytPnl_MainMenu;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox User;
        private Label LblDepart;
        private Label lbKaryawan;
    }
}