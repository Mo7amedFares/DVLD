namespace DVLD_Persntation
{
    partial class MangeTestTypesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MangeTestTypesForm));
            label2 = new Label();
            pictureBox1 = new PictureBox();
            dataGridViewTestTypes = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripSeparator1 = new ToolStripSeparator();
            editToolStripMenuItem = new ToolStripMenuItem();
            refrechToolStripMenuItem = new ToolStripMenuItem();
            btnCloase = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTestTypes).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(324, 137);
            label2.Name = "label2";
            label2.Size = new Size(163, 25);
            label2.TabIndex = 36;
            label2.Text = "Mange Test Types";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.compliance;
            pictureBox1.Location = new Point(346, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 114);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 35;
            pictureBox1.TabStop = false;
            // 
            // dataGridViewTestTypes
            // 
            dataGridViewTestTypes.AllowUserToAddRows = false;
            dataGridViewTestTypes.AllowUserToDeleteRows = false;
            dataGridViewTestTypes.AllowUserToOrderColumns = true;
            dataGridViewTestTypes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTestTypes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridViewTestTypes.ContextMenuStrip = contextMenuStrip1;
            dataGridViewTestTypes.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewTestTypes.Location = new Point(0, 193);
            dataGridViewTestTypes.Name = "dataGridViewTestTypes";
            dataGridViewTestTypes.ReadOnly = true;
            dataGridViewTestTypes.Size = new Size(833, 347);
            dataGridViewTestTypes.TabIndex = 34;
            dataGridViewTestTypes.CellMouseDoubleClick += dataGridViewTestTypes_CellMouseDoubleClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripSeparator1, editToolStripMenuItem, refrechToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(121, 54);
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(117, 6);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Image = (Image)resources.GetObject("editToolStripMenuItem.Image");
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(120, 22);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // refrechToolStripMenuItem
            // 
            refrechToolStripMenuItem.Image = Properties.Resources.cycle;
            refrechToolStripMenuItem.Name = "refrechToolStripMenuItem";
            refrechToolStripMenuItem.Size = new Size(120, 22);
            refrechToolStripMenuItem.Text = "Refresh";
            refrechToolStripMenuItem.Click += refrechToolStripMenuItem_Click;
            // 
            // btnCloase
            // 
            btnCloase.FlatStyle = FlatStyle.Popup;
            btnCloase.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCloase.ImageAlign = ContentAlignment.MiddleRight;
            btnCloase.Location = new Point(730, 546);
            btnCloase.Name = "btnCloase";
            btnCloase.Size = new Size(90, 37);
            btnCloase.TabIndex = 37;
            btnCloase.Text = "Close";
            btnCloase.UseVisualStyleBackColor = true;
            btnCloase.Click += btnCloase_Click;
            // 
            // MangeTestTypesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 590);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridViewTestTypes);
            Controls.Add(btnCloase);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "MangeTestTypesForm";
            Text = "MangeTestTypes";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTestTypes).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private PictureBox pictureBox1;
        private DataGridView dataGridViewTestTypes;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem refrechToolStripMenuItem;
        private Button btnCloase;
    }
}