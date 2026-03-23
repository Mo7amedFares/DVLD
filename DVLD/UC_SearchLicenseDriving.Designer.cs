namespace DVLD_Persntation
{
    partial class UC_SearchLicenseDriving
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
            components = new System.ComponentModel.Container();
            uC_DriverLicenseInfo1 = new UC_DriverLicenseInfo();
            groupBox1 = new GroupBox();
            btnSearch = new Button();
            tbTextFiltter = new TextBox();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // uC_DriverLicenseInfo1
            // 
            uC_DriverLicenseInfo1.BorderStyle = BorderStyle.FixedSingle;
            uC_DriverLicenseInfo1.Location = new Point(3, 86);
            uC_DriverLicenseInfo1.Name = "uC_DriverLicenseInfo1";
            uC_DriverLicenseInfo1.Size = new Size(810, 309);
            uC_DriverLicenseInfo1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(tbTextFiltter);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(3, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(810, 71);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search Lecense";
            // 
            // btnSearch
            // 
            btnSearch.BackgroundImage = Properties.Resources.search_profile;
            btnSearch.BackgroundImageLayout = ImageLayout.Zoom;
            btnSearch.FlatStyle = FlatStyle.Popup;
            btnSearch.Location = new Point(541, 15);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(35, 36);
            btnSearch.TabIndex = 18;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // tbTextFiltter
            // 
            tbTextFiltter.Location = new Point(275, 22);
            tbTextFiltter.Name = "tbTextFiltter";
            tbTextFiltter.Size = new Size(238, 23);
            tbTextFiltter.TabIndex = 17;
            tbTextFiltter.TextChanged += tbTextFiltter_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(173, 22);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 16;
            label1.Text = "License ID:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // UC_SearchLicenseDriving
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Controls.Add(uC_DriverLicenseInfo1);
            Name = "UC_SearchLicenseDriving";
            Size = new Size(816, 399);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private UC_DriverLicenseInfo uC_DriverLicenseInfo1;
        private GroupBox groupBox1;
        private Button btnSearch;
        private TextBox tbTextFiltter;
        private Label label1;
        private ErrorProvider errorProvider1;
    }
}
