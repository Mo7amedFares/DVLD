namespace DVLD_Persntation
{
    partial class LocalDrivingLicenseApplicationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocalDrivingLicenseApplicationForm));
            label2 = new Label();
            pictureBox1 = new PictureBox();
            BtnAddNewLocalLicense = new Button();
            tbTextFiltter = new TextBox();
            label1 = new Label();
            CPoxFilterBy = new ComboBox();
            dataGridViewRequestLocalDrivaingLicense = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            showLocalDrivingLiceseToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            addLocalDrivingLicenseToolStripMenuItem = new ToolStripMenuItem();
            refrechToolStripMenuItem = new ToolStripMenuItem();
            pictureBox2 = new PictureBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRequestLocalDrivaingLicense).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(443, 142);
            label2.Name = "label2";
            label2.Size = new Size(294, 25);
            label2.TabIndex = 20;
            label2.Text = "Local Driving License Application";
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.license;
            pictureBox1.Location = new Point(523, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 114);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // BtnAddNewLocalLicense
            // 
            BtnAddNewLocalLicense.BackgroundImage = Properties.Resources.Add_Car_license1;
            BtnAddNewLocalLicense.BackgroundImageLayout = ImageLayout.Zoom;
            BtnAddNewLocalLicense.FlatStyle = FlatStyle.Popup;
            BtnAddNewLocalLicense.Location = new Point(1132, 154);
            BtnAddNewLocalLicense.Name = "BtnAddNewLocalLicense";
            BtnAddNewLocalLicense.Size = new Size(53, 54);
            BtnAddNewLocalLicense.TabIndex = 18;
            BtnAddNewLocalLicense.UseVisualStyleBackColor = true;
            BtnAddNewLocalLicense.Click += BtnAddNewLocalLicense_Click;
            // 
            // tbTextFiltter
            // 
            tbTextFiltter.Location = new Point(203, 169);
            tbTextFiltter.Name = "tbTextFiltter";
            tbTextFiltter.Size = new Size(120, 23);
            tbTextFiltter.TabIndex = 17;
            tbTextFiltter.TextChanged += tbTextFiltter_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 172);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 16;
            label1.Text = "Filter by";
            // 
            // CPoxFilterBy
            // 
            CPoxFilterBy.FormattingEnabled = true;
            CPoxFilterBy.Location = new Point(65, 169);
            CPoxFilterBy.Name = "CPoxFilterBy";
            CPoxFilterBy.Size = new Size(119, 23);
            CPoxFilterBy.TabIndex = 15;
            CPoxFilterBy.SelectedIndexChanged += CPoxFilterBy_SelectedIndexChanged;
            // 
            // dataGridViewRequestLocalDrivaingLicense
            // 
            dataGridViewRequestLocalDrivaingLicense.AllowUserToAddRows = false;
            dataGridViewRequestLocalDrivaingLicense.AllowUserToDeleteRows = false;
            dataGridViewRequestLocalDrivaingLicense.AllowUserToOrderColumns = true;
            dataGridViewRequestLocalDrivaingLicense.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRequestLocalDrivaingLicense.ContextMenuStrip = contextMenuStrip1;
            dataGridViewRequestLocalDrivaingLicense.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewRequestLocalDrivaingLicense.Location = new Point(0, 213);
            dataGridViewRequestLocalDrivaingLicense.Name = "dataGridViewRequestLocalDrivaingLicense";
            dataGridViewRequestLocalDrivaingLicense.ReadOnly = true;
            dataGridViewRequestLocalDrivaingLicense.Size = new Size(1197, 380);
            dataGridViewRequestLocalDrivaingLicense.TabIndex = 14;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { showLocalDrivingLiceseToolStripMenuItem, toolStripSeparator1, editToolStripMenuItem, deleteToolStripMenuItem, addLocalDrivingLicenseToolStripMenuItem, refrechToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(233, 120);
            // 
            // showLocalDrivingLiceseToolStripMenuItem
            // 
            showLocalDrivingLiceseToolStripMenuItem.Image = (Image)resources.GetObject("showLocalDrivingLiceseToolStripMenuItem.Image");
            showLocalDrivingLiceseToolStripMenuItem.Name = "showLocalDrivingLiceseToolStripMenuItem";
            showLocalDrivingLiceseToolStripMenuItem.Size = new Size(232, 22);
            showLocalDrivingLiceseToolStripMenuItem.Text = "Show Local Driving License";
            showLocalDrivingLiceseToolStripMenuItem.Click += showLocalDrivingLiceseToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(229, 6);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Image = (Image)resources.GetObject("editToolStripMenuItem.Image");
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(232, 22);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Image = (Image)resources.GetObject("deleteToolStripMenuItem.Image");
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(232, 22);
            deleteToolStripMenuItem.Text = "delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // addLocalDrivingLicenseToolStripMenuItem
            // 
            addLocalDrivingLicenseToolStripMenuItem.Image = Properties.Resources.Add_Car_license1;
            addLocalDrivingLicenseToolStripMenuItem.Name = "addLocalDrivingLicenseToolStripMenuItem";
            addLocalDrivingLicenseToolStripMenuItem.Size = new Size(232, 22);
            addLocalDrivingLicenseToolStripMenuItem.Text = "Add Local Driving License";
            addLocalDrivingLicenseToolStripMenuItem.Click += addLocalDrivingLicenseToolStripMenuItem_Click;
            // 
            // refrechToolStripMenuItem
            // 
            refrechToolStripMenuItem.Image = Properties.Resources.cycle;
            refrechToolStripMenuItem.Name = "refrechToolStripMenuItem";
            refrechToolStripMenuItem.Size = new Size(232, 22);
            refrechToolStripMenuItem.Text = "Refresh";
            refrechToolStripMenuItem.Click += refrechToolStripMenuItem_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.hyperlocal;
            pictureBox2.Location = new Point(628, 76);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 43);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // LocalDrivingLicenseApplicationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1197, 592);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(BtnAddNewLocalLicense);
            Controls.Add(tbTextFiltter);
            Controls.Add(label1);
            Controls.Add(CPoxFilterBy);
            Controls.Add(dataGridViewRequestLocalDrivaingLicense);
            Name = "LocalDrivingLicenseApplicationForm";
            Text = "LocalDrivingLicenseApplicationForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRequestLocalDrivaingLicense).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private PictureBox pictureBox1;
        private Button BtnAddNewLocalLicense;
        private TextBox tbTextFiltter;
        private Label label1;
        private ComboBox CPoxFilterBy;
        private DataGridView dataGridViewRequestLocalDrivaingLicense;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem showLocalDrivingLiceseToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem addLocalDrivingLicenseToolStripMenuItem;
        private PictureBox pictureBox2;
        private ToolStripMenuItem refrechToolStripMenuItem;
        private ErrorProvider errorProvider1;
    }
}