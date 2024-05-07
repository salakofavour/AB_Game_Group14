using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace AB_game
{
    public partial class databaseLogs : Form
    {
        public databaseLogs()
        {
            InitializeComponent();
        }

        public void databaseLogs_Load(object sender, EventArgs e)
        {

            const string connectionStringTwo = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ProjectDatabase.mdf;Integrated Security=True;";

            SqlConnection conn = new SqlConnection(connectionStringTwo);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "viewAll";
            conn.Open();
            var dataAdapterInfo = new SqlDataAdapter(cmd.CommandText, conn);
            var databaseLogsPage = new DataTable();
            dataAdapterInfo.Fill(databaseLogsPage);
            dataGridView1.DataSource = databaseLogsPage;

            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
