namespace Hospital_Management_System
{
    partial class ViewStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewStaff));
            label1 = new Label();
            panel1 = new Panel();
            DeleteButton = new Button();
            IDInput = new TextBox();
            panel2 = new Panel();
            panel3 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label6 = new Label();
            fNameInput = new TextBox();
            jobRoleInput = new TextBox();
            panel8 = new Panel();
            panel6 = new Panel();
            lNameInput = new TextBox();
            panel5 = new Panel();
            mNameInput = new TextBox();
            panel4 = new Panel();
            jobDropdown = new FlowLayoutPanel();
            panel17 = new Panel();
            pictureBox1 = new PictureBox();
            SelectButton = new Button();
            panel18 = new Panel();
            AdminButton = new Button();
            panel20 = new Panel();
            DoctorButton = new Button();
            panel21 = new Panel();
            ReceptionistButton = new Button();
            panel9 = new Panel();
            label2 = new Label();
            SaveButton = new Button();
            dropDownTimer = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            jobDropdown.SuspendLayout();
            panel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel18.SuspendLayout();
            panel20.SuspendLayout();
            panel21.SuspendLayout();
            panel9.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(20, 12);
            label1.Name = "label1";
            label1.Size = new Size(184, 39);
            label1.TabIndex = 0;
            label1.Text = "Staff Profile";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(135, 165, 139);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(39, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(385, 61);
            panel1.TabIndex = 1;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.FromArgb(80, 86, 95);
            DeleteButton.FlatAppearance.BorderSize = 0;
            DeleteButton.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteButton.Location = new Point(312, 501);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(200, 41);
            DeleteButton.TabIndex = 6;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // IDInput
            // 
            IDInput.BorderStyle = BorderStyle.None;
            IDInput.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IDInput.Location = new Point(208, 163);
            IDInput.Name = "IDInput";
            IDInput.ReadOnly = true;
            IDInput.Size = new Size(292, 39);
            IDInput.TabIndex = 16;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(135, 165, 139);
            panel2.Location = new Point(208, 198);
            panel2.Name = "panel2";
            panel2.Size = new Size(292, 10);
            panel2.TabIndex = 17;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SlateGray;
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(fNameInput);
            panel3.Controls.Add(jobRoleInput);
            panel3.Controls.Add(panel8);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(lNameInput);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(mNameInput);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(39, 147);
            panel3.Name = "panel3";
            panel3.Size = new Size(473, 348);
            panel3.TabIndex = 2;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(20, 290);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(45, 39);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 28;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(20, 11);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(45, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 27;
            pictureBox2.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(71, 296);
            label7.Name = "label7";
            label7.Size = new Size(84, 23);
            label7.TabIndex = 25;
            label7.Text = "Job Role:";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(22, 218);
            label5.Name = "label5";
            label5.Size = new Size(105, 23);
            label5.TabIndex = 26;
            label5.Text = "Last Name:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(20, 158);
            label4.Name = "label4";
            label4.Size = new Size(126, 23);
            label4.TabIndex = 25;
            label4.Text = "Middle Name:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(20, 95);
            label3.Name = "label3";
            label3.Size = new Size(107, 23);
            label3.TabIndex = 24;
            label3.Text = "First Name:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(71, 22);
            label6.Name = "label6";
            label6.Size = new Size(33, 23);
            label6.TabIndex = 21;
            label6.Text = "ID:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // fNameInput
            // 
            fNameInput.BorderStyle = BorderStyle.None;
            fNameInput.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            fNameInput.Location = new Point(169, 89);
            fNameInput.Name = "fNameInput";
            fNameInput.ReadOnly = true;
            fNameInput.Size = new Size(292, 39);
            fNameInput.TabIndex = 20;
            // 
            // jobRoleInput
            // 
            jobRoleInput.BorderStyle = BorderStyle.None;
            jobRoleInput.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            jobRoleInput.Location = new Point(169, 290);
            jobRoleInput.Name = "jobRoleInput";
            jobRoleInput.ReadOnly = true;
            jobRoleInput.Size = new Size(292, 39);
            jobRoleInput.TabIndex = 22;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(135, 165, 139);
            panel8.Location = new Point(169, 124);
            panel8.Name = "panel8";
            panel8.Size = new Size(292, 10);
            panel8.TabIndex = 21;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(135, 165, 139);
            panel6.Location = new Point(169, 325);
            panel6.Name = "panel6";
            panel6.Size = new Size(292, 10);
            panel6.TabIndex = 23;
            // 
            // lNameInput
            // 
            lNameInput.BorderStyle = BorderStyle.None;
            lNameInput.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lNameInput.Location = new Point(169, 212);
            lNameInput.Name = "lNameInput";
            lNameInput.ReadOnly = true;
            lNameInput.Size = new Size(292, 39);
            lNameInput.TabIndex = 20;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(135, 165, 139);
            panel5.Location = new Point(169, 247);
            panel5.Name = "panel5";
            panel5.Size = new Size(292, 10);
            panel5.TabIndex = 21;
            // 
            // mNameInput
            // 
            mNameInput.BorderStyle = BorderStyle.None;
            mNameInput.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mNameInput.Location = new Point(169, 152);
            mNameInput.Name = "mNameInput";
            mNameInput.ReadOnly = true;
            mNameInput.Size = new Size(292, 39);
            mNameInput.TabIndex = 18;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(135, 165, 139);
            panel4.Location = new Point(169, 187);
            panel4.Name = "panel4";
            panel4.Size = new Size(292, 10);
            panel4.TabIndex = 19;
            // 
            // jobDropdown
            // 
            jobDropdown.Controls.Add(panel17);
            jobDropdown.Controls.Add(panel18);
            jobDropdown.Controls.Add(panel20);
            jobDropdown.Controls.Add(panel21);
            jobDropdown.Location = new Point(609, 210);
            jobDropdown.MaximumSize = new Size(300, 245);
            jobDropdown.MinimumSize = new Size(300, 54);
            jobDropdown.Name = "jobDropdown";
            jobDropdown.Size = new Size(300, 54);
            jobDropdown.TabIndex = 18;
            // 
            // panel17
            // 
            panel17.Controls.Add(pictureBox1);
            panel17.Controls.Add(SelectButton);
            panel17.Dock = DockStyle.Top;
            panel17.Location = new Point(0, 0);
            panel17.Margin = new Padding(0);
            panel17.MaximumSize = new Size(290, 66);
            panel17.MinimumSize = new Size(290, 55);
            panel17.Name = "panel17";
            panel17.Size = new Size(290, 66);
            panel17.TabIndex = 28;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.SlateGray;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(84, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(26, 17);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // SelectButton
            // 
            SelectButton.BackColor = Color.SlateGray;
            SelectButton.FlatStyle = FlatStyle.Flat;
            SelectButton.Location = new Point(-15, -6);
            SelectButton.Name = "SelectButton";
            SelectButton.Size = new Size(315, 77);
            SelectButton.TabIndex = 21;
            SelectButton.Text = "Select";
            SelectButton.UseVisualStyleBackColor = false;
            SelectButton.Click += SelectButton_Click;
            // 
            // panel18
            // 
            panel18.Controls.Add(AdminButton);
            panel18.Dock = DockStyle.Fill;
            panel18.Location = new Point(0, 66);
            panel18.Margin = new Padding(0);
            panel18.MaximumSize = new Size(290, 66);
            panel18.MinimumSize = new Size(290, 55);
            panel18.Name = "panel18";
            panel18.Size = new Size(290, 55);
            panel18.TabIndex = 29;
            // 
            // AdminButton
            // 
            AdminButton.BackColor = Color.FromArgb(135, 165, 139);
            AdminButton.FlatStyle = FlatStyle.Flat;
            AdminButton.Location = new Point(-15, -7);
            AdminButton.Name = "AdminButton";
            AdminButton.Size = new Size(315, 71);
            AdminButton.TabIndex = 24;
            AdminButton.Text = "Admin";
            AdminButton.UseVisualStyleBackColor = false;
            AdminButton.Click += AdminButton_Click;
            // 
            // panel20
            // 
            panel20.Controls.Add(DoctorButton);
            panel20.Dock = DockStyle.Fill;
            panel20.Location = new Point(0, 121);
            panel20.Margin = new Padding(0);
            panel20.MaximumSize = new Size(290, 66);
            panel20.MinimumSize = new Size(290, 55);
            panel20.Name = "panel20";
            panel20.Size = new Size(290, 55);
            panel20.TabIndex = 29;
            // 
            // DoctorButton
            // 
            DoctorButton.BackColor = Color.FromArgb(135, 165, 139);
            DoctorButton.FlatStyle = FlatStyle.Flat;
            DoctorButton.Location = new Point(-15, -7);
            DoctorButton.Name = "DoctorButton";
            DoctorButton.Size = new Size(315, 65);
            DoctorButton.TabIndex = 26;
            DoctorButton.Text = "Doctor";
            DoctorButton.UseVisualStyleBackColor = false;
            DoctorButton.Click += DoctorButton_Click;
            // 
            // panel21
            // 
            panel21.Controls.Add(ReceptionistButton);
            panel21.Dock = DockStyle.Bottom;
            panel21.Location = new Point(0, 176);
            panel21.Margin = new Padding(0);
            panel21.MaximumSize = new Size(290, 66);
            panel21.MinimumSize = new Size(290, 55);
            panel21.Name = "panel21";
            panel21.Size = new Size(290, 66);
            panel21.TabIndex = 30;
            // 
            // ReceptionistButton
            // 
            ReceptionistButton.BackColor = Color.FromArgb(135, 165, 139);
            ReceptionistButton.FlatStyle = FlatStyle.Flat;
            ReceptionistButton.Location = new Point(-15, -8);
            ReceptionistButton.Name = "ReceptionistButton";
            ReceptionistButton.Size = new Size(315, 70);
            ReceptionistButton.TabIndex = 27;
            ReceptionistButton.Text = "Receptionist";
            ReceptionistButton.UseVisualStyleBackColor = false;
            ReceptionistButton.Click += ReceptionistButton_Click;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(135, 165, 139);
            panel9.Controls.Add(label2);
            panel9.Location = new Point(549, 147);
            panel9.Name = "panel9";
            panel9.Size = new Size(385, 42);
            panel9.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(147, 3);
            label2.Name = "label2";
            label2.Size = new Size(238, 39);
            label2.TabIndex = 0;
            label2.Text = "Change Job role";
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.FromArgb(80, 86, 95);
            SaveButton.FlatAppearance.BorderSize = 0;
            SaveButton.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SaveButton.Location = new Point(734, 455);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(200, 41);
            SaveButton.TabIndex = 20;
            SaveButton.Text = "Save Changes";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // dropDownTimer
            // 
            dropDownTimer.Interval = 1;
            dropDownTimer.Tick += dropDownTimer_Tick;
            // 
            // ViewStaff
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(936, 592);
            Controls.Add(SaveButton);
            Controls.Add(panel9);
            Controls.Add(jobDropdown);
            Controls.Add(IDInput);
            Controls.Add(panel2);
            Controls.Add(DeleteButton);
            Controls.Add(panel1);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewStaff";
            Text = "ViewStaff";
            Load += ViewStaff_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            jobDropdown.ResumeLayout(false);
            panel17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel18.ResumeLayout(false);
            panel20.ResumeLayout(false);
            panel21.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button DeleteButton;
        private TextBox IDInput;
        private Panel panel2;
        private Panel panel3;
        private TextBox jobRoleInput;
        private Panel panel6;
        private TextBox lNameInput;
        private Panel panel5;
        private TextBox mNameInput;
        private Panel panel4;
        private TextBox fNameInput;
        private Panel panel8;
        private FlowLayoutPanel jobDropdown;
        private Button SelectButton;
        private Panel panel9;
        private Label label2;
        private Button AdminButton;
        private Button DoctorButton;
        private Button SaveButton;
        private System.Windows.Forms.Timer dropDownTimer;
        private Panel panel17;
        private Panel panel18;
        private Panel panel20;
        private Panel panel21;
        private Button ReceptionistButton;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label6;
        private Label label7;
        private Label label5;
        private Label label4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
    }
}