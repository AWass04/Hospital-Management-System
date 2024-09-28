using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Hospital_Management_System
{
    public partial class AppointmentPopUp : Form
    {
        private readonly DatabaseHelper databaseHelper;
        private List<CheckBox> checkboxes;

        public AppointmentPopUp()
        {
            InitializeComponent();

            // Connect database
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            databaseHelper = new DatabaseHelper(connectionString);

            // Hide erros
            patientIDError.Hide();
            timeError.Hide();

            checkboxes = new List<CheckBox>
            {
                // Add checkboxes to list
                nineTime,
                tenTime,
                elevenTime,
                twelveTime,
                oneTime,
                twoTime,
                threeTime,
                fourTime
            };

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ResetErrors();

            bool requiredInfo = true;
            bool validID = false;

            string appDate = dateInput.Text;
            string doctorID = doctorInput.Text;
            string time = null;
            string patientID = patientIDInput.Text;


            string[] timeList = { "9:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00" };

            // Combine checkboxes and time
            var checkboxAndTime = checkboxes.Zip(timeList, (c, t) => new { checkbox = c, timeList = t });

            // If a checkbox is checked the appropriate time is set to the time variable
            foreach (var i in checkboxAndTime)
            {
                if (i.checkbox.Checked)
                {
                    time = i.timeList;
                }
            }

            // Assigning the users input to a list and errors input to list
            string[] input = { patientID, time };
            Label[] error = { patientIDError, timeError };

            // Combine them
            var inputAndErrors = input.Zip(error, (n, w) => new { input = n, error = w });

            // For each input if they are blank, display appropriate error
            foreach (var i in inputAndErrors)
            {
                if (string.IsNullOrEmpty(i.input) || string.IsNullOrWhiteSpace(i.input))
                {
                    // Stop it from adding appointment
                    requiredInfo = false;
                    i.error.Show();
                }
            }

            // Check Patient ID is registered to a patient
            if (requiredInfo) validID = checkID(patientID);

            // If registered add appointment
            if (validID == true)
            {
                AddAppointment(doctorID, patientID, appDate, time);

                // Log appointment being added
                using (StreamWriter sw = File.AppendText(Log.filePath))
                {
                    sw.WriteLine(DateTime.Now + " " + Login.staffID + " created appointment for " + patientID + " with " + doctorID);
                }
            }

        }

        private bool checkID(string Patient_ID)
        {
            string query = "SELECT COUNT(*) FROM Patients WHERE Patient_ID = @Patient_ID";

            SQLiteParameter[] parameters =
            {
                new SQLiteParameter("@Patient_ID", Patient_ID)
            };

            // Execute the query and get the count
            int count = Convert.ToInt32(databaseHelper.ExecuteScalar(query, parameters));

            // If count is greater than 0, the ID exists in the database
            if (count > 0) return true;
            else
            {
                MessageBox.Show("Patient ID does not exist");
                return false;
            }

        }

        private void AddAppointment(string Staff_ID, string Patient_ID, string App_Date, string App_Time)
        {
            string query = "INSERT INTO Appointments (Patient_ID, Staff_ID, App_Date, App_Time) VALUES (@Patient_ID, @Staff_ID, @App_Date, @App_Time)";

            // Add to the table
            SQLiteParameter[] parameters = {
                    new SQLiteParameter("@Patient_ID", Patient_ID),
                    new SQLiteParameter("@Staff_ID", Staff_ID),
                    new SQLiteParameter("@App_Date", App_Date),
                    new SQLiteParameter("@App_Time", App_Time),
                };

            // Execute
            databaseHelper.ExecuteNonQuery(query, parameters);

            MessageBox.Show("Appointment scheduled.");

        }

        private DataTable displayAppointments(string Staff_ID, string App_Date)
        {
            DataTable dataTable = new DataTable();

            using (SQLiteConnection connection = databaseHelper.GetConnection())
            {
                // Get all appointments that match the doctor selected and the date seleceted
                string query = "SELECT App_Time AS Time, Patient_ID AS PatientID FROM Appointments WHERE Staff_ID = @Staff_ID AND App_Date = @App_Date";

                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@Staff_ID", Staff_ID);
                    adapter.SelectCommand.Parameters.AddWithValue("@App_Date", App_Date);

                    adapter.Fill(dataTable);
                }
            }
            return dataTable;
        }

        private void ResetErrors()
        {
            patientIDError.Hide();
            timeError.Hide();
        }

        private void EventForm_Load(object sender, EventArgs e)
        {
            // Display ID of the doctors schedule that was being viewed
            string doctorSelection = BookAppointment.doctorID;
            doctorInput.Text = doctorSelection;

            // Display date that was clicked on
            string date = UserControlDays.static_day + "/" + BookAppointment.static_month + "/" + BookAppointment.static_year;
            dateInput.Text = date;

            // Display already booked appointments for that doctor for that day
            DataTable appointments = displayAppointments(doctorSelection, date);
            Availability(appointments);

            appointmentTable.DataSource = appointments;
        }

        private void Availability(DataTable appointments)
        {
            // For each appointment scheduled
            foreach (DataRow row in appointments.Rows)
            {
                string appointmentTime = row["Time"].ToString();

                // Update checkboxes based on appointment time
                switch (appointmentTime)
                {
                    case "9:00":
                        nineTime.CheckState = CheckState.Indeterminate;
                        nineTime.Enabled = false;
                        break;
                    case "10:00":
                        tenTime.CheckState = CheckState.Indeterminate;
                        tenTime.Enabled = false;
                        break;
                    case "11:00":
                        elevenTime.CheckState = CheckState.Indeterminate;
                        elevenTime.Enabled = false;
                        break;
                    case "12:00":
                        twelveTime.CheckState = CheckState.Indeterminate;
                        twelveTime.Enabled = false;
                        break;
                    case "13:00":
                        oneTime.CheckState = CheckState.Indeterminate;
                        oneTime.Enabled = false;
                        break;
                    case "14:00":
                        twoTime.CheckState = CheckState.Indeterminate;
                        twoTime.Enabled = false;
                        break;
                    case "15:00":
                        threeTime.CheckState = CheckState.Indeterminate;
                        threeTime.Enabled = false;
                        break;
                    case "16:00":
                        fourTime.CheckState = CheckState.Indeterminate;
                        fourTime.Enabled = false;
                        break;
                }
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            // Reload Table
            appointmentTable.ClearSelection();

            // Display ID of the doctors schedule that was being viewed
            string doctorSelection = BookAppointment.doctorID;
            doctorInput.Text = doctorSelection;

            // Display date that was clicked on
            string date = UserControlDays.static_day + "/" + BookAppointment.static_month + "/" + BookAppointment.static_year;
            dateInput.Text = date;

            // Display already booked appointments for that doctor for that day
            DataTable appointments = displayAppointments(doctorSelection, date);
            Availability(appointments);

            appointmentTable.DataSource = appointments;
        }

        // Allow only one checkbox to be checked at a time
        private void nineTime_CheckedChanged(object sender, EventArgs e)
        {
            if (nineTime.Checked)
            {
                foreach (CheckBox checkBox in checkboxes)
                {
                    if (checkBox != nineTime && checkBox.CheckState != CheckState.Indeterminate)
                    {
                        checkBox.Checked = false;
                    }
                }
            }
        }

        private void tenTime_CheckedChanged(object sender, EventArgs e)
        {
            if (tenTime.Checked)
            {
                foreach (CheckBox checkBox in checkboxes)
                {
                    if (checkBox != tenTime && checkBox.CheckState != CheckState.Indeterminate)
                    {
                        checkBox.Checked = false;
                    }
                }
            }
        }

        private void elevenTime_CheckedChanged(object sender, EventArgs e)
        {
            if (elevenTime.Checked)
            {
                foreach (CheckBox checkBox in checkboxes)
                {
                    if (checkBox != elevenTime && checkBox.CheckState != CheckState.Indeterminate)
                    {
                        checkBox.Checked = false;
                    }
                }
            }
        }

        private void twelveTime_CheckedChanged(object sender, EventArgs e)
        {
            if (twelveTime.Checked)
            {
                foreach (CheckBox checkBox in checkboxes)
                {
                    if (checkBox != twelveTime && checkBox.CheckState != CheckState.Indeterminate)
                    {
                        checkBox.Checked = false;
                    }
                }
            }
        }

        private void oneTime_CheckedChanged(object sender, EventArgs e)
        {
            if (oneTime.Checked)
            {
                foreach (CheckBox checkBox in checkboxes)
                {
                    if (checkBox != oneTime && checkBox.CheckState != CheckState.Indeterminate)
                    {
                        checkBox.Checked = false;
                    }
                }
            }
        }

        private void twoTime_CheckedChanged(object sender, EventArgs e)
        {
            if (twoTime.Checked)
            {
                foreach (CheckBox checkBox in checkboxes)
                {
                    if (checkBox != twoTime && checkBox.CheckState != CheckState.Indeterminate)
                    {
                        checkBox.Checked = false;
                    }
                }
            }
        }

        private void threeTime_CheckedChanged(object sender, EventArgs e)
        {
            if (threeTime.Checked)
            {
                foreach (CheckBox checkBox in checkboxes)
                {
                    if (checkBox != threeTime && checkBox.CheckState != CheckState.Indeterminate)
                    {
                        checkBox.Checked = false;
                    }
                }
            }
        }

        private void fourTime_CheckedChanged(object sender, EventArgs e)
        {
            if (fourTime.Checked)
            {
                foreach (CheckBox checkBox in checkboxes)
                {
                    if (checkBox != fourTime && checkBox.CheckState != CheckState.Indeterminate)
                    {
                        checkBox.Checked = false;
                    }
                }
            }
        }

    }
}
