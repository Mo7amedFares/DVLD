namespace DVLD_Persntation
{
    partial class LicenseHistoryForm
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
            uC_PersonInfomation1 = new UC_PersonInfomation();
            lblAddOrUpdateSystemUser = new Label();
            groupBox1 = new GroupBox();
            tabControl1 = new TabControl();
            tabPageLocalLicense = new TabPage();
            dataGridViewLocalLicense = new DataGridView();
            tabPageInterntionlLicense = new TabPage();
            dataGridViewInternationlLicense = new DataGridView();
            btnCloase = new Button();
            groupBox1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPageLocalLicense.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLocalLicense).BeginInit();
            tabPageInterntionlLicense.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInternationlLicense).BeginInit();
            SuspendLayout();
            // 
            // uC_PersonInfomation1
            // 
            uC_PersonInfomation1.AccessibleName = "";
            uC_PersonInfomation1.BorderStyle = BorderStyle.FixedSingle;
            uC_PersonInfomation1.Location = new Point(0, 55);
            uC_PersonInfomation1.Name = "uC_PersonInfomation1";
            uC_PersonInfomation1.Size = new Size(811, 263);
            uC_PersonInfomation1.TabIndex = 0;
            // 
            // lblAddOrUpdateSystemUser
            // 
            lblAddOrUpdateSystemUser.AutoSize = true;
            lblAddOrUpdateSystemUser.Font = new Font("Stencil", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddOrUpdateSystemUser.ForeColor = Color.DarkRed;
            lblAddOrUpdateSystemUser.Location = new Point(247, 9);
            lblAddOrUpdateSystemUser.Name = "lblAddOrUpdateSystemUser";
            lblAddOrUpdateSystemUser.Size = new Size(301, 38);
            lblAddOrUpdateSystemUser.TabIndex = 16;
            lblAddOrUpdateSystemUser.Text = "License History";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tabControl1);
            groupBox1.Location = new Point(0, 333);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(811, 194);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Driver Licenses";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageLocalLicense);
            tabControl1.Controls.Add(tabPageInterntionlLicense);
            tabControl1.Location = new Point(6, 22);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(805, 166);
            tabControl1.TabIndex = 0;
            // 
            // tabPageLocalLicense
            // 
            tabPageLocalLicense.Controls.Add(dataGridViewLocalLicense);
            tabPageLocalLicense.Location = new Point(4, 24);
            tabPageLocalLicense.Name = "tabPageLocalLicense";
            tabPageLocalLicense.Padding = new Padding(3);
            tabPageLocalLicense.Size = new Size(797, 138);
            tabPageLocalLicense.TabIndex = 0;
            tabPageLocalLicense.Text = "Local License";
            tabPageLocalLicense.UseVisualStyleBackColor = true;
            // 
            // dataGridViewLocalLicense
            // 
            dataGridViewLocalLicense.AllowUserToAddRows = false;
            dataGridViewLocalLicense.AllowUserToDeleteRows = false;
            dataGridViewLocalLicense.AllowUserToOrderColumns = true;
            dataGridViewLocalLicense.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewLocalLicense.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLocalLicense.Location = new Point(0, 0);
            dataGridViewLocalLicense.Name = "dataGridViewLocalLicense";
            dataGridViewLocalLicense.ReadOnly = true;
            dataGridViewLocalLicense.Size = new Size(797, 138);
            dataGridViewLocalLicense.TabIndex = 0;
            // 
            // tabPageInterntionlLicense
            // 
            tabPageInterntionlLicense.Controls.Add(dataGridViewInternationlLicense);
            tabPageInterntionlLicense.Location = new Point(4, 24);
            tabPageInterntionlLicense.Name = "tabPageInterntionlLicense";
            tabPageInterntionlLicense.Padding = new Padding(3);
            tabPageInterntionlLicense.Size = new Size(797, 138);
            tabPageInterntionlLicense.TabIndex = 1;
            tabPageInterntionlLicense.Text = "Internationl License";
            tabPageInterntionlLicense.UseVisualStyleBackColor = true;
            // 
            // dataGridViewInternationlLicense
            // 
            dataGridViewInternationlLicense.AllowUserToAddRows = false;
            dataGridViewInternationlLicense.AllowUserToDeleteRows = false;
            dataGridViewInternationlLicense.AllowUserToOrderColumns = true;
            dataGridViewInternationlLicense.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewInternationlLicense.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInternationlLicense.Location = new Point(0, 0);
            dataGridViewInternationlLicense.Name = "dataGridViewInternationlLicense";
            dataGridViewInternationlLicense.ReadOnly = true;
            dataGridViewInternationlLicense.Size = new Size(797, 138);
            dataGridViewInternationlLicense.TabIndex = 1;
            // 
            // btnCloase
            // 
            btnCloase.FlatStyle = FlatStyle.Popup;
            btnCloase.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCloase.ImageAlign = ContentAlignment.MiddleRight;
            btnCloase.Location = new Point(710, 527);
            btnCloase.Name = "btnCloase";
            btnCloase.Size = new Size(90, 37);
            btnCloase.TabIndex = 18;
            btnCloase.Text = "Close";
            btnCloase.UseVisualStyleBackColor = true;
            btnCloase.Click += btnCloase_Click;
            // 
            // LicenseHistoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 571);
            Controls.Add(btnCloase);
            Controls.Add(groupBox1);
            Controls.Add(lblAddOrUpdateSystemUser);
            Controls.Add(uC_PersonInfomation1);
            Name = "LicenseHistoryForm";
            Text = "LicenseHistoryForm";
            groupBox1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPageLocalLicense.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewLocalLicense).EndInit();
            tabPageInterntionlLicense.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInternationlLicense).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private UC_PersonInfomation uC_PersonInfomation1;
        private Label lblAddOrUpdateSystemUser;
        private GroupBox groupBox1;
        private TabControl tabControl1;
        private TabPage tabPageLocalLicense;
        private DataGridView dataGridViewLocalLicense;
        private TabPage tabPageInterntionlLicense;
        private DataGridView dataGridViewInternationlLicense;
        private Button btnCloase;
    }
}