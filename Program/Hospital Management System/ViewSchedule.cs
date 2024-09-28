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
    public partial class ViewSchedule : Form
    {

        private readonly DatabaseHelper databaseHelper;

        public ViewSchedule()
        {
            InitializeComponent();

            // Connect database
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            databaseHelper = new DatabaseHelper(connectionString);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            scheduleTable.DataSource = null;

            string date = searchBar.Text;

            // Get person logged in
            string ID = Login.staffID;

            // Display appointments
            DataTable appointments = DisplayAppointments(ID, date);

            // Display patients
            DataTable patientsTable = new DataTable();

            // Combine patient information and appointment details
            foreach (DataGridViewRow row in scheduleTable.Rows)
            {
                if (row.DataBoundItem != null && row.DataBoundItem is DataRowView)
                {
                    string Patient_ID = $"{((DataRowView)row.DataBoundItem)["PatientID"]}";
                    DataTable patientInfoTable = PatientInfo(Patient_ID);
                    patientsTable.Merge(patientInfoTable); // Merge patient info into a single table
                }
            }

            // Merge appointments and patient info
            appointments.Merge(patientsTable);

            // Set the DataSource for the DataGridView
            scheduleTable.DataSource = appointments;

            // Adjust column width
            scheduleTable.Columns[0].FillWeight = 40;
            scheduleTable.Columns[1].FillWeight = 30;
            scheduleTable.Columns[2].FillWeight = 32;
            scheduleTable.Columns[4].FillWeight = 15;
            scheduleTable.Columns[5].FillWeight = 40;
        }

        private DataTable DisplayAppointments(string Staff_ID, string App_Date)
        {
            DataTable dataTable = new DataTable();

            using (SQLiteConnection connection = databaseHelper.GetConnection())
            {
                string query = "SELECT App_Date AS Date, App_Time AS Time, Appointments.Patient_ID AS PatientID, " +
                               "Patient_FName || COALESCE(' ' || Patient_MName, '') || ' ' || Patient_LName AS FullName, " +
                               "Patient_Sex AS Sex, Patient_DOB AS DOB " +
                               "FROM Appointments " +
                               "INNER JOIN patients ON Appointments.Patient_ID = patients.Patient_ID " +
                               "WHERE Appointments.Staff_ID = @Staff_ID AND Appointments.App_Date = @App_Date";

                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@Staff_ID", Staff_ID);
                    adapter.SelectCommand.Parameters.AddWithValue("@App_Date", App_Date);
                    adapter.Fill(dataTable);
                }
            }
            return dataTable;
        }

        private DataTable PatientInfo(string Patient_ID)
        {
            DataTable dataTable = new DataTable();

            using (SQLiteConnection connection = databaseHelper.GetConnection())
            {
                string query = "SELECT Patient_FName || COALESCE(' ' || Patient_MName, '') || ' ' || Patient_LName AS Name, " +
                               "Patient_Sex AS Sex, Patient_DOB AS DOB FROM patients WHERE Patient_ID = @Patient_ID";

                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@Patient_ID", Patient_ID);
                    adapter.Fill(dataTable);
                }
            }
            return dataTable;
        }

        private void searchBar_Click(object sender, EventArgs e)
        {
            searchBar.SelectAll();
        }
    }
}
