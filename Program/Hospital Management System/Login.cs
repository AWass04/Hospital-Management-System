using Microsoft.VisualBasic.ApplicationServices;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Hospital_Management_System
{
    public partial class Login : Form
    {
        private readonly DatabaseHelper databaseHelper;

        public static string staffID = "";

        public Login()
        {
            InitializeComponent();

            // Connect database
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            databaseHelper = new DatabaseHelper(connectionString);

            // Hide error messages
            usernameError.Hide(); passwordError.Hide(); checkBoxError.Hide();

        }

        private void LoginButton_Click_1(object sender, EventArgs e)
        {
            ResetErrors();

            bool inputFilled = true;
            bool correctInfo = false;

            // Users inputted username, password and job role
            string usersUsernameInput = usernameInput.Text;
            string usersPasswordInput = passwordInput.Text;
            string jobRole = null;

            if (adminCheckBox.Checked)
            {
                jobRole = "J10";
            }
            else if (receptionistCheckBox.Checked)
            {
                jobRole = "J15";
            }
            else if (doctorCheckBox.Checked)
            {
                jobRole = "J20";
            }

            // Assigning the users input to a list and errors input to list
            string[] input = { usersUsernameInput, usersPasswordInput, jobRole };
            Label[] error = { usernameError, passwordError, checkBoxError };

            // Combine them
            var inputAndErrors = input.Zip(error, (n, w) => new { input = n, error = w });

            // For each input if they are blank, display appropriate error
            foreach (var i in inputAndErrors)
            {
                if (string.IsNullOrEmpty(i.input) || string.IsNullOrWhiteSpace(i.input))
                {
                    // Stop it from logging in
                    inputFilled = false;
                    i.error.Show();

                }
            }

            if (inputFilled)
            {
                // Encrypt password entered 
                usersPasswordInput = Encrypt(usersPasswordInput);

                // Check the password, username and checkbox is correct
                correctInfo = detailsCheck(jobRole, usersPasswordInput);

                // Use the checkbox to open the correct homepage - change to switch case 
                if (correctInfo == true)
                {
                    // Log who logged in
                    using (StreamWriter sw = File.AppendText(Log.filePath))
                    {
                        sw.WriteLine(DateTime.Now + " " + usernameInput.Text + " logged in.");
                    }

                    // Allow logged in ID to be used in other forms
                    staffID = usersUsernameInput;

                    switch (jobRole)
                    {
                        case "J10": // Admin home page

                            AdminHome adminHome = new AdminHome();
                            this.Hide();
                            adminHome.Show();

                            break;
                        case "J15": // Receptionist home page

                            ReceptionistHome receptionistHome = new ReceptionistHome();
                            this.Hide();
                            receptionistHome.Show();

                            break;
                        case "J20": // Doctor home page

                            DoctorHome doctorHome = new DoctorHome();
                            this.Hide();
                            doctorHome.Show();

                            break;
                    }
                }
                else // Show error
                {
                    MessageBox.Show("Username, Password or job role is incorrect");
                }
            }
        }

        private void ResetErrors()
        {
            usernameError.Hide();
            passwordError.Hide();
            checkBoxError.Hide();
        }

        private bool detailsCheck(string jobRole, string Password)
        {
            string query = "SELECT * FROM Staff WHERE Staff_ID = @Staff_ID AND Password = @Password AND Job_ID = @Job_ID ";
           
            // Get connection, makes sure connection doesnt stay open
            using (SQLiteConnection connection = databaseHelper.GetConnection())
            {
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    // Check staff ID, Password and Job selection
                    command.Parameters.AddWithValue("@Staff_ID", usernameInput.Text);
                    command.Parameters.AddWithValue("@Password", Password);
                    command.Parameters.AddWithValue("@Job_ID", jobRole);

                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    // If the count is greater than 0 it is correct log in
                    if (dataTable.Rows.Count > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
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

        private void usernameInput_Click(object sender, EventArgs e)
        {
            usernameInput.SelectAll();
        }

        private void passwordInput_Click(object sender, EventArgs e)
        {
            passwordInput.SelectAll();
        }

        private void adminCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Allow only one checkbox to be selected
            if (adminCheckBox.Checked)
            {
                receptionistCheckBox.Checked = false;
                doctorCheckBox.Checked = false;
            }
        }

        private void receptionistCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Allow only one checkbox to be selected
            if (receptionistCheckBox.Checked)
            {
                adminCheckBox.Checked = false;
                doctorCheckBox.Checked = false;
            }
        }

        private void doctorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Allow only one checkbox to be selected
            if (doctorCheckBox.Checked)
            {
                adminCheckBox.Checked = false;
                receptionistCheckBox.Checked = false;
            }

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}