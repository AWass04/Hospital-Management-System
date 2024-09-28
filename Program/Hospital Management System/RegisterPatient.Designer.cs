namespace Hospital_Management_System
{
    partial class RegisterPatient
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
            DOBInput = new DateTimePicker();
            registerButton = new Button();
            panel16 = new Panel();
            label7 = new Label();
            lastNameInput = new TextBox();
            panel17 = new Panel();
            panel14 = new Panel();
            label1 = new Label();
            middleNameInput = new TextBox();
            panel4 = new Panel();
            firstNameError = new Label();
            lastNameError = new Label();
            firstNameInput = new TextBox();
            panel10 = new Panel();
            panel1 = new Panel();
            label2 = new Label();
            panel15 = new Panel();
            DOBError = new Label();
            emailError = new Label();
            teleNoError = new Label();
            emailInput = new TextBox();
            panel3 = new Panel();
            teleNoInput = new TextBox();
            panel8 = new Panel();
            panel9 = new Panel();
            label10 = new Label();
            panel12 = new Panel();
            label9 = new Label();
            panel7 = new Panel();
            panel13 = new Panel();
            label8 = new Label();
            panel2 = new Panel();
            sexError = new Label();
            femaleCheckBox = new CheckBox();
            maleCheckBox = new CheckBox();
            panel5 = new Panel();
            label3 = new Label();
            panel6 = new Panel();
            panel16.SuspendLayout();
            panel14.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            panel9.SuspendLayout();
            panel12.SuspendLayout();
            panel13.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // DOBInput
            // 
            DOBInput.CalendarFont = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DOBInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DOBInput.Location = new Point(142, 24);
            DOBInput.Name = "DOBInput";
            DOBInput.Size = new Size(293, 39);
            DOBInput.TabIndex = 3;
            // 
            // registerButton
            // 
            registerButton.BackColor = Color.Teal;
            registerButton.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            registerButton.Location = new Point(27, 490);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(214, 47);
            registerButton.TabIndex = 6;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += registerButton_Click;
            // 
            // panel16
            // 
            panel16.BackColor = Color.Teal;
            panel16.Controls.Add(label7);
            panel16.Location = new Point(15, 232);
            panel16.Name = "panel16";
            panel16.Size = new Size(121, 45);
            panel16.TabIndex = 54;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(11, 11);
            label7.Name = "label7";
            label7.Size = new Size(105, 23);
            label7.TabIndex = 3;
            label7.Text = "Last Name:";
            // 
            // lastNameInput
            // 
            lastNameInput.BorderStyle = BorderStyle.None;
            lastNameInput.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameInput.Location = new Point(142, 232);
            lastNameInput.Name = "lastNameInput";
            lastNameInput.Size = new Size(292, 39);
            lastNameInput.TabIndex = 55;
            // 
            // panel17
            // 
            panel17.BackColor = Color.Teal;
            panel17.Location = new Point(142, 267);
            panel17.Name = "panel17";
            panel17.Size = new Size(292, 10);
            panel17.TabIndex = 56;
            // 
            // panel14
            // 
            panel14.BackColor = Color.Teal;
            panel14.Controls.Add(label1);
            panel14.Location = new Point(15, 126);
            panel14.Name = "panel14";
            panel14.Size = new Size(121, 45);
            panel14.TabIndex = 51;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(11, 11);
            label1.Name = "label1";
            label1.Size = new Size(72, 23);
            label1.TabIndex = 2;
            label1.Text = "Middle:";
            // 
            // middleNameInput
            // 
            middleNameInput.BorderStyle = BorderStyle.None;
            middleNameInput.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            middleNameInput.Location = new Point(142, 126);
            middleNameInput.Name = "middleNameInput";
            middleNameInput.Size = new Size(292, 39);
            middleNameInput.TabIndex = 52;
            // 
            // panel4
            // 
            panel4.BackColor = Color.SlateGray;
            panel4.Controls.Add(firstNameError);
            panel4.Controls.Add(lastNameError);
            panel4.Controls.Add(middleNameInput);
            panel4.Controls.Add(firstNameInput);
            panel4.Controls.Add(panel16);
            panel4.Controls.Add(panel10);
            panel4.Controls.Add(lastNameInput);
            panel4.Controls.Add(panel1);
            panel4.Controls.Add(panel17);
            panel4.Controls.Add(panel15);
            panel4.Controls.Add(panel14);
            panel4.Location = new Point(12, 130);
            panel4.Name = "panel4";
            panel4.Size = new Size(449, 316);
            panel4.TabIndex = 48;
            // 
            // firstNameError
            // 
            firstNameError.AutoSize = true;
            firstNameError.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            firstNameError.Location = new Point(142, 73);
            firstNameError.Name = "firstNameError";
            firstNameError.Size = new Size(98, 23);
            firstNameError.TabIndex = 60;
            firstNameError.Text = "* Required";
            // 
            // lastNameError
            // 
            lastNameError.AutoSize = true;
            lastNameError.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameError.Location = new Point(142, 287);
            lastNameError.Name = "lastNameError";
            lastNameError.Size = new Size(98, 23);
            lastNameError.TabIndex = 59;
            lastNameError.Text = "* Required";
            // 
            // firstNameInput
            // 
            firstNameInput.BorderStyle = BorderStyle.None;
            firstNameInput.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            firstNameInput.Location = new Point(142, 25);
            firstNameInput.Name = "firstNameInput";
            firstNameInput.Size = new Size(292, 39);
            firstNameInput.TabIndex = 49;
            // 
            // panel10
            // 
            panel10.BackColor = Color.Teal;
            panel10.Location = new Point(142, 60);
            panel10.Name = "panel10";
            panel10.Size = new Size(292, 10);
            panel10.TabIndex = 50;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(15, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(121, 45);
            panel1.TabIndex = 52;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(11, 11);
            label2.Name = "label2";
            label2.Size = new Size(107, 23);
            label2.TabIndex = 2;
            label2.Text = "First Name:";
            // 
            // panel15
            // 
            panel15.BackColor = Color.Teal;
            panel15.Location = new Point(142, 161);
            panel15.Name = "panel15";
            panel15.Size = new Size(292, 10);
            panel15.TabIndex = 53;
            // 
            // DOBError
            // 
            DOBError.AutoSize = true;
            DOBError.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DOBError.Location = new Point(142, 72);
            DOBError.Name = "DOBError";
            DOBError.Size = new Size(98, 23);
            DOBError.TabIndex = 61;
            DOBError.Text = "* Required";
            // 
            // emailError
            // 
            emailError.AutoSize = true;
            emailError.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            emailError.Location = new Point(142, 174);
            emailError.Name = "emailError";
            emailError.Size = new Size(98, 23);
            emailError.TabIndex = 58;
            emailError.Text = "* Required";
            // 
            // teleNoError
            // 
            teleNoError.AutoSize = true;
            teleNoError.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            teleNoError.Location = new Point(142, 73);
            teleNoError.Name = "teleNoError";
            teleNoError.Size = new Size(98, 23);
            teleNoError.TabIndex = 57;
            teleNoError.Text = "* Required";
            // 
            // emailInput
            // 
            emailInput.BorderStyle = BorderStyle.None;
            emailInput.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            emailInput.Location = new Point(142, 126);
            emailInput.Name = "emailInput";
            emailInput.Size = new Size(293, 39);
            emailInput.TabIndex = 55;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Teal;
            panel3.Location = new Point(143, 59);
            panel3.Name = "panel3";
            panel3.Size = new Size(292, 10);
            panel3.TabIndex = 52;
            // 
            // teleNoInput
            // 
            teleNoInput.BorderStyle = BorderStyle.None;
            teleNoInput.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            teleNoInput.Location = new Point(142, 25);
            teleNoInput.Name = "teleNoInput";
            teleNoInput.Size = new Size(293, 39);
            teleNoInput.TabIndex = 53;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Teal;
            panel8.Location = new Point(142, 161);
            panel8.Name = "panel8";
            panel8.Size = new Size(293, 10);
            panel8.TabIndex = 56;
            // 
            // panel9
            // 
            panel9.BackColor = Color.Teal;
            panel9.Controls.Add(label10);
            panel9.Location = new Point(15, 24);
            panel9.Name = "panel9";
            panel9.Size = new Size(121, 45);
            panel9.TabIndex = 50;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.White;
            label10.Location = new Point(12, 10);
            label10.Name = "label10";
            label10.Size = new Size(53, 25);
            label10.TabIndex = 6;
            label10.Text = "DOB:";
            // 
            // panel12
            // 
            panel12.BackColor = Color.Teal;
            panel12.Controls.Add(label9);
            panel12.Location = new Point(15, 126);
            panel12.Name = "panel12";
            panel12.Size = new Size(121, 45);
            panel12.TabIndex = 51;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(15, 11);
            label9.Name = "label9";
            label9.Size = new Size(62, 23);
            label9.TabIndex = 5;
            label9.Text = "Email:";
            // 
            // panel7
            // 
            panel7.BackColor = Color.Teal;
            panel7.Location = new Point(142, 60);
            panel7.Name = "panel7";
            panel7.Size = new Size(293, 10);
            panel7.TabIndex = 54;
            // 
            // panel13
            // 
            panel13.BackColor = Color.Teal;
            panel13.Controls.Add(label8);
            panel13.Location = new Point(15, 25);
            panel13.Name = "panel13";
            panel13.Size = new Size(121, 45);
            panel13.TabIndex = 52;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(15, 10);
            label8.Name = "label8";
            label8.Size = new Size(77, 23);
            label8.TabIndex = 4;
            label8.Text = "Tele No.";
            // 
            // panel2
            // 
            panel2.BackColor = Color.SlateGray;
            panel2.Controls.Add(sexError);
            panel2.Controls.Add(femaleCheckBox);
            panel2.Controls.Add(maleCheckBox);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(DOBError);
            panel2.Controls.Add(panel9);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(DOBInput);
            panel2.Location = new Point(474, 318);
            panel2.Name = "panel2";
            panel2.Size = new Size(450, 184);
            panel2.TabIndex = 49;
            // 
            // sexError
            // 
            sexError.AutoSize = true;
            sexError.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            sexError.Location = new Point(142, 154);
            sexError.Name = "sexError";
            sexError.Size = new Size(98, 23);
            sexError.TabIndex = 61;
            sexError.Text = "* Required";
            // 
            // femaleCheckBox
            // 
            femaleCheckBox.AutoSize = true;
            femaleCheckBox.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            femaleCheckBox.Location = new Point(308, 121);
            femaleCheckBox.Name = "femaleCheckBox";
            femaleCheckBox.Size = new Size(97, 27);
            femaleCheckBox.TabIndex = 63;
            femaleCheckBox.Text = "Female";
            femaleCheckBox.UseVisualStyleBackColor = true;
            femaleCheckBox.CheckedChanged += femaleCheckBox_CheckedChanged;
            // 
            // maleCheckBox
            // 
            maleCheckBox.AutoSize = true;
            maleCheckBox.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            maleCheckBox.Location = new Point(173, 121);
            maleCheckBox.Name = "maleCheckBox";
            maleCheckBox.Size = new Size(78, 27);
            maleCheckBox.TabIndex = 62;
            maleCheckBox.Text = "Male";
            maleCheckBox.UseVisualStyleBackColor = true;
            maleCheckBox.CheckedChanged += maleCheckBox_CheckedChanged;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Teal;
            panel5.Controls.Add(label3);
            panel5.Location = new Point(15, 110);
            panel5.Name = "panel5";
            panel5.Size = new Size(121, 45);
            panel5.TabIndex = 51;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 10);
            label3.Name = "label3";
            label3.Size = new Size(43, 25);
            label3.TabIndex = 6;
            label3.Text = "Sex:";
            // 
            // panel6
            // 
            panel6.BackColor = Color.SlateGray;
            panel6.Controls.Add(panel13);
            panel6.Controls.Add(teleNoInput);
            panel6.Controls.Add(panel7);
            panel6.Controls.Add(emailError);
            panel6.Controls.Add(teleNoError);
            panel6.Controls.Add(panel12);
            panel6.Controls.Add(emailInput);
            panel6.Controls.Add(panel8);
            panel6.Location = new Point(474, 84);
            panel6.Name = "panel6";
            panel6.Size = new Size(450, 212);
            panel6.TabIndex = 59;
            // 
            // RegisterPatient
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(936, 592);
            Controls.Add(panel6);
            Controls.Add(panel2);
            Controls.Add(registerButton);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(309, 58);
            Name = "RegisterPatient";
            Text = "RegisterPatient";
            panel16.ResumeLayout(false);
            panel16.PerformLayout();
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DateTimePicker DOBInput;
        private Button registerButton;
        private Panel panel16;
        private Label label7;
        private TextBox lastNameInput;
        private Panel panel17;
        private Panel panel14;
        private Label label1;
        private TextBox middleNameInput;
        private Panel panel4;
        private Panel panel15;
        private TextBox firstNameInput;
        private Panel panel10;
        private Panel panel1;
        private Label label2;
        private Panel panel3;
        private Panel panel9;
        private Label label10;
        private Label DOBError;
        private Label firstNameError;
        private Label lastNameError;
        private Label emailError;
        private Label teleNoError;
        private TextBox emailInput;
        private TextBox teleNoInput;
        private Panel panel8;
        private Panel panel12;
        private Label label9;
        private Panel panel7;
        private Panel panel13;
        private Label label8;
        private Panel panel2;
        private Label sexError;
        private CheckBox femaleCheckBox;
        private CheckBox maleCheckBox;
        private Panel panel5;
        private Label label3;
        private Panel panel6;
    }
}