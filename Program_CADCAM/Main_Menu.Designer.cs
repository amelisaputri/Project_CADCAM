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
            Profil = new Panel();
            btnLogout = new Button();
            btnSend = new Button();
            Nama_Karyawan = new Label();
            Depart = new Label();
            User = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            Main_Menu.SuspendLayout();
            Profil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)User).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // Main_Menu
            // 
            Main_Menu.BackColor = SystemColors.ControlLightLight;
            Main_Menu.Controls.Add(Profil);
            Main_Menu.Dock = DockStyle.Fill;
            Main_Menu.Location = new Point(0, 0);
            Main_Menu.Margin = new Padding(5, 6, 5, 6);
            Main_Menu.Name = "Main_Menu";
            Main_Menu.Size = new Size(581, 1060);
            Main_Menu.TabIndex = 0;
            // 
            // Profil
            // 
            Profil.Controls.Add(btnLogout);
            Profil.Controls.Add(User);
            Profil.Controls.Add(btnSend);
            Profil.Controls.Add(tableLayoutPanel1);
            Profil.Dock = DockStyle.Top;
            Profil.Location = new Point(0, 0);
            Profil.Margin = new Padding(5, 6, 5, 6);
            Profil.Name = "Profil";
            Profil.Size = new Size(581, 174);
            Profil.TabIndex = 2;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLogout.BackgroundImage = Properties.Resources.logout__1_;
            btnLogout.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogout.Location = new Point(507, 66);
            btnLogout.Margin = new Padding(3, 4, 3, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(50, 50);
            btnLogout.TabIndex = 6;
            btnLogout.TextAlign = ContentAlignment.TopCenter;
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            btnSend.BackgroundImage = Properties.Resources.settings1;
            btnSend.BackgroundImageLayout = ImageLayout.Stretch;
            btnSend.Location = new Point(444, 76);
            btnSend.Margin = new Padding(3, 4, 3, 4);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(39, 40);
            btnSend.TabIndex = 5;
            btnSend.UseVisualStyleBackColor = true;
            // 
            // Nama_Karyawan
            // 
            Nama_Karyawan.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Nama_Karyawan.AutoSize = true;
            Nama_Karyawan.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            Nama_Karyawan.Location = new Point(63, 55);
            Nama_Karyawan.Margin = new Padding(5, 0, 5, 0);
            Nama_Karyawan.Name = "Nama_Karyawan";
            Nama_Karyawan.Size = new Size(222, 32);
            Nama_Karyawan.TabIndex = 3;
            Nama_Karyawan.Text = "Nama Karyawan";
            // 
            // Depart
            // 
            Depart.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Depart.AutoSize = true;
            Depart.Font = new Font("Microsoft Sans Serif", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 129);
            Depart.Location = new Point(147, 87);
            Depart.Margin = new Padding(5, 0, 5, 0);
            Depart.Name = "Depart";
            Depart.Size = new Size(138, 29);
            Depart.TabIndex = 4;
            Depart.Text = "Department";
            Depart.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // User
            // 
            User.Image = Properties.Resources.icon_2;
            User.Location = new Point(326, 36);
            User.Margin = new Padding(5, 6, 5, 6);
            User.Name = "User";
            User.Size = new Size(100, 100);
            User.SizeMode = PictureBoxSizeMode.StretchImage;
            User.TabIndex = 0;
            User.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(Nama_Karyawan, 0, 0);
            tableLayoutPanel1.Controls.Add(Depart, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(581, 174);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 1060);
            Controls.Add(Main_Menu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            Name = "Main";
            Main_Menu.ResumeLayout(false);
            Profil.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)User).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Main_Menu;
        private Panel Profil;
        private PictureBox User;
        private Label Depart;
        private Label Nama_Karyawan;
        private Button btnLogout;
        private Button btnSend;
        private TableLayoutPanel tableLayoutPanel1;
    }
}