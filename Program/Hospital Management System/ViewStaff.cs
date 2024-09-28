using Dapper;
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

namespace Hospital_Management_System
{
    public partial class ViewStaff : Form
    {
        private readonly DatabaseHelper databaseHelper;

        string jobChange;
        bool deleted = false;
        public ViewStaff()
        {
            InitializeComponent();

            // Connect database
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            databaseHelper = new DatabaseHelper(connectionString);
        }

        bool expand = false;
        private void dropDownTimer_Tick(object sender, EventArgs e)
        {
            if (expand == false)
            {
                jobDropdown.Height += 15;
                if (jobDropdown.Height >= jobDropdown.MaximumSize.Height)
                {
                    dropDownTimer.Stop();
                    expand = true;
                }
            }
            else
            {
                jobDropdown.Height -= 15;
                if (jobDropdown.Height <= jobDropdown.MinimumSize.Height)
                {
                    dropDownTimer.Stop();
                    expand = false;
                }
            }
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            dropDownTimer.Start();
        }

        private void ViewStaff_Load(object sender, EventArgs e)
        {
            string staffID = GetID();

            DisplayStaff(staffID);

        }

        private void DisplayStaff(string Staff_ID)
        {
            // Find the patient by user ID
            string query = "SELECT * FROM Staff WHERE Staff_ID = @Staff_ID";
            SQLiteParameter[] parameters =
            {
                new SQLiteParameter("@Staff_ID", Staff_ID)
            };

            DataTable dataTable = databaseHelper.ExecuteParameterizedQuery(query, parameters);

            if (dataTable.Rows.Count > 0)
            {
                // First result
                DataRow row = dataTable.Rows[0];

                // Assign the database values to the inputs
                IDInput.Text = row["Staff_ID"].ToString();
                fNameInput.Text = row["Staff_FName"].ToString();
                mNameInput.Text = row["Staff_MName"].ToString();
                lNameInput.Text = row["Staff_LName"].ToString();
                string job = row["Job_ID"].ToString();

                switch (job)
                {
                    case "J10":
                        jobRoleInput.Text = "Admin";
                        break;
                    case "J15":
                        jobRoleInput.Text = "Receptionist";
                        break;
                    case "J20":
                        jobRoleInput.Text = "Doctor";
                        break;
                }

            }

        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            jobChange = "J10";

        }

        private void DoctorButton_Click(object sender, EventArgs e)
        {
            jobChange = "J20";
        }

        private void ReceptionistButton_Click(object sender, EventArgs e)
        {
            jobChange = "J15";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            bool selectionCheck = true;
            bool appointmentsCheck = true;
            string staffID = GetID();

            // If blank do not let it update
            if (string.IsNullOrEmpty(jobChange)) selectionCheck = false;

            // Check for appointments only if there is a job change
            if (selectionCheck)
            {
                appointmentsCheck = checkAppointments(staffID);

                // If job has been changed, employee hasn't been deleted, and no appointments
                if (!appointmentsCheck && !deleted)
                {
                    ChangeJob(staffID, jobChange);

                    // Log change
                    using (StreamWriter sw = File.AppendText(Log.filePath))
                    {
                        sw.WriteLine(DateTime.Now + " " + Login.staffID + " changed " + staffID + " job role.");
                    }
                }
            }
        }

        private bool checkAppointments(string Staff_ID)
        {
            string query = "SELECT COUNT(*) FROM Appointments WHERE Staff_ID = @Staff_ID";

            SQLiteParameter[] parameters =
            {
                new SQLiteParameter("@Staff_ID", Staff_ID)
            };

            // Execute the query and get the count
            int count = Convert.ToInt32(databaseHelper.ExecuteScalar(query, parameters));


            // If count is greater than 0, there is appointments assigned to doctor
            if (count > 0)
            {
                MessageBox.Show("Doctor has appointments scheduled, Reassign appointments before continuing");
                return true;
            }
            else return false;

        }

        private void ChangeJob(string Staff_ID, string Job_ID)
        {
            // Update the staff members job
            string query = "UPDATE Staff SET Job_ID = @Job_ID WHERE Staff_ID = @Staff_ID";

            // Update the database
            SQLiteParameter[] parameters =
            {
                new SQLiteParameter("@Staff_ID", Staff_ID),
                new SQLiteParameter("@Job_ID", Job_ID),

            };

            databaseHelper.ExecuteNonQuery(query, parameters);

            MessageBox.Show(fNameInput.Text + "'s job has been changed.");

        }

        private string GetID()
        {
            object ID = null;

            // Find which form brought the user to this form
            ID = Admin.ID;
            if (ID == null || ID == "") ID = Doctors.ID;
            if (ID == null || ID == "") ID = Receptionists.ID;

            string staffID = ID.ToString();
            return staffID;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string staffID = GetID();
            bool appointmentsCheck = checkAppointments(staffID);

            if (appointmentsCheck == false)
            {
                // Confirmation
                DialogResult confirmation = MessageBox.Show("Are you sure you want to delete this staff member?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmation == DialogResult.Yes)
                {
                    // Delete the staff member
                    DeleteStaff(staffID);

                    // Clear textboxes
                    ClearInputs();
                }
            }
        }

        private void DeleteStaff(string Staff_ID)
        {
            // Delete the staff member
            string query = "DELETE FROM Staff WHERE Staff_ID = @Staff_ID";

            // Delete from the database
            SQLiteParameter[] parameters =
            {
                new SQLiteParameter("@Staff_ID", Staff_ID)
            };

            databaseHelper.ExecuteNonQuery(query, parameters);

            MessageBox.Show("Staff member has been deleted.");
        }

        private void ClearInputs()
        {
            // clear all textboxes
            IDInput.Text = "";
            fNameInput.Text = "";
            mNameInput.Text = "";
            lNameInput.Text = "";
            jobRoleInput.Text = "";
        }
    }
}
