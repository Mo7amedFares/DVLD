namespace DVLD_Persntation
{
    partial class AddOrUpdateSystemUserForm
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnNextPage = new Button();
            groupBox1 = new GroupBox();
            button1 = new Button();
            BtnAddNewUser = new Button();
            tbTextFiltter = new TextBox();
            label1 = new Label();
            CPoxFilterBy = new ComboBox();
            uC_PersonInfomation1 = new UC_PersonInfomation();
            tabPage2 = new TabPage();
            cbIsActive = new CheckBox();
            lblSystemUserId = new Label();
            pictureBox4 = new PictureBox();
            tbConfirmPassword = new TextBox();
            label4 = new Label();
            tbUserName = new TextBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            tbPassword = new TextBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            label3 = new Label();
            lblAddOrUpdateSystemUser = new Label();
            btnCloase = new Button();
            btnSave = new Button();
            errorProvider1 = new ErrorProvider(components);
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(1, 50);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(825, 452);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnNextPage);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(uC_PersonInfomation1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(817, 424);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Personal Info";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnNextPage
            // 
            btnNextPage.FlatStyle = FlatStyle.Popup;
            btnNextPage.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNextPage.ImageAlign = ContentAlignment.MiddleRight;
            btnNextPage.Location = new Point(705, 372);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(87, 37);
            btnNextPage.TabIndex = 14;
            btnNextPage.Text = "Next";
            btnNextPage.UseVisualStyleBackColor = true;
            btnNextPage.Click += btnNextPage_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(BtnAddNewUser);
            groupBox1.Controls.Add(tbTextFiltter);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(CPoxFilterBy);
            groupBox1.Location = new Point(7, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(804, 81);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Seach Person";
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.search_profile;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(519, 27);
            button1.Name = "button1";
            button1.Size = new Size(35, 36);
            button1.TabIndex = 15;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // BtnAddNewUser
            // 
            BtnAddNewUser.BackgroundImage = Properties.Resources.add_user;
            BtnAddNewUser.BackgroundImageLayout = ImageLayout.Zoom;
            BtnAddNewUser.FlatStyle = FlatStyle.Popup;
            BtnAddNewUser.Location = new Point(573, 27);
            BtnAddNewUser.Name = "BtnAddNewUser";
            BtnAddNewUser.Size = new Size(41, 36);
            BtnAddNewUser.TabIndex = 14;
            BtnAddNewUser.UseVisualStyleBackColor = true;
            BtnAddNewUser.Click += BtnAddNewUser_Click;
            // 
            // tbTextFiltter
            // 
            tbTextFiltter.Location = new Point(299, 35);
            tbTextFiltter.Name = "tbTextFiltter";
            tbTextFiltter.Size = new Size(190, 23);
            tbTextFiltter.TabIndex = 13;
            tbTextFiltter.TextChanged += tbTextFiltter_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 34);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 12;
            label1.Text = "Filter by";
            // 
            // CPoxFilterBy
            // 
            CPoxFilterBy.FormattingEnabled = true;
            CPoxFilterBy.Items.AddRange(new object[] { "User_ID", "SSN", "Email", "Phone" });
            CPoxFilterBy.Location = new Point(91, 35);
            CPoxFilterBy.Name = "CPoxFilterBy";
            CPoxFilterBy.Size = new Size(178, 23);
            CPoxFilterBy.TabIndex = 11;
            CPoxFilterBy.SelectedIndexChanged += CPoxFilterBy_SelectedIndexChanged;
            // 
            // uC_PersonInfomation1
            // 
            uC_PersonInfomation1.AccessibleName = "";
            uC_PersonInfomation1.BorderStyle = BorderStyle.FixedSingle;
            uC_PersonInfomation1.Location = new Point(3, 93);
            uC_PersonInfomation1.Name = "uC_PersonInfomation1";
            uC_PersonInfomation1.Size = new Size(811, 263);
            uC_PersonInfomation1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(cbIsActive);
            tabPage2.Controls.Add(lblSystemUserId);
            tabPage2.Controls.Add(pictureBox4);
            tabPage2.Controls.Add(tbConfirmPassword);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(tbUserName);
            tabPage2.Controls.Add(pictureBox1);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(tbPassword);
            tabPage2.Controls.Add(pictureBox3);
            tabPage2.Controls.Add(pictureBox2);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label3);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(817, 424);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Login info";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbIsActive
            // 
            cbIsActive.AutoSize = true;
            cbIsActive.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbIsActive.Location = new Point(252, 255);
            cbIsActive.Name = "cbIsActive";
            cbIsActive.Size = new Size(93, 25);
            cbIsActive.TabIndex = 11;
            cbIsActive.Text = "Is Active";
            cbIsActive.UseVisualStyleBackColor = true;
            // 
            // lblSystemUserId
            // 
            lblSystemUserId.AutoSize = true;
            lblSystemUserId.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSystemUserId.ForeColor = Color.Black;
            lblSystemUserId.Location = new Point(228, 52);
            lblSystemUserId.Name = "lblSystemUserId";
            lblSystemUserId.Size = new Size(31, 21);
            lblSystemUserId.TabIndex = 23;
            lblSystemUserId.Text = "???";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources._lock;
            pictureBox4.Location = new Point(187, 213);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(21, 21);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 22;
            pictureBox4.TabStop = false;
            // 
            // tbConfirmPassword
            // 
            tbConfirmPassword.Location = new Point(228, 213);
            tbConfirmPassword.Name = "tbConfirmPassword";
            tbConfirmPassword.Size = new Size(185, 23);
            tbConfirmPassword.TabIndex = 21;
            tbConfirmPassword.TextChanged += tbConfirmPassword_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(16, 211);
            label4.Name = "label4";
            label4.Size = new Size(156, 21);
            label4.TabIndex = 19;
            label4.Text = "Confirm Password :";
            // 
            // tbUserName
            // 
            tbUserName.Location = new Point(228, 107);
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new Size(185, 23);
            tbUserName.TabIndex = 18;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user_interface;
            pictureBox1.Location = new Point(187, 109);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(21, 21);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(74, 105);
            label2.Name = "label2";
            label2.Size = new Size(98, 21);
            label2.TabIndex = 16;
            label2.Text = "UserName :";
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(228, 159);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(185, 23);
            tbPassword.TabIndex = 15;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._lock;
            pictureBox3.Location = new Point(187, 157);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(21, 21);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.id_badge;
            pictureBox2.Location = new Point(187, 52);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(21, 21);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(82, 157);
            label5.Name = "label5";
            label5.Size = new Size(90, 21);
            label5.TabIndex = 11;
            label5.Text = "Password :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(40, 50);
            label3.Name = "label3";
            label3.Size = new Size(132, 21);
            label3.TabIndex = 10;
            label3.Text = "System User ID :";
            // 
            // lblAddOrUpdateSystemUser
            // 
            lblAddOrUpdateSystemUser.AutoSize = true;
            lblAddOrUpdateSystemUser.Font = new Font("Stencil", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddOrUpdateSystemUser.ForeColor = Color.DarkRed;
            lblAddOrUpdateSystemUser.Location = new Point(257, 9);
            lblAddOrUpdateSystemUser.Name = "lblAddOrUpdateSystemUser";
            lblAddOrUpdateSystemUser.Size = new Size(309, 38);
            lblAddOrUpdateSystemUser.TabIndex = 4;
            lblAddOrUpdateSystemUser.Text = "Add System User";
            // 
            // btnCloase
            // 
            btnCloase.FlatStyle = FlatStyle.Popup;
            btnCloase.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCloase.ImageAlign = ContentAlignment.MiddleRight;
            btnCloase.Location = new Point(617, 508);
            btnCloase.Name = "btnCloase";
            btnCloase.Size = new Size(90, 37);
            btnCloase.TabIndex = 12;
            btnCloase.Text = "Close";
            btnCloase.UseVisualStyleBackColor = true;
            btnCloase.Click += btnCloase_Click;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ImageAlign = ContentAlignment.MiddleRight;
            btnSave.Location = new Point(724, 508);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(87, 37);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // AddOrUpdateSystemUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 553);
            Controls.Add(btnSave);
            Controls.Add(btnCloase);
            Controls.Add(lblAddOrUpdateSystemUser);
            Controls.Add(tabControl1);
            Name = "AddOrUpdateSystemUserForm";
            Text = "AddNewSystemUserForm";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private UC_PersonInfomation uC_PersonInfomation1;
        private GroupBox groupBox1;
        private TextBox tbTextFiltter;
        private Label label1;
        private ComboBox CPoxFilterBy;
        private Button button1;
        private Button BtnAddNewUser;
        private Label lblAddOrUpdateSystemUser;
        private TextBox tbPassword;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label5;
        private Label label3;
        private TextBox tbConfirmPassword;
        private Label label4;
        private TextBox tbUserName;
        private PictureBox pictureBox1;
        private Label label2;
        private PictureBox pictureBox4;
        private Label lblSystemUserId;
        private CheckBox cbIsActive;
        private Button btnCloase;
        private Button btnSave;
        private Button btnNextPage;
        private ErrorProvider errorProvider1;
    }
}