namespace DVLD_Persntation
{
    partial class MangeSystemUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MangeSystemUser));
            label2 = new Label();
            pictureBox1 = new PictureBox();
            BtnAddNewUser = new Button();
            tbTextFiltter = new TextBox();
            label1 = new Label();
            CPoxFilterBy = new ComboBox();
            dataGridViewUsers = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            showPersonToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            changePasswordToolStripMenuItem = new ToolStripMenuItem();
            addPeopleToolStripMenuItem = new ToolStripMenuItem();
            label3 = new Label();
            CbIsActive = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(389, 138);
            label2.Name = "label2";
            label2.Size = new Size(182, 25);
            label2.TabIndex = 20;
            label2.Text = "Mange System User";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Peoples;
            pictureBox1.Location = new Point(414, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 114);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // BtnAddNewUser
            // 
            BtnAddNewUser.BackgroundImage = Properties.Resources.add_user;
            BtnAddNewUser.BackgroundImageLayout = ImageLayout.Zoom;
            BtnAddNewUser.FlatStyle = FlatStyle.Popup;
            BtnAddNewUser.Location = new Point(887, 126);
            BtnAddNewUser.Name = "BtnAddNewUser";
            BtnAddNewUser.Size = new Size(53, 54);
            BtnAddNewUser.TabIndex = 18;
            BtnAddNewUser.UseVisualStyleBackColor = true;
            BtnAddNewUser.Click += BtnAddNewUser_Click;
            // 
            // tbTextFiltter
            // 
            tbTextFiltter.Location = new Point(197, 157);
            tbTextFiltter.Name = "tbTextFiltter";
            tbTextFiltter.Size = new Size(120, 23);
            tbTextFiltter.TabIndex = 17;
            tbTextFiltter.TextChanged += tbTextFiltter_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-101, 111);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 16;
            label1.Text = "Filter by";
            // 
            // CPoxFilterBy
            // 
            CPoxFilterBy.FormattingEnabled = true;
            CPoxFilterBy.Location = new Point(59, 157);
            CPoxFilterBy.Name = "CPoxFilterBy";
            CPoxFilterBy.Size = new Size(119, 23);
            CPoxFilterBy.TabIndex = 15;
            CPoxFilterBy.SelectedIndexChanged += CPoxFilterBy_SelectedIndexChanged;
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.AllowUserToAddRows = false;
            dataGridViewUsers.AllowUserToDeleteRows = false;
            dataGridViewUsers.AllowUserToOrderColumns = true;
            dataGridViewUsers.ContextMenuStrip = contextMenuStrip1;
            dataGridViewUsers.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewUsers.Location = new Point(2, 186);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.ReadOnly = true;
            dataGridViewUsers.Size = new Size(976, 357);
            dataGridViewUsers.TabIndex = 14;
            dataGridViewUsers.CellContentClick += dataGridViewUsers_CellContentClick_1;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { showPersonToolStripMenuItem, toolStripSeparator1, editToolStripMenuItem, deleteToolStripMenuItem, changePasswordToolStripMenuItem, addPeopleToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(184, 120);
            // 
            // showPersonToolStripMenuItem
            // 
            showPersonToolStripMenuItem.Image = (Image)resources.GetObject("showPersonToolStripMenuItem.Image");
            showPersonToolStripMenuItem.Name = "showPersonToolStripMenuItem";
            showPersonToolStripMenuItem.Size = new Size(183, 22);
            showPersonToolStripMenuItem.Text = "Show System User";
            showPersonToolStripMenuItem.Click += showPersonToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(180, 6);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Image = (Image)resources.GetObject("editToolStripMenuItem.Image");
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(183, 22);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Image = (Image)resources.GetObject("deleteToolStripMenuItem.Image");
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(183, 22);
            deleteToolStripMenuItem.Text = "delete";
            // 
            // changePasswordToolStripMenuItem
            // 
            changePasswordToolStripMenuItem.Image = Properties.Resources.reset_password1;
            changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            changePasswordToolStripMenuItem.Size = new Size(183, 22);
            changePasswordToolStripMenuItem.Text = "Change Password";
            changePasswordToolStripMenuItem.Click += changePasswordToolStripMenuItem_Click;
            // 
            // addPeopleToolStripMenuItem
            // 
            addPeopleToolStripMenuItem.Image = Properties.Resources.add_user;
            addPeopleToolStripMenuItem.Name = "addPeopleToolStripMenuItem";
            addPeopleToolStripMenuItem.Size = new Size(183, 22);
            addPeopleToolStripMenuItem.Text = "Add System User";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 160);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 21;
            label3.Text = "Filter by";
            // 
            // CbIsActive
            // 
            CbIsActive.FormattingEnabled = true;
            CbIsActive.Items.AddRange(new object[] { "All", "True", "False" });
            CbIsActive.Location = new Point(196, 157);
            CbIsActive.Name = "CbIsActive";
            CbIsActive.Size = new Size(121, 23);
            CbIsActive.TabIndex = 22;
            CbIsActive.Visible = false;
            CbIsActive.SelectedIndexChanged += CbIsActive_SelectedIndexChanged;
            // 
            // MangeSystemUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 542);
            Controls.Add(CbIsActive);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(BtnAddNewUser);
            Controls.Add(tbTextFiltter);
            Controls.Add(label1);
            Controls.Add(CPoxFilterBy);
            Controls.Add(dataGridViewUsers);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MangeSystemUser";
            Text = "MangeSystemUser";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private PictureBox pictureBox1;
        private Button BtnAddNewUser;
        private TextBox tbTextFiltter;
        private Label label1;
        private ComboBox CPoxFilterBy;
        private DataGridView dataGridViewUsers;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem showPersonToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem addPeopleToolStripMenuItem;
        private Label label3;
        private ComboBox CbIsActive;
        private ToolStripMenuItem changePasswordToolStripMenuItem;
    }
}