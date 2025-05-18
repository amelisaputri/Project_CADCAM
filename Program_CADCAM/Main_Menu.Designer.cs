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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            Main_Menu = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            panel1 = new Panel();
            DataChat = new DataGridView();
            Chat = new DataGridViewTextBoxColumn();
            tabPage2 = new TabPage();
            panel2 = new Panel();
            DataContact = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            Profil = new Panel();
            btnLogout = new Button();
            User = new PictureBox();
            btnSend = new Button();
            LblNama_Karyawan = new Label();
            LblDepart = new Label();
            Main_Menu.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataChat).BeginInit();
            tabPage2.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataContact).BeginInit();
            Profil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)User).BeginInit();
            SuspendLayout();
            // 
            // Main_Menu
            // 
            Main_Menu.BackColor = SystemColors.ControlLightLight;
            Main_Menu.Controls.Add(tabControl1);
            Main_Menu.Controls.Add(Profil);
            Main_Menu.Dock = DockStyle.Fill;
            Main_Menu.Location = new Point(0, 0);
            Main_Menu.Margin = new Padding(4, 5, 4, 5);
            Main_Menu.Name = "Main_Menu";
            Main_Menu.Size = new Size(605, 1050);
            Main_Menu.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 145);
            tabControl1.Margin = new Padding(2, 3, 2, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(605, 905);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel1);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Margin = new Padding(2, 3, 2, 3);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2, 3, 2, 3);
            tabPage1.Size = new Size(597, 867);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Chat";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(DataChat);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(2, 3);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(593, 861);
            panel1.TabIndex = 3;
            // 
            // DataChat
            // 
            DataChat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataChat.Columns.AddRange(new DataGridViewColumn[] { Chat });
            DataChat.Dock = DockStyle.Fill;
            DataChat.Location = new Point(0, 0);
            DataChat.Margin = new Padding(2, 3, 2, 3);
            DataChat.Name = "DataChat";
            DataChat.RowHeadersWidth = 62;
            DataChat.Size = new Size(593, 861);
            DataChat.TabIndex = 0;
            // 
            // Chat
            // 
            Chat.HeaderText = " ";
            Chat.MinimumWidth = 8;
            Chat.Name = "Chat";
            Chat.Width = 150;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel2);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Margin = new Padding(2, 3, 2, 3);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2, 3, 2, 3);
            tabPage2.Size = new Size(597, 867);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Contact";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(DataContact);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(2, 3);
            panel2.Margin = new Padding(2, 3, 2, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(593, 861);
            panel2.TabIndex = 4;
            // 
            // DataContact
            // 
            DataContact.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataContact.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1 });
            DataContact.Dock = DockStyle.Fill;
            DataContact.Location = new Point(0, 0);
            DataContact.Margin = new Padding(2, 3, 2, 3);
            DataContact.Name = "DataContact";
            DataContact.RowHeadersWidth = 62;
            DataContact.Size = new Size(593, 861);
            DataContact.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = " ";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 150;
            // 
            // Profil
            // 
            Profil.Controls.Add(btnLogout);
            Profil.Controls.Add(User);
            Profil.Controls.Add(btnSend);
            Profil.Controls.Add(LblNama_Karyawan);
            Profil.Controls.Add(LblDepart);
            Profil.Dock = DockStyle.Top;
            Profil.Location = new Point(0, 0);
            Profil.Margin = new Padding(4, 5, 4, 5);
            Profil.Name = "Profil";
            Profil.Size = new Size(605, 145);
            Profil.TabIndex = 2;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLogout.BackgroundImage = Properties.Resources.logout__1_;
            btnLogout.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogout.Location = new Point(542, 55);
            btnLogout.Margin = new Padding(2, 3, 2, 3);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(42, 42);
            btnLogout.TabIndex = 6;
            btnLogout.TextAlign = ContentAlignment.TopCenter;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // User
            // 
            User.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            User.Image = Properties.Resources.icon_2;
            User.Location = new Point(372, 30);
            User.Margin = new Padding(4, 5, 4, 5);
            User.Name = "User";
            User.Size = new Size(82, 83);
            User.SizeMode = PictureBoxSizeMode.StretchImage;
            User.TabIndex = 0;
            User.TabStop = false;
            // 
            // btnSend
            // 
            btnSend.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSend.BackgroundImage = Properties.Resources.settings1;
            btnSend.BackgroundImageLayout = ImageLayout.Stretch;
            btnSend.Location = new Point(484, 59);
            btnSend.Margin = new Padding(2, 3, 2, 3);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(32, 33);
            btnSend.TabIndex = 5;
            btnSend.UseVisualStyleBackColor = true;
            // 
            // LblNama_Karyawan
            // 
            LblNama_Karyawan.AutoSize = true;
            LblNama_Karyawan.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            LblNama_Karyawan.Location = new Point(34, 30);
            LblNama_Karyawan.Margin = new Padding(4, 0, 4, 0);
            LblNama_Karyawan.Name = "LblNama_Karyawan";
            LblNama_Karyawan.Size = new Size(188, 29);
            LblNama_Karyawan.TabIndex = 3;
            LblNama_Karyawan.Text = "Nama Karyawan";
            // 
            // LblDepart
            // 
            LblDepart.AutoSize = true;
            LblDepart.Font = new Font("Microsoft Sans Serif", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 129);
            LblDepart.Location = new Point(34, 72);
            LblDepart.Margin = new Padding(4, 0, 4, 0);
            LblDepart.Name = "LblDepart";
            LblDepart.Size = new Size(113, 25);
            LblDepart.TabIndex = 4;
            LblDepart.Text = "Department";
            LblDepart.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(605, 1050);
            ControlBox = false;
            Controls.Add(Main_Menu);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Main_Load;
            Main_Menu.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataChat).EndInit();
            tabPage2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataContact).EndInit();
            Profil.ResumeLayout(false);
            Profil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)User).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Main_Menu;
        private Panel Profil;
        private PictureBox User;
        private Label LblDepart;
        private Label LblNama_Karyawan;
        private Button btnLogout;
        private Button btnSend;
        private Panel panel1;
        private DataGridView DataChat;
        private DataGridViewTextBoxColumn Chat;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel panel2;
        private DataGridView DataContact;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}