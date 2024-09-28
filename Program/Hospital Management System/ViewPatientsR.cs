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
using System.Collections;

namespace Hospital_Management_System
{
    public partial class ViewPatientsR : Form
    {

        SearchResultR patientProfile;

        private readonly DatabaseHelper databaseHelper;

        public static object ID = "";


        public ViewPatientsR()
        {
            InitializeComponent();

            // Connect database
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            databaseHelper = new DatabaseHelper(connectionString);

        }

        private void ViewPatientsR_Load(object sender, EventArgs e)
        {
            // Display Patients
            patientTable.DataSource = DisplayPatients();

            // Display view buttom
            ViewButton();

            // Chnage column width
            patientTable.Columns[0].FillWeight = 20;
            patientTable.Columns[2].FillWeight = 10;
            patientTable.Columns[3].FillWeight = 30;
            patientTable.Columns[4].FillWeight = 20;
        }

        private DataTable DisplayPatients()
        {
            DataTable dataTable = new DataTable();

            using (SQLiteConnection connection = databaseHelper.GetConnection())
            {
                // Display all patients
                string query = "SELECT Patient_ID AS ID, Patient_FName || COALESCE(' ' || Patient_MName, '') || ' ' || Patient_LName AS Name, Patient_Sex AS Sex, Patient_DOB AS DOB FROM patients";

                using SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection);
                {
                    adapter.Fill(dataTable);
                }
            }
            return dataTable;
        }

        private void ViewButton()
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Profile";
            btn.Text = "View";
            btn.Name = "btn";
            btn.UseColumnTextForButtonValue = true;
            patientTable.Columns.Add(btn);
        }

        private void patientTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Find the row
            if (e.RowIndex >= 0 && e.ColumnIndex == patientTable.Columns["btn"].Index)
            {
                // Get ID
                ID = patientTable.Rows[e.RowIndex].Cells["ID"].Value;

                // Open patient profile
                patientProfile = new SearchResultR();
                patientProfile.MdiParent = this.MdiParent; // Display it in same location
                patientProfile.Dock = DockStyle.Fill;
                patientProfile.Show();
            }
        }

        private DataTable SearchResult(string Patient_LName)
        {
            DataTable dataTable = new DataTable();

            using (SQLiteConnection connection = databaseHelper.GetConnection())
            {
                string query = "SELECT Patient_ID AS ID, Patient_FName || COALESCE(' ' || Patient_MName, '') || ' ' || Patient_LName AS Name, Patient_Sex AS Sex, Patient_DOB AS DOB FROM patients WHERE Patient_LName = @Patient_LName";

                // Display patients with matching last name
                using SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection);
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@Patient_LName", Patient_LName);
                    adapter.Fill(dataTable);
                }
            }
            return dataTable;

        }

        private void searchBar_Click_1(object sender, EventArgs e)
        {
            searchBar.SelectAll();
        }

        private void searchButton_Click_1(object sender, EventArgs e)
        {

            string lastName = searchBar.Text;

            if (!string.IsNullOrEmpty(lastName) && !string.IsNullOrWhiteSpace(lastName))
            {
                // clear patient table
                patientTable.DataSource = null;
                // Display search results
                patientTable.DataSource = SearchResult(lastName);

                // Adjust column width
                patientTable.Columns[0].FillWeight = 30;
                patientTable.Columns[1].FillWeight = 30;
                patientTable.Columns[3].FillWeight = 30;
                patientTable.Columns[4].FillWeight = 35;
            }
        }
    }
}
