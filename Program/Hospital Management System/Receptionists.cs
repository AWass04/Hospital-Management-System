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
    public partial class Receptionists : Form
    {

        private readonly DatabaseHelper databaseHelper;
        public static object ID = "";
        ViewStaff staffPage;

        public Receptionists()
        {
            InitializeComponent();

            // Connect database
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            databaseHelper = new DatabaseHelper(connectionString);
        }

        private DataTable DisplayStaff(string Job_ID)
        {
            DataTable dataTable = new DataTable();

            // Connect to database
            using (SQLiteConnection connection = databaseHelper.GetConnection())
            {
                string query = "SELECT Staff_ID AS ID, Staff_FName || COALESCE(' ' || Staff_MName, '') || ' ' || Staff_LName AS Name FROM Staff WHERE Job_ID = @Job_ID";

                // Display staff with that have receptionist job ID
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@Job_ID", Job_ID);
                    adapter.Fill(dataTable);

                }
            }
            return dataTable;
        }

        private void Receptionists_Load(object sender, EventArgs e)
        {
            receptionistTable.DataSource = DisplayStaff("J15");

            // Display view buttom
            ViewButton();

            // Change column width
            receptionistTable.Columns[0].FillWeight = 30;
            receptionistTable.Columns[2].FillWeight = 30;

            ID = "";
        }

        private void ViewButton()
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Profile";
            btn.Text = "View";
            btn.Name = "btn";
            btn.UseColumnTextForButtonValue = true;
            receptionistTable.Columns.Add(btn);
        }

        private void receptionistTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Find the column
            if (e.RowIndex >= 0 && e.ColumnIndex == receptionistTable.Columns["btn"].Index)
            {
                // Get ID
                ID = receptionistTable.Rows[e.RowIndex].Cells["ID"].Value;

                // Open patient profile
                staffPage = new ViewStaff();
                staffPage.MdiParent = this.MdiParent; // Display it in same location
                staffPage.Dock = DockStyle.Fill;
                staffPage.Show();

            }
        }
    }
}