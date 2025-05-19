
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
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            Profil = new PictureBox();
            txtBoxUser = new TextBox();
            txtBoxPass = new TextBox();
            txtBoxName = new TextBox();
            txtBoxPhone = new TextBox();
            Team = new Label();
            Department = new Label();
            cmbBoxDepart = new ComboBox();
            cmbBoxTeam = new ComboBox();
            btnDaftar = new Button();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Profil).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BackgroundImage = Properties.Resources.background;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(514, 914);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.3852711F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.86265564F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.5059166F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.9983826F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.86040163F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.3873682F));
            tableLayoutPanel1.Controls.Add(Profil, 1, 1);
            tableLayoutPanel1.Controls.Add(txtBoxUser, 2, 4);
            tableLayoutPanel1.Controls.Add(txtBoxPass, 2, 5);
            tableLayoutPanel1.Controls.Add(txtBoxName, 2, 7);
            tableLayoutPanel1.Controls.Add(txtBoxPhone, 2, 8);
            tableLayoutPanel1.Controls.Add(Team, 2, 9);
            tableLayoutPanel1.Controls.Add(Department, 3, 9);
            tableLayoutPanel1.Controls.Add(cmbBoxDepart, 2, 10);
            tableLayoutPanel1.Controls.Add(cmbBoxTeam, 3, 10);
            tableLayoutPanel1.Controls.Add(btnDaftar, 2, 11);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 13;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4.380934F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.190424F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 23.9046612F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 1.99999142F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4.761884F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4.571409F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.543214F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.2106204F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.3707285F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 3.986694F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4.473142F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15.6062937F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanel1.Size = new Size(514, 914);
            tableLayoutPanel1.TabIndex = 16;
            // 
            // Profil
            // 
            Profil.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Profil.BackColor = Color.Transparent;
            tableLayoutPanel1.SetColumnSpan(Profil, 4);
            Profil.Image = Properties.Resources.icon_2;
            Profil.Location = new Point(57, 42);
            Profil.Margin = new Padding(4, 5, 4, 5);
            Profil.Name = "Profil";
            tableLayoutPanel1.SetRowSpan(Profil, 2);
            Profil.Size = new Size(398, 287);
            Profil.SizeMode = PictureBoxSizeMode.Zoom;
            Profil.TabIndex = 15;
            Profil.TabStop = false;
            // 
            // txtBoxUser
            // 
            txtBoxUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(txtBoxUser, 2);
            txtBoxUser.Font = new Font("Microsoft Sans Serif", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxUser.ForeColor = Color.Gray;
            txtBoxUser.Location = new Point(87, 371);
            txtBoxUser.Margin = new Padding(4, 5, 4, 5);
            txtBoxUser.Name = "txtBoxUser";
            txtBoxUser.Size = new Size(338, 30);
            txtBoxUser.TabIndex = 0;
            txtBoxUser.Text = "NIK";
            txtBoxUser.MouseEnter += txtBoxUsername_Enter;
            txtBoxUser.MouseLeave += txtBoxUsername_Leave;
            // 
            // txtBoxPass
            // 
            txtBoxPass.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(txtBoxPass, 2);
            txtBoxPass.Font = new Font("Microsoft Sans Serif", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxPass.ForeColor = Color.Gray;
            txtBoxPass.Location = new Point(87, 412);
            txtBoxPass.Margin = new Padding(4, 5, 4, 5);
            txtBoxPass.Name = "txtBoxPass";
            txtBoxPass.PasswordChar = '*';
            txtBoxPass.Size = new Size(338, 30);
            txtBoxPass.TabIndex = 7;
            txtBoxPass.Text = "Password";
            txtBoxPass.MouseEnter += txtBoxPassword_Enter;
            txtBoxPass.MouseLeave += txtBoxPassword_Leave;
            // 
            // txtBoxName
            // 
            txtBoxName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(txtBoxName, 2);
            txtBoxName.Font = new Font("Microsoft Sans Serif", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxName.ForeColor = Color.Gray;
            txtBoxName.Location = new Point(87, 499);
            txtBoxName.Margin = new Padding(4, 5, 4, 5);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(338, 30);
            txtBoxName.TabIndex = 9;
            txtBoxName.Text = "Nama Karyawan";
            txtBoxName.MouseEnter += txtBoxNama_Enter;
            txtBoxName.MouseLeave += txtBoxNama_Leave;
            // 
            // txtBoxPhone
            // 
            txtBoxPhone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(txtBoxPhone, 2);
            txtBoxPhone.Font = new Font("Microsoft Sans Serif", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxPhone.ForeColor = Color.Gray;
            txtBoxPhone.Location = new Point(87, 544);
            txtBoxPhone.Margin = new Padding(4, 5, 4, 5);
            txtBoxPhone.Name = "txtBoxPhone";
            txtBoxPhone.Size = new Size(338, 30);
            txtBoxPhone.TabIndex = 10;
            txtBoxPhone.Text = "Nomor Handphone";
            txtBoxPhone.MouseEnter += txtBoxPhone_Enter;
            txtBoxPhone.MouseLeave += txtBoxPhone_Leave;
            // 
            // Team
            // 
            Team.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Team.AutoSize = true;
            Team.BackColor = Color.Transparent;
            Team.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Team.Location = new Point(87, 663);
            Team.Margin = new Padding(4, 0, 4, 0);
            Team.Name = "Team";
            Team.Size = new Size(63, 25);
            Team.TabIndex = 14;
            Team.Text = "Team";
            // 
            // Department
            // 
            Department.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Department.AutoSize = true;
            Department.BackColor = Color.Transparent;
            Department.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Department.Location = new Point(264, 663);
            Department.Margin = new Padding(4, 0, 4, 0);
            Department.Name = "Department";
            Department.Size = new Size(113, 25);
            Department.TabIndex = 13;
            Department.Text = "Department";
            // 
            // cmbBoxDepart
            // 
            cmbBoxDepart.Font = new Font("Times New Roman", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbBoxDepart.FormattingEnabled = true;
            cmbBoxDepart.Items.AddRange(new object[] { "CAD", "CAM", "IT" });
            cmbBoxDepart.Location = new Point(87, 693);
            cmbBoxDepart.Margin = new Padding(4, 5, 4, 5);
            cmbBoxDepart.Name = "cmbBoxDepart";
            cmbBoxDepart.Size = new Size(165, 30);
            cmbBoxDepart.TabIndex = 5;
            // 
            // cmbBoxTeam
            // 
            cmbBoxTeam.Dock = DockStyle.Fill;
            cmbBoxTeam.Font = new Font("Times New Roman", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbBoxTeam.FormattingEnabled = true;
            cmbBoxTeam.Items.AddRange(new object[] { "2D/3D PRINT", "3D/ 3D SCAN", "CAM", "IT" });
            cmbBoxTeam.Location = new Point(264, 693);
            cmbBoxTeam.Margin = new Padding(4, 5, 4, 5);
            cmbBoxTeam.Name = "cmbBoxTeam";
            cmbBoxTeam.Size = new Size(161, 30);
            cmbBoxTeam.TabIndex = 6;
            // 
            // btnDaftar
            // 
            btnDaftar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnDaftar.BackColor = Color.White;
            tableLayoutPanel1.SetColumnSpan(btnDaftar, 2);
            btnDaftar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDaftar.Location = new Point(87, 761);
            btnDaftar.Margin = new Padding(4, 5, 4, 5);
            btnDaftar.Name = "btnDaftar";
            btnDaftar.Size = new Size(338, 65);
            btnDaftar.TabIndex = 12;
            btnDaftar.Text = "Daftar Login";
            btnDaftar.UseVisualStyleBackColor = false;
            btnDaftar.Click += btnDaftar_Click;
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
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "Daftar_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Daftar_Login_Load;
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Profil).EndInit();
            ResumeLayout(false);
        }


        #endregion

        private Panel panel1;
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
        private TableLayoutPanel tableLayoutPanel1;

        public EventHandler btnDaftar_Click1 { get; private set; }
    }
}