namespace DVLD_Persntation
{
    partial class InterntionalDrivaingLicenseInfoForm
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
            btnCloase = new Button();
            lblAddOrNewUser = new Label();
            uC_InterntionalDrivingLicenseInfo1 = new UC_InterntionalDrivingLicenseInfo();
            SuspendLayout();
            // 
            // btnCloase
            // 
            btnCloase.FlatStyle = FlatStyle.Popup;
            btnCloase.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCloase.ImageAlign = ContentAlignment.MiddleRight;
            btnCloase.Location = new Point(713, 392);
            btnCloase.Name = "btnCloase";
            btnCloase.Size = new Size(90, 37);
            btnCloase.TabIndex = 44;
            btnCloase.Text = "Close";
            btnCloase.UseVisualStyleBackColor = true;
            btnCloase.Click += btnCloase_Click;
            // 
            // lblAddOrNewUser
            // 
            lblAddOrNewUser.AutoSize = true;
            lblAddOrNewUser.Font = new Font("Stencil", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddOrNewUser.ForeColor = Color.DarkRed;
            lblAddOrNewUser.Location = new Point(101, 25);
            lblAddOrNewUser.Name = "lblAddOrNewUser";
            lblAddOrNewUser.Size = new Size(612, 38);
            lblAddOrNewUser.TabIndex = 43;
            lblAddOrNewUser.Text = "Interntional Driver License Info";
            // 
            // uC_InterntionalDrivingLicenseInfo1
            // 
            uC_InterntionalDrivingLicenseInfo1.Location = new Point(3, 89);
            uC_InterntionalDrivingLicenseInfo1.Name = "uC_InterntionalDrivingLicenseInfo1";
            uC_InterntionalDrivingLicenseInfo1.Size = new Size(820, 259);
            uC_InterntionalDrivingLicenseInfo1.TabIndex = 45;
            // 
            // InterntionalDrivaingLicenseInfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 448);
            Controls.Add(uC_InterntionalDrivingLicenseInfo1);
            Controls.Add(btnCloase);
            Controls.Add(lblAddOrNewUser);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "InterntionalDrivaingLicenseInfoForm";
            Text = "InterntionalDrivaingLicenseInfoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCloase;
        private Label lblAddOrNewUser;
        private UC_InterntionalDrivingLicenseInfo uC_InterntionalDrivingLicenseInfo1;
    }
}