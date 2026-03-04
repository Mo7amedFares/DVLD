namespace DVLD_Persntation
{
    partial class AddOrUpdateTestVistionForm
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
            uC_AddorUpdateTestAppointment1 = new UC_AddorUpdateTestAppointment();
            btnCloase = new Button();
            SuspendLayout();
            // 
            // uC_AddorUpdateTestAppointment1
            // 
            uC_AddorUpdateTestAppointment1.Location = new Point(12, 12);
            uC_AddorUpdateTestAppointment1.Name = "uC_AddorUpdateTestAppointment1";
            uC_AddorUpdateTestAppointment1.Size = new Size(492, 552);
            uC_AddorUpdateTestAppointment1.TabIndex = 0;
            // 
            // btnCloase
            // 
            btnCloase.FlatStyle = FlatStyle.Popup;
            btnCloase.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCloase.ImageAlign = ContentAlignment.MiddleRight;
            btnCloase.Location = new Point(192, 554);
            btnCloase.Name = "btnCloase";
            btnCloase.Size = new Size(90, 37);
            btnCloase.TabIndex = 77;
            btnCloase.Text = "Close";
            btnCloase.UseVisualStyleBackColor = true;
            btnCloase.Click += btnCloase_Click;
            // 
            // AddOrUpdateTestVistionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 603);
            Controls.Add(btnCloase);
            Controls.Add(uC_AddorUpdateTestAppointment1);
            Name = "AddOrUpdateTestVistionForm";
            Text = "AddOrUpdateTestVistionForm";
            Load += AddOrUpdateTestVistionForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private UC_AddorUpdateTestAppointment uC_AddorUpdateTestAppointment1;
        private Button btnCloase;
    }
}