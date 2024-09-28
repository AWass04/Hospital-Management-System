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
    public partial class ReceptionistHome : Form
    {
        ViewPatientsR viewPatientsPage;
        RegisterPatient registerPatientPage;
        BookAppointment bookAppointmentPage;
        CancelAppointment cancelAppointmentPage;
        Profile profile;

        private readonly DatabaseHelper databaseHelper;

        public ReceptionistHome()
        {
            InitializeComponent();

            // Connect database
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            databaseHelper = new DatabaseHelper(connectionString);

            selectionLabel.Hide();
        }

        private void ViewPatientsButton_Click(object sender, EventArgs e)
        {
            // Open the form
            viewPatientsPage = new ViewPatientsR();
            viewPatientsPage.MdiParent = this;
            viewPatientsPage.Dock = DockStyle.Fill;
            backgroundPanel.Hide();
            viewPatientsPage.Show();
            // Display button selection label
            selectionLabel.Location = new Point(0, 122);
            selectionLabel.Show();
            // Change button colour
            resetColours();
            ViewPatientsButton.BackColor = Color.LightSlateGray;
        }

        private void RegisterPatientsButton_Click(object sender, EventArgs e)
        {
            // Open the form
            registerPatientPage = new RegisterPatient();
            registerPatientPage.MdiParent = this;
            registerPatientPage.Dock = DockStyle.Fill;
            backgroundPanel.Hide();
            registerPatientPage.Show();
            // Display button selection label
            selectionLabel.Location = new Point(0, 187);
            selectionLabel.Show();
            // Change button colour
            resetColours();
            RegisterPatientsButton.BackColor = Color.LightSlateGray;
        }

        private void BookAppointmentButton_Click(object sender, EventArgs e)
        {
            // Open the form
            bookAppointmentPage = new BookAppointment();
            bookAppointmentPage.MdiParent = this;
            bookAppointmentPage.Dock = DockStyle.Fill;
            backgroundPanel.Hide();
            bookAppointmentPage.Show();
            // Display button selection label
            selectionLabel.Location = new Point(0, 398);
            selectionLabel.Show();
            // Change button colour
            resetColours();
            BookAppointmentButton.BackColor = Color.LightSlateGray;
        }


        private void CancelAppointmentButton_Click(object sender, EventArgs e)
        {
            // Open the form
            cancelAppointmentPage = new CancelAppointment();
            cancelAppointmentPage.MdiParent = this;
            cancelAppointmentPage.Dock = DockStyle.Fill;
            backgroundPanel.Hide();
            cancelAppointmentPage.Show();
            // Display button selection label
            selectionLabel.Location = new Point(0, 463);
            selectionLabel.Show();
            // Change button colour
            resetColours();
            CancelAppointmentButton.BackColor = Color.LightSlateGray;
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            // Log staff memeber has logged out
            using (StreamWriter sw = File.AppendText(Log.filePath))
            {
                sw.WriteLine(DateTime.Now + " " + Login.staffID + " logged out");
            }

            // Go to login screen
            Login login = new Login();
            this.Close();
            login.Show();
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
            ViewPatientsButton.BackColor = Color.FromArgb(80, 86, 95);
            RegisterPatientsButton.BackColor = Color.FromArgb(80, 86, 95);
            BookAppointmentButton.BackColor = Color.FromArgb(80, 86, 95);
            CancelAppointmentButton.BackColor = Color.FromArgb(80, 86, 95);
            ProfileButton.BackColor = Color.FromArgb(80, 86, 95);
        }
    }
}
