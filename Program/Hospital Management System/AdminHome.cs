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
    public partial class AdminHome : Form
    {
        Receptionists receptionistsList;
        Doctors doctorsList;
        Admin adminList;
        CreateEmployee addEmployee;
        Profile profile;

        private readonly DatabaseHelper databaseHelper;
        public AdminHome()
        {
            InitializeComponent();

            // Connect database
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            databaseHelper = new DatabaseHelper(connectionString);

            selectionLabel.Hide();
        }

        private void ViewReceptionistButton_Click(object sender, EventArgs e)
        {
            // Open the form 
            receptionistsList = new Receptionists();
            receptionistsList.MdiParent = this;
            receptionistsList.Dock = DockStyle.Fill;
            backgroundPanel.Hide();
            receptionistsList.Show();
            // Display button selection label
            selectionLabel.Location = new Point(0, 124);
            selectionLabel.Show();
            // Change button colour
            resetColours();
            ViewReceptionistButton.BackColor = Color.LightSlateGray;
        }

        private void ViewDoctorsButton_Click(object sender, EventArgs e)
        {
            // Open the form
            doctorsList = new Doctors();
            doctorsList.MdiParent = this;
            doctorsList.Dock = DockStyle.Fill;
            backgroundPanel.Hide();
            doctorsList.Show();
            // Display button selection label
            selectionLabel.Location = new Point(0, 193);
            selectionLabel.Show();
            // Change button colour
            resetColours();
            ViewDoctorsButton.BackColor = Color.LightSlateGray;
        }

        private void ViewAdminButton_Click(object sender, EventArgs e)
        {
            // Open the form
            adminList = new Admin();
            adminList.MdiParent = this;
            adminList.Dock = DockStyle.Fill;
            backgroundPanel.Hide();
            adminList.Show();
            // Display button selection label
            selectionLabel.Location = new Point(0, 258);
            selectionLabel.Show();
            // Change button colour
            resetColours();
            ViewAdminButton.BackColor = Color.LightSlateGray;
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            // Log staff member has logged out
            using (StreamWriter sw = File.AppendText(Log.filePath))
            {
                sw.WriteLine(DateTime.Now + " " + Login.staffID + " logged out");
            }

            // Go to Login
            Login login = new Login();
            this.Close();
            login.Show();
        }

        private void createEmployeeButton_Click(object sender, EventArgs e)
        {
            // Open the form 
            addEmployee = new CreateEmployee();
            addEmployee.MdiParent = this;
            addEmployee.Dock = DockStyle.Fill;
            backgroundPanel.Hide();
            addEmployee.Show();
            // Display button selection label
            selectionLabel.Location = new Point(0, 431);
            selectionLabel.Show();
            // Change button colour
            resetColours();
            createEmployeeButton.BackColor = Color.LightSlateGray;
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            // Open the form
            profile = new Profile();
            profile.MdiParent = this;
            profile.Dock = DockStyle.Fill;
            backgroundPanel.Hide();
            profile.Show();
            // Hide button selection label
            selectionLabel.Hide();
            // Change button colours
            resetColours();
            ProfileButton.BackColor = Color.LightSlateGray;

        }

        private void resetColours()
        {
            ViewAdminButton.BackColor = Color.FromArgb(80, 86, 95);
            ViewDoctorsButton.BackColor = Color.FromArgb(80, 86, 95);
            ViewReceptionistButton.BackColor = Color.FromArgb(80, 86, 95);
            createEmployeeButton.BackColor = Color.FromArgb(80, 86, 95);
            ProfileButton.BackColor = Color.FromArgb(80, 86, 95);
        }
    }
}
