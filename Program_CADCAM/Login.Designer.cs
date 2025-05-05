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
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtBoxUser
            // 
            txtBoxUser.Anchor = AnchorStyles.None;
            txtBoxUser.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxUser.ForeColor = Color.Gray;
            txtBoxUser.Location = new Point(73, 279);
            txtBoxUser.Name = "txtBoxUser";
            txtBoxUser.Size = new Size(190, 22);
            txtBoxUser.TabIndex = 0;
            txtBoxUser.Text = "Username";
            txtBoxUser.MouseEnter += txtUsername_Enter;
            txtBoxUser.MouseLeave += txtUsername_Leave;
            // 
            // Button_Login
            // 
            Button_Login.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Button_Login.BackColor = Color.White;
            Button_Login.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            txtBoxPass.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxPass.ForeColor = Color.Gray;
            txtBoxPass.Location = new Point(73, 307);
            txtBoxPass.Name = "txtBoxPass";
            txtBoxPass.PasswordChar = '*';
            txtBoxPass.Size = new Size(190, 22);
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
            checkBox1.Location = new Point(75, 373);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(89, 20);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Auto Login";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // LinkCreateAcc
            // 
            LinkCreateAcc.ActiveLinkColor = Color.Navy;
            LinkCreateAcc.AutoSize = true;
            LinkCreateAcc.BackColor = Color.White;
            LinkCreateAcc.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LinkCreateAcc.LinkColor = Color.Black;
            LinkCreateAcc.Location = new Point(75, 493);
            LinkCreateAcc.Name = "LinkCreateAcc";
            LinkCreateAcc.Size = new Size(91, 16);
            LinkCreateAcc.TabIndex = 8;
            LinkCreateAcc.TabStop = true;
            LinkCreateAcc.Text = "Daftar Login";
            LinkCreateAcc.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LinkResetPass
            // 
            LinkResetPass.AutoSize = true;
            LinkResetPass.BackColor = Color.White;
            LinkResetPass.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LinkResetPass.LinkColor = Color.Black;
            LinkResetPass.Location = new Point(171, 493);
            LinkResetPass.Name = "LinkResetPass";
            LinkResetPass.Size = new Size(120, 16);
            LinkResetPass.TabIndex = 9;
            LinkResetPass.TabStop = true;
            LinkResetPass.Text = "Reset Password";
            LinkResetPass.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Britannic Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(189, 41);
            label1.Name = "label1";
            label1.Size = new Size(161, 76);
            label1.TabIndex = 10;
            label1.Text = "SHI\r\nCAD/CAM\r\n";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.background;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(LinkResetPass);
            panel1.Controls.Add(LinkCreateAcc);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(txtBoxPass);
            panel1.Controls.Add(Button_Login);
            panel1.Controls.Add(txtBoxUser);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(353, 597);
            panel1.TabIndex = 11;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(353, 597);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            HelpButton = true;
            Name = "Login";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtBoxUser;
        private Button Button_Login;
        private TextBox txtBoxPass;
        private CheckBox checkBox1;
        private LinkLabel LinkCreateAcc;
        private LinkLabel LinkResetPass;
        private Label label1;
        private Panel panel1;
    }
}
