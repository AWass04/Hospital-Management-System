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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Security.Cryptography;

namespace Hospital_Management_System
{
    public partial class CreateEmployee : Form
    {
        private readonly DatabaseHelper databaseHelper;
        public CreateEmployee()
        {
            InitializeComponent();

            // Connect database
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            databaseHelper = new DatabaseHelper(connectionString);

            firstNameError.Hide();
            lastNameError.Hide();
            jobRoleError.Hide();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            ResetErrors();

            // Assigning the users inputs to variables
            string fName = fNameInput.Text;
            string mName = mNameInput.Text;
            string lName = lNameInput.Text;
            string jobRole = null;

            // Setting the variable depending on which checkbox is checked
            if (adminCheckBox.Checked) jobRole = "J10";
            else if (doctorCheckBox.Checked) jobRole = "J20";
            else if (receptionistCheckBox.Checked) jobRole = "J15";

            bool requiredInfo = true;

            // Assigning the users input to a list and errors input to list
            string[] input = { fName, lName, jobRole};
            Label[] error = { firstNameError, lastNameError, jobRoleError };

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
                // Create an ID
                string ID = IDCreation();

                // Create a password
                string password = PasswordCreation(ID, lName);

                password = Encrypt(password);

                // Add employee
                AddEmployee(ID,fName,mName,lName,password,jobRole);

                // Add to log
                using (StreamWriter sw = File.AppendText(Log.filePath))
                {
                    sw.WriteLine(DateTime.Now + " " + Login.staffID + " created account " + ID);
                }
            }

        }

        private string PasswordCreation(string Staff_ID, string Staff_LName)
        {
            // Create a password using last name and their ID
            Staff_ID = Staff_ID.Remove(0, 1);
            string password = Staff_LName + Staff_ID;

            // Show the user the temporary password so they can log in and change it
            MessageBox.Show("Employee successfully added \n\nTemporary Password: " + password);

            return password;
        }

        // Given by Zairul 
        private string Encrypt(string password)
        {
            using (var md5Hash = MD5.Create())
            {
                // Byte array representation of source string
                var sourceBytes = Encoding.UTF8.GetBytes(password);

                // Generate hash value(Byte Array) for input data
                var hashBytes = md5Hash.ComputeHash(sourceBytes);

                // Convert hash byte array to string
                var hash = BitConverter.ToString(hashBytes).Replace("-", string.Empty);

                return hash;
            }
        }
        private string IDCreation()
        {
            bool uniqueID = false;
            string staffID = "H";

            do
            {
                staffID = "H";

                // Create a random 4 digit number
                Random random = new Random();
                staffID += random.Next(1000, 10000);

                // check if doesn't match with any other ID's
                string query = "SELECT COUNT(*) FROM Staff WHERE Staff_ID = @Staff_ID";

                // Use the databaseHelper to get the connection
                using (SQLiteConnection connection = databaseHelper.GetConnection())
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Staff_ID", staffID);

                        int count = Convert.ToInt32(command.ExecuteScalar());

                        if (count == 0)
                        {
                            uniqueID = true;
                        }
                    }
                }
            } while (uniqueID == false);

            return staffID;

        }

        private void AddEmployee(string Staff_ID, string Staff_FName, string Staff_MName, string staff_LName, string Password, string Job_ID)
        {
            string query = "INSERT INTO Staff (Staff_ID, Staff_FName, Staff_MName, staff_LName, Password, Job_ID) " +
                               "VALUES (@Staff_ID, @Staff_FName, @Staff_MName, @staff_LName, @Password, @Job_ID)";

            // Add to the table
            SQLiteParameter[] parameters = {
                    new SQLiteParameter("@Staff_ID", Staff_ID),
                    new SQLiteParameter("@Staff_FName", Staff_FName),
                    new SQLiteParameter("@Staff_MName", Staff_MName),
                    new SQLiteParameter("@staff_LName", staff_LName),
                    new SQLiteParameter("@Password", Password),
                    new SQLiteParameter("@Job_ID", Job_ID)
                };

            // Execute
            databaseHelper.ExecuteNonQuery(query, parameters);

        }

        private void adminCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (adminCheckBox.Checked)
            {
                receptionistCheckBox.Checked = false;
                doctorCheckBox.Checked = false;
            }
        }

        private void doctorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (doctorCheckBox.Checked)
            {
                adminCheckBox.Checked = false;
                receptionistCheckBox.Checked = false;

            }

        }

        private void receptionistCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (receptionistCheckBox.Checked)
            {
                adminCheckBox.Checked = false;
                doctorCheckBox.Checked = false;

            }
        }

        private void ResetErrors()
        {
            firstNameError.Hide();
            lastNameError.Hide();
            jobRoleError.Hide();
        }

    }
}
