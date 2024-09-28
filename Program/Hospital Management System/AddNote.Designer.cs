namespace Hospital_Management_System
{
    partial class AddNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNote));
            dateInput = new DateTimePicker();
            closeButton = new Button();
            panel1 = new Panel();
            noteInput = new TextBox();
            panel4 = new Panel();
            AddButton = new Button();
            label4 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            noteError = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dateInput
            // 
            dateInput.Checked = false;
            dateInput.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateInput.Location = new Point(172, 129);
            dateInput.Name = "dateInput";
            dateInput.Size = new Size(318, 46);
            dateInput.TabIndex = 0;
            // 
            // closeButton
            // 
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.Location = new Point(482, 0);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(51, 50);
            closeButton.TabIndex = 0;
            closeButton.Text = "X";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(80, 86, 95);
            panel1.Controls.Add(closeButton);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(536, 50);
            panel1.TabIndex = 4;
            // 
            // noteInput
            // 
            noteInput.BorderStyle = BorderStyle.None;
            noteInput.Font = new Font("Yu Gothic", 13F, FontStyle.Regular, GraphicsUnit.Point);
            noteInput.Location = new Point(172, 220);
            noteInput.Name = "noteInput";
            noteInput.Size = new Size(318, 42);
            noteInput.TabIndex = 18;
            // 
            // panel4
            // 
            panel4.BackColor = Color.SlateGray;
            panel4.Location = new Point(172, 258);
            panel4.Name = "panel4";
            panel4.Size = new Size(318, 10);
            panel4.TabIndex = 19;
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.SlateGray;
            AddButton.FlatAppearance.BorderSize = 0;
            AddButton.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AddButton.Location = new Point(342, 348);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(148, 41);
            AddButton.TabIndex = 17;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(69, 141);
            label4.Name = "label4";
            label4.Size = new Size(67, 29);
            label4.TabIndex = 20;
            label4.Text = "Date:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(69, 224);
            label1.Name = "label1";
            label1.Size = new Size(67, 29);
            label1.TabIndex = 21;
            label1.Text = "Note:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(23, 134);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 41);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(23, 220);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 41);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            // 
            // noteError
            // 
            noteError.AutoSize = true;
            noteError.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            noteError.Location = new Point(172, 271);
            noteError.Name = "noteError";
            noteError.Size = new Size(98, 23);
            noteError.TabIndex = 24;
            noteError.Text = "* Required";
            // 
            // AddNote
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(536, 436);
            Controls.Add(noteError);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(noteInput);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(dateInput);
            Controls.Add(AddButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddNote";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddNote";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateInput;
        private Button closeButton;
        private Panel panel1;
        private TextBox noteInput;
        private Panel panel4;
        private Button AddButton;
        private Label label4;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label noteError;
    }
}