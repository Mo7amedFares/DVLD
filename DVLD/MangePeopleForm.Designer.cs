namespace DVLD
{
    partial class MangePeopleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MangePeopleForm));
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
            addPeopleToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(515, 151);
            label2.Name = "label2";
            label2.Size = new Size(134, 25);
            label2.TabIndex = 13;
            label2.Text = "Mange People";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = DVLD_Persntation.Properties.Resources.Peoples;
            pictureBox1.Location = new Point(521, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 114);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // BtnAddNewUser
            // 
            BtnAddNewUser.BackgroundImage = DVLD_Persntation.Properties.Resources.add_user;
            BtnAddNewUser.BackgroundImageLayout = ImageLayout.Zoom;
            BtnAddNewUser.FlatStyle = FlatStyle.Popup;
            BtnAddNewUser.Location = new Point(1130, 151);
            BtnAddNewUser.Name = "BtnAddNewUser";
            BtnAddNewUser.Size = new Size(53, 54);
            BtnAddNewUser.TabIndex = 11;
            BtnAddNewUser.UseVisualStyleBackColor = true;
            BtnAddNewUser.Click += BtnAddNewUser_Click;
            // 
            // tbTextFiltter
            // 
            tbTextFiltter.Location = new Point(201, 166);
            tbTextFiltter.Name = "tbTextFiltter";
            tbTextFiltter.Size = new Size(120, 23);
            tbTextFiltter.TabIndex = 10;
            tbTextFiltter.TextChanged += tbTextFiltter_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 169);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 9;
            label1.Text = "Filter by";
            // 
            // CPoxFilterBy
            // 
            CPoxFilterBy.FormattingEnabled = true;
            CPoxFilterBy.Location = new Point(63, 166);
            CPoxFilterBy.Name = "CPoxFilterBy";
            CPoxFilterBy.Size = new Size(119, 23);
            CPoxFilterBy.TabIndex = 8;
            CPoxFilterBy.SelectedIndexChanged += CPoxFilterBy_SelectedIndexChanged;
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.AllowUserToAddRows = false;
            dataGridViewUsers.AllowUserToDeleteRows = false;
            dataGridViewUsers.AllowUserToOrderColumns = true;
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.ContextMenuStrip = contextMenuStrip1;
            dataGridViewUsers.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewUsers.Location = new Point(-2, 210);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.ReadOnly = true;
            dataGridViewUsers.Size = new Size(1197, 380);
            dataGridViewUsers.TabIndex = 7;
            dataGridViewUsers.CellContentClick += dataGridViewUsers_CellContentClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { showPersonToolStripMenuItem, toolStripSeparator1, editToolStripMenuItem, deleteToolStripMenuItem, addPeopleToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(152, 98);
            // 
            // showPersonToolStripMenuItem
            // 
            showPersonToolStripMenuItem.Image = (Image)resources.GetObject("showPersonToolStripMenuItem.Image");
            showPersonToolStripMenuItem.Name = "showPersonToolStripMenuItem";
            showPersonToolStripMenuItem.Size = new Size(151, 22);
            showPersonToolStripMenuItem.Text = "Show Person";
            showPersonToolStripMenuItem.Click += showPersonToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(148, 6);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Image = (Image)resources.GetObject("editToolStripMenuItem.Image");
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(151, 22);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Image = (Image)resources.GetObject("deleteToolStripMenuItem.Image");
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(151, 22);
            deleteToolStripMenuItem.Text = "delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // addPeopleToolStripMenuItem
            // 
            addPeopleToolStripMenuItem.Image = DVLD_Persntation.Properties.Resources.add_user;
            addPeopleToolStripMenuItem.Name = "addPeopleToolStripMenuItem";
            addPeopleToolStripMenuItem.Size = new Size(151, 22);
            addPeopleToolStripMenuItem.Text = "Add Person";
            addPeopleToolStripMenuItem.Click += addPeopleToolStripMenuItem_Click;
            // 
            // MangePeopleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1193, 589);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(BtnAddNewUser);
            Controls.Add(tbTextFiltter);
            Controls.Add(label1);
            Controls.Add(CPoxFilterBy);
            Controls.Add(dataGridViewUsers);
            Name = "MangePeopleForm";
            Text = "MangePeople";
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
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem addPeopleToolStripMenuItem;
        private ToolStripMenuItem showPersonToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
    }
}