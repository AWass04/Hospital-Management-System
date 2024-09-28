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
using System.Globalization;

namespace Hospital_Management_System
{
    public partial class BookAppointment : Form
    {
        private readonly DatabaseHelper databaseHelper;

        public static string doctorID = "";
        public static int static_month, static_year;

        int month, year;
        string staffID;
        public BookAppointment()
        {
            InitializeComponent();

            // Connect database
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            databaseHelper = new DatabaseHelper(connectionString);

        }

        private void BookAppointment_Load(object sender, EventArgs e)
        {
            DisplayDays();
            fillCombobox();
        }

        // Referenced: https://www.youtube.com/watch?v=tY8_GE6NRYA
        // Referenced: https://www.youtube.com/watch?v=j2T72fxMH60

        private void DisplayDays()
        {
            DateTime now = DateTime.Now;

            month = now.Month;
            year = now.Year;

            String monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            monthYearDisplay.Text = monthName + " " + year;

            static_month = month;
            static_year = year;


            // Getting first day of the month
            DateTime startOfMonth = new DateTime(year, month, 1);

            // Getting the days in that month
            int days = DateTime.DaysInMonth(now.Year, month);

            // Convert to int
            int daysOfTheWeek = Convert.ToInt32(startOfMonth.DayOfWeek.ToString("d")) + 1;

            DisplayUserControl(daysOfTheWeek, days);
        }

        private void DisplayDayNewPage()
        {
            static_month = month;
            static_year = year;

            String monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            monthYearDisplay.Text = monthName + " " + year;

            // Getting first day of the month 
            DateTime startOfMonth = new DateTime(year, month, 1);

            // Getting the days in that month
            int days = DateTime.DaysInMonth(year, month);

            // Convert to int
            int daysOfTheWeek = Convert.ToInt32(startOfMonth.DayOfWeek.ToString("d")) + 1;

            DisplayUserControl(daysOfTheWeek, days);

        }

        private void DisplayUserControl(int daysOfTheWeek, int days)
        {
            // Blank usercontrol
            for (int i = 1; i < daysOfTheWeek; i++)
            {
                UserControlBlank ucBlank = new UserControlBlank();
                dayContainer.Controls.Add(ucBlank);
            }

            // Days usercontrol
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                dayContainer.Controls.Add(ucdays);
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            // Clear container
            dayContainer.Controls.Clear();

            // Increase month
            month++;

            DisplayDayNewPage();

        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            // Clear container
            dayContainer.Controls.Clear();

            // Decrease month
            month--;

            DisplayDayNewPage();

        }


        private void fillCombobox()
        {
            // Clear existing items in the ComboBox
            doctorChoice.Items.Clear();

            // Get only doctors
            string query = "SELECT Staff_ID, Staff_LName FROM Staff WHERE Job_ID = 'J20'";
            DataTable dataTable = databaseHelper.ExecuteQuery(query);

            // Check if there are any results
            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    // Combine first name and last name, and add to ComboBox
                    string name = "Dr. " + $"{row["Staff_LName"]}";
                    doctorID = $"{row["Staff_ID"]}";
                    doctorChoice.Items.Add(name + " " + doctorID);
                }
            }
        }

        private void doctorChoice_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (doctorChoice.SelectedIndex >= 0)
            {
                // Extract the doctor's ID from the selected item
                string selectedDoctor = doctorChoice.SelectedItem.ToString();
                doctorID = selectedDoctor.Split(' ')[2];
            }

        }
    }
}
