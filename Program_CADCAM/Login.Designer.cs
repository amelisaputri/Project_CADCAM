namespace Program_CADCAM
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            txtBoxUser = new TextBox();
            Button_Login = new Button();
            txtBoxPass = new TextBox();
            checkBox1 = new CheckBox();
            LinkCreateAcc = new LinkLabel();
            LinkResetPass = new LinkLabel();
            SHI = new Label();
            Panel_Login = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            Panel_Login.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtBoxUser
            // 
            tableLayoutPanel1.SetColumnSpan(txtBoxUser, 3);
            txtBoxUser.Dock = DockStyle.Fill;
            txtBoxUser.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxUser.ForeColor = Color.Gray;
            txtBoxUser.Location = new Point(110, 352);
            txtBoxUser.Name = "txtBoxUser";
            txtBoxUser.Size = new Size(276, 26);
            txtBoxUser.TabIndex = 0;
            txtBoxUser.Text = "NIK";
            txtBoxUser.MouseEnter += txtUsername_Enter;
            txtBoxUser.MouseLeave += txtUsername_Leave;
            // 
            // Button_Login
            // 
            Button_Login.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Button_Login.BackColor = Color.White;
            tableLayoutPanel1.SetColumnSpan(Button_Login, 3);
            Button_Login.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button_Login.Location = new Point(110, 480);
            Button_Login.Name = "Button_Login";
            Button_Login.Size = new Size(276, 57);
            Button_Login.TabIndex = 2;
            Button_Login.Text = "Login";
            Button_Login.UseVisualStyleBackColor = false;
            Button_Login.Click += btn_Login;
            // 
            // txtBoxPass
            // 
            tableLayoutPanel1.SetColumnSpan(txtBoxPass, 3);
            txtBoxPass.Dock = DockStyle.Fill;
            txtBoxPass.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxPass.ForeColor = Color.Gray;
            txtBoxPass.Location = new Point(110, 400);
            txtBoxPass.Name = "txtBoxPass";
            txtBoxPass.PasswordChar = '*';
            txtBoxPass.Size = new Size(276, 26);
            txtBoxPass.TabIndex = 1;
            txtBoxPass.Tag = "";
            txtBoxPass.Text = "Password";
            txtBoxPass.MouseEnter += txtPassword_Enter;
            txtBoxPass.MouseLeave += txtPassword_Leave;
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            tableLayoutPanel1.SetColumnSpan(checkBox1, 2);
            checkBox1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(110, 454);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(89, 20);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Auto Login";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // LinkCreateAcc
            // 
            LinkCreateAcc.ActiveLinkColor = Color.Navy;
            LinkCreateAcc.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            LinkCreateAcc.AutoSize = true;
            LinkCreateAcc.BackColor = Color.Transparent;
            tableLayoutPanel1.SetColumnSpan(LinkCreateAcc, 2);
            LinkCreateAcc.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LinkCreateAcc.LinkColor = Color.Black;
            LinkCreateAcc.Location = new Point(138, 660);
            LinkCreateAcc.Name = "LinkCreateAcc";
            LinkCreateAcc.Size = new Size(91, 16);
            LinkCreateAcc.TabIndex = 4;
            LinkCreateAcc.TabStop = true;
            LinkCreateAcc.Text = "Daftar Login";
            LinkCreateAcc.TextAlign = ContentAlignment.MiddleCenter;
            LinkCreateAcc.LinkClicked += LinkCreateAcc_LinkClicked;
            LinkCreateAcc.MouseEnter += LinkCreateAcc_MouseEnter;
            LinkCreateAcc.MouseLeave += LinkCreateAcc_MouseLeave;
            // 
            // LinkResetPass
            // 
            LinkResetPass.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            LinkResetPass.AutoSize = true;
            LinkResetPass.BackColor = Color.Transparent;
            tableLayoutPanel1.SetColumnSpan(LinkResetPass, 3);
            LinkResetPass.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LinkResetPass.ImageAlign = ContentAlignment.MiddleLeft;
            LinkResetPass.LinkColor = Color.Black;
            LinkResetPass.Location = new Point(264, 660);
            LinkResetPass.Name = "LinkResetPass";
            LinkResetPass.Size = new Size(120, 16);
            LinkResetPass.TabIndex = 5;
            LinkResetPass.TabStop = true;
            LinkResetPass.Text = "Reset Password";
            LinkResetPass.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SHI
            // 
            SHI.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SHI.AutoSize = true;
            SHI.BackColor = Color.Transparent;
            tableLayoutPanel1.SetColumnSpan(SHI, 4);
            SHI.Font = new Font("Britannic Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SHI.ForeColor = Color.DarkBlue;
            SHI.ImageAlign = ContentAlignment.TopCenter;
            SHI.Location = new Point(334, 54);
            SHI.Name = "SHI";
            SHI.Size = new Size(161, 76);
            SHI.TabIndex = 10;
            SHI.Text = "SHI\r\nCAD/CAM\r\n";
            SHI.TextAlign = ContentAlignment.TopRight;
            // 
            // Panel_Login
            // 
            Panel_Login.BackgroundImage = Properties.Resources.background;
            Panel_Login.BackgroundImageLayout = ImageLayout.Stretch;
            Panel_Login.Controls.Add(tableLayoutPanel1);
            Panel_Login.Dock = DockStyle.Fill;
            Panel_Login.Location = new Point(0, 0);
            Panel_Login.Name = "Panel_Login";
            Panel_Login.Size = new Size(498, 864);
            Panel_Login.TabIndex = 11;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.69814F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.950413F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.1239662F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.808032F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.7851238F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.619835F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.7012768F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(Button_Login, 2, 5);
            tableLayoutPanel1.Controls.Add(LinkCreateAcc, 1, 6);
            tableLayoutPanel1.Controls.Add(LinkResetPass, 4, 6);
            tableLayoutPanel1.Controls.Add(SHI, 3, 1);
            tableLayoutPanel1.Controls.Add(checkBox1, 2, 4);
            tableLayoutPanel1.Controls.Add(txtBoxPass, 2, 3);
            tableLayoutPanel1.Controls.Add(txtBoxUser, 2, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.32146F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 34.1904755F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.65302134F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4.97076035F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4.47619057F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.33333349F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15.7740993F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 21.2268753F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 14F));
            tableLayoutPanel1.Size = new Size(498, 864);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(498, 864);
            Controls.Add(Panel_Login);
            DoubleBuffered = true;
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Login_Load;
            Panel_Login.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtBoxUser;
        private Button Button_Login;
        private TextBox txtBoxPass;
        private CheckBox checkBox1;
        private LinkLabel LinkCreateAcc;
        private LinkLabel LinkResetPass;
        private Label SHI;
        private Panel Panel_Login;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
