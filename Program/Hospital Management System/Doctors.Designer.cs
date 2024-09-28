namespace Hospital_Management_System
{
    partial class Doctors
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
            label9 = new Label();
            label10 = new Label();
            panel1 = new Panel();
            label7 = new Label();
            panel8 = new Panel();
            label2 = new Label();
            panel7 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            doctorTable = new DataGridView();
            panel4 = new Panel();
            panel2 = new Panel();
            panel5 = new Panel();
            panel1.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)doctorTable).BeginInit();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Yu Gothic", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(655, 65);
            label9.Name = "label9";
            label9.Size = new Size(175, 52);
            label9.TabIndex = 11;
            label9.Text = "Doctors";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(98, 103);
            label10.Name = "label10";
            label10.Size = new Size(740, 25);
            label10.TabIndex = 12;
            label10.Text = "--------------------------------------------------------------------------------------------------------";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel7);
            panel1.Location = new Point(307, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(0, 0);
            panel1.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 117);
            label7.Name = "label7";
            label7.Size = new Size(901, 25);
            label7.TabIndex = 11;
            label7.Text = "-------------------------------------------------------------------------------------------------------------------------------";
            // 
            // panel8
            // 
            panel8.BackColor = Color.DarkSeaGreen;
            panel8.Controls.Add(label2);
            panel8.Location = new Point(246, 184);
            panel8.Name = "panel8";
            panel8.Size = new Size(571, 42);
            panel8.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(272, 9);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 0;
            label2.Text = "Name:";
            // 
            // panel7
            // 
            panel7.BackColor = Color.DarkSeaGreen;
            panel7.Controls.Add(label1);
            panel7.Location = new Point(69, 184);
            panel7.Name = "panel7";
            panel7.Size = new Size(171, 42);
            panel7.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(65, 9);
            label1.Name = "label1";
            label1.Size = new Size(34, 25);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(80, 86, 95);
            panel3.Location = new Point(103, 150);
            panel3.Name = "panel3";
            panel3.Size = new Size(16, 51);
            panel3.TabIndex = 9;
            // 
            // doctorTable
            // 
            doctorTable.AllowUserToAddRows = false;
            doctorTable.AllowUserToDeleteRows = false;
            doctorTable.AllowUserToOrderColumns = true;
            doctorTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            doctorTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            doctorTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            doctorTable.BackgroundColor = Color.FromArgb(135, 165, 139);
            doctorTable.BorderStyle = BorderStyle.None;
            doctorTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(80, 86, 95);
            dataGridViewCellStyle2.Font = new Font("Yu Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(80, 86, 95);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            doctorTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            doctorTable.ColumnHeadersHeight = 50;
            doctorTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            doctorTable.DefaultCellStyle = dataGridViewCellStyle3;
            doctorTable.EnableHeadersVisualStyles = false;
            doctorTable.GridColor = Color.White;
            doctorTable.Location = new Point(9, 11);
            doctorTable.MultiSelect = false;
            doctorTable.Name = "doctorTable";
            doctorTable.ReadOnly = true;
            doctorTable.RowHeadersVisible = false;
            doctorTable.RowHeadersWidth = 62;
            doctorTable.RowTemplate.Height = 33;
            doctorTable.Size = new Size(718, 368);
            doctorTable.TabIndex = 24;
            doctorTable.CellClick += doctorTable_CellClick;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(219, 227, 223);
            panel4.Controls.Add(panel2);
            panel4.Location = new Point(98, 150);
            panel4.Name = "panel4";
            panel4.Size = new Size(740, 380);
            panel4.TabIndex = 15;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(135, 165, 139);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(doctorTable);
            panel2.Location = new Point(5, -11);
            panel2.Name = "panel2";
            panel2.Size = new Size(735, 382);
            panel2.TabIndex = 14;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(80, 86, 95);
            panel5.Location = new Point(722, 11);
            panel5.Name = "panel5";
            panel5.Size = new Size(16, 51);
            panel5.TabIndex = 10;
            // 
            // Doctors
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(936, 592);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Doctors";
            Text = "Doctors";
            Load += Doctors_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)doctorTable).EndInit();
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private Label label10;
        private Panel panel1;
        private Label label7;
        private Panel panel8;
        private Label label2;
        private Panel panel7;
        private Label label1;
        private Panel panel3;
        private DataGridView doctorTable;
        private Panel panel4;
        private Panel panel2;
        private Panel panel5;
    }
}