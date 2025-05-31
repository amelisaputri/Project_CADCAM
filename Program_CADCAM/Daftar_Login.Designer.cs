
namespace Program_CADCAM
{
    partial class Daftar_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Daftar_Login));
            Panel_DaftarLogin = new Panel();
            PanelLayout_DaftarLogin = new TableLayoutPanel();
            Profil = new PictureBox();
            txtBoxUser = new TextBox();
            txtBoxPass = new TextBox();
            txtBoxName = new TextBox();
            Team = new Label();
            Department = new Label();
            cmbBoxTeam = new ComboBox();
            btnDaftar = new Button();
            txtBoxPhone = new TextBox();
            cmbBoxDepart = new ComboBox();
            picLogout = new PictureBox();
            Panel_DaftarLogin.SuspendLayout();
            PanelLayout_DaftarLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Profil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLogout).BeginInit();
            SuspendLayout();
            // 
            // Panel_DaftarLogin
            // 
            Panel_DaftarLogin.BackColor = Color.White;
            Panel_DaftarLogin.BackgroundImage = Properties.Resources.background;
            Panel_DaftarLogin.BackgroundImageLayout = ImageLayout.Stretch;
            Panel_DaftarLogin.Controls.Add(PanelLayout_DaftarLogin);
            Panel_DaftarLogin.Dock = DockStyle.Fill;
            Panel_DaftarLogin.Location = new Point(0, 0);
            Panel_DaftarLogin.Margin = new Padding(4, 5, 4, 5);
            Panel_DaftarLogin.Name = "Panel_DaftarLogin";
            Panel_DaftarLogin.Size = new Size(514, 914);
            Panel_DaftarLogin.TabIndex = 0;
            // 
            // PanelLayout_DaftarLogin
            // 
            PanelLayout_DaftarLogin.BackColor = Color.Transparent;
            PanelLayout_DaftarLogin.ColumnCount = 6;
            PanelLayout_DaftarLogin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.23141F));
            PanelLayout_DaftarLogin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.77580166F));
            PanelLayout_DaftarLogin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.99472F));
            PanelLayout_DaftarLogin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.99101F));
            PanelLayout_DaftarLogin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.77358055F));
            PanelLayout_DaftarLogin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.2334814F));
            PanelLayout_DaftarLogin.Controls.Add(Profil, 1, 1);
            PanelLayout_DaftarLogin.Controls.Add(txtBoxUser, 2, 4);
            PanelLayout_DaftarLogin.Controls.Add(txtBoxPass, 2, 5);
            PanelLayout_DaftarLogin.Controls.Add(txtBoxName, 2, 7);
            PanelLayout_DaftarLogin.Controls.Add(Team, 2, 9);
            PanelLayout_DaftarLogin.Controls.Add(Department, 3, 9);
            PanelLayout_DaftarLogin.Controls.Add(cmbBoxTeam, 3, 10);
            PanelLayout_DaftarLogin.Controls.Add(btnDaftar, 2, 11);
            PanelLayout_DaftarLogin.Controls.Add(txtBoxPhone, 2, 8);
            PanelLayout_DaftarLogin.Controls.Add(cmbBoxDepart, 2, 10);
            PanelLayout_DaftarLogin.Controls.Add(picLogout, 0, 1);
            PanelLayout_DaftarLogin.Dock = DockStyle.Fill;
            PanelLayout_DaftarLogin.Location = new Point(0, 0);
            PanelLayout_DaftarLogin.Margin = new Padding(2);
            PanelLayout_DaftarLogin.Name = "PanelLayout_DaftarLogin";
            PanelLayout_DaftarLogin.RowCount = 13;
            PanelLayout_DaftarLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 4.37807F));
            PanelLayout_DaftarLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 12.1824541F));
            PanelLayout_DaftarLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 22.5433922F));
            PanelLayout_DaftarLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 2.67267013F));
            PanelLayout_DaftarLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 5.69395F));
            PanelLayout_DaftarLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 5.223064F));
            PanelLayout_DaftarLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 4.758792F));
            PanelLayout_DaftarLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 5.2072134F));
            PanelLayout_DaftarLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 12.7526789F));
            PanelLayout_DaftarLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 4.52140474F));
            PanelLayout_DaftarLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 4.4702177F));
            PanelLayout_DaftarLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 15.5960913F));
            PanelLayout_DaftarLogin.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            PanelLayout_DaftarLogin.Size = new Size(514, 914);
            PanelLayout_DaftarLogin.TabIndex = 16;
            // 
            // Profil
            // 
            Profil.BackColor = Color.Transparent;
            PanelLayout_DaftarLogin.SetColumnSpan(Profil, 4);
            Profil.Dock = DockStyle.Fill;
            Profil.Image = Properties.Resources.icon_2;
            Profil.Location = new Point(56, 42);
            Profil.Margin = new Padding(4, 5, 4, 5);
            Profil.Name = "Profil";
            PanelLayout_DaftarLogin.SetRowSpan(Profil, 2);
            Profil.Size = new Size(398, 290);
            Profil.SizeMode = PictureBoxSizeMode.Zoom;
            Profil.TabIndex = 15;
            Profil.TabStop = false;
            // 
            // txtBoxUser
            // 
            PanelLayout_DaftarLogin.SetColumnSpan(txtBoxUser, 2);
            txtBoxUser.Dock = DockStyle.Fill;
            txtBoxUser.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxUser.ForeColor = Color.Gray;
            txtBoxUser.Location = new Point(85, 365);
            txtBoxUser.Margin = new Padding(4, 5, 4, 5);
            txtBoxUser.Name = "txtBoxUser";
            txtBoxUser.Size = new Size(340, 36);
            txtBoxUser.TabIndex = 0;
            txtBoxUser.Text = "NIK";
            txtBoxUser.MouseEnter += txtBoxUsername_Enter;
            txtBoxUser.MouseLeave += txtBoxUsername_Leave;
            // 
            // txtBoxPass
            // 
            txtBoxPass.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PanelLayout_DaftarLogin.SetColumnSpan(txtBoxPass, 2);
            txtBoxPass.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxPass.ForeColor = Color.Gray;
            txtBoxPass.Location = new Point(85, 414);
            txtBoxPass.Margin = new Padding(4, 5, 4, 5);
            txtBoxPass.Name = "txtBoxPass";
            txtBoxPass.PasswordChar = '*';
            txtBoxPass.Size = new Size(340, 36);
            txtBoxPass.TabIndex = 1;
            txtBoxPass.Text = "Password";
            txtBoxPass.MouseEnter += txtBoxPassword_Enter;
            txtBoxPass.MouseLeave += txtBoxPassword_Leave;
            // 
            // txtBoxName
            // 
            txtBoxName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PanelLayout_DaftarLogin.SetColumnSpan(txtBoxName, 2);
            txtBoxName.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxName.ForeColor = Color.Gray;
            txtBoxName.Location = new Point(85, 500);
            txtBoxName.Margin = new Padding(4, 5, 4, 5);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(340, 36);
            txtBoxName.TabIndex = 2;
            txtBoxName.Text = "Nama Karyawan";
            txtBoxName.MouseEnter += txtBoxNama_Enter;
            txtBoxName.MouseLeave += txtBoxNama_Leave;
            // 
            // Team
            // 
            Team.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Team.AutoSize = true;
            Team.BackColor = Color.Transparent;
            Team.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Team.Location = new Point(85, 660);
            Team.Margin = new Padding(4, 0, 4, 0);
            Team.Name = "Team";
            Team.Size = new Size(139, 29);
            Team.TabIndex = 14;
            Team.Text = "Department";
            // 
            // Department
            // 
            Department.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Department.AutoSize = true;
            Department.BackColor = Color.Transparent;
            Department.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Department.Location = new Point(259, 660);
            Department.Margin = new Padding(4, 0, 4, 0);
            Department.Name = "Department";
            Department.Size = new Size(73, 29);
            Department.TabIndex = 13;
            Department.Text = "Team";
            // 
            // cmbBoxTeam
            // 
            cmbBoxTeam.Dock = DockStyle.Fill;
            cmbBoxTeam.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbBoxTeam.FormattingEnabled = true;
            cmbBoxTeam.Items.AddRange(new object[] { "2D/3D PRINT", "3D/3D SCAN", "CAM", "IT" });
            cmbBoxTeam.Location = new Point(259, 694);
            cmbBoxTeam.Margin = new Padding(4, 5, 4, 5);
            cmbBoxTeam.Name = "cmbBoxTeam";
            cmbBoxTeam.Size = new Size(166, 32);
            cmbBoxTeam.TabIndex = 5;
            // 
            // btnDaftar
            // 
            btnDaftar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnDaftar.BackColor = Color.White;
            PanelLayout_DaftarLogin.SetColumnSpan(btnDaftar, 2);
            btnDaftar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDaftar.Location = new Point(85, 762);
            btnDaftar.Margin = new Padding(4, 5, 4, 5);
            btnDaftar.Name = "btnDaftar";
            btnDaftar.Size = new Size(340, 65);
            btnDaftar.TabIndex = 6;
            btnDaftar.Text = "Daftar Login";
            btnDaftar.UseVisualStyleBackColor = false;
            btnDaftar.Click += btnDaftar_Click;
            // 
            // txtBoxPhone
            // 
            txtBoxPhone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PanelLayout_DaftarLogin.SetColumnSpan(txtBoxPhone, 2);
            txtBoxPhone.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxPhone.ForeColor = Color.Gray;
            txtBoxPhone.Location = new Point(85, 545);
            txtBoxPhone.Margin = new Padding(4, 5, 4, 5);
            txtBoxPhone.Name = "txtBoxPhone";
            txtBoxPhone.Size = new Size(340, 36);
            txtBoxPhone.TabIndex = 3;
            txtBoxPhone.Text = "Nomor Handphone";
            txtBoxPhone.MouseEnter += txtBoxPhone_Enter;
            txtBoxPhone.MouseLeave += txtBoxPhone_Leave;
            // 
            // cmbBoxDepart
            // 
            cmbBoxDepart.Dock = DockStyle.Fill;
            cmbBoxDepart.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbBoxDepart.FormattingEnabled = true;
            cmbBoxDepart.Items.AddRange(new object[] { "CADCAM" });
            cmbBoxDepart.Location = new Point(85, 694);
            cmbBoxDepart.Margin = new Padding(4, 5, 4, 5);
            cmbBoxDepart.Name = "cmbBoxDepart";
            cmbBoxDepart.Size = new Size(166, 32);
            cmbBoxDepart.TabIndex = 4;
            // 
            // picLogout
            // 
            picLogout.Anchor = AnchorStyles.None;
            picLogout.BackgroundImage = Properties.Resources.back_removebg_preview;
            picLogout.BackgroundImageLayout = ImageLayout.Stretch;
            picLogout.Location = new Point(8, 71);
            picLogout.Name = "picLogout";
            picLogout.Size = new Size(36, 36);
            picLogout.TabIndex = 17;
            picLogout.TabStop = false;
            picLogout.Click += picLogout_Click;
            // 
            // Daftar_Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(514, 914);
            ControlBox = false;
            Controls.Add(Panel_DaftarLogin);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "Daftar_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Daftar_Login_Load;
            Panel_DaftarLogin.ResumeLayout(false);
            PanelLayout_DaftarLogin.ResumeLayout(false);
            PanelLayout_DaftarLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Profil).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLogout).EndInit();
            ResumeLayout(false);
        }


        #endregion

        private Panel Panel_DaftarLogin;
        private ComboBox cmbBoxTeam;
        private ComboBox cmbBoxDepart;
        private TextBox txtBoxUser;
        private Button btnDaftar;
        private TextBox txtBoxPhone;
        private TextBox txtBoxName;
        private TextBox txtBoxPass;
        private Label Department;
        private Label Team;
        private PictureBox Profil;
        private TableLayoutPanel PanelLayout_DaftarLogin;
        private PictureBox picLogout;

        public EventHandler btnDaftar_Click1 { get; private set; }
    }
}