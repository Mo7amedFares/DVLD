namespace DVLD_Persntation
{
    partial class US_SystemUserInfo
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
            uC_PersonInfomation1 = new UC_PersonInfomation();
            groupBox1 = new GroupBox();
            lblSystemUserID = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblUserName = new Label();
            lblIsActive = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // uC_PersonInfomation1
            // 
            uC_PersonInfomation1.AccessibleName = "";
            uC_PersonInfomation1.BorderStyle = BorderStyle.FixedSingle;
            uC_PersonInfomation1.Location = new Point(4, 3);
            uC_PersonInfomation1.Name = "uC_PersonInfomation1";
            uC_PersonInfomation1.Size = new Size(811, 263);
            uC_PersonInfomation1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblIsActive);
            groupBox1.Controls.Add(lblUserName);
            groupBox1.Controls.Add(lblSystemUserID);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.ImeMode = ImeMode.NoControl;
            groupBox1.Location = new Point(4, 272);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(811, 88);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "System User Info";
            // 
            // lblSystemUserID
            // 
            lblSystemUserID.AutoSize = true;
            lblSystemUserID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSystemUserID.Location = new Point(218, 36);
            lblSystemUserID.Name = "lblSystemUserID";
            lblSystemUserID.Size = new Size(24, 21);
            lblSystemUserID.TabIndex = 3;
            lblSystemUserID.Text = "??";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(568, 36);
            label3.Name = "label3";
            label3.Size = new Size(78, 21);
            label3.TabIndex = 2;
            label3.Text = "IsActive :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(325, 36);
            label2.Name = "label2";
            label2.Size = new Size(98, 21);
            label2.TabIndex = 1;
            label2.Text = "UserName :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(80, 36);
            label1.Name = "label1";
            label1.Size = new Size(132, 21);
            label1.TabIndex = 0;
            label1.Text = "System User ID :";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserName.Location = new Point(429, 36);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(24, 21);
            lblUserName.TabIndex = 4;
            lblUserName.Text = "??";
            // 
            // lblIsActive
            // 
            lblIsActive.AutoSize = true;
            lblIsActive.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIsActive.Location = new Point(652, 36);
            lblIsActive.Name = "lblIsActive";
            lblIsActive.Size = new Size(24, 21);
            lblIsActive.TabIndex = 5;
            lblIsActive.Text = "??";
            // 
            // US_SystemUserInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Controls.Add(uC_PersonInfomation1);
            Name = "US_SystemUserInfo";
            Size = new Size(818, 364);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private UC_PersonInfomation uC_PersonInfomation1;
        private GroupBox groupBox1;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label lblSystemUserID;
        private Label lblIsActive;
        private Label lblUserName;
    }
}
