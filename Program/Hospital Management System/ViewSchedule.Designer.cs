namespace Hospital_Management_System
{
    partial class ViewSchedule
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
            searchButton = new Button();
            searchBar = new TextBox();
            scheduleTable = new DataGridView();
            panel3 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            ((System.ComponentModel.ISupportInitialize)scheduleTable).BeginInit();
            SuspendLayout();
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.SlateGray;
            searchButton.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            searchButton.Location = new Point(652, 84);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(191, 36);
            searchButton.TabIndex = 6;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // searchBar
            // 
            searchBar.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            searchBar.Location = new Point(103, 84);
            searchBar.Name = "searchBar";
            searchBar.Size = new Size(543, 36);
            searchBar.TabIndex = 5;
            searchBar.Text = "Enter Date";
            searchBar.Click += searchBar_Click;
            // 
            // scheduleTable
            // 
            scheduleTable.AllowUserToAddRows = false;
            scheduleTable.AllowUserToDeleteRows = false;
            scheduleTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            scheduleTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            scheduleTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            scheduleTable.BackgroundColor = Color.FromArgb(174, 70, 74);
            scheduleTable.BorderStyle = BorderStyle.None;
            scheduleTable.CellBorderStyle = DataGridViewCellBorderStyle.None;
            scheduleTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(80, 86, 95);
            dataGridViewCellStyle2.Font = new Font("Yu Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(80, 86, 95);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            scheduleTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            scheduleTable.ColumnHeadersHeight = 50;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            scheduleTable.DefaultCellStyle = dataGridViewCellStyle3;
            scheduleTable.EnableHeadersVisualStyles = false;
            scheduleTable.GridColor = Color.White;
            scheduleTable.Location = new Point(115, 166);
            scheduleTable.Name = "scheduleTable";
            scheduleTable.RowHeadersVisible = false;
            scheduleTable.RowHeadersWidth = 62;
            scheduleTable.RowTemplate.Height = 33;
            scheduleTable.Size = new Size(719, 363);
            scheduleTable.TabIndex = 17;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(80, 86, 95);
            panel3.Location = new Point(108, 166);
            panel3.Name = "panel3";
            panel3.Size = new Size(735, 51);
            panel3.TabIndex = 16;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(174, 70, 74);
            panel2.Location = new Point(108, 166);
            panel2.Name = "panel2";
            panel2.Size = new Size(734, 375);
            panel2.TabIndex = 18;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(219, 227, 223);
            panel4.Location = new Point(103, 177);
            panel4.Name = "panel4";
            panel4.Size = new Size(732, 369);
            panel4.TabIndex = 19;
            // 
            // ViewSchedule
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(936, 592);
            Controls.Add(scheduleTable);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(searchButton);
            Controls.Add(searchBar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewSchedule";
            Text = "ViewSchedule";
            ((System.ComponentModel.ISupportInitialize)scheduleTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox searchBar;
        private Button searchButton;
        private DataGridView scheduleTable;
        private Panel panel3;
        private Panel panel2;
        private Panel panel4;
    }
}