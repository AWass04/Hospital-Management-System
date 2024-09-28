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
    public partial class Admin : Form
    {
        private readonly DatabaseHelper databaseHelper;
        ViewStaff staffPage;
        public static object ID = "";

        ViewStaff testPage;
        public Admin()
        {
            InitializeComponent();

            // Connect database
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            databaseHelper = new DatabaseHelper(connectionString);
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            adminTable.DataSource = DisplayStaff("J10");

            // Display view buttom
            ViewButton();

            // Adjust column width 
            adminTable.Columns[0].FillWeight = 30;
            adminTable.Columns[2].FillWeight = 30;

            ID = "";
        }

        private void ViewButton()
        {
            // Add a view button to data table
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Profile";
            btn.Text = "View";
            btn.Name = "btn";
            btn.UseColumnTextForButtonValue = true;
            adminTable.Columns.Add(btn);
        }

        private void adminTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Find the column
            if (e.RowIndex >= 0 && e.ColumnIndex == adminTable.Columns["btn"].Index)
            {
                // Get ID
                ID = adminTable.Rows[e.RowIndex].Cells["ID"].Value;

                // Open patient profile
                staffPage = new ViewStaff();
                staffPage.MdiParent = this.MdiParent; // Display it in same location
                staffPage.Dock = DockStyle.Fill;
                staffPage.Show();

            }
        }

        private DataTable DisplayStaff(string Job_ID)
        {
            DataTable dataTable = new DataTable();

            using (SQLiteConnection connection = databaseHelper.GetConnection())
            {
                string query = "SELECT Staff_ID AS ID, Staff_FName || COALESCE(' ' || Staff_MName, '') || ' ' || Staff_LName AS Name FROM Staff WHERE Job_ID = @Job_ID";

                // Fill table with staff that have admin ID
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@Job_ID", Job_ID);
                    adapter.Fill(dataTable);

                }
            }
            return dataTable;
        }
    }
}
