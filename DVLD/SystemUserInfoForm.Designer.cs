namespace DVLD_Persntation
{
    partial class SystemUserInfoForm
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
            uS_SystemUserInfo1 = new US_SystemUserInfo();
            lblAddOrNewUser = new Label();
            SuspendLayout();
            // 
            // uS_SystemUserInfo1
            // 
            uS_SystemUserInfo1.Location = new Point(2, 67);
            uS_SystemUserInfo1.Name = "uS_SystemUserInfo1";
            uS_SystemUserInfo1.Size = new Size(818, 364);
            uS_SystemUserInfo1.TabIndex = 0;
            // 
            // lblAddOrNewUser
            // 
            lblAddOrNewUser.AutoSize = true;
            lblAddOrNewUser.Font = new Font("Stencil", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddOrNewUser.ForeColor = Color.DarkRed;
            lblAddOrNewUser.Location = new Point(226, 9);
            lblAddOrNewUser.Name = "lblAddOrNewUser";
            lblAddOrNewUser.Size = new Size(378, 38);
            lblAddOrNewUser.TabIndex = 3;
            lblAddOrNewUser.Text = "System User Details";
            // 
            // SystemUserInfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 443);
            Controls.Add(lblAddOrNewUser);
            Controls.Add(uS_SystemUserInfo1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SystemUserInfoForm";
            Text = "SystemUserInfoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private US_SystemUserInfo uS_SystemUserInfo1;
        private Label lblAddOrNewUser;
    }
}