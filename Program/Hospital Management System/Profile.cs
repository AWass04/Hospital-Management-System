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
using System.Security.Cryptography;

namespace Hospital_Management_System
{
    public partial class Profile : Form
    {
        private readonly DatabaseHelper databaseHelper;
        public Profile()
        {
            InitializeComponent();

            // Connect database
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            databaseHelper = new DatabaseHelper(connectionString);

            // Hide errors
            fNameError.Hide(); lNameError.Hide(); passwordError1.Hide(); passwordError2.Hide();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            // Get the staff ID from the login screen
            string ID = Login.staffID;

            displayProfile(ID);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            ResetErrors();

            bool notEmpty = true;

            string firstName = firstNameInput.Text;
            string middleName = middleNameInput.Text;
            string lastName = lastNameInput.Text;

            // Assigning the users input to a list and errors input to list
            string[] input = { firstName, lastName };
            Label[] error = { fNameError, lNameError };

            // Combine them
            var inputAndErrors = input.Zip(error, (n, w) => new { input = n, error = w });

            // For each input if they are blank, display appropriate error
            foreach (var i in inputAndErrors)
            {
                if (string.IsNullOrEmpty(i.input) || string.IsNullOrWhiteSpace(i.input))
                {
                    // Stop it from updating the database
                    notEmpty = false;
                    i.error.Show();
                }
            }

            // create update staff method 
            if (notEmpty)
            {
                // Get the logged in user
                string ID = Login.staffID;

                updateStaff(ID, firstName, middleName, lastName);

                // Log change
                using (StreamWriter sw = File.AppendText(Log.filePath))
                {
                    sw.WriteLine(DateTime.Now + " " + Login.staffID + " changed their profile details.");
                }

                MessageBox.Show("Profile successfully updated");
            }

        }

        private void PasswordButton_Click(object sender, EventArgs e)
        {
            ResetErrors();

            bool notNull = true;
            bool sameInput = false;

            // check not empty
            if (string.IsNullOrWhiteSpace(passwordInput.Text)) 
            {
                notNull = false;
                MessageBox.Show("Please enter a password");
            }

            // Check password confirmation isnt empty
            if (notNull == true && string.IsNullOrWhiteSpace(confirmPasswordInput.Text))
            {
                notNull = false;
                passwordError2.Show();
            }

            // If the passwords arent empty and are the same allow the staff member change password
            if (notNull == true)
            {
                if (passwordInput.Text == confirmPasswordInput.Text) sameInput = true;
                else MessageBox.Show("Passwords do not match");
            }


            if (sameInput == true) 
            {
                // Get the logged in user
                string ID = Login.staffID;
                string password = passwordInput.Text;

                password = Encrypt(password);

                updatePassword(password, ID);

                MessageBox.Show("Password updated successfully.");
            }
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

        private void updatePassword(string Password, string Staff_ID)
        {
            // Update the staff member that is logged in via their ID
            string query = "UPDATE Staff SET Password = @Password WHERE Staff_ID = @Staff_ID";

            // Update the database
            SQLiteParameter[] parameters =
            {
                new SQLiteParameter("@Staff_ID", Staff_ID),
                new SQLiteParameter("@Password", Password),

            };

            databaseHelper.ExecuteNonQuery(query, parameters);
        }

        private void ResetErrors()
        {
            fNameError.Hide(); lNameError.Hide(); passwordError1.Hide(); passwordError2.Hide();
        }

        private void displayProfile(string Staff_ID)
        {
            string query = "SELECT * FROM Staff WHERE Staff_ID = @Staff_ID";

            SQLiteParameter[] parameters =
            {
                 new SQLiteParameter("@Staff_ID", Staff_ID)
            };

            DataTable dataTable = databaseHelper.ExecuteParameterizedQuery(query, parameters);

            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                // Assign the first result in the database table to the variables
                DataRow row = dataTable.Rows[0];

                IDInput.Text = row["Staff_ID"].ToString();
                firstNameInput.Text = row["Staff_FName"].ToString();
                middleNameInput.Text = row["Staff_MName"].ToString();
                lastNameInput.Text = row["Staff_LName"].ToString();
                string jobRole = row["Job_ID"].ToString();

                switch (jobRole)
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

        private void updateStaff(string Staff_ID, string Staff_FName, string Staff_MName, string Staff_LName)
        {

            // Update the staff member that is logged in via their ID
            string query = "UPDATE Staff SET Staff_FName = @Staff_FName, Staff_MName = @Staff_MName, Staff_LName = @Staff_LName WHERE Staff_ID = @Staff_ID";

            // Update the database
            SQLiteParameter[] parameters =
            {
                new SQLiteParameter("@Staff_ID", Staff_ID),
                new SQLiteParameter("@Staff_FName", Staff_FName),
                new SQLiteParameter("@Staff_MName", Staff_MName),
                new SQLiteParameter("@Staff_LName", Staff_LName)

            };

            databaseHelper.ExecuteNonQuery(query, parameters);
        }
    }
}
