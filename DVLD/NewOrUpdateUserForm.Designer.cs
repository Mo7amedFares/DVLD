namespace DVLD_Persntation
{
    partial class NewOrUpdateUserForm : Form
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
            label5 = new Label();
            lblPersonId = new Label();
            userControl11 = new UserControl1();
            SuspendLayout();
            // 
            // lblAddOrNewUser
            // 
            lblAddOrNewUser.AutoSize = true;
            lblAddOrNewUser.Font = new Font("Stencil", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddOrNewUser.ForeColor = Color.DarkRed;
            lblAddOrNewUser.Location = new Point(327, 9);
            lblAddOrNewUser.Name = "lblAddOrNewUser";
            lblAddOrNewUser.Size = new Size(295, 38);
            lblAddOrNewUser.TabIndex = 1;
            lblAddOrNewUser.Text = "Add New Person";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(10, 69);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(99, 20);
            label5.TabIndex = 47;
            label5.Text = "Person ID :";
            // 
            // lblPersonId
            // 
            lblPersonId.AutoSize = true;
            lblPersonId.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPersonId.Location = new Point(136, 69);
            lblPersonId.Margin = new Padding(4, 0, 4, 0);
            lblPersonId.Name = "lblPersonId";
            lblPersonId.Size = new Size(39, 20);
            lblPersonId.TabIndex = 49;
            lblPersonId.Text = "???";
            // 
            // userControl11
            // 
            userControl11.Location = new Point(1, 98);
            userControl11.Name = "userControl11";
            userControl11.Size = new Size(916, 374);
            userControl11.TabIndex = 50;
            userControl11.Load += userControl11_Load;
            // 
            // NewOrUpdateUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 471);
            Controls.Add(userControl11);
            Controls.Add(lblPersonId);
            Controls.Add(label5);
            Controls.Add(lblAddOrNewUser);
            Name = "NewOrUpdateUserForm";
            Text = "NewOrUpdateUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAddOrNewUser;
        private Label label5;
        private Label lblPersonId;
        private UserControl1 userControl11;
    }
}