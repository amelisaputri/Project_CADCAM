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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Server));
            panel1 = new Panel();
            ListServer = new TextBox();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(ListServer);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-2, -1);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(463, 280);
            panel1.TabIndex = 0;
            // 
            // ListServer
            // 
            ListServer.BackColor = SystemColors.ButtonHighlight;
            ListServer.Location = new Point(24, 42);
            ListServer.Margin = new Padding(2, 2, 2, 2);
            ListServer.Multiline = true;
            ListServer.Name = "ListServer";
            ListServer.Size = new Size(426, 224);
            ListServer.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label1.Location = new Point(22, 16);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(124, 24);
            label1.TabIndex = 0;
            label1.Text = "List User Chat";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Server
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 277);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 2, 2, 2);
            Name = "Server";
            Text = "Server";
            Load += ServerForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox ListServer;
        private Label label1;
        private ErrorProvider errorProvider1;
    }
}
