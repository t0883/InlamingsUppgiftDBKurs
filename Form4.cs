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
    public partial class ViewAllPlayersInDB : Form
    {
        MySqlConnection conn;

        public ViewAllPlayersInDB()
        {
            InitializeComponent();

            //Skapa en MySQL connection objekt
            string server = "localhost";
            string database = "handballdb";
            string user = "root";
            string password = "";

            string connString = $"SERVER={server};DATABASE={database};UID={user};PASSWORD={password};";

            conn = new MySqlConnection(connString);
        }

        private void ViewAllPlayersInDB_Load(object sender, EventArgs e)
        {
            //Skapar SQL query
            string sqlQuery = "CALL selectAllPlayers()";

            MySqlCommand cmd = new MySqlCommand(sqlQuery, conn);

            try
            {
                //Öppna anslutningen
                conn.Open();

                //Exekverar kommandot
                MySqlDataReader reader = cmd.ExecuteReader();

                //Skapar ett DataTable objekt
                DataTable dt = new DataTable();

                //Lastar objektet med data
                dt.Load(reader);

                //Lägger in datan från DataTable objektet i gridviewn
                dataGridView1.DataSource = dt;

                //Stäng anslutningen
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
