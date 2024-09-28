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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hospital_Management_System
{

    public partial class SearchResultR : Form
    {
        private readonly DatabaseHelper databaseHelper;

        ViewPatientsR viewPatientsPage;

        public SearchResultR()
        {
            InitializeComponent();

            // Connect Database
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            databaseHelper = new DatabaseHelper(connectionString);

            // Hide errors
            firstNameError.Hide(); lastNameError.Hide(); emailError.Hide(); teleNoError.Hide();
        }

        private void SaveButton_Click_1(object sender, EventArgs e)
        {
            resetErrors();

            string ID = IDInput.Text;
            string DOB = DOBInput.Text;
            string sex = sexInput.Text;
            string fName = firstNameInput.Text;
            string mName = middleNameInput.Text;
            string lName = lastNameInput.Text;
            string teleNO = teleNoInput.Text;
            string email = emailInput.Text;

            bool requiredInfo = true;

            // Assigning the users input to a list and errors input to list
            string[] input = { fName, lName, teleNO, email };
            Label[] error = { firstNameError, lastNameError, teleNoError, emailError };

            // Combine them
            var inputAndErrors = input.Zip(error, (n, w) => new { input = n, error = w });

            // For each input if they are blank, display appropriate error
            foreach (var i in inputAndErrors)
            {
                if (string.IsNullOrEmpty(i.input) || string.IsNullOrWhiteSpace(i.input))
                {
                    // Stop it from registering patient
                    requiredInfo = false;
                    i.error.Show();
                }
            }

            if (requiredInfo)
            {
                UpdatePatient(ID, fName, mName, lName, sex, DOB, teleNO, email);

                // Log update
                using (StreamWriter sw = File.AppendText(Log.filePath))
                {
                    sw.WriteLine(DateTime.Now + " " + Login.staffID + " changed " + ID + "'s details");
                }
            }
        }

        private void SearchResult_Load(object sender, EventArgs e)
        {
            object ID = ViewPatientsR.ID;
            string patientID = ID.ToString();

            DisplayPatient(patientID);
        }

        private void DisplayPatient(string patientID)
        {
            // Find the patient by user ID
            string query = "SELECT * FROM Patients WHERE Patient_ID = @Patient_ID";

            SQLiteParameter[] parameters =
            {
                new SQLiteParameter("@Patient_ID", patientID)
            };

            DataTable patientData = databaseHelper.ExecuteParameterizedQuery(query, parameters);

            if (patientData.Rows.Count > 0)
            {
                // First result
                DataRow patientRow = patientData.Rows[0];

                // Assign the database values to the inputs
                IDInput.Text = patientRow["Patient_ID"].ToString();
                firstNameInput.Text = patientRow["Patient_FName"].ToString();
                middleNameInput.Text = patientRow["Patient_MName"].ToString();
                lastNameInput.Text = patientRow["Patient_LName"].ToString();
                sexInput.Text = patientRow["Patient_Sex"].ToString();
                DOBInput.Text = patientRow["Patient_DOB"].ToString();
                string teleNo = "0" + patientRow["Patient_TeleNO"].ToString();
                teleNoInput.Text = teleNo;
                emailInput.Text = patientRow["Patient_Email"].ToString();
            }

        }

        private void UpdatePatient(string patientID, string firstName, string middleName, string lastName, string sex, string DOB, string phoneNo, string email)
        {
            // Update the patient with the specified patient ID
            string query = "UPDATE Patients SET Patient_FName = @FirstName, Patient_MName = @MiddleName, Patient_LName = @LastName, Patient_Sex = @Sex, Patient_DOB = @DOB, Patient_TeleNO = @PhoneNo, Patient_Email = @Email WHERE Patient_ID = @Patient_ID";

            // Update the database
            SQLiteParameter[] parameters =
            {
                new SQLiteParameter("@Patient_ID", patientID),
                new SQLiteParameter("@FirstName", firstName),
                new SQLiteParameter("@MiddleName", middleName),
                new SQLiteParameter("@LastName", lastName),
                new SQLiteParameter("@Sex", sex),
                new SQLiteParameter("@DOB", DOB),
                new SQLiteParameter("@PhoneNo", phoneNo),
                new SQLiteParameter("@Email", email)
            };

            databaseHelper.ExecuteNonQuery(query, parameters);

            MessageBox.Show("Changes have been saved");
        }

        private void BackButton_Click_1(object sender, EventArgs e)
        {
            // Load form
            viewPatientsPage = new();
            viewPatientsPage.MdiParent = this.MdiParent; // Display it in same location
            viewPatientsPage.Dock = DockStyle.Fill;
            viewPatientsPage.Show();

            this.Close();
        }

        private void resetErrors()
        {
            firstNameError.Hide(); lastNameError.Hide(); emailError.Hide(); teleNoError.Hide();
        }
    }
}
