
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
            Profil = new PictureBox();
            Team = new Label();
            Department = new Label();
            btnDaftar = new Button();
            txtBoxUser = new TextBox();
            txtBoxPass = new TextBox();
            txtBoxName = new TextBox();
            txtBoxPhone = new TextBox();
            cmbBoxDepart = new ComboBox();
            cmbBoxTeam = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Profil).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BackgroundImage = Properties.Resources.background;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(Profil);
            panel1.Controls.Add(Team);
            panel1.Controls.Add(Department);
            panel1.Controls.Add(btnDaftar);
            panel1.Controls.Add(txtBoxUser);
            panel1.Controls.Add(txtBoxPass);
            panel1.Controls.Add(txtBoxName);
            panel1.Controls.Add(txtBoxPhone);
            panel1.Controls.Add(cmbBoxDepart);
            panel1.Controls.Add(cmbBoxTeam);
            panel1.Location = new Point(0, 2);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(484, 942);
            panel1.TabIndex = 0;
            // 
            // Profil
            // 
            Profil.BackColor = Color.Transparent;
            Profil.Image = Properties.Resources.icon_2;
            Profil.Location = new Point(84, 63);
            Profil.Margin = new Padding(4, 5, 4, 5);
            Profil.Name = "Profil";
            Profil.Size = new Size(354, 333);
            Profil.SizeMode = PictureBoxSizeMode.Zoom;
            Profil.TabIndex = 15;
            Profil.TabStop = false;
            // 
            // Team
            // 
            Team.AutoSize = true;
            Team.BackColor = Color.Transparent;
            Team.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Team.Location = new Point(272, 662);
            Team.Margin = new Padding(4, 0, 4, 0);
            Team.Name = "Team";
            Team.Size = new Size(63, 25);
            Team.TabIndex = 14;
            Team.Text = "Team";
            // 
            // Department
            // 
            Department.AutoSize = true;
            Department.BackColor = Color.Transparent;
            Department.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Department.Location = new Point(84, 662);
            Department.Margin = new Padding(4, 0, 4, 0);
            Department.Name = "Department";
            Department.Size = new Size(113, 25);
            Department.TabIndex = 13;
            Department.Text = "Department";
            // 
            // btnDaftar
            // 
            btnDaftar.BackColor = Color.White;
            btnDaftar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDaftar.Location = new Point(114, 789);
            btnDaftar.Margin = new Padding(4, 5, 4, 5);
            btnDaftar.Name = "btnDaftar";
            btnDaftar.Size = new Size(252, 65);
            btnDaftar.TabIndex = 12;
            btnDaftar.Text = "Daftar Login";
            btnDaftar.UseVisualStyleBackColor = false;
            btnDaftar.Click += btnDaftar_Click;
            // 
            // txtBoxUser
            // 
            txtBoxUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtBoxUser.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxUser.ForeColor = Color.Gray;
            txtBoxUser.Location = new Point(84, 413);
            txtBoxUser.Margin = new Padding(4, 5, 4, 5);
            txtBoxUser.Name = "txtBoxUser";
            txtBoxUser.Size = new Size(332, 30);
            txtBoxUser.TabIndex = 0;
            txtBoxUser.Text = "Username";
            txtBoxUser.MouseEnter += txtBoxUsername_Enter;
            txtBoxUser.MouseLeave += txtBoxUsername_Leave;
            // 
            // txtBoxPass
            // 
            txtBoxPass.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtBoxPass.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxPass.ForeColor = Color.Gray;
            txtBoxPass.Location = new Point(84, 462);
            txtBoxPass.Margin = new Padding(4, 5, 4, 5);
            txtBoxPass.Name = "txtBoxPass";
            txtBoxPass.Size = new Size(332, 30);
            txtBoxPass.TabIndex = 7;
            txtBoxPass.Text = "Password";
            txtBoxPass.MouseEnter += txtBoxPassword_Enter;
            txtBoxPass.MouseLeave += txtBoxPassword_Leave;
            // 
            // txtBoxName
            // 
            txtBoxName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtBoxName.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxName.ForeColor = Color.Gray;
            txtBoxName.Location = new Point(84, 545);
            txtBoxName.Margin = new Padding(4, 5, 4, 5);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(332, 30);
            txtBoxName.TabIndex = 9;
            txtBoxName.Text = "Nama Karyawan";
            txtBoxName.MouseEnter += txtBoxNama_Enter;
            txtBoxName.MouseLeave += txtBoxNama_Leave;
            // 
            // txtBoxPhone
            // 
            txtBoxPhone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtBoxPhone.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxPhone.ForeColor = Color.Gray;
            txtBoxPhone.Location = new Point(84, 593);
            txtBoxPhone.Margin = new Padding(4, 5, 4, 5);
            txtBoxPhone.Name = "txtBoxPhone";
            txtBoxPhone.Size = new Size(332, 30);
            txtBoxPhone.TabIndex = 10;
            txtBoxPhone.Text = "Nomor Handphone";
            txtBoxPhone.MouseEnter += txtBoxPhone_Enter;
            txtBoxPhone.MouseLeave += txtBoxPhone_Leave;
            // 
            // cmbBoxDepart
            // 
            cmbBoxDepart.FormattingEnabled = true;
            cmbBoxDepart.Items.AddRange(new object[] { "CAD", "CAM", "IT" });
            cmbBoxDepart.Location = new Point(72, 692);
            cmbBoxDepart.Margin = new Padding(4, 5, 4, 5);
            cmbBoxDepart.Name = "cmbBoxDepart";
            cmbBoxDepart.Size = new Size(172, 33);
            cmbBoxDepart.TabIndex = 5;
            // 
            // cmbBoxTeam
            // 
            cmbBoxTeam.FormattingEnabled = true;
            cmbBoxTeam.Items.AddRange(new object[] { "2D/3D PRINT", "3D/ 3D SCAN", "CAM", "IT" });
            cmbBoxTeam.Location = new Point(251, 692);
            cmbBoxTeam.Margin = new Padding(4, 5, 4, 5);
            cmbBoxTeam.Name = "cmbBoxTeam";
            cmbBoxTeam.Size = new Size(172, 33);
            cmbBoxTeam.TabIndex = 6;
            // 
            // Daftar_Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            ClientSize = new Size(484, 875);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "Daftar_Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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

        public EventHandler btnDaftar_Click1 { get; private set; }
    }
}