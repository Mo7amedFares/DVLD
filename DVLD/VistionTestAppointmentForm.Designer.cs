namespace DVLD_Persntation
{
    partial class VistionTestAppointmentForm
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
            dataGridView1 = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            takeTestToolStripMenuItem = new ToolStripMenuItem();
            editTestToolStripMenuItem = new ToolStripMenuItem();
            BtnAddNewTestAppointment = new Button();
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
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            dataGridView1.Location = new Point(0, 443);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(647, 174);
            dataGridView1.TabIndex = 19;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            // BtnAddNewTestAppointment
            // 
            BtnAddNewTestAppointment.BackgroundImage = Properties.Resources.add_event;
            BtnAddNewTestAppointment.BackgroundImageLayout = ImageLayout.Zoom;
            BtnAddNewTestAppointment.FlatStyle = FlatStyle.Popup;
            BtnAddNewTestAppointment.Location = new Point(598, 404);
            BtnAddNewTestAppointment.Name = "BtnAddNewTestAppointment";
            BtnAddNewTestAppointment.Size = new Size(37, 37);
            BtnAddNewTestAppointment.TabIndex = 20;
            BtnAddNewTestAppointment.UseVisualStyleBackColor = true;
            BtnAddNewTestAppointment.Click += BtnAddNewTestAppointment_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 411);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 21;
            label1.Text = "Appointments:";
            // 
            // VistionTestAppointmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(647, 617);
            Controls.Add(label1);
            Controls.Add(BtnAddNewTestAppointment);
            Controls.Add(dataGridView1);
            Controls.Add(uC_LicenseAndRequestBasicInfo1);
            Controls.Add(pictureBox1);
            Controls.Add(lblAddOrUpdateSystemUser);
            Name = "VistionTestAppointmentForm";
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
        private DataGridView dataGridView1;
        private Button BtnAddNewTestAppointment;
        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem takeTestToolStripMenuItem;
        private ToolStripMenuItem editTestToolStripMenuItem;
    }
}