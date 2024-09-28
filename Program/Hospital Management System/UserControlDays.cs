using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class UserControlDays : UserControl
    {

        public static string static_day;
        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }

        public void days(int numdays)
        {
            daysText.Text = numdays + "";

        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            static_day = daysText.Text;

            AppointmentPopUp eventForm = new AppointmentPopUp();
            eventForm.Show();
        }
    }
}
