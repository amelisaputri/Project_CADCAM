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
            dataGridView1 = new DataGridView();
            Chat = new DataGridViewTextBoxColumn();
            tabPage2 = new TabPage();
            panel2 = new Panel();
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            Profil = new Panel();
            btnLogout = new Button();
            User = new PictureBox();
            btnSend = new Button();
            Nama_Karyawan = new Label();
            Depart = new Label();
            Main_Menu.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
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
            Main_Menu.Name = "Main_Menu";
            Main_Menu.Size = new Size(554, 721);
            Main_Menu.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 87);
            tabControl1.Margin = new Padding(2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(554, 634);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2);
            tabPage1.Size = new Size(546, 606);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Chat";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(2, 2);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(542, 602);
            panel1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Chat });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(542, 602);
            dataGridView1.TabIndex = 0;
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
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2);
            tabPage2.Size = new Size(597, 935);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Contact";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(2, 2);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(593, 931);
            panel2.TabIndex = 4;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1 });
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(0, 0);
            dataGridView2.Margin = new Padding(2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(593, 931);
            dataGridView2.TabIndex = 0;
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
            Profil.Controls.Add(Nama_Karyawan);
            Profil.Controls.Add(Depart);
            Profil.Dock = DockStyle.Top;
            Profil.Location = new Point(0, 0);
            Profil.Name = "Profil";
            Profil.Size = new Size(554, 87);
            Profil.TabIndex = 2;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLogout.BackgroundImage = Properties.Resources.logout__1_;
            btnLogout.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogout.Location = new Point(510, 33);
            btnLogout.Margin = new Padding(1, 2, 1, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(29, 25);
            btnLogout.TabIndex = 6;
            btnLogout.TextAlign = ContentAlignment.TopCenter;
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // User
            // 
            User.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            User.Image = Properties.Resources.icon_2;
            User.Location = new Point(391, 18);
            User.Name = "User";
            User.Size = new Size(58, 50);
            User.SizeMode = PictureBoxSizeMode.StretchImage;
            User.TabIndex = 0;
            User.TabStop = false;
            // 
            // btnSend
            // 
            btnSend.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSend.BackgroundImage = Properties.Resources.settings1;
            btnSend.BackgroundImageLayout = ImageLayout.Stretch;
            btnSend.Location = new Point(460, 38);
            btnSend.Margin = new Padding(1, 2, 1, 2);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(22, 20);
            btnSend.TabIndex = 5;
            btnSend.UseVisualStyleBackColor = true;
            // 
            // Nama_Karyawan
            // 
            Nama_Karyawan.AutoSize = true;
            Nama_Karyawan.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            Nama_Karyawan.Location = new Point(24, 18);
            Nama_Karyawan.Name = "Nama_Karyawan";
            Nama_Karyawan.Size = new Size(124, 20);
            Nama_Karyawan.TabIndex = 3;
            Nama_Karyawan.Text = "Nama Karyawan";
            // 
            // Depart
            // 
            Depart.AutoSize = true;
            Depart.Font = new Font("Microsoft Sans Serif", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 129);
            Depart.Location = new Point(66, 38);
            Depart.Name = "Depart";
            Depart.Size = new Size(82, 17);
            Depart.TabIndex = 4;
            Depart.Text = "Department";
            Depart.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 721);
            Controls.Add(Main_Menu);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Main_Menu.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            Profil.ResumeLayout(false);
            Profil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)User).EndInit();
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
        private Panel panel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Chat;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel panel2;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}