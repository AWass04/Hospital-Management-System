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
    public partial class ViewPatientsD : Form
    {
        private readonly DatabaseHelper databaseHelper;

        public static object ID = "";
        SearchResultD patientProfile;

        public ViewPatientsD()
        {
            InitializeComponent();

            // Connect database
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            databaseHelper = new DatabaseHelper(connectionString);
        }

        private void ViewPatientsD_Load(object sender, EventArgs e)
        {
            // Display Patients
            patientTable.DataSource = DisplayPatients();

            // Display view buttom
            ViewButton();

            // Change column wdith
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
            // Find the column
            if (e.RowIndex >= 0 && e.ColumnIndex == patientTable.Columns["btn"].Index)
            {
                // Get ID
                ID = patientTable.Rows[e.RowIndex].Cells["ID"].Value;

                // Open patient profile
                patientProfile = new SearchResultD();
                patientProfile.MdiParent = this.MdiParent; // Display it in same location
                patientProfile.Dock = DockStyle.Fill;
                patientProfile.Show();

            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string lastName = searchBar.Text;

            if (!string.IsNullOrEmpty(lastName) && !string.IsNullOrWhiteSpace(lastName))
            {
                // Clear patient table
                patientTable.DataSource = null;
                // Display patients matching search result
                patientTable.DataSource = SearchResult(lastName);

                // Change column width
                patientTable.Columns[0].FillWeight = 30;
                patientTable.Columns[1].FillWeight = 30;
                patientTable.Columns[3].FillWeight = 30;
                patientTable.Columns[4].FillWeight = 35;
            }
        }

        private DataTable SearchResult(string Patient_LName)
        {
            DataTable dataTable = new DataTable();

            // Connect 
            using (SQLiteConnection connection = databaseHelper.GetConnection())
            {
                string query = "SELECT Patient_ID AS ID, Patient_FName || COALESCE(' ' || Patient_MName, '') || ' ' || Patient_LName AS Name, Patient_Sex AS Sex, Patient_DOB AS DOB FROM patients WHERE Patient_LName = @Patient_LName";

                // Display patients that have a matching mast name 
                using SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection);
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@Patient_LName", Patient_LName);
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
