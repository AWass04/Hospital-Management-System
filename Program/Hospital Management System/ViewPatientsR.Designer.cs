namespace Hospital_Management_System
{
    partial class ViewPatientsR
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
            patientTable = new DataGridView();
            panel3 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            searchButton = new Button();
            searchBar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)patientTable).BeginInit();
            SuspendLayout();
            // 
            // patientTable
            // 
            patientTable.AllowUserToAddRows = false;
            patientTable.AllowUserToDeleteRows = false;
            patientTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            patientTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            patientTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            patientTable.BackgroundColor = Color.FromArgb(78, 153, 156);
            patientTable.BorderStyle = BorderStyle.None;
            patientTable.CellBorderStyle = DataGridViewCellBorderStyle.None;
            patientTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(80, 86, 95);
            dataGridViewCellStyle2.Font = new Font("Yu Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(80, 86, 95);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            patientTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            patientTable.ColumnHeadersHeight = 50;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            patientTable.DefaultCellStyle = dataGridViewCellStyle3;
            patientTable.EnableHeadersVisualStyles = false;
            patientTable.GridColor = Color.White;
            patientTable.Location = new Point(110, 147);
            patientTable.Name = "patientTable";
            patientTable.ReadOnly = true;
            patientTable.RowHeadersVisible = false;
            patientTable.RowHeadersWidth = 62;
            patientTable.RowTemplate.Height = 33;
            patientTable.Size = new Size(719, 363);
            patientTable.TabIndex = 29;
            patientTable.CellClick += patientTable_CellClick;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(80, 86, 95);
            panel3.Location = new Point(103, 147);
            panel3.Name = "panel3";
            panel3.Size = new Size(735, 51);
            panel3.TabIndex = 28;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(78, 153, 156);
            panel2.Location = new Point(103, 147);
            panel2.Name = "panel2";
            panel2.Size = new Size(734, 375);
            panel2.TabIndex = 30;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(219, 227, 223);
            panel4.Location = new Point(98, 158);
            panel4.Name = "panel4";
            panel4.Size = new Size(732, 369);
            panel4.TabIndex = 31;
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.SlateGray;
            searchButton.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            searchButton.Location = new Point(647, 65);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(191, 36);
            searchButton.TabIndex = 27;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click_1;
            // 
            // searchBar
            // 
            searchBar.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            searchBar.Location = new Point(98, 65);
            searchBar.Name = "searchBar";
            searchBar.Size = new Size(543, 36);
            searchBar.TabIndex = 26;
            searchBar.Text = "Enter Last Name";
            searchBar.Click += searchBar_Click_1;
            // 
            // ViewPatientsR
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(936, 592);
            Controls.Add(patientTable);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(searchButton);
            Controls.Add(searchBar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewPatientsR";
            Text = "View Patient";
            Load += ViewPatientsR_Load;
            ((System.ComponentModel.ISupportInitialize)patientTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView patientTable;
        private Panel panel3;
        private Panel panel2;
        private Panel panel4;
        private Button searchButton;
        private TextBox searchBar;
    }
}