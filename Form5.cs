using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InlamingsUppgiftDBKurs
{
    public partial class ViewAllTeamsInDB : Form
    {
        MySqlConnection conn;

        public ViewAllTeamsInDB()
        {
            InitializeComponent();

            // Skapa en MySQL connection objekt
            string server = "localhost";
            string database = "handballdb";
            string user = "root";
            string password = "";

            string connString = $"SERVER={server};DATABASE={database};UID={user};PASSWORD={password};";

            conn = new MySqlConnection(connString);
        }

        private void ViewAllTeamsInDB_Load(object sender, EventArgs e)
        {
            //SQL query som kallar på en store procedure som i sin tur kallar på en view
            string sqlQuery = "CALL selectAllTeams()";

            MySqlCommand cmd = new MySqlCommand(sqlQuery, conn);

            try
            {
                //Öppna anslutning
                conn.Open();

                //Exekverar kommando
                MySqlDataReader reader = cmd.ExecuteReader();

                //Skapar ett DataTable objekt
                DataTable dt = new DataTable();

                //Lastar objektet med data
                dt.Load(reader);

                //Lägger in datan från DataTable objektet i gridviewn
                dataGridView1.DataSource = dt;

                //Stänga anslutning
                conn.Close();
            }
            catch (Exception b)
            {
                //Eventuella felmeddelande 
                MessageBox.Show(b.Message);
            }
        }
    }
}
