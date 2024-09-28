using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Hospital_Management_System
{
    public partial class AddNote : Form
    {
        private readonly DatabaseHelper databaseHelper;
        public AddNote()
        {
            InitializeComponent();

            // Connect Database
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            databaseHelper = new DatabaseHelper(connectionString);

            // Hide errors
            noteError.Hide();

            // Display the date as dd/mm/yyyy 
            dateInput.Format = DateTimePickerFormat.Custom;
            dateInput.CustomFormat = "dd/MM/yyyy";
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            resetErrors();

            bool requiredInfo = true;

            // If there is no note, fail to add
            if (String.IsNullOrEmpty(noteInput.Text))
            {
                requiredInfo = false;
                noteError.Show();
            }

            if (requiredInfo)
            {
                // Get patient ID
                string patientID = ViewPatientsD.ID.ToString();

                // Get the doctor that is logged in
                string staffID = Login.staffID;

                // Add note
                NoteAdd(patientID, staffID, dateInput.Text, noteInput.Text);

                // Log note being added
                using (StreamWriter sw = File.AppendText(Log.filePath))
                {
                    sw.WriteLine(DateTime.Now + " " + Login.staffID + " added note to " + patientID + "'s record");
                }
            }

        }

        private void NoteAdd(string Patient_ID, string Staff_ID, string Note_Date, string Note)
        {
            string query = "INSERT INTO Notes (Patient_ID, Staff_ID, Note_Date, Note) VALUES (@Patient_ID, @Staff_ID, @Note_Date, @Note)";

            // Add to the table
            SQLiteParameter[] parameters =
            {
                    new SQLiteParameter("@Patient_ID", Patient_ID),
                    new SQLiteParameter("@Staff_ID", Staff_ID),
                    new SQLiteParameter("@Note_Date", Note_Date),
                    new SQLiteParameter("@Note", Note),
            };

            // Execute
            databaseHelper.ExecuteNonQuery(query, parameters);

            MessageBox.Show("Note successfully added to record");
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resetErrors()
        {
            noteError.Hide();
        }
    }
}
