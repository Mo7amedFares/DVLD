namespace DVLD
{
    partial class MainForm
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
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            TSBtnPeople = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButton3 = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            toolStripButton4 = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripButton5 = new ToolStripButton();
            pictureBox1 = new PictureBox();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.ImageScalingSize = new Size(42, 42);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripSeparator2, TSBtnPeople, toolStripSeparator1, toolStripButton3, toolStripSeparator4, toolStripButton4, toolStripSeparator3, toolStripButton5 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1218, 49);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.Image = DVLD_Persntation.Properties.Resources.Applications_Icon;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(143, 46);
            toolStripButton1.Text = "Applications ";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 49);
            // 
            // TSBtnPeople
            // 
            TSBtnPeople.Image = DVLD_Persntation.Properties.Resources.Peoples;
            TSBtnPeople.ImageTransparentColor = Color.Magenta;
            TSBtnPeople.Name = "TSBtnPeople";
            TSBtnPeople.Size = new Size(105, 46);
            TSBtnPeople.Text = "People ";
            TSBtnPeople.Click += TSBtnPeople_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 49);
            // 
            // toolStripButton3
            // 
            toolStripButton3.Image = DVLD_Persntation.Properties.Resources.driver;
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(108, 46);
            toolStripButton3.Text = "Drivers ";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 49);
            // 
            // toolStripButton4
            // 
            toolStripButton4.Image = DVLD_Persntation.Properties.Resources.Users;
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(96, 46);
            toolStripButton4.Text = "Users ";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 49);
            // 
            // toolStripButton5
            // 
            toolStripButton5.Image = DVLD_Persntation.Properties.Resources.account_settings;
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(169, 46);
            toolStripButton5.Text = "Account Settings";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = DVLD_Persntation.Properties.Resources.background_DVLD;
            pictureBox1.Location = new Point(0, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1218, 617);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.DarkGray;
            ClientSize = new Size(1218, 666);
            Controls.Add(pictureBox1);
            Controls.Add(toolStrip1);
            Name = "MainForm";
            Text = "MainForm";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton TSBtnPeople;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private ToolStripButton toolStripButton5;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripSeparator toolStripSeparator3;
        private PictureBox pictureBox1;
    }
}
