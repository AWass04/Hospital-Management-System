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
using System.Xml;

namespace Hospital_Management_System
{
    public partial class Doctors : Form
    {
        private readonly DatabaseHelper databaseHelper;
        ViewStaff staffPage;
        public static object ID = "";
        public Doctors()
        {
            InitializeComponent();

            // Connect database
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            databaseHelper = new DatabaseHelper(connectionString);

        }
        private DataTable DisplayStaff(string Job_ID)
        {
            DataTable dataTable = new DataTable();

            using (SQLiteConnection connection = databaseHelper.GetConnection())
            {
                string query = "SELECT Staff_ID AS ID, Staff_FName || COALESCE(' ' || Staff_MName, '') || ' ' || Staff_LName AS Name FROM Staff WHERE Job_ID = @Job_ID";

                // Fill table with staff that have doctor Job ID
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@Job_ID", Job_ID);
                    adapter.Fill(dataTable);

                }
            }
            return dataTable;
        }

        private void Doctors_Load(object sender, EventArgs e)
        {
            // Display table
            doctorTable.DataSource = DisplayStaff("J20");

            // Display view buttom
            ViewButton();

            // Chnage column width
            doctorTable.Columns[0].FillWeight = 30;
            doctorTable.Columns[2].FillWeight = 30;

            ID = "";
        }

        private void ViewButton()
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Profile";
            btn.Text = "View";
            btn.Name = "btn";
            btn.UseColumnTextForButtonValue = true;
            doctorTable.Columns.Add(btn);
        }

        private void doctorTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Find the column
            if (e.RowIndex >= 0 && e.ColumnIndex == doctorTable.Columns["btn"].Index)
            {
                // Get ID
                ID = doctorTable.Rows[e.RowIndex].Cells["ID"].Value;

                // Open patient profile
                staffPage = new ViewStaff();
                staffPage.MdiParent = this.MdiParent; // Display it in same location
                staffPage.Dock = DockStyle.Fill;
                staffPage.Show();

            }
        }
    }
}
