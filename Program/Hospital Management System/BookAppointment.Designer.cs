namespace Hospital_Management_System
{
    partial class BookAppointment
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
            dayContainer = new FlowLayoutPanel();
            NextButton = new Button();
            PreviousButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            monthYearDisplay = new Label();
            doctorChoice = new ComboBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // dayContainer
            // 
            dayContainer.Location = new Point(12, 109);
            dayContainer.Name = "dayContainer";
            dayContainer.Size = new Size(912, 429);
            dayContainer.TabIndex = 0;
            // 
            // NextButton
            // 
            NextButton.BackColor = Color.SlateGray;
            NextButton.FlatAppearance.BorderSize = 0;
            NextButton.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            NextButton.Location = new Point(817, 544);
            NextButton.Name = "NextButton";
            NextButton.Size = new Size(107, 36);
            NextButton.TabIndex = 3;
            NextButton.Text = "Next";
            NextButton.UseVisualStyleBackColor = false;
            NextButton.Click += NextButton_Click;
            // 
            // PreviousButton
            // 
            PreviousButton.BackColor = Color.SlateGray;
            PreviousButton.FlatAppearance.BorderSize = 0;
            PreviousButton.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PreviousButton.Location = new Point(704, 544);
            PreviousButton.Name = "PreviousButton";
            PreviousButton.Size = new Size(107, 36);
            PreviousButton.TabIndex = 4;
            PreviousButton.Text = "Previous";
            PreviousButton.UseVisualStyleBackColor = false;
            PreviousButton.Click += PreviousButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(36, 76);
            label1.Name = "label1";
            label1.Size = new Size(82, 26);
            label1.TabIndex = 5;
            label1.Text = "Sunday";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(168, 76);
            label2.Name = "label2";
            label2.Size = new Size(86, 26);
            label2.TabIndex = 6;
            label2.Text = "Monday";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(294, 76);
            label3.Name = "label3";
            label3.Size = new Size(89, 26);
            label3.TabIndex = 7;
            label3.Text = "Tuesday";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(407, 76);
            label4.Name = "label4";
            label4.Size = new Size(119, 26);
            label4.TabIndex = 8;
            label4.Text = "Wednesday";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(549, 76);
            label5.Name = "label5";
            label5.Size = new Size(99, 26);
            label5.TabIndex = 9;
            label5.Text = "Thursday";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(694, 76);
            label6.Name = "label6";
            label6.Size = new Size(68, 26);
            label6.TabIndex = 10;
            label6.Text = "Friday";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(807, 76);
            label7.Name = "label7";
            label7.Size = new Size(95, 26);
            label7.TabIndex = 11;
            label7.Text = "Saturday";
            // 
            // monthYearDisplay
            // 
            monthYearDisplay.AutoSize = true;
            monthYearDisplay.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            monthYearDisplay.Location = new Point(375, 9);
            monthYearDisplay.Name = "monthYearDisplay";
            monthYearDisplay.Size = new Size(175, 31);
            monthYearDisplay.TabIndex = 12;
            monthYearDisplay.Text = "MONTH YEAR";
            // 
            // doctorChoice
            // 
            doctorChoice.BackColor = Color.SlateGray;
            doctorChoice.DropDownStyle = ComboBoxStyle.DropDownList;
            doctorChoice.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            doctorChoice.FormattingEnabled = true;
            doctorChoice.Location = new Point(157, 13);
            doctorChoice.Name = "doctorChoice";
            doctorChoice.Size = new Size(182, 31);
            doctorChoice.TabIndex = 13;
            doctorChoice.SelectedIndexChanged += doctorChoice_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Yu Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(12, 14);
            label8.Name = "label8";
            label8.Size = new Size(139, 26);
            label8.TabIndex = 14;
            label8.Text = "Select doctor:";
            // 
            // BookAppointment
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(936, 592);
            Controls.Add(label8);
            Controls.Add(doctorChoice);
            Controls.Add(monthYearDisplay);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PreviousButton);
            Controls.Add(NextButton);
            Controls.Add(dayContainer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BookAppointment";
            Text = "BookAppointment";
            Load += BookAppointment_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel dayContainer;
        private Button NextButton;
        private Button PreviousButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label monthYearDisplay;
        private ComboBox doctorChoice;
        private Label label8;
    }
}