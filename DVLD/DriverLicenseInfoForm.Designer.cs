namespace DVLD_Persntation
{
    partial class DriverLicenseInfoForm
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
            lblAddOrNewUser = new Label();
            uC_DriverLicenseInfo1 = new UC_DriverLicenseInfo();
            btnCloase = new Button();
            SuspendLayout();
            // 
            // lblAddOrNewUser
            // 
            lblAddOrNewUser.AutoSize = true;
            lblAddOrNewUser.Font = new Font("Stencil", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddOrNewUser.ForeColor = Color.DarkRed;
            lblAddOrNewUser.Location = new Point(234, 9);
            lblAddOrNewUser.Name = "lblAddOrNewUser";
            lblAddOrNewUser.Size = new Size(366, 38);
            lblAddOrNewUser.TabIndex = 3;
            lblAddOrNewUser.Text = "Driver License Info";
            // 
            // uC_DriverLicenseInfo1
            // 
            uC_DriverLicenseInfo1.BorderStyle = BorderStyle.FixedSingle;
            uC_DriverLicenseInfo1.Location = new Point(2, 58);
            uC_DriverLicenseInfo1.Name = "uC_DriverLicenseInfo1";
            uC_DriverLicenseInfo1.Size = new Size(812, 311);
            uC_DriverLicenseInfo1.TabIndex = 4;
            // 
            // btnCloase
            // 
            btnCloase.FlatStyle = FlatStyle.Popup;
            btnCloase.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCloase.ImageAlign = ContentAlignment.MiddleRight;
            btnCloase.Location = new Point(715, 375);
            btnCloase.Name = "btnCloase";
            btnCloase.Size = new Size(90, 37);
            btnCloase.TabIndex = 42;
            btnCloase.Text = "Close";
            btnCloase.UseVisualStyleBackColor = true;
            btnCloase.Click += btnCloase_Click;
            // 
            // DriverLicenseInfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 422);
            Controls.Add(btnCloase);
            Controls.Add(uC_DriverLicenseInfo1);
            Controls.Add(lblAddOrNewUser);
            Name = "DriverLicenseInfoForm";
            Text = "DriverLicenseInfoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAddOrNewUser;
        private UC_DriverLicenseInfo uC_DriverLicenseInfo1;
        private Button btnCloase;
    }
}