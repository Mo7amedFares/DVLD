namespace DVLD_Persntation
{
    partial class AddOrUpdateLocalDrivingLicenseForm
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
            errorProvider1 = new ErrorProvider(components);
            btnSave = new Button();
            btnCloase = new Button();
            lblAddOrUpdateSystemUser = new Label();
            lblApplicationID = new Label();
            pictureBox4 = new PictureBox();
            label4 = new Label();
            btnNextPage = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            label3 = new Label();
            uC_SearchPeoble1 = new UC_SearchPeoble();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            cmbLicenseClass = new ComboBox();
            lblCreatedBy = new Label();
            pictureBox5 = new PictureBox();
            label8 = new Label();
            lblApplicationFees = new Label();
            lblApplicationDate = new Label();
            tabLocalLicense = new TabControl();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            tabLocalLicense.SuspendLayout();
            SuspendLayout();
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ImageAlign = ContentAlignment.MiddleRight;
            btnSave.Location = new Point(721, 521);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(87, 37);
            btnSave.TabIndex = 17;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCloase
            // 
            btnCloase.FlatStyle = FlatStyle.Popup;
            btnCloase.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCloase.ImageAlign = ContentAlignment.MiddleRight;
            btnCloase.Location = new Point(614, 521);
            btnCloase.Name = "btnCloase";
            btnCloase.Size = new Size(90, 37);
            btnCloase.TabIndex = 16;
            btnCloase.Text = "Close";
            btnCloase.UseVisualStyleBackColor = true;
            btnCloase.Click += btnCloase_Click;
            // 
            // lblAddOrUpdateSystemUser
            // 
            lblAddOrUpdateSystemUser.AutoSize = true;
            lblAddOrUpdateSystemUser.Font = new Font("Stencil", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddOrUpdateSystemUser.ForeColor = Color.DarkRed;
            lblAddOrUpdateSystemUser.Location = new Point(63, 9);
            lblAddOrUpdateSystemUser.Name = "lblAddOrUpdateSystemUser";
            lblAddOrUpdateSystemUser.Size = new Size(698, 38);
            lblAddOrUpdateSystemUser.TabIndex = 15;
            lblAddOrUpdateSystemUser.Text = "Add Local Driving License Application";
            // 
            // lblApplicationID
            // 
            lblApplicationID.AutoSize = true;
            lblApplicationID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApplicationID.ForeColor = Color.Black;
            lblApplicationID.Location = new Point(231, 54);
            lblApplicationID.Name = "lblApplicationID";
            lblApplicationID.Size = new Size(31, 21);
            lblApplicationID.TabIndex = 23;
            lblApplicationID.Text = "???";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.handFees;
            pictureBox4.Location = new Point(185, 201);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(21, 21);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 22;
            pictureBox4.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(26, 201);
            label4.Name = "label4";
            label4.Size = new Size(144, 21);
            label4.TabIndex = 19;
            label4.Text = "Application Fees :";
            // 
            // btnNextPage
            // 
            btnNextPage.FlatStyle = FlatStyle.Popup;
            btnNextPage.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNextPage.ImageAlign = ContentAlignment.MiddleRight;
            btnNextPage.Location = new Point(705, 372);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(87, 37);
            btnNextPage.TabIndex = 14;
            btnNextPage.Text = "Next";
            btnNextPage.UseVisualStyleBackColor = true;
            btnNextPage.Click += btnNextPage_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.calendar_clock;
            pictureBox1.Location = new Point(185, 103);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(21, 21);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(26, 103);
            label2.Name = "label2";
            label2.Size = new Size(147, 21);
            label2.TabIndex = 16;
            label2.Text = "Application Date :";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.driving_license__1_;
            pictureBox3.Location = new Point(185, 152);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(21, 21);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.id_badge;
            pictureBox2.Location = new Point(185, 54);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(21, 21);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(26, 152);
            label5.Name = "label5";
            label5.Size = new Size(116, 21);
            label5.TabIndex = 11;
            label5.Text = "Lecinse Class :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(26, 54);
            label3.Name = "label3";
            label3.Size = new Size(128, 21);
            label3.TabIndex = 10;
            label3.Text = "Application ID :";
            // 
            // uC_SearchPeoble1
            // 
            uC_SearchPeoble1.Location = new Point(3, 3);
            uC_SearchPeoble1.Name = "uC_SearchPeoble1";
            uC_SearchPeoble1.Size = new Size(817, 356);
            uC_SearchPeoble1.TabIndex = 15;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(uC_SearchPeoble1);
            tabPage1.Controls.Add(btnNextPage);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(824, 424);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Personal Info";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(cmbLicenseClass);
            tabPage2.Controls.Add(lblCreatedBy);
            tabPage2.Controls.Add(pictureBox5);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(lblApplicationFees);
            tabPage2.Controls.Add(lblApplicationDate);
            tabPage2.Controls.Add(lblApplicationID);
            tabPage2.Controls.Add(pictureBox4);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(pictureBox1);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(pictureBox3);
            tabPage2.Controls.Add(pictureBox2);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label3);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(824, 424);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Application info";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // cmbLicenseClass
            // 
            cmbLicenseClass.FormattingEnabled = true;
            cmbLicenseClass.Location = new Point(231, 150);
            cmbLicenseClass.Name = "cmbLicenseClass";
            cmbLicenseClass.Size = new Size(293, 23);
            cmbLicenseClass.TabIndex = 29;
            // 
            // lblCreatedBy
            // 
            lblCreatedBy.AutoSize = true;
            lblCreatedBy.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreatedBy.ForeColor = Color.Black;
            lblCreatedBy.Location = new Point(231, 250);
            lblCreatedBy.Name = "lblCreatedBy";
            lblCreatedBy.Size = new Size(31, 21);
            lblCreatedBy.TabIndex = 28;
            lblCreatedBy.Text = "???";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.magic_wand;
            pictureBox5.Location = new Point(185, 250);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(21, 21);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 27;
            pictureBox5.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(26, 250);
            label8.Name = "label8";
            label8.Size = new Size(100, 21);
            label8.TabIndex = 26;
            label8.Text = "Created by :";
            // 
            // lblApplicationFees
            // 
            lblApplicationFees.AutoSize = true;
            lblApplicationFees.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApplicationFees.ForeColor = Color.Black;
            lblApplicationFees.Location = new Point(231, 201);
            lblApplicationFees.Name = "lblApplicationFees";
            lblApplicationFees.Size = new Size(31, 21);
            lblApplicationFees.TabIndex = 25;
            lblApplicationFees.Text = "???";
            // 
            // lblApplicationDate
            // 
            lblApplicationDate.AutoSize = true;
            lblApplicationDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApplicationDate.ForeColor = Color.Black;
            lblApplicationDate.Location = new Point(231, 103);
            lblApplicationDate.Name = "lblApplicationDate";
            lblApplicationDate.Size = new Size(31, 21);
            lblApplicationDate.TabIndex = 24;
            lblApplicationDate.Text = "???";
            // 
            // tabLocalLicense
            // 
            tabLocalLicense.Controls.Add(tabPage1);
            tabLocalLicense.Controls.Add(tabPage2);
            tabLocalLicense.Location = new Point(-2, 63);
            tabLocalLicense.Name = "tabLocalLicense";
            tabLocalLicense.SelectedIndex = 0;
            tabLocalLicense.Size = new Size(832, 452);
            tabLocalLicense.TabIndex = 14;
            // 
            // AddOrUpdateLocalDrivingLicenseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 565);
            Controls.Add(btnSave);
            Controls.Add(btnCloase);
            Controls.Add(lblAddOrUpdateSystemUser);
            Controls.Add(tabLocalLicense);
            Name = "AddOrUpdateLocalDrivingLicenseForm";
            Text = "AddOrUpdateLocalDrivingLicenseForm";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            tabLocalLicense.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ErrorProvider errorProvider1;
        private Button btnSave;
        private Button btnCloase;
        private Label lblAddOrUpdateSystemUser;
        private TabControl tabLocalLicense;
        private TabPage tabPage1;
        private UC_SearchPeoble uC_SearchPeoble1;
        private Button btnNextPage;
        private TabPage tabPage2;
        private Label lblApplicationID;
        private PictureBox pictureBox4;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label5;
        private Label label3;
        private Label lblApplicationFees;
        private Label lblApplicationDate;
        private Label lblCreatedBy;
        private PictureBox pictureBox5;
        private Label label8;
        private ComboBox cmbLicenseClass;
    }
}