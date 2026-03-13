namespace DVLD_Persntation
{
    partial class IssueDrivingLicenseForTheFirstTimeForm
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
            uC_LicenseAndRequestBasicInfo1 = new UC_LicenseAndRequestBasicInfo();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            txNote = new TextBox();
            btnIssue = new Button();
            btnCloase = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // uC_LicenseAndRequestBasicInfo1
            // 
            uC_LicenseAndRequestBasicInfo1.Location = new Point(0, 12);
            uC_LicenseAndRequestBasicInfo1.Name = "uC_LicenseAndRequestBasicInfo1";
            uC_LicenseAndRequestBasicInfo1.Size = new Size(648, 281);
            uC_LicenseAndRequestBasicInfo1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 299);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 1;
            label1.Text = "Note:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Notes;
            pictureBox1.Location = new Point(66, 299);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(18, 20);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // txNote
            // 
            txNote.Location = new Point(99, 299);
            txNote.Multiline = true;
            txNote.Name = "txNote";
            txNote.Size = new Size(524, 79);
            txNote.TabIndex = 3;
            // 
            // btnIssue
            // 
            btnIssue.FlatStyle = FlatStyle.Popup;
            btnIssue.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIssue.ImageAlign = ContentAlignment.MiddleRight;
            btnIssue.Location = new Point(536, 392);
            btnIssue.Name = "btnIssue";
            btnIssue.Size = new Size(87, 37);
            btnIssue.TabIndex = 15;
            btnIssue.Text = "Issue";
            btnIssue.UseVisualStyleBackColor = true;
            btnIssue.Click += btnIssue_Click;
            // 
            // btnCloase
            // 
            btnCloase.FlatStyle = FlatStyle.Popup;
            btnCloase.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCloase.ImageAlign = ContentAlignment.MiddleRight;
            btnCloase.Location = new Point(429, 392);
            btnCloase.Name = "btnCloase";
            btnCloase.Size = new Size(90, 37);
            btnCloase.TabIndex = 14;
            btnCloase.Text = "Close";
            btnCloase.UseVisualStyleBackColor = true;
            btnCloase.Click += btnCloase_Click;
            // 
            // IssueDrivingLicenseForTheFirstTimeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(647, 441);
            Controls.Add(btnIssue);
            Controls.Add(btnCloase);
            Controls.Add(txNote);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(uC_LicenseAndRequestBasicInfo1);
            MaximizeBox = false;
            Name = "IssueDrivingLicenseForTheFirstTimeForm";
            Text = "IssueDrivingLicenseForTheFirstTimeForm";
            Load += IssueDrivingLicenseForTheFirstTimeForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private UC_LicenseAndRequestBasicInfo uC_LicenseAndRequestBasicInfo1;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox txNote;
        private Button btnIssue;
        private Button btnCloase;
    }
}