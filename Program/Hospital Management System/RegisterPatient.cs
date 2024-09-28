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
    public partial class RegisterPatient : Form
    {
        private readonly DatabaseHelper databaseHelper;
        public RegisterPatient()
        {
            InitializeComponent();

            // Connect database
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            databaseHelper = new DatabaseHelper(connectionString);

            // Hide errors
            firstNameError.Hide(); lastNameError.Hide(); DOBError.Hide(); emailError.Hide(); teleNoError.Hide(); sexError.Hide();

            // Display the date as dd/mm/yyyy 
            DOBInput.Format = DateTimePickerFormat.Custom;
            DOBInput.CustomFormat = "dd/MM/yyyy";

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            ResetErrors();

            // Assigning the users inputs to variables
            string firstName = firstNameInput.Text;
            string middleName = middleNameInput.Text;
            string lastName = lastNameInput.Text;
            string sex = null;
            string DOB = DOBInput.Text;
            string email = emailInput.Text;
            string teleNo = teleNoInput.Text;

            // Male or female
            if (femaleCheckBox.Checked)
            {
                sex = "F";
            }
            else if (maleCheckBox.Checked)
            {
                sex = "M";
            }


            bool requiredInfo = true;

            // Assigning the users input to a list and errors input to list
            string[] input = { firstName, lastName, sex, DOB, teleNo, email };
            Label[] error = { firstNameError, lastNameError, sexError, DOBError, teleNoError, emailError };

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

            // Register patient
            if (requiredInfo)
            {
                // Get unique ID
                string patientID = IDCreation();

                string query = "INSERT INTO Patients (Patient_ID, Patient_FName, Patient_MName, Patient_LName, Patient_Sex, Patient_DOB, Patient_TeleNO, Patient_Email) " +
                               "VALUES (@Patient_ID, @Patient_FName, @Patient_MName, @Patient_LName, @Patient_Sex, @Patient_DOB, @Patient_TeleNO, @Patient_Email)";

                // Add to the table
                SQLiteParameter[] parameters = {
                    new SQLiteParameter("@Patient_ID", patientID),
                    new SQLiteParameter("@Patient_FName", firstName),
                    new SQLiteParameter("@Patient_MName", middleName),
                    new SQLiteParameter("@Patient_LName", lastName),
                    new SQLiteParameter("@Patient_Sex", sex),
                    new SQLiteParameter("@Patient_DOB", DOB),
                    new SQLiteParameter("@Patient_TeleNO", teleNo),
                    new SQLiteParameter("@Patient_Email", email)
                };

                // Execute
                databaseHelper.ExecuteNonQuery(query, parameters);

                using (StreamWriter sw = File.AppendText(Log.filePath))
                {
                    sw.WriteLine(DateTime.Now + " " + Login.staffID + " registered patient " + patientID);
                }
                if (string.IsNullOrEmpty(middleName) || string.IsNullOrWhiteSpace(middleName)) MessageBox.Show("New patient successfully added \n\nName: " + firstName + " " + lastName + "\nSex: " + sex + "\nDOB: " + DOB + "\nPhone No.: " + teleNo + "\nEmail: " + email);
                else MessageBox.Show("New patient successfully added \n\nName: " + firstName + " " + middleName + " " + lastName + "\nSex: " + sex + "\nDOB: " + DOB + "\nPhone No.: " + teleNo + "\nEmail: " + email);
            }

        }

        private void ResetErrors()
        {
            firstNameError.Hide(); lastNameError.Hide(); DOBError.Hide(); emailError.Hide(); teleNoError.Hide(); sexError.Hide();
        }

        private string IDCreation()
        {
            bool uniqueID = false;
            string patientID = "P";

            do
            {
                patientID = "P";

                // Create a random 5 digit number
                Random random = new Random();
                patientID += random.Next(10000, 100000);

                // check if doesn't match with any other ID's
                string query = "SELECT COUNT(*) FROM Patients WHERE Patient_ID = @patientID";

                // Use the databaseHelper to get the connection
                using (SQLiteConnection connection = databaseHelper.GetConnection())
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@patientID", patientID);

                        int count = Convert.ToInt32(command.ExecuteScalar());

                        if (count == 0)
                        {
                            uniqueID = true;
                        }
                    }
                }
            } while (uniqueID == false);

            return patientID;
        }

        private void maleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (maleCheckBox.Checked == true) femaleCheckBox.Checked = false;
        }

        private void femaleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (femaleCheckBox.Checked == true) maleCheckBox.Checked = false;
        }
    }
}
