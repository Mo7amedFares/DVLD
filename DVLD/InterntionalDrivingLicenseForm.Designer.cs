namespace DVLD_Persntation
{
    partial class InterntionalDrivingLicenseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterntionalDrivingLicenseForm));
            errorProvider1 = new ErrorProvider(components);
            showLicenseHistoryToolStripMenuItem = new ToolStripMenuItem();
            refrechToolStripMenuItem = new ToolStripMenuItem();
            addLocalDrivingLicenseToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            showLocalDrivingLiceseToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            pictureBox2 = new PictureBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            BtnAddNewLocalLicense = new Button();
            tbTextFiltter = new TextBox();
            label1 = new Label();
            CPoxFilterBy = new ComboBox();
            dataGridViewRequestLocalDrivaingLicense = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRequestLocalDrivaingLicense).BeginInit();
            SuspendLayout();
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // showLicenseHistoryToolStripMenuItem
            // 
            showLicenseHistoryToolStripMenuItem.Image = Properties.Resources.clock;
            showLicenseHistoryToolStripMenuItem.Name = "showLicenseHistoryToolStripMenuItem";
            showLicenseHistoryToolStripMenuItem.Size = new Size(274, 22);
            showLicenseHistoryToolStripMenuItem.Text = "Show License History";
            // 
            // refrechToolStripMenuItem
            // 
            refrechToolStripMenuItem.Image = Properties.Resources.cycle;
            refrechToolStripMenuItem.Name = "refrechToolStripMenuItem";
            refrechToolStripMenuItem.Size = new Size(274, 22);
            refrechToolStripMenuItem.Text = "Refresh";
            refrechToolStripMenuItem.Click += refrechToolStripMenuItem_Click;
            // 
            // addLocalDrivingLicenseToolStripMenuItem
            // 
            addLocalDrivingLicenseToolStripMenuItem.Image = Properties.Resources.Add_Car_license1;
            addLocalDrivingLicenseToolStripMenuItem.Name = "addLocalDrivingLicenseToolStripMenuItem";
            addLocalDrivingLicenseToolStripMenuItem.Size = new Size(274, 22);
            addLocalDrivingLicenseToolStripMenuItem.Text = "Add Interntional Driving License";
            addLocalDrivingLicenseToolStripMenuItem.Click += addLocalDrivingLicenseToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(271, 6);
            // 
            // showLocalDrivingLiceseToolStripMenuItem
            // 
            showLocalDrivingLiceseToolStripMenuItem.Image = (Image)resources.GetObject("showLocalDrivingLiceseToolStripMenuItem.Image");
            showLocalDrivingLiceseToolStripMenuItem.Name = "showLocalDrivingLiceseToolStripMenuItem";
            showLocalDrivingLiceseToolStripMenuItem.Size = new Size(274, 22);
            showLocalDrivingLiceseToolStripMenuItem.Text = "Show InterntionalDriving License";
            showLocalDrivingLiceseToolStripMenuItem.Click += showLocalDrivingLiceseToolStripMenuItem_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { showLocalDrivingLiceseToolStripMenuItem, toolStripSeparator1, addLocalDrivingLicenseToolStripMenuItem, refrechToolStripMenuItem, showLicenseHistoryToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(275, 98);
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.earth;
            pictureBox2.Location = new Point(628, 65);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 43);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 29;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(401, 131);
            label2.Name = "label2";
            label2.Size = new Size(351, 25);
            label2.TabIndex = 28;
            label2.Text = "Interntional Driving License Application";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.license;
            pictureBox1.Location = new Point(523, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 114);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // BtnAddNewLocalLicense
            // 
            BtnAddNewLocalLicense.BackgroundImage = Properties.Resources.Add_Car_license1;
            BtnAddNewLocalLicense.BackgroundImageLayout = ImageLayout.Zoom;
            BtnAddNewLocalLicense.FlatStyle = FlatStyle.Popup;
            BtnAddNewLocalLicense.Location = new Point(1132, 143);
            BtnAddNewLocalLicense.Name = "BtnAddNewLocalLicense";
            BtnAddNewLocalLicense.Size = new Size(53, 54);
            BtnAddNewLocalLicense.TabIndex = 26;
            BtnAddNewLocalLicense.UseVisualStyleBackColor = true;
            BtnAddNewLocalLicense.Click += BtnAddNewLocalLicense_Click;
            // 
            // tbTextFiltter
            // 
            tbTextFiltter.Location = new Point(203, 158);
            tbTextFiltter.Name = "tbTextFiltter";
            tbTextFiltter.Size = new Size(120, 23);
            tbTextFiltter.TabIndex = 25;
            tbTextFiltter.TextChanged += tbTextFiltter_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 161);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 24;
            label1.Text = "Filter by";
            // 
            // CPoxFilterBy
            // 
            CPoxFilterBy.FormattingEnabled = true;
            CPoxFilterBy.Location = new Point(65, 158);
            CPoxFilterBy.Name = "CPoxFilterBy";
            CPoxFilterBy.Size = new Size(119, 23);
            CPoxFilterBy.TabIndex = 23;
            CPoxFilterBy.SelectedIndexChanged += CPoxFilterBy_SelectedIndexChanged;
            // 
            // dataGridViewRequestLocalDrivaingLicense
            // 
            dataGridViewRequestLocalDrivaingLicense.AllowUserToAddRows = false;
            dataGridViewRequestLocalDrivaingLicense.AllowUserToDeleteRows = false;
            dataGridViewRequestLocalDrivaingLicense.AllowUserToOrderColumns = true;
            dataGridViewRequestLocalDrivaingLicense.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewRequestLocalDrivaingLicense.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRequestLocalDrivaingLicense.ContextMenuStrip = contextMenuStrip1;
            dataGridViewRequestLocalDrivaingLicense.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewRequestLocalDrivaingLicense.Location = new Point(-5, 202);
            dataGridViewRequestLocalDrivaingLicense.Name = "dataGridViewRequestLocalDrivaingLicense";
            dataGridViewRequestLocalDrivaingLicense.ReadOnly = true;
            dataGridViewRequestLocalDrivaingLicense.Size = new Size(1202, 380);
            dataGridViewRequestLocalDrivaingLicense.TabIndex = 22;
            // 
            // InterntionalDrivingLicenseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1196, 582);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(BtnAddNewLocalLicense);
            Controls.Add(tbTextFiltter);
            Controls.Add(label1);
            Controls.Add(CPoxFilterBy);
            Controls.Add(dataGridViewRequestLocalDrivaingLicense);
            MaximizeBox = false;
            Name = "InterntionalDrivingLicenseForm";
            Text = "InterntionalDrivingLicenseForm";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRequestLocalDrivaingLicense).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ErrorProvider errorProvider1;
        private PictureBox pictureBox2;
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
        private ToolStripMenuItem addLocalDrivingLicenseToolStripMenuItem;
        private ToolStripMenuItem refrechToolStripMenuItem;
        private ToolStripMenuItem showLicenseHistoryToolStripMenuItem;
    }
}