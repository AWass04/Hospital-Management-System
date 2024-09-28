namespace Hospital_Management_System
{
    partial class AdminHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminHome));
            panel1 = new Panel();
            label5 = new Label();
            ProfileButton = new Button();
            LogoutButton = new Button();
            panel2 = new Panel();
            selectionLabel = new Panel();
            createEmployeeButton = new Button();
            ViewAdminButton = new Button();
            ViewDoctorsButton = new Button();
            label3 = new Label();
            ViewReceptionistButton = new Button();
            label1 = new Label();
            label4 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            backgroundPanel = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            backgroundPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(135, 165, 139);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(317, 60);
            panel1.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(29, 9);
            label5.Name = "label5";
            label5.Size = new Size(263, 46);
            label5.TabIndex = 3;
            label5.Text = "Hospital Management System \r\nAdmin\r\n";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ProfileButton
            // 
            ProfileButton.FlatAppearance.BorderSize = 0;
            ProfileButton.FlatStyle = FlatStyle.Flat;
            ProfileButton.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ProfileButton.ForeColor = Color.White;
            ProfileButton.Location = new Point(733, 9);
            ProfileButton.Name = "ProfileButton";
            ProfileButton.Size = new Size(107, 44);
            ProfileButton.TabIndex = 10;
            ProfileButton.Text = "| Profile |";
            ProfileButton.UseVisualStyleBackColor = true;
            ProfileButton.Click += ProfileButton_Click;
            // 
            // LogoutButton
            // 
            LogoutButton.FlatAppearance.BorderSize = 0;
            LogoutButton.FlatStyle = FlatStyle.Flat;
            LogoutButton.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LogoutButton.ForeColor = Color.White;
            LogoutButton.Location = new Point(829, 9);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(107, 44);
            LogoutButton.TabIndex = 2;
            LogoutButton.Text = "| Log out |";
            LogoutButton.UseVisualStyleBackColor = true;
            LogoutButton.Click += LogoutButton_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(80, 86, 95);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(selectionLabel);
            panel2.Controls.Add(createEmployeeButton);
            panel2.Controls.Add(ViewAdminButton);
            panel2.Controls.Add(ViewDoctorsButton);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(ViewReceptionistButton);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(317, 665);
            panel2.TabIndex = 9;
            // 
            // selectionLabel
            // 
            selectionLabel.BackColor = Color.FromArgb(135, 165, 139);
            selectionLabel.Location = new Point(0, 431);
            selectionLabel.Name = "selectionLabel";
            selectionLabel.Size = new Size(15, 59);
            selectionLabel.TabIndex = 9;
            // 
            // createEmployeeButton
            // 
            createEmployeeButton.BackColor = Color.Transparent;
            createEmployeeButton.FlatAppearance.BorderSize = 0;
            createEmployeeButton.FlatStyle = FlatStyle.Flat;
            createEmployeeButton.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            createEmployeeButton.ForeColor = Color.White;
            createEmployeeButton.Location = new Point(3, 431);
            createEmployeeButton.Name = "createEmployeeButton";
            createEmployeeButton.Size = new Size(314, 59);
            createEmployeeButton.TabIndex = 18;
            createEmployeeButton.Text = "Create";
            createEmployeeButton.UseVisualStyleBackColor = false;
            createEmployeeButton.Click += createEmployeeButton_Click;
            // 
            // ViewAdminButton
            // 
            ViewAdminButton.BackColor = Color.Transparent;
            ViewAdminButton.FlatAppearance.BorderSize = 0;
            ViewAdminButton.FlatStyle = FlatStyle.Flat;
            ViewAdminButton.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ViewAdminButton.ForeColor = Color.White;
            ViewAdminButton.Location = new Point(3, 258);
            ViewAdminButton.Name = "ViewAdminButton";
            ViewAdminButton.Size = new Size(314, 59);
            ViewAdminButton.TabIndex = 17;
            ViewAdminButton.Text = "View Admin";
            ViewAdminButton.UseVisualStyleBackColor = false;
            ViewAdminButton.Click += ViewAdminButton_Click;
            // 
            // ViewDoctorsButton
            // 
            ViewDoctorsButton.BackColor = Color.Transparent;
            ViewDoctorsButton.FlatAppearance.BorderSize = 0;
            ViewDoctorsButton.FlatStyle = FlatStyle.Flat;
            ViewDoctorsButton.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ViewDoctorsButton.ForeColor = Color.White;
            ViewDoctorsButton.Location = new Point(3, 193);
            ViewDoctorsButton.Name = "ViewDoctorsButton";
            ViewDoctorsButton.Size = new Size(314, 59);
            ViewDoctorsButton.TabIndex = 16;
            ViewDoctorsButton.Text = "View Doctors";
            ViewDoctorsButton.UseVisualStyleBackColor = false;
            ViewDoctorsButton.Click += ViewDoctorsButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(108, 390);
            label3.Name = "label3";
            label3.Size = new Size(85, 23);
            label3.TabIndex = 10;
            label3.Text = "Accounts";
            // 
            // ViewReceptionistButton
            // 
            ViewReceptionistButton.BackColor = Color.Transparent;
            ViewReceptionistButton.FlatAppearance.BorderSize = 0;
            ViewReceptionistButton.FlatStyle = FlatStyle.Flat;
            ViewReceptionistButton.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ViewReceptionistButton.ForeColor = Color.White;
            ViewReceptionistButton.Location = new Point(0, 124);
            ViewReceptionistButton.Name = "ViewReceptionistButton";
            ViewReceptionistButton.Size = new Size(317, 59);
            ViewReceptionistButton.TabIndex = 15;
            ViewReceptionistButton.Text = "View Receptionists";
            ViewReceptionistButton.UseVisualStyleBackColor = false;
            ViewReceptionistButton.Click += ViewReceptionistButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(132, 85);
            label1.Name = "label1";
            label1.Size = new Size(49, 23);
            label1.TabIndex = 8;
            label1.Text = "Staff";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(11, 403);
            label4.Name = "label4";
            label4.Size = new Size(292, 25);
            label4.TabIndex = 11;
            label4.Text = "----------------------------------------";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(11, 96);
            label2.Name = "label2";
            label2.Size = new Size(292, 25);
            label2.TabIndex = 9;
            label2.Text = "----------------------------------------";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(80, 86, 95);
            panel3.Controls.Add(LogoutButton);
            panel3.Controls.Add(ProfileButton);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(317, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(943, 60);
            panel3.TabIndex = 11;
            // 
            // backgroundPanel
            // 
            backgroundPanel.Controls.Add(pictureBox1);
            backgroundPanel.Dock = DockStyle.Fill;
            backgroundPanel.Location = new Point(0, 0);
            backgroundPanel.Name = "backgroundPanel";
            backgroundPanel.Size = new Size(1260, 665);
            backgroundPanel.TabIndex = 13;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(555, 124);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(512, 512);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // AdminHome
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1260, 665);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(backgroundPanel);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "AdminHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            backgroundPanel.ResumeLayout(false);
            backgroundPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private Button LogoutButton;
        private Panel panel2;
        private Button ViewReceptionistButton;
        private Label label3;
        private Label label4;
        private Label label1;
        private Label label2;
        private Button ViewAdminButton;
        private Button ViewDoctorsButton;
        private Button createEmployeeButton;
        private Button ProfileButton;
        private Panel panel3;
        private Panel selectionLabel;
        private Panel backgroundPanel;
        private PictureBox pictureBox1;
    }
}