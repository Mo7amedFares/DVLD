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
            lblAddOrUpdateSystemUser = new Label();
            pictureBox1 = new PictureBox();
            uC_LicenseAndRequestBasicInfo1 = new UC_LicenseAndRequestBasicInfo();
            btnCloase = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            uC_LicenseAndRequestBasicInfo1.Size = new Size(647, 494);
            uC_LicenseAndRequestBasicInfo1.TabIndex = 18;
            uC_LicenseAndRequestBasicInfo1.Load += uC_LicenseAndRequestBasicInfo1_Load;
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
            // TestAppointmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(647, 670);
            Controls.Add(btnCloase);
            Controls.Add(uC_LicenseAndRequestBasicInfo1);
            Controls.Add(pictureBox1);
            Controls.Add(lblAddOrUpdateSystemUser);
            Name = "TestAppointmentForm";
            Text = "VistionTestAppointmentForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAddOrUpdateSystemUser;
        private PictureBox pictureBox1;
        private UC_LicenseAndRequestBasicInfo uC_LicenseAndRequestBasicInfo1;
        private Button btnCloase;
    }
}