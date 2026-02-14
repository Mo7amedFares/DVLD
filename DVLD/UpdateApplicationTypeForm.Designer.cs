namespace DVLD_Persntation
{
    partial class UpdateApplicationTypeForm
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
            tbAppName = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tbAppFees = new TextBox();
            pictureBox3 = new PictureBox();
            label5 = new Label();
            label2 = new Label();
            lblAppID = new Label();
            pictureBox2 = new PictureBox();
            btnSave = new Button();
            btnCloase = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblAddOrUpdateSystemUser
            // 
            lblAddOrUpdateSystemUser.AutoSize = true;
            lblAddOrUpdateSystemUser.Font = new Font("Stencil", 20F, FontStyle.Bold);
            lblAddOrUpdateSystemUser.ForeColor = Color.DarkRed;
            lblAddOrUpdateSystemUser.Location = new Point(37, 9);
            lblAddOrUpdateSystemUser.Name = "lblAddOrUpdateSystemUser";
            lblAddOrUpdateSystemUser.Size = new Size(389, 32);
            lblAddOrUpdateSystemUser.TabIndex = 6;
            lblAddOrUpdateSystemUser.Text = "Update Application Type";
            // 
            // tbAppName
            // 
            tbAppName.Location = new Point(155, 110);
            tbAppName.Name = "tbAppName";
            tbAppName.Size = new Size(288, 23);
            tbAppName.TabIndex = 37;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Name;
            pictureBox1.Location = new Point(111, 112);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(21, 21);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(41, 112);
            label1.Name = "label1";
            label1.Size = new Size(64, 21);
            label1.TabIndex = 35;
            label1.Text = "Name :";
            // 
            // tbAppFees
            // 
            tbAppFees.Location = new Point(155, 149);
            tbAppFees.Name = "tbAppFees";
            tbAppFees.Size = new Size(288, 23);
            tbAppFees.TabIndex = 34;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.handFees;
            pictureBox3.Location = new Point(111, 149);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(21, 21);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 33;
            pictureBox3.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(41, 147);
            label5.Name = "label5";
            label5.Size = new Size(51, 21);
            label5.TabIndex = 32;
            label5.Text = "Fees :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(41, 75);
            label2.Name = "label2";
            label2.Size = new Size(35, 21);
            label2.TabIndex = 38;
            label2.Text = "ID :";
            // 
            // lblAppID
            // 
            lblAppID.AutoSize = true;
            lblAppID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAppID.ForeColor = Color.Black;
            lblAppID.Location = new Point(155, 75);
            lblAppID.Name = "lblAppID";
            lblAppID.Size = new Size(31, 21);
            lblAppID.TabIndex = 39;
            lblAppID.Text = "???";
            // 
            // pictureBox2
            // 
            pictureBox2.ErrorImage = Properties.Resources.id_badge;
            pictureBox2.Image = Properties.Resources.id_badge;
            pictureBox2.InitialImage = Properties.Resources.id_badge;
            pictureBox2.Location = new Point(111, 75);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(21, 21);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 40;
            pictureBox2.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ImageAlign = ContentAlignment.MiddleRight;
            btnSave.Location = new Point(246, 217);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(87, 37);
            btnSave.TabIndex = 42;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCloase
            // 
            btnCloase.FlatStyle = FlatStyle.Popup;
            btnCloase.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCloase.ImageAlign = ContentAlignment.MiddleRight;
            btnCloase.Location = new Point(139, 217);
            btnCloase.Name = "btnCloase";
            btnCloase.Size = new Size(90, 37);
            btnCloase.TabIndex = 41;
            btnCloase.Text = "Close";
            btnCloase.UseVisualStyleBackColor = true;
            btnCloase.Click += btnCloase_Click;
            // 
            // UpdateApplicationTypeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 266);
            Controls.Add(btnSave);
            Controls.Add(btnCloase);
            Controls.Add(pictureBox2);
            Controls.Add(lblAppID);
            Controls.Add(label2);
            Controls.Add(tbAppName);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(tbAppFees);
            Controls.Add(pictureBox3);
            Controls.Add(label5);
            Controls.Add(lblAddOrUpdateSystemUser);
            Name = "UpdateApplicationTypeForm";
            Text = "UpdateApplicationTypeForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAddOrUpdateSystemUser;
        private TextBox tbAppName;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox tbAppFees;
        private PictureBox pictureBox3;
        private Label label5;
        private Label label2;
        private Label lblAppID;
        private PictureBox pictureBox2;
        private Button btnSave;
        private Button btnCloase;
    }
}