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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InlamingsUppgiftDBKurs
{

    public partial class EditPlayerForm : Form
    {
        MySqlConnection conn;

        //Får ett error när jag skriver koden på detta sättet
        //TextBox[] textBox;
        //Men problemet blir löst när jag lägger till System.Windows.Forms innan
        private System.Windows.Forms.TextBox[] textBox;
        private System.Windows.Forms.ComboBox[] comboBox;

        public EditPlayerForm()
        {
            InitializeComponent();

            //Skapa en MySQL connection objekt
            string server = "localhost";
            string database = "handballdb";
            string user = "root";
            string password = "";

            string connString = $"SERVER={server};DATABASE={database};UID={user};PASSWORD={password};";

            conn = new MySqlConnection(connString);

            //Skapa en array referens för input fälten
            textBox = new System.Windows.Forms.TextBox[] { txtboxplayerFirstName, txtboxplayerLastName, txtboxAge, txtboxPlayerNumber, txtboxPhonenumber, txtboxEmailAdress, txtboxSeachFirstName, txtboxSearchLastName };
            comboBox = new System.Windows.Forms.ComboBox[] { comboboxPlayerPosition, comboBoxLeague, comboBoxTeam, comboBoxCountry };
        }

        private void EditPlayerForm_Load(object sender, EventArgs e)
        {
            HideInput();
            SelectCountryFromDB();
            SelectTeamFromDB();
            SelectLeagueFromDB();
            SelectPlayerPositionFromDB();
        }

        private void HideInput()
        {
            //Gömmer alla input fälten tills man har matat in något i sökfälten
            lblplayerId.Hide();
            lblplayerFirstName.Hide();
            lblplayerLastName.Hide();
            lblplayerAge.Hide();
            lblplayerNumber.Hide();
            lblplayerPosition.Hide();
            lblplayerLeague.Hide();
            lblplayerTeam.Hide();
            lblplayerCountry.Hide();
            lblplayerPhoneNumber.Hide();
            lblplayerEmailAddress.Hide();
            lblContact_id.Hide();
            txtplayerId.Hide();
            txtboxplayerFirstName.Hide();
            txtboxplayerLastName.Hide();
            txtboxAge.Hide();
            txtboxPlayerNumber.Hide();
            comboboxPlayerPosition.Hide();
            comboBoxLeague.Hide();
            comboBoxTeam.Hide();
            comboBoxCountry.Hide();
            txtboxPhonenumber.Hide();
            txtboxEmailAdress.Hide();
            txtContactId.Hide();
            btnUpdatePlayer.Hide();

        }

        private void ShowInput()
        {
            //Gömmer alla input fälten tills man har matat in något i sökfälten
            lblplayerFirstName.Show();
            lblplayerLastName.Show();
            lblplayerAge.Show();
            lblplayerNumber.Show();
            lblplayerPosition.Show();
            lblplayerLeague.Show();
            lblplayerTeam.Show();
            lblplayerCountry.Show();
            lblplayerPhoneNumber.Show();
            lblplayerEmailAddress.Show();
            txtboxplayerFirstName.Show();
            txtboxplayerLastName.Show();
            txtboxAge.Show();
            txtboxPlayerNumber.Show();
            comboboxPlayerPosition.Show();
            comboBoxLeague.Show();
            comboBoxTeam.Show();
            comboBoxCountry.Show();
            txtboxPhonenumber.Show();
            txtboxEmailAdress.Show();
            btnUpdatePlayer.Show();
        }

        private void SelectPlayerFromDB()
        {
            //Validering
            bool valid = true;

            //Trimmar text-innehållet
            txtboxSeachFirstName.Text = txtboxSeachFirstName.Text.Trim();
            txtboxSearchLastName.Text = txtboxSearchLastName.Text.Trim();

            if (txtboxSeachFirstName.Text == "" && txtboxSearchLastName.Text == "")
            {
                //Validering har misslyckats
                valid = false;
                txtboxSeachFirstName.BackColor = Color.Red;
                txtboxSearchLastName.BackColor = Color.Red;
            }
            else
            {
                txtboxSeachFirstName.BackColor = System.Windows.Forms.TextBox.DefaultBackColor;
                txtboxSearchLastName.BackColor = System.Windows.Forms.TextBox.DefaultBackColor;
            }
            //Kontrollera valid
            if (!valid)
            {
                MessageBox.Show("Felaktig validering. Kontrollera röda fält.");
                return;
            }

            string firstName = txtboxSeachFirstName.Text;
            string lastName = txtboxSearchLastName.Text;

            //Skapa sqlQuery
            string sqlQuery = $"CALL selectPlayerByName('{firstName}', '{lastName}');";

            //MySQL kommando
            MySqlCommand cmd = new MySqlCommand(sqlQuery, conn);

            //Exekvera kommando mot databasen och få tillbaka data
            try
            {
                //Öppna kopplingen
                conn.Open();

                //Exekvera kommandot
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    ShowInput();

                    while (reader.Read())
                    {
                        txtplayerId.Text = reader.GetString(0);
                        txtboxplayerFirstName.Text = reader.GetString(1);
                        txtboxplayerLastName.Text = reader.GetString(2);
                        txtboxAge.Text = reader.GetString(3);
                        txtboxPlayerNumber.Text = reader.GetString(4);
                        txtContactId.Text = reader.GetString(5);
                        comboboxPlayerPosition.Text = reader.GetString(6);
                        comboBoxLeague.Text = reader.GetString(7);
                        comboBoxTeam.Text = reader.GetString(8);
                        comboBoxCountry.Text = reader.GetString(9);
                        txtboxPhonenumber.Text = reader.GetString(10);
                        txtboxEmailAdress.Text = reader.GetString(11);
                    }
                }
                else
                {
                    //HideInput();
                    MessageBox.Show($"No player with {firstName} and {lastName} exist in the database.");
                }

                //Stänga kopplingen
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SelectPlayerFromDB();
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

        private void UpdatePlayerToDB()
        {
            //Samla in datan och placera det i en sträng
            int playerId = Convert.ToInt32(txtplayerId.Text);
            string playerFirstName = txtboxplayerFirstName.Text;
            string playerLastName = txtboxplayerLastName.Text;
            int playerAge = Convert.ToInt32(txtboxAge.Text);
            int playerNumber = Convert.ToInt32(txtboxPlayerNumber.Text);
            int playerPosition = comboboxPlayerPosition.SelectedIndex +1;
            int playerLeague = comboBoxLeague.SelectedIndex +1;
            int playerTeam = comboBoxTeam.SelectedIndex +1;
            int playerCountry = comboBoxCountry.SelectedIndex +1;
            int playerContactId = Convert.ToInt32(txtContactId.Text);
            string playerContactPhonenumber = txtboxPhonenumber.Text;
            string playerEmailAddress = txtboxEmailAdress.Text;

            string sqlQuery = $"CALL updatePlayer({playerId}, '{playerFirstName}', '{playerLastName}', {playerAge}, {playerNumber}, {playerPosition}, {playerLeague}, {playerTeam}, {playerCountry}); CALL updateContact({playerContactId}, '{playerContactPhonenumber}', '{playerEmailAddress}');";

            //MessageBox.Show($"{sqlQuery}");

            //Bygga upp MySQL kommandot
            MySqlCommand cmd = new MySqlCommand(sqlQuery, conn);

            //Exekvera kommandot
            try
            {
                //Öppna koppling
                conn.Open();

                //Utför kommando
                cmd.ExecuteReader();

                //Stäng koppling
                conn.Close();

                MessageBox.Show("Spelaren har blivit updaterad i databasen!");

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void btnUpdatePlayer_Click(object sender, EventArgs e)
        {
            UpdatePlayerToDB();
        }
    }
}



