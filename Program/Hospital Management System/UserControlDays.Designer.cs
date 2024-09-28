namespace Hospital_Management_System
{
    partial class UserControlDays
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            daysText = new Label();
            SuspendLayout();
            // 
            // daysText
            // 
            daysText.AutoSize = true;
            daysText.Location = new Point(3, 0);
            daysText.Name = "daysText";
            daysText.Size = new Size(32, 25);
            daysText.TabIndex = 0;
            daysText.Text = "00";
            // 
            // UserControlDays
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            Controls.Add(daysText);
            Name = "UserControlDays";
            Size = new Size(124, 65);
            Load += UserControlDays_Load;
            Click += UserControlDays_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label daysText;
    }
}
