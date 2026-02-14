namespace DVLD_Persntation
{
    partial class ApplicationTypesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicationTypesForm));
            label2 = new Label();
            pictureBox1 = new PictureBox();
            dataGridViewApplicationTypes = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripSeparator1 = new ToolStripSeparator();
            editToolStripMenuItem = new ToolStripMenuItem();
            btnCloase = new Button();
            refrechToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewApplicationTypes).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(336, 138);
            label2.Name = "label2";
            label2.Size = new Size(182, 25);
            label2.TabIndex = 29;
            label2.Text = "Mange System User";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.deployment;
            pictureBox1.Location = new Point(366, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 114);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // dataGridViewApplicationTypes
            // 
            dataGridViewApplicationTypes.AllowUserToAddRows = false;
            dataGridViewApplicationTypes.AllowUserToDeleteRows = false;
            dataGridViewApplicationTypes.AllowUserToOrderColumns = true;
            dataGridViewApplicationTypes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewApplicationTypes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridViewApplicationTypes.ContextMenuStrip = contextMenuStrip1;
            dataGridViewApplicationTypes.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewApplicationTypes.Location = new Point(0, 185);
            dataGridViewApplicationTypes.Name = "dataGridViewApplicationTypes";
            dataGridViewApplicationTypes.ReadOnly = true;
            dataGridViewApplicationTypes.Size = new Size(833, 347);
            dataGridViewApplicationTypes.TabIndex = 23;
            dataGridViewApplicationTypes.ColumnHeaderMouseClick += dataGridViewApplicationTypes_ColumnHeaderMouseClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripSeparator1, editToolStripMenuItem, refrechToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(181, 76);
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Image = (Image)resources.GetObject("editToolStripMenuItem.Image");
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(180, 22);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // btnCloase
            // 
            btnCloase.FlatStyle = FlatStyle.Popup;
            btnCloase.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCloase.ImageAlign = ContentAlignment.MiddleRight;
            btnCloase.Location = new Point(730, 538);
            btnCloase.Name = "btnCloase";
            btnCloase.Size = new Size(90, 37);
            btnCloase.TabIndex = 33;
            btnCloase.Text = "Close";
            btnCloase.UseVisualStyleBackColor = true;
            btnCloase.Click += btnCloase_Click;
            // 
            // refrechToolStripMenuItem
            // 
            refrechToolStripMenuItem.Image = Properties.Resources.cycle;
            refrechToolStripMenuItem.Name = "refrechToolStripMenuItem";
            refrechToolStripMenuItem.Size = new Size(180, 22);
            refrechToolStripMenuItem.Text = "Refresh";
            refrechToolStripMenuItem.Click += refrechToolStripMenuItem_Click;
            // 
            // ApplicationTypesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 582);
            Controls.Add(btnCloase);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridViewApplicationTypes);
            Name = "ApplicationTypesForm";
            Text = "ApplicationTypesForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewApplicationTypes).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private PictureBox pictureBox1;
        private DataGridView dataGridViewApplicationTypes;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem editToolStripMenuItem;
        private Button btnCloase;
        private ToolStripMenuItem refrechToolStripMenuItem;
    }
}