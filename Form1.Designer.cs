namespace InlamingsUppgiftDBKurs
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewTeamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHometeamScore = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAwayteamScore = new System.Windows.Forms.Button();
            this.btnStartClock = new System.Windows.Forms.Button();
            this.lblAwayteamScore = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnWithdrawAwayteam = new System.Windows.Forms.Button();
            this.comboboxAwayTeam = new System.Windows.Forms.ComboBox();
            this.btnResetClock = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblCurrentHalf = new System.Windows.Forms.Label();
            this.btnWithdrawHometeam = new System.Windows.Forms.Button();
            this.lblHometeamScore = new System.Windows.Forms.Label();
            this.comboboxHomeTeam = new System.Windows.Forms.ComboBox();
            this.comboboxleague = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.searchPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPlayerToolStripMenuItem,
            this.editPlayerToolStripMenuItem,
            this.deletePlayerToolStripMenuItem,
            this.searchPlayerToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addPlayerToolStripMenuItem
            // 
            this.addPlayerToolStripMenuItem.Name = "addPlayerToolStripMenuItem";
            this.addPlayerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addPlayerToolStripMenuItem.Text = "Add player";
            this.addPlayerToolStripMenuItem.Click += new System.EventHandler(this.addPlayerToolStripMenuItem_Click);
            // 
            // editPlayerToolStripMenuItem
            // 
            this.editPlayerToolStripMenuItem.Name = "editPlayerToolStripMenuItem";
            this.editPlayerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editPlayerToolStripMenuItem.Text = "Edit player";
            this.editPlayerToolStripMenuItem.Click += new System.EventHandler(this.editPlayerToolStripMenuItem_Click);
            // 
            // deletePlayerToolStripMenuItem
            // 
            this.deletePlayerToolStripMenuItem.Name = "deletePlayerToolStripMenuItem";
            this.deletePlayerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deletePlayerToolStripMenuItem.Text = "Delete player";
            this.deletePlayerToolStripMenuItem.Click += new System.EventHandler(this.deletePlayerToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewPlayerToolStripMenuItem,
            this.viewTeamToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // viewPlayerToolStripMenuItem
            // 
            this.viewPlayerToolStripMenuItem.Name = "viewPlayerToolStripMenuItem";
            this.viewPlayerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewPlayerToolStripMenuItem.Text = "View player";
            this.viewPlayerToolStripMenuItem.Click += new System.EventHandler(this.viewPlayerToolStripMenuItem_Click);
            // 
            // viewTeamToolStripMenuItem
            // 
            this.viewTeamToolStripMenuItem.Name = "viewTeamToolStripMenuItem";
            this.viewTeamToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewTeamToolStripMenuItem.Text = "View team";
            this.viewTeamToolStripMenuItem.Click += new System.EventHandler(this.viewTeamToolStripMenuItem_Click);
            // 
            // btnHometeamScore
            // 
            this.btnHometeamScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHometeamScore.Location = new System.Drawing.Point(3, 277);
            this.btnHometeamScore.Name = "btnHometeamScore";
            this.btnHometeamScore.Size = new System.Drawing.Size(252, 55);
            this.btnHometeamScore.TabIndex = 1;
            this.btnHometeamScore.Text = "Add goal";
            this.btnHometeamScore.UseVisualStyleBackColor = true;
            this.btnHometeamScore.Click += new System.EventHandler(this.btnHometeamScore_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Home team";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(587, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Away team";
            // 
            // btnAwayteamScore
            // 
            this.btnAwayteamScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAwayteamScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAwayteamScore.Location = new System.Drawing.Point(519, 277);
            this.btnAwayteamScore.Name = "btnAwayteamScore";
            this.btnAwayteamScore.Size = new System.Drawing.Size(254, 55);
            this.btnAwayteamScore.TabIndex = 1;
            this.btnAwayteamScore.Text = "Add goal";
            this.btnAwayteamScore.UseVisualStyleBackColor = true;
            this.btnAwayteamScore.Click += new System.EventHandler(this.btnAwayteamScore_Click);
            // 
            // btnStartClock
            // 
            this.btnStartClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartClock.Location = new System.Drawing.Point(261, 277);
            this.btnStartClock.Name = "btnStartClock";
            this.btnStartClock.Size = new System.Drawing.Size(252, 55);
            this.btnStartClock.TabIndex = 1;
            this.btnStartClock.Text = "START CLOCK";
            this.btnStartClock.UseVisualStyleBackColor = true;
            this.btnStartClock.Click += new System.EventHandler(this.btnStartClock_Click);
            // 
            // lblAwayteamScore
            // 
            this.lblAwayteamScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAwayteamScore.AutoSize = true;
            this.lblAwayteamScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAwayteamScore.Location = new System.Drawing.Point(620, 212);
            this.lblAwayteamScore.Name = "lblAwayteamScore";
            this.lblAwayteamScore.Size = new System.Drawing.Size(51, 55);
            this.lblAwayteamScore.TabIndex = 2;
            this.lblAwayteamScore.Text = "0";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnWithdrawAwayteam, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnAwayteamScore, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblAwayteamScore, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.comboboxAwayTeam, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnResetClock, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnStartClock, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblTimer, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblCurrentHalf, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnWithdrawHometeam, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnHometeamScore, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblHometeamScore, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.comboboxHomeTeam, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.comboboxleague, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.24138F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.55172F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.55172F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.55172F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.55172F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.55172F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 411);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // btnWithdrawAwayteam
            // 
            this.btnWithdrawAwayteam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWithdrawAwayteam.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdrawAwayteam.Location = new System.Drawing.Point(519, 345);
            this.btnWithdrawAwayteam.Name = "btnWithdrawAwayteam";
            this.btnWithdrawAwayteam.Size = new System.Drawing.Size(254, 55);
            this.btnWithdrawAwayteam.TabIndex = 1;
            this.btnWithdrawAwayteam.Text = "Withdraw goal";
            this.btnWithdrawAwayteam.UseVisualStyleBackColor = true;
            this.btnWithdrawAwayteam.Click += new System.EventHandler(this.btnWithdrawAwayteam_Click);
            // 
            // comboboxAwayTeam
            // 
            this.comboboxAwayTeam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboboxAwayTeam.FormattingEnabled = true;
            this.comboboxAwayTeam.Location = new System.Drawing.Point(585, 161);
            this.comboboxAwayTeam.Name = "comboboxAwayTeam";
            this.comboboxAwayTeam.Size = new System.Drawing.Size(121, 21);
            this.comboboxAwayTeam.TabIndex = 5;
            // 
            // btnResetClock
            // 
            this.btnResetClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetClock.Location = new System.Drawing.Point(261, 345);
            this.btnResetClock.Name = "btnResetClock";
            this.btnResetClock.Size = new System.Drawing.Size(252, 55);
            this.btnResetClock.TabIndex = 1;
            this.btnResetClock.Text = "RESET CLOCK";
            this.btnResetClock.UseVisualStyleBackColor = true;
            this.btnResetClock.Click += new System.EventHandler(this.btnResetClock_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(314, 212);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(145, 55);
            this.lblTimer.TabIndex = 2;
            this.lblTimer.Text = "00:00";
            // 
            // lblCurrentHalf
            // 
            this.lblCurrentHalf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCurrentHalf.AutoSize = true;
            this.lblCurrentHalf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentHalf.Location = new System.Drawing.Point(313, 159);
            this.lblCurrentHalf.Name = "lblCurrentHalf";
            this.lblCurrentHalf.Size = new System.Drawing.Size(148, 25);
            this.lblCurrentHalf.TabIndex = 4;
            this.lblCurrentHalf.Text = "Current half: 1";
            // 
            // btnWithdrawHometeam
            // 
            this.btnWithdrawHometeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdrawHometeam.Location = new System.Drawing.Point(3, 345);
            this.btnWithdrawHometeam.Name = "btnWithdrawHometeam";
            this.btnWithdrawHometeam.Size = new System.Drawing.Size(252, 55);
            this.btnWithdrawHometeam.TabIndex = 1;
            this.btnWithdrawHometeam.Text = "Withdraw goal";
            this.btnWithdrawHometeam.UseVisualStyleBackColor = true;
            this.btnWithdrawHometeam.Click += new System.EventHandler(this.btnWithdrawHometeam_Click);
            // 
            // lblHometeamScore
            // 
            this.lblHometeamScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHometeamScore.AutoSize = true;
            this.lblHometeamScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHometeamScore.Location = new System.Drawing.Point(103, 212);
            this.lblHometeamScore.Name = "lblHometeamScore";
            this.lblHometeamScore.Size = new System.Drawing.Size(51, 55);
            this.lblHometeamScore.TabIndex = 2;
            this.lblHometeamScore.Text = "0";
            // 
            // comboboxHomeTeam
            // 
            this.comboboxHomeTeam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboboxHomeTeam.FormattingEnabled = true;
            this.comboboxHomeTeam.Location = new System.Drawing.Point(68, 161);
            this.comboboxHomeTeam.Name = "comboboxHomeTeam";
            this.comboboxHomeTeam.Size = new System.Drawing.Size(121, 21);
            this.comboboxHomeTeam.TabIndex = 5;
            // 
            // comboboxleague
            // 
            this.comboboxleague.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboboxleague.FormattingEnabled = true;
            this.comboboxleague.Location = new System.Drawing.Point(326, 93);
            this.comboboxleague.Name = "comboboxleague";
            this.comboboxleague.Size = new System.Drawing.Size(121, 21);
            this.comboboxleague.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(339, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Select league";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Select home team";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(584, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Select away team";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // searchPlayerToolStripMenuItem
            // 
            this.searchPlayerToolStripMenuItem.Name = "searchPlayerToolStripMenuItem";
            this.searchPlayerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.searchPlayerToolStripMenuItem.Text = "Search player";
            this.searchPlayerToolStripMenuItem.Click += new System.EventHandler(this.searchPlayerToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Scoretracker";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editPlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletePlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewPlayerToolStripMenuItem;
        private System.Windows.Forms.Button btnHometeamScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAwayteamScore;
        private System.Windows.Forms.Button btnStartClock;
        private System.Windows.Forms.Label lblAwayteamScore;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblHometeamScore;
        private System.Windows.Forms.ToolStripMenuItem viewTeamToolStripMenuItem;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.Button btnWithdrawHometeam;
        private System.Windows.Forms.Button btnWithdrawAwayteam;
        private System.Windows.Forms.Label lblCurrentHalf;
        private System.Windows.Forms.Button btnResetClock;
        private System.Windows.Forms.ComboBox comboboxAwayTeam;
        private System.Windows.Forms.ComboBox comboboxHomeTeam;
        private System.Windows.Forms.ComboBox comboboxleague;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem searchPlayerToolStripMenuItem;
    }
}

