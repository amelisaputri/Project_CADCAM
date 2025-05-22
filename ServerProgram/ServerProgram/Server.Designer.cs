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
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ListUser = new ListBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(ListUser);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-3, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(661, 467);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label1.Location = new Point(28, 27);
            label1.Name = "label1";
            label1.Size = new Size(200, 33);
            label1.TabIndex = 0;
            label1.Text = "List User Chat";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // ListUser
            // 
            ListUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ListUser.FormattingEnabled = true;
            ListUser.ItemHeight = 25;
            ListUser.Location = new Point(24, 83);
            ListUser.Name = "ListUser";
            ListUser.Size = new Size(617, 354);
            ListUser.TabIndex = 1;
            // 
            // Server
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 462);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
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
        private Label label1;
        private ErrorProvider errorProvider1;
        private ListBox ListUser;
    }
}
