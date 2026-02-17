namespace DVLD_Persntation
{
    partial class PersonInfoForm
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
            uC_PersonInfomation1 = new UC_PersonInfomation();
            SuspendLayout();
            // 
            // lblAddOrNewUser
            // 
            lblAddOrNewUser.AutoSize = true;
            lblAddOrNewUser.Font = new Font("Stencil", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddOrNewUser.ForeColor = Color.DarkRed;
            lblAddOrNewUser.Location = new Point(257, 9);
            lblAddOrNewUser.Name = "lblAddOrNewUser";
            lblAddOrNewUser.Size = new Size(286, 38);
            lblAddOrNewUser.TabIndex = 2;
            lblAddOrNewUser.Text = "Person Details";
            // 
            // uC_PersonInfomation1
            // 
            uC_PersonInfomation1.AccessibleName = "";
            uC_PersonInfomation1.BorderStyle = BorderStyle.FixedSingle;
            uC_PersonInfomation1.Location = new Point(2, 67);
            uC_PersonInfomation1.Name = "uC_PersonInfomation1";
            uC_PersonInfomation1.Size = new Size(813, 265);
            uC_PersonInfomation1.TabIndex = 3;
            // 
            // PersonInfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 335);
            Controls.Add(uC_PersonInfomation1);
            Controls.Add(lblAddOrNewUser);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PersonInfoForm";
            Text = "PersonInfoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAddOrNewUser;
        private UC_PersonInfomation uC_PersonInfomation1;
    }
}