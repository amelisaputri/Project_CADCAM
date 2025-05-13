namespace Program_CADCAM
{
    partial class ChatForm_20250513
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatForm));
            txtBoxMessage = new TextBox();
            txtBoxChat = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            btnSend = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtBoxMessage
            // 
            txtBoxMessage.Location = new Point(10, 1049);
            txtBoxMessage.Multiline = true;
            txtBoxMessage.Name = "txtBoxMessage";
            txtBoxMessage.Size = new Size(495, 68);
            txtBoxMessage.TabIndex = 0;
            // 
            // txtBoxChat
            // 
            txtBoxChat.BackColor = SystemColors.ControlLightLight;
            txtBoxChat.Location = new Point(-3, 111);
            txtBoxChat.Multiline = true;
            txtBoxChat.Name = "txtBoxChat";
            txtBoxChat.Size = new Size(586, 932);
            txtBoxChat.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtBoxChat);
            panel1.Controls.Add(txtBoxMessage);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(581, 1131);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Pretendard", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label1.Location = new Point(25, 48);
            label1.Name = "label1";
            label1.Size = new Size(189, 29);
            label1.TabIndex = 2;
            label1.Text = "Nama Karyawan";
            // 
            // btnSend
            // 
            btnSend.BackgroundImage = Properties.Resources.message__1_;
            btnSend.BackgroundImageLayout = ImageLayout.Stretch;
            btnSend.Location = new Point(512, 1049);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(40, 40);
            btnSend.TabIndex = 4;
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // ChatForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 1130);
            Controls.Add(btnSend);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ChatForm";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtBoxMessage;
        private TextBox txtBoxChat;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnSend;
    }
}