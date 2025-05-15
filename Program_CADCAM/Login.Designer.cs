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
            Panel_Login.SuspendLayout();
            SuspendLayout();
            // 
            // txtBoxUser
            // 
            txtBoxUser.Anchor = AnchorStyles.None;
            txtBoxUser.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxUser.ForeColor = Color.Gray;
            txtBoxUser.Location = new Point(146, 495);
            txtBoxUser.Name = "txtBoxUser";
            txtBoxUser.Size = new Size(326, 30);
            txtBoxUser.TabIndex = 0;
            txtBoxUser.Text = "Username";
            txtBoxUser.MouseEnter += txtUsername_Enter;
            txtBoxUser.MouseLeave += txtUsername_Leave;
            // 
            // Button_Login
            // 
            Button_Login.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Button_Login.BackColor = Color.White;
            Button_Login.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button_Login.Location = new Point(146, 587);
            Button_Login.Name = "Button_Login";
            Button_Login.Size = new Size(326, 58);
            Button_Login.TabIndex = 4;
            Button_Login.Text = "Login";
            Button_Login.UseVisualStyleBackColor = false;
            Button_Login.Click += btn_Login;
            // 
            // txtBoxPass
            // 
            txtBoxPass.Anchor = AnchorStyles.None;
            txtBoxPass.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxPass.ForeColor = Color.Gray;
            txtBoxPass.Location = new Point(146, 547);
            txtBoxPass.Name = "txtBoxPass";
            txtBoxPass.PasswordChar = '*';
            txtBoxPass.Size = new Size(326, 35);
            txtBoxPass.TabIndex = 6;
            txtBoxPass.Tag = "";
            txtBoxPass.Text = "Password";
            txtBoxPass.MouseEnter += txtPassword_Enter;
            txtBoxPass.MouseLeave += txtPassword_Leave;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(146, 671);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(132, 29);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Auto Login";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // LinkCreateAcc
            // 
            LinkCreateAcc.ActiveLinkColor = Color.Navy;
            LinkCreateAcc.AutoSize = true;
            LinkCreateAcc.BackColor = Color.Transparent;
            LinkCreateAcc.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LinkCreateAcc.LinkColor = Color.Black;
            LinkCreateAcc.Location = new Point(135, 913);
            LinkCreateAcc.Name = "LinkCreateAcc";
            LinkCreateAcc.Size = new Size(129, 25);
            LinkCreateAcc.TabIndex = 8;
            LinkCreateAcc.TabStop = true;
            LinkCreateAcc.Text = "Daftar Login";
            LinkCreateAcc.TextAlign = ContentAlignment.MiddleCenter;
            LinkCreateAcc.LinkClicked += LinkCreateAcc_LinkClicked;
            LinkCreateAcc.MouseEnter += LinkCreateAcc_MouseEnter;
            LinkCreateAcc.MouseLeave += LinkCreateAcc_MouseLeave;
            // 
            // LinkResetPass
            // 
            LinkResetPass.AutoSize = true;
            LinkResetPass.BackColor = Color.Transparent;
            LinkResetPass.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LinkResetPass.LinkColor = Color.Black;
            LinkResetPass.Location = new Point(295, 913);
            LinkResetPass.Name = "LinkResetPass";
            LinkResetPass.Size = new Size(167, 25);
            LinkResetPass.TabIndex = 9;
            LinkResetPass.TabStop = true;
            LinkResetPass.Text = "Reset Password";
            LinkResetPass.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SHI
            // 
            SHI.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SHI.AutoSize = true;
            SHI.BackColor = Color.Transparent;
            SHI.Font = new Font("Britannic Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SHI.ForeColor = Color.DarkBlue;
            SHI.Location = new Point(317, 73);
            SHI.Name = "SHI";
            SHI.Size = new Size(244, 116);
            SHI.TabIndex = 10;
            SHI.Text = "SHI\r\nCAD/CAM\r\n";
            SHI.TextAlign = ContentAlignment.TopRight;
            // 
            // Panel_Login
            // 
            Panel_Login.BackgroundImage = Properties.Resources.background;
            Panel_Login.BackgroundImageLayout = ImageLayout.Stretch;
            Panel_Login.Controls.Add(SHI);
            Panel_Login.Controls.Add(LinkResetPass);
            Panel_Login.Controls.Add(LinkCreateAcc);
            Panel_Login.Controls.Add(checkBox1);
            Panel_Login.Controls.Add(txtBoxPass);
            Panel_Login.Controls.Add(Button_Login);
            Panel_Login.Controls.Add(txtBoxUser);
            Panel_Login.Dock = DockStyle.Fill;
            Panel_Login.Location = new Point(0, 0);
            Panel_Login.Name = "Panel_Login";
            Panel_Login.Size = new Size(605, 1050);
            Panel_Login.TabIndex = 11;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(605, 1050);
            Controls.Add(Panel_Login);
            DoubleBuffered = true;
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            StartPosition = FormStartPosition.CenterParent;
            Panel_Login.ResumeLayout(false);
            Panel_Login.PerformLayout();
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
    }
}
