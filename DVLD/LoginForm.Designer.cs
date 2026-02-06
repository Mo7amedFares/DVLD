namespace DVLD_Persntation
{
    partial class LoginForm
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            tbUserName = new TextBox();
            tbPassword = new TextBox();
            cbRememperMe = new CheckBox();
            btnSave = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.background_DVLD;
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(383, 453);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoEllipsis = true;
            label1.AutoSize = true;
            label1.Cursor = Cursors.SizeNS;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(429, 20);
            label1.Name = "label1";
            label1.Size = new Size(338, 25);
            label1.TabIndex = 1;
            label1.Text = "Driving License Management System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.ForeColor = Color.LightSeaGreen;
            label2.Location = new Point(549, 67);
            label2.Name = "label2";
            label2.Size = new Size(64, 25);
            label2.TabIndex = 2;
            label2.Text = "LogIn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(404, 139);
            label3.Name = "label3";
            label3.Size = new Size(98, 21);
            label3.TabIndex = 3;
            label3.Text = "UserName :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(404, 190);
            label5.Name = "label5";
            label5.Size = new Size(90, 21);
            label5.TabIndex = 5;
            label5.Text = "Password :";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.user_interface;
            pictureBox2.Location = new Point(508, 139);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(21, 21);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._lock;
            pictureBox3.Location = new Point(508, 190);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(21, 21);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // tbUserName
            // 
            tbUserName.Location = new Point(549, 137);
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new Size(185, 23);
            tbUserName.TabIndex = 8;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(549, 192);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(185, 23);
            tbPassword.TabIndex = 9;
            // 
            // cbRememperMe
            // 
            cbRememperMe.AutoSize = true;
            cbRememperMe.FlatStyle = FlatStyle.Flat;
            cbRememperMe.Location = new Point(549, 233);
            cbRememperMe.Name = "cbRememperMe";
            cbRememperMe.Size = new Size(101, 19);
            cbRememperMe.TabIndex = 10;
            cbRememperMe.Text = "Rememper Me";
            cbRememperMe.UseVisualStyleBackColor = true;
            cbRememperMe.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.ImageAlign = ContentAlignment.MiddleRight;
            btnSave.Location = new Point(692, 289);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 11;
            btnSave.Text = "Login";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(cbRememperMe);
            Controls.Add(tbPassword);
            Controls.Add(tbUserName);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "LoginForm";
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TextBox tbUserName;
        private TextBox tbPassword;
        private CheckBox cbRememperMe;
        private Button btnSave;
        private ErrorProvider errorProvider1;
    }
}