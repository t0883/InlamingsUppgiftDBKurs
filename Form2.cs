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
    public partial class AddPlayerForm : Form
    {
        MySqlConnection conn;

        private TextBox[] txtBoxes;
        private ComboBox[] comboBoxes;


        public AddPlayerForm()
        {
            InitializeComponent();

            //Skapa en MySQL connection objekt
            string server = "localhost";
            string database = "handballdb";
            string user = "root";
            string password = "!Phuglife9835";

            string connString = $"SERVER={server};DATABASE={database};UID={user};PASSWORD={password};";

            conn = new MySqlConnection(connString);

            //Skapa en array referens för input fälten
            txtBoxes = new TextBox[] { txtboxplayerFirstName, txtboxplayerLastName, txtboxAge, txtboxPlayerNumber, txtboxPhonenumber, txtboxEmailAdress };
            comboBoxes = new ComboBox[] { comboboxPlayerPosition, comboBoxLeague, comboBoxTeam, comboBoxCountry };
        }

        private void AddPlayer()
        {
            //Validering
            bool valid = true;

            foreach (TextBox txtBox in txtBoxes)
            {
                //Trimmar text-innehållet
                txtBox.Text = txtBox.Text.Trim();

                //Kontrollera att txtBox har text
                if (txtBox.Text == "")
                {
                    //Validering har misslyckats
                    valid = false;
                    txtBox.BackColor = Color.Red;
                }
                else
                {
                    txtBox.BackColor = TextBox.DefaultBackColor;
                }
            }

            foreach (ComboBox cb in comboBoxes)
            {
                //Kontrollerar att comboboxarna har ett valt värde
                if (cb.SelectedIndex < 0)
                {
                    //Valideringen har misslyckats
                    valid = false;
                    cb.BackColor = Color.Red;
                }
                else
                {
                    cb.BackColor = ComboBox.DefaultBackColor;
                }
            }

            //Kontrollera valid
            if (!valid)
            {
                MessageBox.Show("Felaktig validering. Kontrollera röda fält.");
                return;
            }

            //Hämta all data från text/comboboxarna
            string firstName = txtboxplayerFirstName.Text;
            string lastName = txtboxplayerLastName.Text;
            int age = Convert.ToInt32(txtboxAge.Text);
            int playerNumber = Convert.ToInt32(txtboxPlayerNumber.Text);
            int playerPosition = comboboxPlayerPosition.SelectedIndex + 1;
            int league = comboBoxLeague.SelectedIndex + 1;
            int team = comboBoxTeam.SelectedIndex + 1;
            int country = comboBoxCountry.SelectedIndex + 1;
            string phoneNumber = txtboxPhonenumber.Text;
            string emailAdress = txtboxEmailAdress.Text;

            MessageBox.Show($"{firstName}, {lastName}, {age}, {playerNumber}, {playerPosition}, {league}, {team}, {country}, {phoneNumber}, {emailAdress}");
            //Föra in det i databasen
            string sqlQuery = $"CALL insertNewPlayerWithNewContact('{firstName}', '{lastName}', {age}, {playerNumber}, {playerPosition}, {league}, {team}, {country}, '{phoneNumber}', '{emailAdress}');";

            MySqlCommand cmd = new MySqlCommand(sqlQuery, conn);

            try
            {
                //Öppna Connection
                conn.Open();

                //Exekvera kommando
                cmd.ExecuteReader();

                //Stänga Connection
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            MessageBox.Show("Insert finished successfully.");

            //Tömmer alla input fälten för att förhindra dubbletter
            txtboxplayerFirstName.Clear();
            txtboxplayerLastName.Clear();
            txtboxAge.Clear();
            txtboxPlayerNumber.Clear();
            comboboxPlayerPosition.SelectedIndex = -1;
            comboBoxLeague.SelectedIndex = -1;
            comboBoxTeam.SelectedIndex = -1;
            comboBoxCountry.SelectedIndex = -1;
            txtboxPhonenumber.Clear();
            txtboxEmailAdress.Clear();

        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            AddPlayer();
        }

        private void PlayerForm_Load(object sender, EventArgs e)
        {
            SelectCountryFromDB();
            SelectTeamFromDB();
            SelectLeagueFromDB();
            SelectPlayerPositionFromDB();
        }

        private void SelectCountryFromDB()
        {
            //MySQL query
            string sqlQuery = "CALL selectCountry();";

            //MySQL kommando
            MySqlCommand cmd = new MySqlCommand(sqlQuery, conn);

            //Exekvera kommando mot databasen och få tillbaka data
            try
            {
                //Öppna
                conn.Open();

                //Exekvera kommandot
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    comboBoxCountry.Items.Add((string)reader["country_name"]);
                }

                //Stänga
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void SelectTeamFromDB()
        {
            //MySQL query
            string sqlQuery = "CALL selectTeam();";

            //MySQL kommando
            MySqlCommand cmd = new MySqlCommand(sqlQuery, conn);

            //Exekvera kommando mot databasen och få tillbaka data
            try
            {
                //Öppna
                conn.Open();

                //Exekvera kommandot
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    comboBoxTeam.Items.Add((string)reader["team_name"]);
                }

                //Stänga
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void SelectLeagueFromDB()
        {
            //MySQL query
            string sqlQuery = "CALL selectLeague();";

            //MySQL kommando
            MySqlCommand cmd = new MySqlCommand(sqlQuery, conn);

            //Exekvera kommando mot databasen och få tillbaka data
            try
            {
                //Öppna
                conn.Open();

                //Exekvera kommandot
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    comboBoxLeague.Items.Add((string)reader["league_name"]);
                }

                //Stänga
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void SelectPlayerPositionFromDB()
        {
            //MySQL query
            string sqlQuery = "CALL selectPlayerPosition();";

            //MySQL kommando
            MySqlCommand cmd = new MySqlCommand(sqlQuery, conn);

            //Exekvera kommando mot databasen och få tillbaka data
            try
            {
                //Öppna
                conn.Open();

                //Exekvera kommandot
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    comboboxPlayerPosition.Items.Add((string)reader["position_name"]);
                }

                //Stänga
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
