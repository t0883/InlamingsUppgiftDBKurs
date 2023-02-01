using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InlamingsUppgiftDBKurs
{
    public partial class MainForm : Form
    {

        private Stopwatch stopWatch;

        
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStartClock_Click(object sender, EventArgs e)
        {

            if (btnStartClock.Text == "STOP CLOCK")
            {
                stopWatch.Stop();

                btnStartClock.Text = "START CLOCK";

                btnResetClock.Enabled= true;

                return;
            }
            stopWatch.Start();

            btnHometeamScore.Enabled = true;
            btnAwayteamScore.Enabled = true;
            btnWithdrawHometeam.Enabled = true;
            btnWithdrawAwayteam.Enabled = true;
            btnResetClock.Enabled = false;

            btnStartClock.Text = "STOP CLOCK";

        }

        private void btnAwayteamScore_Click(object sender, EventArgs e)
        {
            int score = Convert.ToInt32(lblAwayteamScore.Text);

            score++;

            lblAwayteamScore.Text = score.ToString();
        }

        private void btnHometeamScore_Click(object sender, EventArgs e)
        {
            int score = Convert.ToInt32(lblHometeamScore.Text);

            score++;

            lblHometeamScore.Text = score.ToString();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lblTimer.Text = string.Format("{0:mm\\:ss}", stopWatch.Elapsed);

            if (lblTimer.Text == "00:02" && lblCurrentHalf.Text == "Current half: 2")
            {
                btnHometeamScore.Enabled = false;
                btnAwayteamScore.Enabled = false;
                btnStartClock.Enabled = false;
                btnWithdrawHometeam.Enabled = false;
                btnWithdrawAwayteam.Enabled = false;

                stopWatch.Stop();
                //stopWatch.Restart();
                lblCurrentHalf.Text = "Game Over";
            }
            else if (lblTimer.Text == "00:02" && lblCurrentHalf.Text == "Current half: 1")
            {
                stopWatch.Reset();
                lblCurrentHalf.Text = "Current half: 2";
                btnStartClock.Text = "START CLOCK";

                btnHometeamScore.Enabled = false;
                btnAwayteamScore.Enabled = false;
                //btnStartClock.Enabled = false;
                btnWithdrawHometeam.Enabled = false;
                btnWithdrawAwayteam.Enabled = false;
                //stopWatch.Stop();
                //return;

            }
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            stopWatch = new Stopwatch();

            btnHometeamScore.Enabled = false;
            btnAwayteamScore.Enabled = false;
            btnWithdrawHometeam.Enabled = false;
            btnWithdrawAwayteam.Enabled = false;
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblHometeamScore.Text = "0";

            lblAwayteamScore.Text = "0";

            lblTimer.Text = "00:00";

            btnStartClock.Text = "START CLOCK";

            stopWatch.Reset();

            lblCurrentHalf.Text = "Current half: 1";

            btnStartClock.Enabled = true;
        }

        private void btnWithdrawHometeam_Click(object sender, EventArgs e)
        {
            int score = Convert.ToInt32(lblHometeamScore.Text);

            score--;

            lblHometeamScore.Text = score.ToString();
        }

        private void btnWithdrawAwayteam_Click(object sender, EventArgs e)
        {
            int score = Convert.ToInt32(lblAwayteamScore.Text);

            score--;

            lblAwayteamScore.Text = score.ToString();
        }

        private void btnResetClock_Click(object sender, EventArgs e)
        {
            lblTimer.Text = "00:00";
            stopWatch.Reset();
            btnStartClock.Text = "START CLOCK";
        }

        private void addPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPlayerForm playerForm = new AddPlayerForm();

            playerForm.Show();
        }

        private void editPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditPlayerForm editPlayerForm = new EditPlayerForm();

            editPlayerForm.Show();
        }
    }
}
