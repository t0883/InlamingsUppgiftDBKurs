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
            string password = "!Phuglife9835";

            string connString = $"SERVER={server};DATABASE={database};UID={user};PASSWORD={password};";

            conn = new MySqlConnection(connString);
        }

        private void ViewAllPlayersInDB_Load(object sender, EventArgs e)
        {
            string sqlQuery = "CALL selectAllPlayers()";

            MySqlCommand cmd = new MySqlCommand(sqlQuery, conn);

            try
            {
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);

                dataGridView1.DataSource= dt;

                reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    string firstName = reader["player_firstName"].ToString();
                    string lastName = reader["player_lastName"].ToString();
                    int age = Convert.ToInt32(reader["player_age"]);
                    int playerNumber = Convert.ToInt32(reader["player_number"]);
                    string playerPosition = reader["position_name"].ToString();
                    string league = reader["league_name"].ToString();
                    string team = reader["team_name"].ToString();
                    string country = reader["country_name"].ToString();
                    string contactPhonenumber = reader["contact_Phonenumber"].ToString();
                    string contactEmailAdress = reader["contact_EmailAdress"].ToString();
                }

                conn.Close();
            }
            catch (Exception b)
            {
                MessageBox.Show(b.Message);
            }
        }
    }
}
