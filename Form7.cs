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
    public partial class SearchPlayerForm : Form
    {
        MySqlConnection conn;

        public SearchPlayerForm()
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

        private void SearchPlayerForm_Load(object sender, EventArgs e)
        {
            HideInput();
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

        private void DisableInput()
        {
            //Gör så att användaren inte kan editera innehåller när den endast söker efter en specifik spelare
            //Använder inte denna funktionen då man kan sätta värdena direkt i properties fönstret i designläget
            txtplayerId.Enabled= false;
            txtboxplayerFirstName.Enabled= false;
            txtboxplayerLastName.Enabled= false;
            txtboxAge.Enabled= false;
            txtboxPlayerNumber.Enabled= false;
            comboboxPlayerPosition.Enabled= false;
            comboBoxLeague.Enabled= false;
            comboBoxTeam.Enabled= false;
            comboBoxCountry.Enabled= false;
            txtboxPhonenumber.Enabled= false;
            txtboxEmailAdress.Enabled= false;
        }
    }
}
