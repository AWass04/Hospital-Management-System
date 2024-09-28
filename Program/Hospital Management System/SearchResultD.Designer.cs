namespace Hospital_Management_System
{
    partial class SearchResultD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchResultD));
            label3 = new Label();
            panel3 = new Panel();
            noteTable = new DataGridView();
            BackButton = new Button();
            label2 = new Label();
            label1 = new Label();
            NoteButton = new Button();
            PrescriptionButton = new Button();
            label4 = new Label();
            panel2 = new Panel();
            IDInput = new TextBox();
            panel1 = new Panel();
            nameInput = new TextBox();
            panel4 = new Panel();
            panel5 = new Panel();
            label5 = new Label();
            DOBInput = new TextBox();
            panel6 = new Panel();
            panel7 = new Panel();
            label6 = new Label();
            RefreshButton = new Button();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)noteTable).BeginInit();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(70, 199);
            label3.Name = "label3";
            label3.Size = new Size(108, 39);
            label3.TabIndex = 28;
            label3.Text = "Notes:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(noteTable);
            panel3.Location = new Point(36, 225);
            panel3.Name = "panel3";
            panel3.Size = new Size(853, 307);
            panel3.TabIndex = 27;
            // 
            // noteTable
            // 
            noteTable.AllowUserToAddRows = false;
            noteTable.AllowUserToDeleteRows = false;
            noteTable.AllowUserToResizeColumns = false;
            noteTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            noteTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            noteTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            noteTable.BackgroundColor = Color.Snow;
            noteTable.BorderStyle = BorderStyle.None;
            noteTable.CellBorderStyle = DataGridViewCellBorderStyle.None;
            noteTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(80, 86, 95);
            dataGridViewCellStyle2.Font = new Font("Yu Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(80, 86, 95);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            noteTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            noteTable.ColumnHeadersHeight = 50;
            noteTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            noteTable.ColumnHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            noteTable.DefaultCellStyle = dataGridViewCellStyle3;
            noteTable.EnableHeadersVisualStyles = false;
            noteTable.GridColor = Color.White;
            noteTable.Location = new Point(3, 3);
            noteTable.Name = "noteTable";
            noteTable.ReadOnly = true;
            noteTable.RowHeadersVisible = false;
            noteTable.RowHeadersWidth = 62;
            noteTable.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            noteTable.RowTemplate.Height = 33;
            noteTable.Size = new Size(845, 299);
            noteTable.TabIndex = 24;
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.SlateGray;
            BackButton.FlatAppearance.BorderSize = 0;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.ForeColor = Color.Black;
            BackButton.Location = new Point(735, 42);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(154, 34);
            BackButton.TabIndex = 19;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 75);
            label2.Name = "label2";
            label2.Size = new Size(887, 25);
            label2.TabIndex = 18;
            label2.Text = "-----------------------------------------------------------------------------------------------------------------------------";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(70, 42);
            label1.Name = "label1";
            label1.Size = new Size(217, 39);
            label1.TabIndex = 17;
            label1.Text = "Patient Profile";
            // 
            // NoteButton
            // 
            NoteButton.BackColor = Color.SlateGray;
            NoteButton.FlatAppearance.BorderSize = 0;
            NoteButton.FlatStyle = FlatStyle.Flat;
            NoteButton.ForeColor = Color.Black;
            NoteButton.Location = new Point(36, 546);
            NoteButton.Name = "NoteButton";
            NoteButton.Size = new Size(154, 34);
            NoteButton.TabIndex = 37;
            NoteButton.Text = "Add Note";
            NoteButton.UseVisualStyleBackColor = false;
            NoteButton.Click += NoteButton_Click;
            // 
            // PrescriptionButton
            // 
            PrescriptionButton.BackColor = Color.SlateGray;
            PrescriptionButton.FlatAppearance.BorderSize = 0;
            PrescriptionButton.FlatStyle = FlatStyle.Flat;
            PrescriptionButton.ForeColor = Color.Black;
            PrescriptionButton.Location = new Point(520, 42);
            PrescriptionButton.Name = "PrescriptionButton";
            PrescriptionButton.Size = new Size(209, 34);
            PrescriptionButton.TabIndex = 38;
            PrescriptionButton.Text = "Create Prescription";
            PrescriptionButton.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(26, 5);
            label4.Name = "label4";
            label4.Size = new Size(33, 23);
            label4.TabIndex = 0;
            label4.Text = "ID:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(174, 70, 74);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(12, 138);
            panel2.Name = "panel2";
            panel2.Size = new Size(84, 38);
            panel2.TabIndex = 20;
            // 
            // IDInput
            // 
            IDInput.BorderStyle = BorderStyle.None;
            IDInput.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IDInput.Location = new Point(102, 137);
            IDInput.Name = "IDInput";
            IDInput.ReadOnly = true;
            IDInput.Size = new Size(168, 39);
            IDInput.TabIndex = 39;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(174, 70, 74);
            panel1.Location = new Point(102, 172);
            panel1.Name = "panel1";
            panel1.Size = new Size(168, 10);
            panel1.TabIndex = 40;
            // 
            // nameInput
            // 
            nameInput.BorderStyle = BorderStyle.None;
            nameInput.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nameInput.Location = new Point(379, 137);
            nameInput.Name = "nameInput";
            nameInput.ReadOnly = true;
            nameInput.Size = new Size(269, 39);
            nameInput.TabIndex = 42;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(174, 70, 74);
            panel4.Location = new Point(379, 172);
            panel4.Name = "panel4";
            panel4.Size = new Size(269, 10);
            panel4.TabIndex = 43;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(174, 70, 74);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(289, 138);
            panel5.Name = "panel5";
            panel5.Size = new Size(84, 38);
            panel5.TabIndex = 41;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(10, 5);
            label5.Name = "label5";
            label5.Size = new Size(64, 23);
            label5.TabIndex = 0;
            label5.Text = "Name:";
            // 
            // DOBInput
            // 
            DOBInput.BorderStyle = BorderStyle.None;
            DOBInput.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DOBInput.Location = new Point(754, 137);
            DOBInput.Name = "DOBInput";
            DOBInput.ReadOnly = true;
            DOBInput.Size = new Size(168, 39);
            DOBInput.TabIndex = 45;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(174, 70, 74);
            panel6.Location = new Point(754, 172);
            panel6.Name = "panel6";
            panel6.Size = new Size(168, 10);
            panel6.TabIndex = 46;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(174, 70, 74);
            panel7.Controls.Add(label6);
            panel7.Location = new Point(664, 138);
            panel7.Name = "panel7";
            panel7.Size = new Size(84, 38);
            panel7.TabIndex = 44;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(20, 5);
            label6.Name = "label6";
            label6.Size = new Size(53, 23);
            label6.TabIndex = 0;
            label6.Text = "DOB:";
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
            RefreshButton.Location = new Point(891, 225);
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Size = new Size(37, 35);
            RefreshButton.TabIndex = 47;
            RefreshButton.UseVisualStyleBackColor = false;
            RefreshButton.Click += RefreshButton_Click;
            // 
            // SearchResultD
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(936, 592);
            Controls.Add(RefreshButton);
            Controls.Add(label3);
            Controls.Add(DOBInput);
            Controls.Add(panel6);
            Controls.Add(panel7);
            Controls.Add(nameInput);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Controls.Add(IDInput);
            Controls.Add(panel1);
            Controls.Add(PrescriptionButton);
            Controls.Add(NoteButton);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(BackButton);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SearchResultD";
            Text = "SearchResultD";
            Load += SearchResultD_Load;
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)noteTable).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Panel panel3;
        private Button BackButton;
        private Label label2;
        private Label label1;
        private Button NoteButton;
        private Button PrescriptionButton;
        private Label label4;
        private Panel panel2;
        private TextBox IDInput;
        private Panel panel1;
        private TextBox nameInput;
        private Panel panel4;
        private Panel panel5;
        private Label label5;
        private TextBox DOBInput;
        private Panel panel6;
        private Panel panel7;
        private Label label6;
        private DataGridView noteTable;
        private Button RefreshButton;
    }
}