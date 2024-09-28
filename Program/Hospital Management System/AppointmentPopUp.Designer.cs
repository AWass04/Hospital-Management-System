namespace Hospital_Management_System
{
    partial class AppointmentPopUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointmentPopUp));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel3 = new Panel();
            closeButton = new Button();
            patientIDInput = new TextBox();
            doctorInput = new TextBox();
            tenTime = new CheckBox();
            elevenTime = new CheckBox();
            oneTime = new CheckBox();
            twelveTime = new CheckBox();
            twoTime = new CheckBox();
            threeTime = new CheckBox();
            fourTime = new CheckBox();
            nineTime = new CheckBox();
            addButton = new Button();
            label1 = new Label();
            label2 = new Label();
            dateInput = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            panel9 = new Panel();
            patientIDError = new Label();
            timeError = new Label();
            panel10 = new Panel();
            RefreshButton = new Button();
            appointmentTable = new DataGridView();
            panel3.SuspendLayout();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)appointmentTable).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(80, 86, 95);
            panel3.Controls.Add(closeButton);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1041, 53);
            panel3.TabIndex = 3;
            // 
            // closeButton
            // 
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.Location = new Point(990, 3);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(51, 50);
            closeButton.TabIndex = 0;
            closeButton.Text = "X";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // patientIDInput
            // 
            patientIDInput.BorderStyle = BorderStyle.None;
            patientIDInput.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            patientIDInput.Location = new Point(212, 87);
            patientIDInput.Name = "patientIDInput";
            patientIDInput.Size = new Size(322, 39);
            patientIDInput.TabIndex = 16;
            // 
            // doctorInput
            // 
            doctorInput.BorderStyle = BorderStyle.None;
            doctorInput.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            doctorInput.Location = new Point(212, 153);
            doctorInput.Name = "doctorInput";
            doctorInput.ReadOnly = true;
            doctorInput.Size = new Size(322, 39);
            doctorInput.TabIndex = 17;
            // 
            // tenTime
            // 
            tenTime.AutoSize = true;
            tenTime.Location = new Point(189, 309);
            tenTime.Name = "tenTime";
            tenTime.Size = new Size(82, 29);
            tenTime.TabIndex = 18;
            tenTime.Text = "10:00";
            tenTime.UseVisualStyleBackColor = true;
            tenTime.CheckedChanged += tenTime_CheckedChanged;
            // 
            // elevenTime
            // 
            elevenTime.AutoSize = true;
            elevenTime.Location = new Point(314, 309);
            elevenTime.Name = "elevenTime";
            elevenTime.Size = new Size(82, 29);
            elevenTime.TabIndex = 19;
            elevenTime.Text = "11:00";
            elevenTime.UseVisualStyleBackColor = true;
            elevenTime.CheckedChanged += elevenTime_CheckedChanged;
            // 
            // oneTime
            // 
            oneTime.AutoSize = true;
            oneTime.Location = new Point(49, 369);
            oneTime.Name = "oneTime";
            oneTime.Size = new Size(82, 29);
            oneTime.TabIndex = 20;
            oneTime.Text = "13:00";
            oneTime.UseVisualStyleBackColor = true;
            oneTime.CheckedChanged += oneTime_CheckedChanged;
            // 
            // twelveTime
            // 
            twelveTime.AutoSize = true;
            twelveTime.Location = new Point(452, 309);
            twelveTime.Name = "twelveTime";
            twelveTime.Size = new Size(82, 29);
            twelveTime.TabIndex = 21;
            twelveTime.Text = "12:00";
            twelveTime.UseVisualStyleBackColor = true;
            twelveTime.CheckedChanged += twelveTime_CheckedChanged;
            // 
            // twoTime
            // 
            twoTime.AutoSize = true;
            twoTime.Location = new Point(189, 369);
            twoTime.Name = "twoTime";
            twoTime.Size = new Size(82, 29);
            twoTime.TabIndex = 22;
            twoTime.Text = "14:00";
            twoTime.UseVisualStyleBackColor = true;
            twoTime.CheckedChanged += twoTime_CheckedChanged;
            // 
            // threeTime
            // 
            threeTime.AutoSize = true;
            threeTime.Location = new Point(314, 369);
            threeTime.Name = "threeTime";
            threeTime.Size = new Size(82, 29);
            threeTime.TabIndex = 23;
            threeTime.Text = "15:00";
            threeTime.UseVisualStyleBackColor = true;
            threeTime.CheckedChanged += threeTime_CheckedChanged;
            // 
            // fourTime
            // 
            fourTime.AutoSize = true;
            fourTime.Location = new Point(452, 369);
            fourTime.Name = "fourTime";
            fourTime.Size = new Size(82, 29);
            fourTime.TabIndex = 24;
            fourTime.Text = "16:00";
            fourTime.UseVisualStyleBackColor = true;
            fourTime.CheckedChanged += fourTime_CheckedChanged;
            // 
            // nineTime
            // 
            nineTime.AutoSize = true;
            nineTime.Location = new Point(49, 309);
            nineTime.Name = "nineTime";
            nineTime.Size = new Size(82, 29);
            nineTime.TabIndex = 25;
            nineTime.Text = "09:00";
            nineTime.UseVisualStyleBackColor = true;
            nineTime.CheckedChanged += nineTime_CheckedChanged;
            // 
            // addButton
            // 
            addButton.BackColor = Color.FromArgb(80, 86, 95);
            addButton.FlatAppearance.BorderSize = 0;
            addButton.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            addButton.Location = new Point(413, 416);
            addButton.Name = "addButton";
            addButton.Size = new Size(146, 37);
            addButton.TabIndex = 26;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(49, 91);
            label1.Name = "label1";
            label1.Size = new Size(111, 26);
            label1.TabIndex = 27;
            label1.Text = "Patient ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(49, 157);
            label2.Name = "label2";
            label2.Size = new Size(106, 26);
            label2.TabIndex = 28;
            label2.Text = "Doctor ID:";
            // 
            // dateInput
            // 
            dateInput.BorderStyle = BorderStyle.None;
            dateInput.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateInput.Location = new Point(212, 220);
            dateInput.Name = "dateInput";
            dateInput.ReadOnly = true;
            dateInput.Size = new Size(322, 39);
            dateInput.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(49, 224);
            label3.Name = "label3";
            label3.Size = new Size(62, 26);
            label3.TabIndex = 30;
            label3.Text = "Date:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.GhostWhite;
            panel1.Location = new Point(25, 292);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 115);
            panel1.TabIndex = 31;
            // 
            // panel2
            // 
            panel2.BackColor = Color.GhostWhite;
            panel2.Location = new Point(549, 292);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 112);
            panel2.TabIndex = 32;
            // 
            // panel4
            // 
            panel4.BackColor = Color.GhostWhite;
            panel4.Location = new Point(25, 400);
            panel4.Name = "panel4";
            panel4.Size = new Size(535, 10);
            panel4.TabIndex = 33;
            // 
            // panel5
            // 
            panel5.BackColor = Color.GhostWhite;
            panel5.Location = new Point(26, 292);
            panel5.Name = "panel5";
            panel5.Size = new Size(531, 11);
            panel5.TabIndex = 34;
            // 
            // panel6
            // 
            panel6.BackColor = Color.GhostWhite;
            panel6.Location = new Point(25, 271);
            panel6.Name = "panel6";
            panel6.Size = new Size(533, 12);
            panel6.TabIndex = 35;
            // 
            // panel7
            // 
            panel7.BackColor = Color.GhostWhite;
            panel7.Location = new Point(26, 59);
            panel7.Name = "panel7";
            panel7.Size = new Size(533, 10);
            panel7.TabIndex = 36;
            // 
            // panel8
            // 
            panel8.BackColor = Color.GhostWhite;
            panel8.Location = new Point(25, 62);
            panel8.Name = "panel8";
            panel8.Size = new Size(10, 219);
            panel8.TabIndex = 32;
            // 
            // panel9
            // 
            panel9.BackColor = Color.GhostWhite;
            panel9.Location = new Point(549, 62);
            panel9.Name = "panel9";
            panel9.Size = new Size(11, 221);
            panel9.TabIndex = 33;
            // 
            // patientIDError
            // 
            patientIDError.AutoSize = true;
            patientIDError.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            patientIDError.Location = new Point(212, 129);
            patientIDError.Name = "patientIDError";
            patientIDError.Size = new Size(89, 23);
            patientIDError.TabIndex = 37;
            patientIDError.Text = "* Missing";
            // 
            // timeError
            // 
            timeError.AutoSize = true;
            timeError.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            timeError.Location = new Point(42, 413);
            timeError.Name = "timeError";
            timeError.Size = new Size(89, 23);
            timeError.TabIndex = 38;
            timeError.Text = "* Missing";
            // 
            // panel10
            // 
            panel10.BackColor = Color.GhostWhite;
            panel10.Controls.Add(RefreshButton);
            panel10.Controls.Add(appointmentTable);
            panel10.Location = new Point(572, 41);
            panel10.Name = "panel10";
            panel10.Size = new Size(469, 423);
            panel10.TabIndex = 34;
            // 
            // RefreshButton
            // 
            RefreshButton.BackColor = Color.SlateGray;
            RefreshButton.BackgroundImage = (Image)resources.GetObject("RefreshButton.BackgroundImage");
            RefreshButton.BackgroundImageLayout = ImageLayout.Zoom;
            RefreshButton.FlatAppearance.BorderSize = 0;
            RefreshButton.FlatStyle = FlatStyle.Flat;
            RefreshButton.ForeColor = Color.Black;
            RefreshButton.Image = (Image)resources.GetObject("RefreshButton.Image");
            RefreshButton.Location = new Point(420, 21);
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Size = new Size(37, 35);
            RefreshButton.TabIndex = 48;
            RefreshButton.UseVisualStyleBackColor = false;
            RefreshButton.Click += RefreshButton_Click;
            // 
            // appointmentTable
            // 
            appointmentTable.AllowUserToAddRows = false;
            appointmentTable.AllowUserToDeleteRows = false;
            appointmentTable.AllowUserToOrderColumns = true;
            appointmentTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            appointmentTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            appointmentTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            appointmentTable.BackgroundColor = Color.GhostWhite;
            appointmentTable.BorderStyle = BorderStyle.None;
            appointmentTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(80, 86, 95);
            dataGridViewCellStyle2.Font = new Font("Yu Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(80, 86, 95);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            appointmentTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            appointmentTable.ColumnHeadersHeight = 50;
            appointmentTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            appointmentTable.DefaultCellStyle = dataGridViewCellStyle3;
            appointmentTable.EnableHeadersVisualStyles = false;
            appointmentTable.GridColor = Color.White;
            appointmentTable.Location = new Point(11, 21);
            appointmentTable.MultiSelect = false;
            appointmentTable.Name = "appointmentTable";
            appointmentTable.ReadOnly = true;
            appointmentTable.RowHeadersVisible = false;
            appointmentTable.RowHeadersWidth = 62;
            appointmentTable.RowTemplate.Height = 33;
            appointmentTable.Size = new Size(400, 388);
            appointmentTable.TabIndex = 25;
            // 
            // AppointmentPopUp
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(1041, 458);
            Controls.Add(timeError);
            Controls.Add(patientIDError);
            Controls.Add(panel9);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(dateInput);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(addButton);
            Controls.Add(nineTime);
            Controls.Add(fourTime);
            Controls.Add(threeTime);
            Controls.Add(twoTime);
            Controls.Add(twelveTime);
            Controls.Add(oneTime);
            Controls.Add(elevenTime);
            Controls.Add(tenTime);
            Controls.Add(doctorInput);
            Controls.Add(patientIDInput);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel10);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AppointmentPopUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EventForm";
            Load += EventForm_Load;
            panel3.ResumeLayout(false);
            panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)appointmentTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel3;
        private Button closeButton;
        private TextBox patientIDInput;
        private TextBox doctorInput;
        private CheckBox tenTime;
        private CheckBox elevenTime;
        private CheckBox oneTime;
        private CheckBox twelveTime;
        private CheckBox twoTime;
        private CheckBox threeTime;
        private CheckBox fourTime;
        private CheckBox nineTime;
        private Button addButton;
        private Label label1;
        private Label label2;
        private TextBox dateInput;
        private Label label3;
        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private Label patientIDError;
        private Label timeError;
        private Panel panel10;
        private DataGridView appointmentTable;
        private Button RefreshButton;
    }
}