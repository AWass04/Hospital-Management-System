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
    public partial class CancelAppointment : Form
    {
        private readonly DatabaseHelper databaseHelper;

        string doctorID;
        public CancelAppointment()
        {
            InitializeComponent();

            // Connect database
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            databaseHelper = new DatabaseHelper(connectionString);
        }

        private void CancelAppointment_Load(object sender, EventArgs e)
        {
            FillCombobox();
            CancelButton();

        }

        private void FillCombobox()
        {
            // Clear existing items in the ComboBox
            doctorSelect.Items.Clear();

            // Get only doctors
            string query = "SELECT Staff_ID, Staff_LName FROM Staff WHERE Job_ID = 'J20'";
            DataTable dataTable = databaseHelper.ExecuteQuery(query);

            // Check if there are any results
            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    // Combine first name and last name, and add to ComboBox
                    string name = "Dr. " + $"{row["Staff_LName"]}";
                    string doctorID = $"{row["Staff_ID"]}";
                    doctorSelect.Items.Add(name + " " + doctorID);
                }
            }

        }

        private void doctorSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (doctorSelect.SelectedIndex >= 0)
            {
                // Extract the doctor's ID from the selected item
                string selectedDoctor = doctorSelect.SelectedItem.ToString();
                doctorID = selectedDoctor.Split(' ')[2];
            }

            // Display Patients
            appointmentTable.DataSource = DisplayAppointments(doctorID);


        }

        private void CancelButton()
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "";
            btn.Text = "Cancel";
            btn.Name = "btn";
            btn.UseColumnTextForButtonValue = true;
            appointmentTable.Columns.Add(btn);
        }

        private DataTable DisplayAppointments(string Staff_ID)
        {
            
             DataTable dataTable = new DataTable();

             using (SQLiteConnection connection = databaseHelper.GetConnection())
             {
                string query = "SELECT Staff_ID AS staffID, Patient_ID AS PatientID, App_Time AS Time, App_Date AS Date FROM Appointments WHERE Staff_ID = @Staff_ID";

                using SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection);
                {

                    adapter.SelectCommand.Parameters.AddWithValue("@Staff_ID", Staff_ID);
                    adapter.Fill(dataTable);
                }
             }

             return dataTable;       
        }

        private void appointmentTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Find the row
            if (e.RowIndex >= 0 && e.ColumnIndex == appointmentTable.Columns["btn"].Index)
            {
                // Confirmation
                DialogResult confirmation = MessageBox.Show("Are you sure you want to delete this appointment?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmation == DialogResult.Yes)
                {

                    string ID= (string)appointmentTable.Rows[e.RowIndex].Cells["PatientID"].Value;

                    // Delete the appointment
                    DeleteAppointment(ID);

                    MessageBox.Show("Appointment deleted.");

                    using (StreamWriter sw = File.AppendText(Log.filePath))
                    {
                        sw.WriteLine(DateTime.Now + " " + Login.staffID + " cancelled " + ID + "'s Appointment");
                    }
                }
            }
        }

        private void DeleteAppointment(string Patient_ID)
        {
            // Delete the appointment
            string query = "DELETE FROM Appointments WHERE Patient_ID = @Patient_ID";

            // Delete from the database
            SQLiteParameter[] parameters =
            {
                new SQLiteParameter("@Patient_ID", Patient_ID)
            };

            databaseHelper.ExecuteNonQuery(query, parameters);
        }
    }
}
