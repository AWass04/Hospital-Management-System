namespace Hospital_Management_System
{
    partial class CancelAppointment
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel4 = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            panel5 = new Panel();
            appointmentTable = new DataGridView();
            panel3 = new Panel();
            label8 = new Label();
            doctorSelect = new ComboBox();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)appointmentTable).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(219, 227, 223);
            panel4.Controls.Add(panel2);
            panel4.Location = new Point(103, 154);
            panel4.Name = "panel4";
            panel4.Size = new Size(740, 380);
            panel4.TabIndex = 17;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(78, 153, 156);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(appointmentTable);
            panel2.Location = new Point(5, -11);
            panel2.Name = "panel2";
            panel2.Size = new Size(735, 382);
            panel2.TabIndex = 14;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(80, 86, 95);
            panel1.Location = new Point(0, 11);
            panel1.Name = "panel1";
            panel1.Size = new Size(16, 51);
            panel1.TabIndex = 11;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(80, 86, 95);
            panel5.Location = new Point(722, 11);
            panel5.Name = "panel5";
            panel5.Size = new Size(16, 51);
            panel5.TabIndex = 10;
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
            appointmentTable.BackgroundColor = Color.FromArgb(78, 153, 156);
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
            appointmentTable.Location = new Point(9, 11);
            appointmentTable.MultiSelect = false;
            appointmentTable.Name = "appointmentTable";
            appointmentTable.ReadOnly = true;
            appointmentTable.RowHeadersVisible = false;
            appointmentTable.RowHeadersWidth = 62;
            appointmentTable.RowTemplate.Height = 33;
            appointmentTable.Size = new Size(718, 368);
            appointmentTable.TabIndex = 24;
            appointmentTable.CellContentClick += appointmentTable_CellContentClick;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SlateGray;
            panel3.Controls.Add(label8);
            panel3.Location = new Point(103, 65);
            panel3.Name = "panel3";
            panel3.Size = new Size(435, 47);
            panel3.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Yu Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(14, 10);
            label8.Name = "label8";
            label8.Size = new Size(139, 26);
            label8.TabIndex = 18;
            label8.Text = "Select doctor:";
            // 
            // doctorSelect
            // 
            doctorSelect.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            doctorSelect.FormattingEnabled = true;
            doctorSelect.Location = new Point(568, 68);
            doctorSelect.Name = "doctorSelect";
            doctorSelect.Size = new Size(275, 39);
            doctorSelect.TabIndex = 18;
            doctorSelect.SelectedIndexChanged += doctorSelect_SelectedIndexChanged;
            // 
            // CancelAppointment
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(936, 592);
            Controls.Add(doctorSelect);
            Controls.Add(panel3);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CancelAppointment";
            Text = "CancelAppointment";
            Load += CancelAppointment_Load;
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)appointmentTable).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private Panel panel2;
        private Panel panel1;
        private Panel panel5;
        private DataGridView appointmentTable;
        private Panel panel3;
        private Label label8;
        private ComboBox doctorSelect;
    }
}