namespace DVLD_Persntation
{
    partial class UserControl1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            tpSSN = new TextBox();
            lkRemoveImage = new LinkLabel();
            lkSetImage = new LinkLabel();
            btnClose = new Button();
            btnSave = new Button();
            tbAddress = new TextBox();
            pictureBox9 = new PictureBox();
            label12 = new Label();
            tbNationality = new ComboBox();
            pictureBox8 = new PictureBox();
            label11 = new Label();
            tbEmail = new TextBox();
            pictureBox7 = new PictureBox();
            label10 = new Label();
            tbPhone = new TextBox();
            pictureBox6 = new PictureBox();
            label9 = new Label();
            rbFemale = new RadioButton();
            rbMale = new RadioButton();
            pictureBox5 = new PictureBox();
            label8 = new Label();
            dtpDateOfBirth = new DateTimePicker();
            pictureBox4 = new PictureBox();
            label7 = new Label();
            pictureBox3 = new PictureBox();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tbSecondName = new TextBox();
            tbThirdName = new TextBox();
            tbLastName = new TextBox();
            tbFirstName = new TextBox();
            PbImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PbImage).BeginInit();
            SuspendLayout();
            // 
            // tpSSN
            // 
            tpSSN.Location = new Point(182, 84);
            tpSSN.Name = "tpSSN";
            tpSSN.Size = new Size(163, 23);
            tpSSN.TabIndex = 110;
            // 
            // lkRemoveImage
            // 
            lkRemoveImage.AutoSize = true;
            lkRemoveImage.Location = new Point(751, 288);
            lkRemoveImage.Name = "lkRemoveImage";
            lkRemoveImage.Size = new Size(86, 15);
            lkRemoveImage.TabIndex = 109;
            lkRemoveImage.TabStop = true;
            lkRemoveImage.Text = "Remove image";
            lkRemoveImage.LinkClicked += lkRemoveImage_LinkClicked;
            // 
            // lkSetImage
            // 
            lkSetImage.AutoSize = true;
            lkSetImage.Location = new Point(751, 260);
            lkSetImage.Name = "lkSetImage";
            lkSetImage.Size = new Size(59, 15);
            lkSetImage.TabIndex = 108;
            lkSetImage.TabStop = true;
            lkSetImage.Text = "Set image";
            lkSetImage.LinkClicked += lkSetImage_LinkClicked;
            // 
            // btnClose
            // 
            btnClose.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(499, 310);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 40);
            btnClose.TabIndex = 107;
            btnClose.Text = "Close";
            btnClose.TextImageRelation = TextImageRelation.ImageAboveText;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(608, 310);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 40);
            btnSave.TabIndex = 106;
            btnSave.Text = "Save";
            btnSave.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // tbAddress
            // 
            tbAddress.AccessibleName = "";
            tbAddress.Cursor = Cursors.IBeam;
            tbAddress.Location = new Point(182, 220);
            tbAddress.Margin = new Padding(4);
            tbAddress.Multiline = true;
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(520, 83);
            tbAddress.TabIndex = 105;
            tbAddress.UseWaitCursor = true;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(138, 218);
            pictureBox9.Margin = new Padding(4);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(36, 26);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 104;
            pictureBox9.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label12.Location = new Point(15, 222);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(85, 20);
            label12.TabIndex = 103;
            label12.Text = "Address :";
            // 
            // tbNationality
            // 
            tbNationality.AccessibleName = "";
            tbNationality.Cursor = Cursors.IBeam;
            tbNationality.FormattingEnabled = true;
            tbNationality.Location = new Point(534, 176);
            tbNationality.Margin = new Padding(4);
            tbNationality.Name = "tbNationality";
            tbNationality.Size = new Size(163, 23);
            tbNationality.TabIndex = 87;
            tbNationality.UseWaitCursor = true;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(490, 173);
            pictureBox8.Margin = new Padding(4);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(36, 26);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 102;
            pictureBox8.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label11.Location = new Point(396, 179);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(81, 20);
            label11.TabIndex = 101;
            label11.Text = "Country :";
            // 
            // tbEmail
            // 
            tbEmail.AccessibleName = "";
            tbEmail.Cursor = Cursors.IBeam;
            tbEmail.Location = new Point(182, 173);
            tbEmail.Margin = new Padding(4);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(163, 23);
            tbEmail.TabIndex = 100;
            tbEmail.UseWaitCursor = true;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(138, 173);
            pictureBox7.Margin = new Padding(4);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(36, 26);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 99;
            pictureBox7.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label10.Location = new Point(15, 177);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(63, 20);
            label10.TabIndex = 98;
            label10.Text = "Email :";
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(536, 128);
            tbPhone.Margin = new Padding(4);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(164, 23);
            tbPhone.TabIndex = 97;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(490, 128);
            pictureBox6.Margin = new Padding(4);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(36, 26);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 96;
            pictureBox6.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label9.Location = new Point(407, 134);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(70, 20);
            label9.TabIndex = 95;
            label9.Text = "Phone :";
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Location = new Point(264, 132);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(63, 19);
            rbFemale.TabIndex = 94;
            rbFemale.TabStop = true;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Location = new Point(182, 131);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(51, 19);
            rbMale.TabIndex = 93;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(138, 128);
            pictureBox5.Margin = new Padding(4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(36, 26);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 92;
            pictureBox5.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label8.Location = new Point(15, 132);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(79, 20);
            label8.TabIndex = 91;
            label8.Text = "Gendor :";
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.ImeMode = ImeMode.NoControl;
            dtpDateOfBirth.Location = new Point(536, 85);
            dtpDateOfBirth.MaxDate = new DateTime(2026, 2, 2, 0, 0, 0, 0);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(164, 23);
            dtpDateOfBirth.TabIndex = 90;
            dtpDateOfBirth.Value = new DateTime(2026, 2, 2, 0, 0, 0, 0);
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(490, 81);
            pictureBox4.Margin = new Padding(4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(36, 26);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 89;
            pictureBox4.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label7.Location = new Point(355, 87);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(122, 20);
            label7.TabIndex = 88;
            label7.Text = "Birth of Date :";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(138, 81);
            pictureBox3.Margin = new Padding(4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(36, 26);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 86;
            pictureBox3.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label6.Location = new Point(15, 85);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(112, 20);
            label6.TabIndex = 85;
            label6.Text = "National No :";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(138, 33);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 84;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(15, 35);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 83;
            label5.Text = "Name : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Fuchsia;
            label4.Location = new Point(705, 11);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 82;
            label4.Text = "Last";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Fuchsia;
            label3.Location = new Point(523, 11);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 81;
            label3.Text = "Third";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Fuchsia;
            label2.Location = new Point(197, 11);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 80;
            label2.Text = "First";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Fuchsia;
            label1.Location = new Point(355, 11);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 79;
            label1.Text = "Secound";
            // 
            // tbSecondName
            // 
            tbSecondName.Location = new Point(355, 33);
            tbSecondName.Margin = new Padding(4);
            tbSecondName.Name = "tbSecondName";
            tbSecondName.Size = new Size(171, 23);
            tbSecondName.TabIndex = 78;
            // 
            // tbThirdName
            // 
            tbThirdName.Location = new Point(536, 33);
            tbThirdName.Margin = new Padding(4);
            tbThirdName.Name = "tbThirdName";
            tbThirdName.Size = new Size(164, 23);
            tbThirdName.TabIndex = 77;
            // 
            // tbLastName
            // 
            tbLastName.Location = new Point(710, 33);
            tbLastName.Margin = new Padding(4);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(180, 23);
            tbLastName.TabIndex = 76;
            // 
            // tbFirstName
            // 
            tbFirstName.AccessibleName = "";
            tbFirstName.Cursor = Cursors.IBeam;
            tbFirstName.Location = new Point(182, 33);
            tbFirstName.Margin = new Padding(4);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(163, 23);
            tbFirstName.TabIndex = 75;
            tbFirstName.UseWaitCursor = true;
            // 
            // PbImage
            // 
            PbImage.Image = Properties.Resources.default_profile_picture;
            PbImage.Location = new Point(710, 68);
            PbImage.Margin = new Padding(4);
            PbImage.Name = "PbImage";
            PbImage.Size = new Size(181, 161);
            PbImage.SizeMode = PictureBoxSizeMode.Zoom;
            PbImage.TabIndex = 74;
            PbImage.TabStop = false;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tpSSN);
            Controls.Add(lkRemoveImage);
            Controls.Add(lkSetImage);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(tbAddress);
            Controls.Add(pictureBox9);
            Controls.Add(label12);
            Controls.Add(tbNationality);
            Controls.Add(pictureBox8);
            Controls.Add(label11);
            Controls.Add(tbEmail);
            Controls.Add(pictureBox7);
            Controls.Add(label10);
            Controls.Add(tbPhone);
            Controls.Add(pictureBox6);
            Controls.Add(label9);
            Controls.Add(rbFemale);
            Controls.Add(rbMale);
            Controls.Add(pictureBox5);
            Controls.Add(label8);
            Controls.Add(dtpDateOfBirth);
            Controls.Add(pictureBox4);
            Controls.Add(label7);
            Controls.Add(pictureBox3);
            Controls.Add(label6);
            Controls.Add(pictureBox2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbSecondName);
            Controls.Add(tbThirdName);
            Controls.Add(tbLastName);
            Controls.Add(tbFirstName);
            Controls.Add(PbImage);
            Name = "UserControl1";
            Size = new Size(916, 370);
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)PbImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tpSSN;
        private LinkLabel lkRemoveImage;
        private LinkLabel lkSetImage;
        private Button btnClose;
        private Button btnSave;
        private TextBox tbAddress;
        private PictureBox pictureBox9;
        private Label label12;
        private ComboBox tbNationality;
        private PictureBox pictureBox8;
        private Label label11;
        private TextBox tbEmail;
        private PictureBox pictureBox7;
        private Label label10;
        private TextBox tbPhone;
        private PictureBox pictureBox6;
        private Label label9;
        private RadioButton rbFemale;
        private RadioButton rbMale;
        private PictureBox pictureBox5;
        private Label label8;
        private DateTimePicker dtpDateOfBirth;
        private PictureBox pictureBox4;
        private Label label7;
        private PictureBox pictureBox3;
        private Label label6;
        private PictureBox pictureBox2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tbSecondName;
        private TextBox tbThirdName;
        private TextBox tbLastName;
        private TextBox tbFirstName;
        private PictureBox PbImage;
    }
}
