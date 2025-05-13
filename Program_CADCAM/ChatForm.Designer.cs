namespace Program_CADCAM
{
    partial class ChatForm
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
            panel2 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // txtBoxMessage
            // 
            txtBoxMessage.Dock = DockStyle.Fill;
            txtBoxMessage.Location = new Point(2, 2);
            txtBoxMessage.Margin = new Padding(2, 2, 2, 2);
            txtBoxMessage.Multiline = true;
            txtBoxMessage.Name = "txtBoxMessage";
            txtBoxMessage.Size = new Size(287, 40);
            txtBoxMessage.TabIndex = 0;
            // 
            // txtBoxChat
            // 
            txtBoxChat.BackColor = SystemColors.ControlLightLight;
            tableLayoutPanel1.SetColumnSpan(txtBoxChat, 2);
            txtBoxChat.Dock = DockStyle.Fill;
            txtBoxChat.Location = new Point(2, 52);
            txtBoxChat.Margin = new Padding(2, 2, 2, 2);
            txtBoxChat.Multiline = true;
            txtBoxChat.Name = "txtBoxChat";
            txtBoxChat.Size = new Size(333, 411);
            txtBoxChat.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            tableLayoutPanel1.SetColumnSpan(panel1, 2);
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(2, 467);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(333, 44);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Microsoft Sans Serif", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label1.Location = new Point(2, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(168, 50);
            label1.TabIndex = 2;
            label1.Text = "Nama Karyawan";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSend
            // 
            btnSend.BackgroundImage = Properties.Resources.message__1_;
            btnSend.BackgroundImageLayout = ImageLayout.Stretch;
            btnSend.Dock = DockStyle.Fill;
            btnSend.Location = new Point(293, 2);
            btnSend.Margin = new Padding(2, 2, 2, 2);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(38, 40);
            btnSend.TabIndex = 4;
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(337, 513);
            panel2.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.0385742F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.9614258F));
            tableLayoutPanel1.Controls.Add(txtBoxChat, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.951057F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 81.09162F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.161794F));
            tableLayoutPanel1.Size = new Size(337, 513);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 87.38739F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.6126127F));
            tableLayoutPanel2.Controls.Add(btnSend, 1, 0);
            tableLayoutPanel2.Controls.Add(txtBoxMessage, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(333, 44);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // ChatForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(337, 513);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 2, 2, 2);
            Name = "ChatForm";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtBoxMessage;
        private TextBox txtBoxChat;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnSend;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
    }
}