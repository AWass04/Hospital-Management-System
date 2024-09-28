namespace Hospital_Management_System
{
    partial class DoctorHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorHome));
            LogoutButton = new Button();
            selectionLabel = new Panel();
            ViewAppointmentsButton = new Button();
            ViewPatientsButton = new Button();
            label3 = new Label();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            ProfileButton = new Button();
            panel2 = new Panel();
            panel4 = new Panel();
            label6 = new Label();
            panel1 = new Panel();
            backgroundPanel = new Panel();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            backgroundPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LogoutButton
            // 
            LogoutButton.FlatAppearance.BorderSize = 0;
            LogoutButton.FlatStyle = FlatStyle.Flat;
            LogoutButton.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LogoutButton.ForeColor = Color.White;
            LogoutButton.Location = new Point(828, 9);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(107, 44);
            LogoutButton.TabIndex = 2;
            LogoutButton.Text = "| Log out |";
            LogoutButton.UseVisualStyleBackColor = true;
            LogoutButton.Click += LogoutButton_Click;
            // 
            // selectionLabel
            // 
            selectionLabel.BackColor = Color.FromArgb(174, 70, 74);
            selectionLabel.Location = new Point(0, 373);
            selectionLabel.Name = "selectionLabel";
            selectionLabel.Size = new Size(15, 59);
            selectionLabel.TabIndex = 8;
            // 
            // ViewAppointmentsButton
            // 
            ViewAppointmentsButton.BackColor = Color.Transparent;
            ViewAppointmentsButton.FlatAppearance.BorderSize = 0;
            ViewAppointmentsButton.FlatStyle = FlatStyle.Flat;
            ViewAppointmentsButton.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ViewAppointmentsButton.ForeColor = Color.White;
            ViewAppointmentsButton.Location = new Point(3, 373);
            ViewAppointmentsButton.Name = "ViewAppointmentsButton";
            ViewAppointmentsButton.Size = new Size(314, 59);
            ViewAppointmentsButton.TabIndex = 14;
            ViewAppointmentsButton.Text = "View";
            ViewAppointmentsButton.UseVisualStyleBackColor = false;
            ViewAppointmentsButton.Click += ViewAppointmentsButton_Click;
            // 
            // ViewPatientsButton
            // 
            ViewPatientsButton.BackColor = Color.Transparent;
            ViewPatientsButton.BackgroundImageLayout = ImageLayout.None;
            ViewPatientsButton.FlatAppearance.BorderSize = 0;
            ViewPatientsButton.FlatStyle = FlatStyle.Flat;
            ViewPatientsButton.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ViewPatientsButton.ForeColor = Color.White;
            ViewPatientsButton.ImageAlign = ContentAlignment.MiddleLeft;
            ViewPatientsButton.Location = new Point(3, 150);
            ViewPatientsButton.Name = "ViewPatientsButton";
            ViewPatientsButton.Size = new Size(314, 59);
            ViewPatientsButton.TabIndex = 12;
            ViewPatientsButton.Text = "View";
            ViewPatientsButton.UseVisualStyleBackColor = false;
            ViewPatientsButton.Click += ViewPatientsButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(102, 331);
            label3.Name = "label3";
            label3.Size = new Size(124, 23);
            label3.TabIndex = 10;
            label3.Text = "Appointments";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 345);
            label4.Name = "label4";
            label4.Size = new Size(292, 25);
            label4.TabIndex = 11;
            label4.Text = "----------------------------------------";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(122, 109);
            label1.Name = "label1";
            label1.Size = new Size(78, 23);
            label1.TabIndex = 8;
            label1.Text = "Patients";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 122);
            label2.Name = "label2";
            label2.Size = new Size(292, 25);
            label2.TabIndex = 9;
            label2.Text = "----------------------------------------";
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
            ProfileButton.TabIndex = 5;
            ProfileButton.Text = "| Profile |";
            ProfileButton.UseVisualStyleBackColor = true;
            ProfileButton.Click += ProfileButton_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(80, 86, 95);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(selectionLabel);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(ViewAppointmentsButton);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(ViewPatientsButton);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(317, 665);
            panel2.TabIndex = 15;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(174, 70, 74);
            panel4.Controls.Add(label6);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(317, 60);
            panel4.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(26, 9);
            label6.Name = "label6";
            label6.Size = new Size(263, 46);
            label6.TabIndex = 16;
            label6.Text = "Hospital Management System \r\nDoctor    \r\n";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(80, 86, 95);
            panel1.Controls.Add(LogoutButton);
            panel1.Controls.Add(ProfileButton);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(317, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(943, 60);
            panel1.TabIndex = 16;
            // 
            // backgroundPanel
            // 
            backgroundPanel.Controls.Add(pictureBox1);
            backgroundPanel.Dock = DockStyle.Fill;
            backgroundPanel.Location = new Point(317, 60);
            backgroundPanel.Name = "backgroundPanel";
            backgroundPanel.Size = new Size(943, 605);
            backgroundPanel.TabIndex = 18;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(222, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(512, 512);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // DoctorHome
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1260, 665);
            Controls.Add(backgroundPanel);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "DoctorHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            backgroundPanel.ResumeLayout(false);
            backgroundPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button LogoutButton;
        private Panel selectionLabel;
        private Button ViewAppointmentsButton;
        private Button ViewPatientsButton;
        private Label label3;
        private Label label4;
        private Label label1;
        private Label label2;
        private Button ProfileButton;
        private Panel panel2;
        private Panel panel4;
        private Label label6;
        private Panel panel1;
        private Panel backgroundPanel;
        private PictureBox pictureBox1;
    }
}