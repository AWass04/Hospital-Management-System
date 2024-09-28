namespace Hospital_Management_System
{
    partial class Admin
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
            panel2 = new Panel();
            adminTable = new DataGridView();
            panel4 = new Panel();
            panel5 = new Panel();
            panel1.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)adminTable).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Yu Gothic", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(692, 63);
            label9.Name = "label9";
            label9.Size = new Size(146, 52);
            label9.TabIndex = 18;
            label9.Text = "Admin";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(98, 102);
            label10.Name = "label10";
            label10.Size = new Size(740, 25);
            label10.TabIndex = 19;
            label10.Text = "--------------------------------------------------------------------------------------------------------";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel7);
            panel1.Location = new Point(307, 79);
            panel1.Name = "panel1";
            panel1.Size = new Size(0, 0);
            panel1.TabIndex = 17;
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
            panel3.Location = new Point(103, 149);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 51);
            panel3.TabIndex = 16;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(135, 165, 139);
            panel2.Controls.Add(adminTable);
            panel2.Location = new Point(103, 149);
            panel2.Name = "panel2";
            panel2.Size = new Size(734, 375);
            panel2.TabIndex = 21;
            // 
            // adminTable
            // 
            adminTable.AllowUserToAddRows = false;
            adminTable.AllowUserToDeleteRows = false;
            adminTable.AllowUserToOrderColumns = true;
            adminTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            adminTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            adminTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            adminTable.BackgroundColor = Color.FromArgb(135, 165, 139);
            adminTable.BorderStyle = BorderStyle.None;
            adminTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(80, 86, 95);
            dataGridViewCellStyle2.Font = new Font("Yu Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(80, 86, 95);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            adminTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            adminTable.ColumnHeadersHeight = 50;
            adminTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            adminTable.DefaultCellStyle = dataGridViewCellStyle3;
            adminTable.EnableHeadersVisualStyles = false;
            adminTable.GridColor = Color.White;
            adminTable.Location = new Point(8, 0);
            adminTable.MultiSelect = false;
            adminTable.Name = "adminTable";
            adminTable.ReadOnly = true;
            adminTable.RowHeadersVisible = false;
            adminTable.RowHeadersWidth = 62;
            adminTable.RowTemplate.Height = 33;
            adminTable.Size = new Size(716, 368);
            adminTable.TabIndex = 25;
            adminTable.CellClick += adminTable_CellClick;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(219, 227, 223);
            panel4.Location = new Point(98, 160);
            panel4.Name = "panel4";
            panel4.Size = new Size(732, 369);
            panel4.TabIndex = 22;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(80, 86, 95);
            panel5.Location = new Point(825, 149);
            panel5.Name = "panel5";
            panel5.Size = new Size(12, 51);
            panel5.TabIndex = 17;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(936, 592);
            Controls.Add(panel5);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Admin";
            Text = "Admin";
            Load += Admin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)adminTable).EndInit();
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
        private Panel panel2;
        private Panel panel4;
        private DataGridView adminTable;
        private Panel panel5;
    }
}