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

namespace Hospital_Management_System
{
    public partial class SearchResultD : Form
    {

        private readonly DatabaseHelper databaseHelper;

        ViewPatientsD viewPatientsPage;
        AddNote notePage;
        public SearchResultD()
        {
            InitializeComponent();

            // Connect Database
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            databaseHelper = new DatabaseHelper(connectionString);
        }

        private void SearchResultD_Load(object sender, EventArgs e)
        {
            object ID = ViewPatientsD.ID;
            string patientID = ID.ToString();

            DisplayPatient(patientID);

            noteTable.DataSource = DisplayNotes(patientID);
            // Change column width
            noteTable.Columns[0].FillWeight = 20;
        }

        private DataTable DisplayNotes(string Patient_ID)
        {
            DataTable dataTable = new DataTable();

            // Connect to database
            using (SQLiteConnection connection = databaseHelper.GetConnection())
            {
                string query = "SELECT Note_Date, Note FROM Notes WHERE Patient_ID = @Patient_ID";

                // Get all notes that pateint has
                using SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection);
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@Patient_ID", Patient_ID);
                    adapter.Fill(dataTable);
                }
            }
            return dataTable;
        }
        private void DisplayPatient(string Patient_ID)
        {
            // Find the patient by user ID
            string query = "SELECT * FROM Patients WHERE Patient_ID = @Patient_ID";

            SQLiteParameter[] parameters =
            {
                new SQLiteParameter("@Patient_ID", Patient_ID)
            };

            DataTable patientData = databaseHelper.ExecuteParameterizedQuery(query, parameters);

            if (patientData.Rows.Count > 0)
            {
                // First result
                DataRow patientRow = patientData.Rows[0];

                // Assign the database values to the inputs
                IDInput.Text = patientRow["Patient_ID"].ToString();
                string fName = patientRow["Patient_FName"].ToString();
                string mName = patientRow["Patient_MName"].ToString();
                string lName = patientRow["Patient_LName"].ToString();
                DOBInput.Text = patientRow["Patient_DOB"].ToString();

                if (String.IsNullOrEmpty(mName)) nameInput.Text = fName + " " + lName;
                else nameInput.Text = fName + " " + mName + " " + lName;
            }

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            // Load form
            viewPatientsPage = new();
            viewPatientsPage.MdiParent = this.MdiParent; // Display it in same location
            viewPatientsPage.Dock = DockStyle.Fill;
            viewPatientsPage.Show();

            this.Close();
        }

        private void NoteButton_Click(object sender, EventArgs e)
        {
            // Load form
            notePage = new();
            notePage.Show();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            // Reload Page
            this.Controls.Clear();
            this.InitializeComponent();

            object ID = ViewPatientsD.ID;
            string patientID = ID.ToString();

            DisplayPatient(patientID);

            noteTable.DataSource = DisplayNotes(patientID);
            // Chnage column width
            noteTable.Columns[0].FillWeight = 20;
        }
    }
}
