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
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripButton1 = new ToolStripDropDownButton();
            applicationTypesToolStripMenuItem = new ToolStripMenuItem();
            mangeTestTypesToolStripMenuItem = new ToolStripMenuItem();
            TSBtnPeople = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButton3 = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            toolStripButton4 = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripButton5 = new ToolStripDropDownButton();
            curentUserInfoToolStripMenuItem = new ToolStripMenuItem();
            chagePasswordToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            sigToolStripMenuItem = new ToolStripMenuItem();
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
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripSeparator2, toolStripButton1, TSBtnPeople, toolStripSeparator1, toolStripButton3, toolStripSeparator4, toolStripButton4, toolStripSeparator3, toolStripButton5 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1218, 49);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 49);
            // 
            // toolStripButton1
            // 
            toolStripButton1.DropDownItems.AddRange(new ToolStripItem[] { applicationTypesToolStripMenuItem, mangeTestTypesToolStripMenuItem });
            toolStripButton1.Image = DVLD_Persntation.Properties.Resources.Applications_Icon;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(152, 46);
            toolStripButton1.Text = "Applications ";
            // 
            // applicationTypesToolStripMenuItem
            // 
            applicationTypesToolStripMenuItem.Image = DVLD_Persntation.Properties.Resources.deployment;
            applicationTypesToolStripMenuItem.Name = "applicationTypesToolStripMenuItem";
            applicationTypesToolStripMenuItem.Size = new Size(224, 48);
            applicationTypesToolStripMenuItem.Text = "Application Types";
            applicationTypesToolStripMenuItem.Click += applicationTypesToolStripMenuItem_Click;
            // 
            // mangeTestTypesToolStripMenuItem
            // 
            mangeTestTypesToolStripMenuItem.Image = DVLD_Persntation.Properties.Resources.compliance;
            mangeTestTypesToolStripMenuItem.Name = "mangeTestTypesToolStripMenuItem";
            mangeTestTypesToolStripMenuItem.Size = new Size(224, 48);
            mangeTestTypesToolStripMenuItem.Text = "Mange Test Types";
            mangeTestTypesToolStripMenuItem.Click += mangeTestTypesToolStripMenuItem_Click;
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
            toolStripButton4.Click += toolStripButton4_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 49);
            // 
            // toolStripButton5
            // 
            toolStripButton5.DropDownItems.AddRange(new ToolStripItem[] { curentUserInfoToolStripMenuItem, chagePasswordToolStripMenuItem, toolStripSeparator5, sigToolStripMenuItem });
            toolStripButton5.Image = DVLD_Persntation.Properties.Resources.account_settings;
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(178, 46);
            toolStripButton5.Text = "Account Settings";
            // 
            // curentUserInfoToolStripMenuItem
            // 
            curentUserInfoToolStripMenuItem.Image = DVLD_Persntation.Properties.Resources.information;
            curentUserInfoToolStripMenuItem.Name = "curentUserInfoToolStripMenuItem";
            curentUserInfoToolStripMenuItem.Size = new Size(222, 48);
            curentUserInfoToolStripMenuItem.Text = "curent user info";
            curentUserInfoToolStripMenuItem.Click += curentUserInfoToolStripMenuItem_Click;
            // 
            // chagePasswordToolStripMenuItem
            // 
            chagePasswordToolStripMenuItem.Image = DVLD_Persntation.Properties.Resources.padlock;
            chagePasswordToolStripMenuItem.Name = "chagePasswordToolStripMenuItem";
            chagePasswordToolStripMenuItem.Size = new Size(222, 48);
            chagePasswordToolStripMenuItem.Text = "change password";
            chagePasswordToolStripMenuItem.Click += chagePasswordToolStripMenuItem_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(219, 6);
            // 
            // sigToolStripMenuItem
            // 
            sigToolStripMenuItem.Image = DVLD_Persntation.Properties.Resources.log_out;
            sigToolStripMenuItem.Name = "sigToolStripMenuItem";
            sigToolStripMenuItem.Size = new Size(222, 48);
            sigToolStripMenuItem.Text = "sign out";
            sigToolStripMenuItem.Click += sigToolStripMenuItem_Click;
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
        private ToolStripButton TSBtnPeople;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripSeparator toolStripSeparator3;
        private PictureBox pictureBox1;
        private ToolStripDropDownButton toolStripButton5;
        private ToolStripMenuItem curentUserInfoToolStripMenuItem;
        private ToolStripMenuItem chagePasswordToolStripMenuItem;
        private ToolStripMenuItem sigToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripDropDownButton toolStripButton1;
        private ToolStripMenuItem applicationTypesToolStripMenuItem;
        private ToolStripMenuItem mangeTestTypesToolStripMenuItem;
    }
}
