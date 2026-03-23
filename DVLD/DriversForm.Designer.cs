namespace DVLD_Persntation
{
    partial class DriversForm
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
            label2 = new Label();
            pictureBox1 = new PictureBox();
            dataGridViewTestTypes = new DataGridView();
            btnCloase = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTestTypes).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(409, 129);
            label2.Name = "label2";
            label2.Size = new Size(73, 25);
            label2.TabIndex = 40;
            label2.Text = "Drivers";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.driver;
            pictureBox1.Location = new Point(387, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 114);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 39;
            pictureBox1.TabStop = false;
            // 
            // dataGridViewTestTypes
            // 
            dataGridViewTestTypes.AllowUserToAddRows = false;
            dataGridViewTestTypes.AllowUserToDeleteRows = false;
            dataGridViewTestTypes.AllowUserToOrderColumns = true;
            dataGridViewTestTypes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTestTypes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridViewTestTypes.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewTestTypes.Location = new Point(0, 184);
            dataGridViewTestTypes.Name = "dataGridViewTestTypes";
            dataGridViewTestTypes.ReadOnly = true;
            dataGridViewTestTypes.Size = new Size(880, 347);
            dataGridViewTestTypes.TabIndex = 38;
            // 
            // btnCloase
            // 
            btnCloase.FlatStyle = FlatStyle.Popup;
            btnCloase.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCloase.ImageAlign = ContentAlignment.MiddleRight;
            btnCloase.Location = new Point(776, 537);
            btnCloase.Name = "btnCloase";
            btnCloase.Size = new Size(90, 37);
            btnCloase.TabIndex = 41;
            btnCloase.Text = "Close";
            btnCloase.UseVisualStyleBackColor = true;
            btnCloase.Click += btnCloase_Click;
            // 
            // DriversForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 582);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridViewTestTypes);
            Controls.Add(btnCloase);
            MaximizeBox = false;
            Name = "DriversForm";
            Text = "DriversForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTestTypes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private PictureBox pictureBox1;
        private DataGridView dataGridViewTestTypes;
        private Button btnCloase;
    }
}