namespace DVLD_Persntation
{
    partial class UC_SearchPeoble
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            button1 = new Button();
            BtnAddNewUser = new Button();
            tbTextFiltter = new TextBox();
            label1 = new Label();
            CPoxFilterBy = new ComboBox();
            uC_PersonInfomation1 = new UC_PersonInfomation();
            errorProvider1 = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(BtnAddNewUser);
            groupBox1.Controls.Add(tbTextFiltter);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(CPoxFilterBy);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(804, 81);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Seach Person";
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.search_profile;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(534, 19);
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
            BtnAddNewUser.Location = new Point(588, 19);
            BtnAddNewUser.Name = "BtnAddNewUser";
            BtnAddNewUser.Size = new Size(41, 36);
            BtnAddNewUser.TabIndex = 14;
            BtnAddNewUser.UseVisualStyleBackColor = true;
            BtnAddNewUser.Click += BtnAddNewUser_Click;
            // 
            // tbTextFiltter
            // 
            tbTextFiltter.Location = new Point(314, 27);
            tbTextFiltter.Name = "tbTextFiltter";
            tbTextFiltter.Size = new Size(190, 23);
            tbTextFiltter.TabIndex = 13;
            tbTextFiltter.TextChanged += tbTextFiltter_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 26);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 12;
            label1.Text = "Filter by";
            // 
            // CPoxFilterBy
            // 
            CPoxFilterBy.FormattingEnabled = true;
            CPoxFilterBy.Items.AddRange(new object[] { "User_ID", "SSN", "Email", "Phone" });
            CPoxFilterBy.Location = new Point(106, 27);
            CPoxFilterBy.Name = "CPoxFilterBy";
            CPoxFilterBy.Size = new Size(178, 23);
            CPoxFilterBy.TabIndex = 11;
            CPoxFilterBy.SelectedIndexChanged += CPoxFilterBy_SelectedIndexChanged;
            // 
            // uC_PersonInfomation1
            // 
            uC_PersonInfomation1.AccessibleName = "";
            uC_PersonInfomation1.BorderStyle = BorderStyle.FixedSingle;
            uC_PersonInfomation1.Location = new Point(3, 90);
            uC_PersonInfomation1.Name = "uC_PersonInfomation1";
            uC_PersonInfomation1.Size = new Size(811, 263);
            uC_PersonInfomation1.TabIndex = 15;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // UC_SearchPeoble
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Controls.Add(uC_PersonInfomation1);
            Name = "UC_SearchPeoble";
            Size = new Size(817, 356);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Button button1;
        private Button BtnAddNewUser;
        private TextBox tbTextFiltter;
        private Label label1;
        private ComboBox CPoxFilterBy;
        private UC_PersonInfomation uC_PersonInfomation1;
        private ErrorProvider errorProvider1;
    }
}
