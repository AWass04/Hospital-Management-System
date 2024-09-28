namespace Hospital_Management_System
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            LoginButton = new Button();
            adminCheckBox = new CheckBox();
            receptionistCheckBox = new CheckBox();
            doctorCheckBox = new CheckBox();
            usernameInput = new TextBox();
            passwordInput = new TextBox();
            usernameError = new Label();
            passwordError = new Label();
            checkBoxError = new Label();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            closeButton = new Button();
            label1 = new Label();
            panel3 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.SlateGray;
            LoginButton.FlatAppearance.BorderSize = 0;
            LoginButton.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LoginButton.Location = new Point(848, 520);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(148, 53);
            LoginButton.TabIndex = 2;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click_1;
            // 
            // adminCheckBox
            // 
            adminCheckBox.AutoSize = true;
            adminCheckBox.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            adminCheckBox.Location = new Point(881, 415);
            adminCheckBox.Name = "adminCheckBox";
            adminCheckBox.Size = new Size(89, 27);
            adminCheckBox.TabIndex = 3;
            adminCheckBox.Text = "Admin";
            adminCheckBox.UseVisualStyleBackColor = true;
            adminCheckBox.CheckedChanged += adminCheckBox_CheckedChanged;
            // 
            // receptionistCheckBox
            // 
            receptionistCheckBox.AutoSize = true;
            receptionistCheckBox.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            receptionistCheckBox.Location = new Point(565, 415);
            receptionistCheckBox.Name = "receptionistCheckBox";
            receptionistCheckBox.Size = new Size(138, 27);
            receptionistCheckBox.TabIndex = 4;
            receptionistCheckBox.Text = "Receptionist";
            receptionistCheckBox.UseVisualStyleBackColor = true;
            receptionistCheckBox.CheckedChanged += receptionistCheckBox_CheckedChanged;
            // 
            // doctorCheckBox
            // 
            doctorCheckBox.AutoSize = true;
            doctorCheckBox.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            doctorCheckBox.Location = new Point(741, 415);
            doctorCheckBox.Name = "doctorCheckBox";
            doctorCheckBox.Size = new Size(91, 27);
            doctorCheckBox.TabIndex = 5;
            doctorCheckBox.Text = "Doctor";
            doctorCheckBox.UseVisualStyleBackColor = true;
            doctorCheckBox.CheckedChanged += doctorCheckBox_CheckedChanged;
            // 
            // usernameInput
            // 
            usernameInput.BorderStyle = BorderStyle.None;
            usernameInput.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            usernameInput.Location = new Point(621, 206);
            usernameInput.Name = "usernameInput";
            usernameInput.Size = new Size(349, 39);
            usernameInput.TabIndex = 6;
            usernameInput.Text = "Staff ID";
            usernameInput.Click += usernameInput_Click;
            // 
            // passwordInput
            // 
            passwordInput.BorderStyle = BorderStyle.None;
            passwordInput.Font = new Font("Yu Gothic", 13F, FontStyle.Regular, GraphicsUnit.Point);
            passwordInput.Location = new Point(621, 308);
            passwordInput.Name = "passwordInput";
            passwordInput.Size = new Size(349, 42);
            passwordInput.TabIndex = 7;
            passwordInput.Text = "Password";
            passwordInput.Click += passwordInput_Click;
            // 
            // usernameError
            // 
            usernameError.AutoSize = true;
            usernameError.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            usernameError.Location = new Point(621, 254);
            usernameError.Name = "usernameError";
            usernameError.Size = new Size(112, 23);
            usernameError.TabIndex = 8;
            usernameError.Text = "* Missing ID";
            // 
            // passwordError
            // 
            passwordError.AutoSize = true;
            passwordError.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            passwordError.Location = new Point(621, 359);
            passwordError.Name = "passwordError";
            passwordError.Size = new Size(173, 23);
            passwordError.TabIndex = 9;
            passwordError.Text = "* Missing password";
            // 
            // checkBoxError
            // 
            checkBoxError.AutoSize = true;
            checkBoxError.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxError.Location = new Point(570, 447);
            checkBoxError.Name = "checkBoxError";
            checkBoxError.Size = new Size(168, 23);
            checkBoxError.TabIndex = 10;
            checkBoxError.Text = "* Missing selection";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSlateGray;
            panel1.Controls.Add(pictureBox3);
            panel1.Location = new Point(-3, -10);
            panel1.Name = "panel1";
            panel1.Size = new Size(504, 905);
            panel1.TabIndex = 12;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(59, 99);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(394, 383);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // closeButton
            // 
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.Location = new Point(974, 3);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(51, 50);
            closeButton.TabIndex = 0;
            closeButton.Text = "X";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(630, 109);
            label1.Name = "label1";
            label1.Size = new Size(296, 36);
            label1.TabIndex = 14;
            label1.Text = "Login to your Account";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(80, 86, 95);
            panel3.Controls.Add(closeButton);
            panel3.Location = new Point(0, -7);
            panel3.Name = "panel3";
            panel3.Size = new Size(1555, 53);
            panel3.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SlateGray;
            panel2.Location = new Point(621, 241);
            panel2.Name = "panel2";
            panel2.Size = new Size(349, 10);
            panel2.TabIndex = 15;
            // 
            // panel4
            // 
            panel4.BackColor = Color.SlateGray;
            panel4.Location = new Point(621, 346);
            panel4.Name = "panel4";
            panel4.Size = new Size(349, 10);
            panel4.TabIndex = 16;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(565, 205);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 46);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(565, 308);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(45, 48);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1026, 597);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(passwordInput);
            Controls.Add(panel4);
            Controls.Add(usernameInput);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(checkBoxError);
            Controls.Add(passwordError);
            Controls.Add(usernameError);
            Controls.Add(doctorCheckBox);
            Controls.Add(receptionistCheckBox);
            Controls.Add(adminCheckBox);
            Controls.Add(LoginButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button LoginButton;
        private CheckBox adminCheckBox;
        private CheckBox receptionistCheckBox;
        private CheckBox doctorCheckBox;
        private TextBox usernameInput;
        private TextBox passwordInput;
        private Label usernameError;
        private Label passwordError;
        private Label checkBoxError;
        private Panel panel1;
        private Button closeButton;
        private Label label1;
        private Panel panel3;
        private Panel panel2;
        private Panel panel4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}