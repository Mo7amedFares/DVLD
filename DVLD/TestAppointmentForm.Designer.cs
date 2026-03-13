namespace DVLD_Persntation
{
    partial class TestAppointmentForm
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
            components = new System.ComponentModel.Container();
            lblAddOrUpdateSystemUser = new Label();
            pictureBox1 = new PictureBox();
            uC_LicenseAndRequestBasicInfo1 = new UC_LicenseAndRequestBasicInfo();
            btnCloase = new Button();
            dataGridView1 = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            takeTestToolStripMenuItem = new ToolStripMenuItem();
            editTestToolStripMenuItem = new ToolStripMenuItem();
            BtnAddNewUser = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblAddOrUpdateSystemUser
            // 
            lblAddOrUpdateSystemUser.AutoSize = true;
            lblAddOrUpdateSystemUser.Font = new Font("Stencil", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddOrUpdateSystemUser.ForeColor = Color.DarkRed;
            lblAddOrUpdateSystemUser.Location = new Point(100, 85);
            lblAddOrUpdateSystemUser.Name = "lblAddOrUpdateSystemUser";
            lblAddOrUpdateSystemUser.Size = new Size(458, 38);
            lblAddOrUpdateSystemUser.TabIndex = 16;
            lblAddOrUpdateSystemUser.Text = "Viston Test Appointment";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.eye;
            pictureBox1.Location = new Point(287, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(91, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // uC_LicenseAndRequestBasicInfo1
            // 
            uC_LicenseAndRequestBasicInfo1.Location = new Point(0, 126);
            uC_LicenseAndRequestBasicInfo1.Name = "uC_LicenseAndRequestBasicInfo1";
            uC_LicenseAndRequestBasicInfo1.Size = new Size(647, 281);
            uC_LicenseAndRequestBasicInfo1.TabIndex = 18;
            // 
            // btnCloase
            // 
            btnCloase.FlatStyle = FlatStyle.Popup;
            btnCloase.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCloase.ImageAlign = ContentAlignment.MiddleRight;
            btnCloase.Location = new Point(257, 626);
            btnCloase.Name = "btnCloase";
            btnCloase.Size = new Size(90, 37);
            btnCloase.TabIndex = 77;
            btnCloase.Text = "Close";
            btnCloase.UseVisualStyleBackColor = true;
            btnCloase.Click += btnCloase_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            dataGridView1.Location = new Point(0, 443);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(647, 177);
            dataGridView1.TabIndex = 78;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { takeTestToolStripMenuItem, editTestToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(121, 48);
            // 
            // takeTestToolStripMenuItem
            // 
            takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
            takeTestToolStripMenuItem.Size = new Size(120, 22);
            takeTestToolStripMenuItem.Text = "Take Test";
            takeTestToolStripMenuItem.Click += takeTestToolStripMenuItem_Click;
            // 
            // editTestToolStripMenuItem
            // 
            editTestToolStripMenuItem.Name = "editTestToolStripMenuItem";
            editTestToolStripMenuItem.Size = new Size(120, 22);
            editTestToolStripMenuItem.Text = "Edit Test";
            editTestToolStripMenuItem.Click += editTestToolStripMenuItem_Click;
            // 
            // BtnAddNewUser
            // 
            BtnAddNewUser.BackgroundImage = Properties.Resources.add_event;
            BtnAddNewUser.BackgroundImageLayout = ImageLayout.Zoom;
            BtnAddNewUser.FlatStyle = FlatStyle.Popup;
            BtnAddNewUser.Location = new Point(597, 401);
            BtnAddNewUser.Name = "BtnAddNewUser";
            BtnAddNewUser.Size = new Size(38, 36);
            BtnAddNewUser.TabIndex = 80;
            BtnAddNewUser.UseVisualStyleBackColor = true;
            BtnAddNewUser.Click += BtnAddNewTestAppointment_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 410);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 81;
            label1.Text = "Appointment:";
            // 
            // TestAppointmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(647, 670);
            Controls.Add(label1);
            Controls.Add(BtnAddNewUser);
            Controls.Add(dataGridView1);
            Controls.Add(btnCloase);
            Controls.Add(uC_LicenseAndRequestBasicInfo1);
            Controls.Add(pictureBox1);
            Controls.Add(lblAddOrUpdateSystemUser);
            Name = "TestAppointmentForm";
            Text = "VistionTestAppointmentForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAddOrUpdateSystemUser;
        private PictureBox pictureBox1;
        private UC_LicenseAndRequestBasicInfo uC_LicenseAndRequestBasicInfo1;
        private Button btnCloase;
        private DataGridView dataGridView1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem takeTestToolStripMenuItem;
        private ToolStripMenuItem editTestToolStripMenuItem;
        private Button BtnAddNewUser;
        private Label label1;
    }
}