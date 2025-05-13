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
            Nama_Karyawan = new Label();
            Depart = new Label();
            Logout = new PictureBox();
            Setting = new PictureBox();
            User = new PictureBox();
            Main_Menu.SuspendLayout();
            tabControl1.SuspendLayout();
            Profil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Setting).BeginInit();
            ((System.ComponentModel.ISupportInitialize)User).BeginInit();
            SuspendLayout();
            // 
            // Main_Menu
            // 
            Main_Menu.BackColor = SystemColors.ControlLightLight;
            Main_Menu.Controls.Add(tabControl1);
            Main_Menu.Controls.Add(Profil);
            Main_Menu.Location = new Point(-2, 0);
            Main_Menu.Margin = new Padding(5, 6, 5, 6);
            Main_Menu.Name = "Main_Menu";
            Main_Menu.Size = new Size(610, 1194);
            Main_Menu.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Chat);
            tabControl1.Controls.Add(Grup_Chat);
            tabControl1.Location = new Point(0, 178);
            tabControl1.Margin = new Padding(5, 6, 5, 6);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(588, 960);
            tabControl1.TabIndex = 3;
            // 
            // Chat
            // 
            Chat.BackgroundImageLayout = ImageLayout.Stretch;
            Chat.Location = new Point(4, 39);
            Chat.Margin = new Padding(5, 6, 5, 6);
            Chat.Name = "Chat";
            Chat.Padding = new Padding(5, 6, 5, 6);
            Chat.Size = new Size(580, 917);
            Chat.TabIndex = 0;
            Chat.Text = "Chat";
            Chat.UseVisualStyleBackColor = true;
            // 
            // Grup_Chat
            // 
            Grup_Chat.Location = new Point(4, 39);
            Grup_Chat.Margin = new Padding(5, 6, 5, 6);
            Grup_Chat.Name = "Grup_Chat";
            Grup_Chat.Padding = new Padding(5, 6, 5, 6);
            Grup_Chat.Size = new Size(580, 917);
            Grup_Chat.TabIndex = 1;
            Grup_Chat.Text = "Grup Chat";
            Grup_Chat.UseVisualStyleBackColor = true;
            // 
            // Profil
            // 
            Profil.Controls.Add(Nama_Karyawan);
            Profil.Controls.Add(Depart);
            Profil.Controls.Add(Logout);
            Profil.Controls.Add(Setting);
            Profil.Controls.Add(User);
            Profil.Location = new Point(2, 0);
            Profil.Margin = new Padding(5, 6, 5, 6);
            Profil.Name = "Profil";
            Profil.Size = new Size(605, 174);
            Profil.TabIndex = 2;
            // 
            // Nama_Karyawan
            // 
            Nama_Karyawan.AutoSize = true;
            Nama_Karyawan.Font = new Font("Pretendard", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            Nama_Karyawan.Location = new Point(97, 60);
            Nama_Karyawan.Margin = new Padding(5, 0, 5, 0);
            Nama_Karyawan.Name = "Nama_Karyawan";
            Nama_Karyawan.Size = new Size(220, 34);
            Nama_Karyawan.TabIndex = 3;
            Nama_Karyawan.Text = "Nama Karyawan";
            // 
            // Depart
            // 
            Depart.AutoSize = true;
            Depart.Font = new Font("Pretendard", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 129);
            Depart.Location = new Point(170, 98);
            Depart.Margin = new Padding(5, 0, 5, 0);
            Depart.Name = "Depart";
            Depart.Size = new Size(140, 29);
            Depart.TabIndex = 4;
            Depart.Text = "Department";
            Depart.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Logout
            // 
            Logout.Image = Properties.Resources.logout__1_;
            Logout.Location = new Point(505, 68);
            Logout.Margin = new Padding(5, 6, 5, 6);
            Logout.Name = "Logout";
            Logout.Size = new Size(45, 45);
            Logout.SizeMode = PictureBoxSizeMode.StretchImage;
            Logout.TabIndex = 2;
            Logout.TabStop = false;
            // 
            // Setting
            // 
            Setting.Image = Properties.Resources.settings;
            Setting.Location = new Point(440, 71);
            Setting.Margin = new Padding(5, 6, 5, 6);
            Setting.Name = "Setting";
            Setting.Size = new Size(40, 40);
            Setting.SizeMode = PictureBoxSizeMode.StretchImage;
            Setting.TabIndex = 1;
            Setting.TabStop = false;
            // 
            // User
            // 
            User.Image = Properties.Resources.icon_2;
            User.Location = new Point(329, 39);
            User.Margin = new Padding(5, 6, 5, 6);
            User.Name = "User";
            User.Size = new Size(90, 90);
            User.SizeMode = PictureBoxSizeMode.StretchImage;
            User.TabIndex = 0;
            User.TabStop = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 1130);
            Controls.Add(Main_Menu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            Name = "Main";
            Main_Menu.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            Profil.ResumeLayout(false);
            Profil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Logout).EndInit();
            ((System.ComponentModel.ISupportInitialize)Setting).EndInit();
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
        private PictureBox Setting;
        private PictureBox Logout;
        private Label Depart;
        private Label Nama_Karyawan;
    }
}