namespace Program_CADCAM
{
    partial class ControlChat
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            picProfile = new PictureBox();
            LbName = new Label();
            LbText = new Label();
            LbTime = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)picProfile).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // picProfile
            // 
            picProfile.Anchor = AnchorStyles.Right;
            picProfile.Image = Properties.Resources.icon_2;
            picProfile.Location = new Point(14, 24);
            picProfile.Margin = new Padding(2);
            picProfile.Name = "picProfile";
            tableLayoutPanel1.SetRowSpan(picProfile, 2);
            picProfile.Size = new Size(50, 50);
            picProfile.SizeMode = PictureBoxSizeMode.StretchImage;
            picProfile.TabIndex = 0;
            picProfile.TabStop = false;
            // 
            // LbName
            // 
            LbName.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            LbName.AutoSize = true;
            LbName.BackColor = Color.White;
            LbName.Font = new Font("Tahoma", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LbName.Location = new Point(68, 13);
            LbName.Margin = new Padding(2, 0, 2, 0);
            LbName.Name = "LbName";
            LbName.Size = new Size(74, 17);
            LbName.TabIndex = 1;
            LbName.Text = "Nama User";
            // 
            // LbText
            // 
            LbText.BackColor = Color.White;
            LbText.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LbText.Location = new Point(0, 0);
            LbText.Margin = new Padding(2, 0, 2, 0);
            LbText.Name = "LbText";
            LbText.Size = new Size(270, 45);
            LbText.TabIndex = 2;
            LbText.Text = "Typing";
            // 
            // LbTime
            // 
            LbTime.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LbTime.BackColor = Color.Transparent;
            LbTime.Font = new Font("Tahoma", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LbTime.ForeColor = SystemColors.ControlDark;
            LbTime.Location = new Point(194, 46);
            LbTime.Margin = new Padding(2, 0, 2, 0);
            LbTime.Name = "LbTime";
            LbTime.Size = new Size(73, 16);
            LbTime.TabIndex = 3;
            LbTime.Text = "10:00";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.3846149F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.61539F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 14F));
            tableLayoutPanel1.Controls.Add(LbName, 1, 0);
            tableLayoutPanel1.Controls.Add(panel1, 1, 1);
            tableLayoutPanel1.Controls.Add(picProfile, 0, 0);
            tableLayoutPanel1.Location = new Point(2, 2);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30.8943081F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 69.10569F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 16F));
            tableLayoutPanel1.Size = new Size(342, 98);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(LbText);
            panel1.Controls.Add(LbTime);
            panel1.Location = new Point(68, 32);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(272, 64);
            panel1.TabIndex = 4;
            // 
            // ControlChat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(2);
            Name = "ControlChat";
            Size = new Size(347, 103);
            ((System.ComponentModel.ISupportInitialize)picProfile).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picProfile;
        private Label LbName;
        private Label LbText;
        private Label LbTime;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
    }
}
