namespace ServerProgram
{
    partial class Server
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Server));
            panel1 = new Panel();
            ListServer = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(ListServer);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-3, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(794, 559);
            panel1.TabIndex = 0;
            // 
            // ListServer
            // 
            ListServer.BackColor = SystemColors.ButtonHighlight;
            ListServer.Location = new Point(41, 83);
            ListServer.Multiline = true;
            ListServer.Name = "ListServer";
            ListServer.Size = new Size(727, 445);
            ListServer.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Pretendard", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label1.Location = new Point(37, 32);
            label1.Name = "label1";
            label1.Size = new Size(225, 39);
            label1.TabIndex = 0;
            label1.Text = "List User Chat";
            // 
            // Server
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 554);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Server";
            Text = "Server";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox ListServer;
        private Label label1;
    }
}
