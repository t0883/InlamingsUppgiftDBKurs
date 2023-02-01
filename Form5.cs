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
            string password = "!Phuglife9835";

            string connString = $"SERVER={server};DATABASE={database};UID={user};PASSWORD={password};";

            conn = new MySqlConnection(connString);
        }

        private void ViewAllTeamsInDB_Load(object sender, EventArgs e)
        {
            string sqlQuery = "CALL selectAllTeams()";

            MySqlCommand cmd = new MySqlCommand(sqlQuery, conn);

            try
            {
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);

                dataGridView1.DataSource = dt;

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string teamnName = reader["team_name"].ToString();
                    string adress = reader["adress_adress"].ToString();
                    string postalcode = reader["adress_postalcode"].ToString();
                    string city = reader["adress_city"].ToString();
                    string phonenumber = reader["contact_Phonenumber"].ToString();
                    string emailAdress = reader["contact_EmailAdress"].ToString();
                    string teamslogan = reader["team_slogan"].ToString();
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
