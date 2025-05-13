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
            Chat = new TabPage();
            Grup_Chat = new TabPage();
            Profil = new Panel();
            button1 = new Button();
            btnSend = new Button();
            Nama_Karyawan = new Label();
            Depart = new Label();
            Logout = new PictureBox();
            User = new PictureBox();
            Main_Menu.SuspendLayout();
            tabControl1.SuspendLayout();
            Profil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logout).BeginInit();
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
            Main_Menu.Name = "Main_Menu";
            Main_Menu.Size = new Size(339, 530);
            Main_Menu.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Chat);
            tabControl1.Controls.Add(Grup_Chat);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 87);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(339, 443);
            tabControl1.TabIndex = 3;
            // 
            // Chat
            // 
            Chat.BackgroundImageLayout = ImageLayout.Stretch;
            Chat.Location = new Point(4, 24);
            Chat.Name = "Chat";
            Chat.Padding = new Padding(3, 3, 3, 3);
            Chat.Size = new Size(331, 415);
            Chat.TabIndex = 0;
            Chat.Text = "Chat";
            Chat.UseVisualStyleBackColor = true;
            // 
            // Grup_Chat
            // 
            Grup_Chat.Location = new Point(4, 24);
            Grup_Chat.Name = "Grup_Chat";
            Grup_Chat.Padding = new Padding(3, 3, 3, 3);
            Grup_Chat.Size = new Size(335, 452);
            Grup_Chat.TabIndex = 1;
            Grup_Chat.Text = "Grup Chat";
            Grup_Chat.UseVisualStyleBackColor = true;
            // 
            // Profil
            // 
            Profil.Controls.Add(button1);
            Profil.Controls.Add(btnSend);
            Profil.Controls.Add(Nama_Karyawan);
            Profil.Controls.Add(Depart);
            Profil.Controls.Add(Logout);
            Profil.Controls.Add(User);
            Profil.Dock = DockStyle.Top;
            Profil.Location = new Point(0, 0);
            Profil.Name = "Profil";
            Profil.Size = new Size(339, 87);
            Profil.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.logout__1_;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(295, 36);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(29, 25);
            button1.TabIndex = 6;
            button1.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            btnSend.BackgroundImage = Properties.Resources.settings1;
            btnSend.BackgroundImageLayout = ImageLayout.Stretch;
            btnSend.Location = new Point(259, 38);
            btnSend.Margin = new Padding(2, 2, 2, 2);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(23, 20);
            btnSend.TabIndex = 5;
            btnSend.UseVisualStyleBackColor = true;
            // 
            // Nama_Karyawan
            // 
            Nama_Karyawan.AutoSize = true;
            Nama_Karyawan.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            Nama_Karyawan.Location = new Point(57, 30);
            Nama_Karyawan.Name = "Nama_Karyawan";
            Nama_Karyawan.Size = new Size(124, 20);
            Nama_Karyawan.TabIndex = 3;
            Nama_Karyawan.Text = "Nama Karyawan";
            // 
            // Depart
            // 
            Depart.AutoSize = true;
            Depart.Font = new Font("Microsoft Sans Serif", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 129);
            Depart.Location = new Point(99, 49);
            Depart.Name = "Depart";
            Depart.Size = new Size(82, 17);
            Depart.TabIndex = 4;
            Depart.Text = "Department";
            Depart.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Logout
            // 
            Logout.Image = Properties.Resources.logout__1_;
            Logout.Location = new Point(295, 34);
            Logout.Name = "Logout";
            Logout.Size = new Size(0, 0);
            Logout.SizeMode = PictureBoxSizeMode.StretchImage;
            Logout.TabIndex = 2;
            Logout.TabStop = false;
            // 
            // User
            // 
            User.Image = Properties.Resources.icon_2;
            User.Location = new Point(192, 20);
            User.Name = "User";
            User.Size = new Size(52, 45);
            User.SizeMode = PictureBoxSizeMode.StretchImage;
            User.TabIndex = 0;
            User.TabStop = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 530);
            Controls.Add(Main_Menu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main";
            Main_Menu.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            Profil.ResumeLayout(false);
            Profil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Logout).EndInit();
            ((System.ComponentModel.ISupportInitialize)User).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Main_Menu;
        private Panel Profil;
        private PictureBox User;
        private TabControl tabControl1;
        private TabPage Chat;
        private TabPage Grup_Chat;
        private PictureBox Logout;
        private Label Depart;
        private Label Nama_Karyawan;
        private Button button1;
        private Button btnSend;
    }
}