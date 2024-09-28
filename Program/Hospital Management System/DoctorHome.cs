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
    public partial class DoctorHome : Form
    {
        ViewPatientsD viewPatientsPage;
        ViewSchedule viewSchedulePage;
        Profile profile;

        private readonly DatabaseHelper databaseHelper;
        public DoctorHome()
        {
            InitializeComponent();

            // Connect database
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            databaseHelper = new DatabaseHelper(connectionString);

            selectionLabel.Hide();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = File.AppendText(Log.filePath))
            {
                sw.WriteLine(DateTime.Now + " " + Login.staffID + " logged out");
            }

            // Go to login page
            Login login = new Login();
            this.Close();
            login.Show();
        }

        private void ViewPatientsButton_Click(object sender, EventArgs e)
        {
            // open the form
            viewPatientsPage = new ViewPatientsD();
            viewPatientsPage.MdiParent = this;
            viewPatientsPage.Dock = DockStyle.Fill;
            backgroundPanel.Hide();
            viewPatientsPage.Show();
            // Display button selection label 
            selectionLabel.Location = new Point(0, 150);
            selectionLabel.Show();
            // Change button colour
            resetColours();
            ViewPatientsButton.BackColor = Color.LightSlateGray;
        }

        private void ViewAppointmentsButton_Click(object sender, EventArgs e)
        {
            // Open the form
            viewSchedulePage = new ViewSchedule();
            viewSchedulePage.MdiParent = this;
            viewSchedulePage.Dock = DockStyle.Fill;
            backgroundPanel.Hide();
            viewSchedulePage.Show();
            // Display button selection label
            selectionLabel.Location = new Point(0, 373);
            selectionLabel.Show();
            // Change button colour
            resetColours();
            ViewAppointmentsButton.BackColor = Color.LightSlateGray;
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
            // Change button colour
            resetColours();
            ProfileButton.BackColor = Color.LightSlateGray;
        }

        private void resetColours()
        {
            ViewAppointmentsButton.BackColor = Color.FromArgb(80, 86, 95);
            ViewPatientsButton.BackColor = Color.FromArgb(80, 86, 95);
            ProfileButton.BackColor = Color.FromArgb(80, 86, 95);

        }
    }
}
