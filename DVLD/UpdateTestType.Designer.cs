namespace DVLD_Persntation
{
    partial class UpdateTestType
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
            btnSave = new Button();
            btnCloase = new Button();
            pictureBox2 = new PictureBox();
            lblTestTypeID = new Label();
            label2 = new Label();
            tbTestTypeName = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tbTestTypeFees = new TextBox();
            pictureBox3 = new PictureBox();
            label5 = new Label();
            lblAddOrUpdateSystemUser = new Label();
            tbTestTypeDescreption = new TextBox();
            pictureBox4 = new PictureBox();
            label3 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ImageAlign = ContentAlignment.MiddleRight;
            btnSave.Location = new Point(220, 271);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(87, 37);
            btnSave.TabIndex = 54;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCloase
            // 
            btnCloase.FlatStyle = FlatStyle.Popup;
            btnCloase.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCloase.ImageAlign = ContentAlignment.MiddleRight;
            btnCloase.Location = new Point(113, 271);
            btnCloase.Name = "btnCloase";
            btnCloase.Size = new Size(90, 37);
            btnCloase.TabIndex = 53;
            btnCloase.Text = "Close";
            btnCloase.UseVisualStyleBackColor = true;
            btnCloase.Click += btnCloase_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.ErrorImage = Properties.Resources.id_badge;
            pictureBox2.Image = Properties.Resources.id_badge;
            pictureBox2.InitialImage = Properties.Resources.id_badge;
            pictureBox2.Location = new Point(131, 71);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(21, 21);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 52;
            pictureBox2.TabStop = false;
            // 
            // lblTestTypeID
            // 
            lblTestTypeID.AutoSize = true;
            lblTestTypeID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTestTypeID.ForeColor = Color.Black;
            lblTestTypeID.Location = new Point(175, 73);
            lblTestTypeID.Name = "lblTestTypeID";
            lblTestTypeID.Size = new Size(31, 21);
            lblTestTypeID.TabIndex = 51;
            lblTestTypeID.Text = "???";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(20, 71);
            label2.Name = "label2";
            label2.Size = new Size(35, 21);
            label2.TabIndex = 50;
            label2.Text = "ID :";
            // 
            // tbTestTypeName
            // 
            tbTestTypeName.Location = new Point(175, 108);
            tbTestTypeName.Name = "tbTestTypeName";
            tbTestTypeName.Size = new Size(288, 23);
            tbTestTypeName.TabIndex = 49;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Name;
            pictureBox1.Location = new Point(131, 108);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(21, 21);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 48;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(20, 108);
            label1.Name = "label1";
            label1.Size = new Size(64, 21);
            label1.TabIndex = 47;
            label1.Text = "Name :";
            // 
            // tbTestTypeFees
            // 
            tbTestTypeFees.Location = new Point(175, 147);
            tbTestTypeFees.Name = "tbTestTypeFees";
            tbTestTypeFees.Size = new Size(288, 23);
            tbTestTypeFees.TabIndex = 46;
            tbTestTypeFees.TextChanged += tbTestTypeFees_TextChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.handFees;
            pictureBox3.Location = new Point(131, 145);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(21, 21);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 45;
            pictureBox3.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(20, 143);
            label5.Name = "label5";
            label5.Size = new Size(51, 21);
            label5.TabIndex = 44;
            label5.Text = "Fees :";
            // 
            // lblAddOrUpdateSystemUser
            // 
            lblAddOrUpdateSystemUser.AutoSize = true;
            lblAddOrUpdateSystemUser.Font = new Font("Stencil", 20F, FontStyle.Bold);
            lblAddOrUpdateSystemUser.ForeColor = Color.DarkRed;
            lblAddOrUpdateSystemUser.Location = new Point(100, 9);
            lblAddOrUpdateSystemUser.Name = "lblAddOrUpdateSystemUser";
            lblAddOrUpdateSystemUser.Size = new Size(274, 32);
            lblAddOrUpdateSystemUser.TabIndex = 43;
            lblAddOrUpdateSystemUser.Text = "Update Test Type";
            // 
            // tbTestTypeDescreption
            // 
            tbTestTypeDescreption.Location = new Point(175, 186);
            tbTestTypeDescreption.Multiline = true;
            tbTestTypeDescreption.Name = "tbTestTypeDescreption";
            tbTestTypeDescreption.Size = new Size(288, 55);
            tbTestTypeDescreption.TabIndex = 57;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.handFees;
            pictureBox4.Location = new Point(131, 186);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(21, 21);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 56;
            pictureBox4.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(20, 184);
            label3.Name = "label3";
            label3.Size = new Size(110, 21);
            label3.TabIndex = 55;
            label3.Text = "Descreption :";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // UpdateTestType
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 320);
            Controls.Add(tbTestTypeDescreption);
            Controls.Add(pictureBox4);
            Controls.Add(label3);
            Controls.Add(btnSave);
            Controls.Add(btnCloase);
            Controls.Add(pictureBox2);
            Controls.Add(lblTestTypeID);
            Controls.Add(label2);
            Controls.Add(tbTestTypeName);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(tbTestTypeFees);
            Controls.Add(pictureBox3);
            Controls.Add(label5);
            Controls.Add(lblAddOrUpdateSystemUser);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UpdateTestType";
            Text = "UpdateTestType";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Button btnCloase;
        private PictureBox pictureBox2;
        private Label lblTestTypeID;
        private Label label2;
        private TextBox tbTestTypeName;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox tbTestTypeFees;
        private PictureBox pictureBox3;
        private Label label5;
        private Label lblAddOrUpdateSystemUser;
        private TextBox tbTestTypeDescreption;
        private PictureBox pictureBox4;
        private Label label3;
        private ErrorProvider errorProvider1;
    }
}