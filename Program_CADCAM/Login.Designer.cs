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
            txtBoxUser = new TextBox();
            Button_Login = new Button();
            txtBoxPass = new TextBox();
            checkBox1 = new CheckBox();
            LinkCreateAcc = new LinkLabel();
            LinkResetPass = new LinkLabel();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtBoxUser
            // 
            txtBoxUser.Anchor = AnchorStyles.None;
            txtBoxUser.Font = new Font("Pretendard", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxUser.ForeColor = Color.Black;
            txtBoxUser.Location = new Point(73, 279);
            txtBoxUser.Name = "txtBoxUser";
            txtBoxUser.Size = new Size(190, 23);
            txtBoxUser.TabIndex = 0;
            txtBoxUser.Text = "Username";
            // 
            // Button_Login
            // 
            Button_Login.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Button_Login.BackColor = Color.White;
            Button_Login.Font = new Font("Pretendard SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Button_Login.Location = new Point(73, 336);
            Button_Login.Name = "Button_Login";
            Button_Login.Size = new Size(190, 31);
            Button_Login.TabIndex = 4;
            Button_Login.Text = "Login";
            Button_Login.UseVisualStyleBackColor = false;
            Button_Login.Click += btn_Login;
            // 
            // txtBoxPass
            // 
            txtBoxPass.Anchor = AnchorStyles.None;
            txtBoxPass.Font = new Font("Pretendard", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxPass.ForeColor = SystemColors.ActiveCaptionText;
            txtBoxPass.Location = new Point(73, 307);
            txtBoxPass.Name = "txtBoxPass";
            txtBoxPass.PasswordChar = '*';
            txtBoxPass.Size = new Size(190, 23);
            txtBoxPass.TabIndex = 6;
            txtBoxPass.Tag = "";
            txtBoxPass.Text = "Password";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.Font = new Font("Pretendard", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(75, 373);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(87, 19);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Auto Login";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // LinkCreateAcc
            // 
            LinkCreateAcc.ActiveLinkColor = Color.Navy;
            LinkCreateAcc.AutoSize = true;
            LinkCreateAcc.BackColor = Color.Transparent;
            LinkCreateAcc.Font = new Font("Pretendard", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LinkCreateAcc.LinkColor = Color.Black;
            LinkCreateAcc.Location = new Point(75, 493);
            LinkCreateAcc.Name = "LinkCreateAcc";
            LinkCreateAcc.Size = new Size(82, 15);
            LinkCreateAcc.TabIndex = 8;
            LinkCreateAcc.TabStop = true;
            LinkCreateAcc.Text = "Daftar Login";
            // 
            // LinkResetPass
            // 
            LinkResetPass.AutoSize = true;
            LinkResetPass.BackColor = Color.Transparent;
            LinkResetPass.Font = new Font("Pretendard", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LinkResetPass.LinkColor = Color.Black;
            LinkResetPass.Location = new Point(171, 493);
            LinkResetPass.Name = "LinkResetPass";
            LinkResetPass.Size = new Size(105, 15);
            LinkResetPass.TabIndex = 9;
            LinkResetPass.TabStop = true;
            LinkResetPass.Text = "Reset Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Britannic Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(191, 39);
            label1.Name = "label1";
            label1.Size = new Size(161, 76);
            label1.TabIndex = 10;
            label1.Text = "SHI\r\nCAD/CAM\r\n";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(353, 597);
            Controls.Add(label1);
            Controls.Add(LinkResetPass);
            Controls.Add(LinkCreateAcc);
            Controls.Add(checkBox1);
            Controls.Add(txtBoxPass);
            Controls.Add(Button_Login);
            Controls.Add(txtBoxUser);
            DoubleBuffered = true;
            Font = new Font("Pretendard", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            HelpButton = true;
            Name = "Login";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxUser;
        private Button Button_Login;
        private TextBox txtBoxPass;
        private CheckBox checkBox1;
        private LinkLabel LinkCreateAcc;
        private LinkLabel LinkResetPass;
        private Label label1;
    }
}
