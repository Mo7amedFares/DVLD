namespace DVLD_Persntation
{
    partial class ChangePasswordSystemUserForm
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
            uS_SystemUserInfo1 = new US_SystemUserInfo();
            lblAddOrUpdateSystemUser = new Label();
            pictureBox4 = new PictureBox();
            tbConfirmNewPassword = new TextBox();
            label4 = new Label();
            tbNewPassword = new TextBox();
            pictureBox3 = new PictureBox();
            label5 = new Label();
            tbCurentPassword = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnSave = new Button();
            btnCloase = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // uS_SystemUserInfo1
            // 
            uS_SystemUserInfo1.Location = new Point(-1, 61);
            uS_SystemUserInfo1.Name = "uS_SystemUserInfo1";
            uS_SystemUserInfo1.Size = new Size(818, 364);
            uS_SystemUserInfo1.TabIndex = 0;
            // 
            // lblAddOrUpdateSystemUser
            // 
            lblAddOrUpdateSystemUser.AutoSize = true;
            lblAddOrUpdateSystemUser.Font = new Font("Stencil", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddOrUpdateSystemUser.ForeColor = Color.DarkRed;
            lblAddOrUpdateSystemUser.Location = new Point(117, 9);
            lblAddOrUpdateSystemUser.Name = "lblAddOrUpdateSystemUser";
            lblAddOrUpdateSystemUser.Size = new Size(555, 38);
            lblAddOrUpdateSystemUser.TabIndex = 5;
            lblAddOrUpdateSystemUser.Text = "Change Password System User";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources._lock;
            pictureBox4.Location = new Point(229, 530);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(21, 21);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 28;
            pictureBox4.TabStop = false;
            // 
            // tbConfirmNewPassword
            // 
            tbConfirmNewPassword.Location = new Point(270, 530);
            tbConfirmNewPassword.Name = "tbConfirmNewPassword";
            tbConfirmNewPassword.Size = new Size(185, 23);
            tbConfirmNewPassword.TabIndex = 27;
            tbConfirmNewPassword.TextChanged += tbConfirmNewPassword_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(19, 528);
            label4.Name = "label4";
            label4.Size = new Size(195, 21);
            label4.TabIndex = 26;
            label4.Text = "Confirm New Password :";
            // 
            // tbNewPassword
            // 
            tbNewPassword.Location = new Point(270, 476);
            tbNewPassword.Name = "tbNewPassword";
            tbNewPassword.Size = new Size(185, 23);
            tbNewPassword.TabIndex = 25;
            tbNewPassword.TextChanged += tbNewPassword_TextChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._lock;
            pictureBox3.Location = new Point(229, 474);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(21, 21);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 24;
            pictureBox3.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(85, 474);
            label5.Name = "label5";
            label5.Size = new Size(129, 21);
            label5.TabIndex = 23;
            label5.Text = "New Password :";
            // 
            // tbCurentPassword
            // 
            tbCurentPassword.Location = new Point(270, 428);
            tbCurentPassword.Name = "tbCurentPassword";
            tbCurentPassword.Size = new Size(185, 23);
            tbCurentPassword.TabIndex = 31;
            tbCurentPassword.TextChanged += tbCurentPassword_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._lock;
            pictureBox1.Location = new Point(229, 426);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(21, 21);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(69, 425);
            label1.Name = "label1";
            label1.Size = new Size(145, 21);
            label1.TabIndex = 29;
            label1.Text = "Curent Password :";
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ImageAlign = ContentAlignment.MiddleRight;
            btnSave.Location = new Point(720, 560);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(87, 37);
            btnSave.TabIndex = 33;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCloase
            // 
            btnCloase.FlatStyle = FlatStyle.Popup;
            btnCloase.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCloase.ImageAlign = ContentAlignment.MiddleRight;
            btnCloase.Location = new Point(613, 560);
            btnCloase.Name = "btnCloase";
            btnCloase.Size = new Size(90, 37);
            btnCloase.TabIndex = 32;
            btnCloase.Text = "Close";
            btnCloase.UseVisualStyleBackColor = true;
            btnCloase.Click += btnCloase_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // ChangePasswordSystemUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 609);
            Controls.Add(btnSave);
            Controls.Add(btnCloase);
            Controls.Add(tbCurentPassword);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox4);
            Controls.Add(tbConfirmNewPassword);
            Controls.Add(label4);
            Controls.Add(tbNewPassword);
            Controls.Add(pictureBox3);
            Controls.Add(label5);
            Controls.Add(lblAddOrUpdateSystemUser);
            Controls.Add(uS_SystemUserInfo1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ChangePasswordSystemUserForm";
            Text = "ChangePasswordSystemUserForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private US_SystemUserInfo uS_SystemUserInfo1;
        private Label lblAddOrUpdateSystemUser;
        private PictureBox pictureBox4;
        private TextBox tbConfirmNewPassword;
        private Label label4;
        private TextBox tbNewPassword;
        private PictureBox pictureBox3;
        private Label label5;
        private TextBox tbCurentPassword;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btnSave;
        private Button btnCloase;
        private ErrorProvider errorProvider1;
    }
}