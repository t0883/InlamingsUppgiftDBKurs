namespace InlamingsUppgiftDBKurs
{
    partial class EditPlayerForm
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
            this.btnUpdatePlayer = new System.Windows.Forms.Button();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.comboBoxTeam = new System.Windows.Forms.ComboBox();
            this.comboBoxLeague = new System.Windows.Forms.ComboBox();
            this.comboboxPlayerPosition = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblplayerCountry = new System.Windows.Forms.Label();
            this.txtboxPlayerNumber = new System.Windows.Forms.TextBox();
            this.lblplayerTeam = new System.Windows.Forms.Label();
            this.txtboxAge = new System.Windows.Forms.TextBox();
            this.lblplayerLeague = new System.Windows.Forms.Label();
            this.txtboxplayerLastName = new System.Windows.Forms.TextBox();
            this.lblplayerPosition = new System.Windows.Forms.Label();
            this.lblplayerNumber = new System.Windows.Forms.Label();
            this.txtboxEmailAdress = new System.Windows.Forms.TextBox();
            this.txtboxPhonenumber = new System.Windows.Forms.TextBox();
            this.txtboxplayerFirstName = new System.Windows.Forms.TextBox();
            this.lblplayerEmailAddress = new System.Windows.Forms.Label();
            this.lblplayerAge = new System.Windows.Forms.Label();
            this.lblplayerPhoneNumber = new System.Windows.Forms.Label();
            this.lblplayerLastName = new System.Windows.Forms.Label();
            this.lblplayerFirstName = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtboxSeachFirstName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtboxSearchLastName = new System.Windows.Forms.TextBox();
            this.lblplayerId = new System.Windows.Forms.Label();
            this.txtplayerId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnUpdatePlayer
            // 
            this.btnUpdatePlayer.Location = new System.Drawing.Point(548, 368);
            this.btnUpdatePlayer.Name = "btnUpdatePlayer";
            this.btnUpdatePlayer.Size = new System.Drawing.Size(75, 23);
            this.btnUpdatePlayer.TabIndex = 33;
            this.btnUpdatePlayer.Text = "Update";
            this.btnUpdatePlayer.UseVisualStyleBackColor = true;
            this.btnUpdatePlayer.Click += new System.EventHandler(this.btnUpdatePlayer_Click);
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Location = new System.Drawing.Point(503, 269);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCountry.TabIndex = 30;
            // 
            // comboBoxTeam
            // 
            this.comboBoxTeam.FormattingEnabled = true;
            this.comboBoxTeam.Location = new System.Drawing.Point(503, 242);
            this.comboBoxTeam.Name = "comboBoxTeam";
            this.comboBoxTeam.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTeam.TabIndex = 29;
            // 
            // comboBoxLeague
            // 
            this.comboBoxLeague.FormattingEnabled = true;
            this.comboBoxLeague.Location = new System.Drawing.Point(503, 215);
            this.comboBoxLeague.Name = "comboBoxLeague";
            this.comboBoxLeague.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLeague.TabIndex = 28;
            // 
            // comboboxPlayerPosition
            // 
            this.comboboxPlayerPosition.FormattingEnabled = true;
            this.comboboxPlayerPosition.Location = new System.Drawing.Point(503, 188);
            this.comboboxPlayerPosition.Name = "comboboxPlayerPosition";
            this.comboboxPlayerPosition.Size = new System.Drawing.Size(121, 21);
            this.comboboxPlayerPosition.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "Edit player in database";
            // 
            // lblplayerCountry
            // 
            this.lblplayerCountry.AutoSize = true;
            this.lblplayerCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblplayerCountry.Location = new System.Drawing.Point(392, 268);
            this.lblplayerCountry.Name = "lblplayerCountry";
            this.lblplayerCountry.Size = new System.Drawing.Size(64, 18);
            this.lblplayerCountry.TabIndex = 21;
            this.lblplayerCountry.Text = "Country:";
            // 
            // txtboxPlayerNumber
            // 
            this.txtboxPlayerNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxPlayerNumber.Location = new System.Drawing.Point(503, 159);
            this.txtboxPlayerNumber.Name = "txtboxPlayerNumber";
            this.txtboxPlayerNumber.Size = new System.Drawing.Size(123, 24);
            this.txtboxPlayerNumber.TabIndex = 26;
            // 
            // lblplayerTeam
            // 
            this.lblplayerTeam.AutoSize = true;
            this.lblplayerTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblplayerTeam.Location = new System.Drawing.Point(392, 245);
            this.lblplayerTeam.Name = "lblplayerTeam";
            this.lblplayerTeam.Size = new System.Drawing.Size(50, 18);
            this.lblplayerTeam.TabIndex = 19;
            this.lblplayerTeam.Text = "Team:";
            // 
            // txtboxAge
            // 
            this.txtboxAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxAge.Location = new System.Drawing.Point(476, 129);
            this.txtboxAge.Name = "txtboxAge";
            this.txtboxAge.Size = new System.Drawing.Size(150, 24);
            this.txtboxAge.TabIndex = 25;
            // 
            // lblplayerLeague
            // 
            this.lblplayerLeague.AutoSize = true;
            this.lblplayerLeague.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblplayerLeague.Location = new System.Drawing.Point(392, 218);
            this.lblplayerLeague.Name = "lblplayerLeague";
            this.lblplayerLeague.Size = new System.Drawing.Size(60, 18);
            this.lblplayerLeague.TabIndex = 12;
            this.lblplayerLeague.Text = "League:";
            // 
            // txtboxplayerLastName
            // 
            this.txtboxplayerLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxplayerLastName.Location = new System.Drawing.Point(476, 99);
            this.txtboxplayerLastName.Name = "txtboxplayerLastName";
            this.txtboxplayerLastName.Size = new System.Drawing.Size(150, 24);
            this.txtboxplayerLastName.TabIndex = 23;
            // 
            // lblplayerPosition
            // 
            this.lblplayerPosition.AutoSize = true;
            this.lblplayerPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblplayerPosition.Location = new System.Drawing.Point(392, 191);
            this.lblplayerPosition.Name = "lblplayerPosition";
            this.lblplayerPosition.Size = new System.Drawing.Size(109, 18);
            this.lblplayerPosition.TabIndex = 17;
            this.lblplayerPosition.Text = "Player position:";
            // 
            // lblplayerNumber
            // 
            this.lblplayerNumber.AutoSize = true;
            this.lblplayerNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblplayerNumber.Location = new System.Drawing.Point(392, 162);
            this.lblplayerNumber.Name = "lblplayerNumber";
            this.lblplayerNumber.Size = new System.Drawing.Size(107, 18);
            this.lblplayerNumber.TabIndex = 16;
            this.lblplayerNumber.Text = "Player number:";
            // 
            // txtboxEmailAdress
            // 
            this.txtboxEmailAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxEmailAdress.Location = new System.Drawing.Point(501, 326);
            this.txtboxEmailAdress.Name = "txtboxEmailAdress";
            this.txtboxEmailAdress.Size = new System.Drawing.Size(123, 24);
            this.txtboxEmailAdress.TabIndex = 32;
            // 
            // txtboxPhonenumber
            // 
            this.txtboxPhonenumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxPhonenumber.Location = new System.Drawing.Point(501, 296);
            this.txtboxPhonenumber.Name = "txtboxPhonenumber";
            this.txtboxPhonenumber.Size = new System.Drawing.Size(123, 24);
            this.txtboxPhonenumber.TabIndex = 31;
            // 
            // txtboxplayerFirstName
            // 
            this.txtboxplayerFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxplayerFirstName.Location = new System.Drawing.Point(476, 69);
            this.txtboxplayerFirstName.Name = "txtboxplayerFirstName";
            this.txtboxplayerFirstName.Size = new System.Drawing.Size(150, 24);
            this.txtboxplayerFirstName.TabIndex = 22;
            // 
            // lblplayerEmailAddress
            // 
            this.lblplayerEmailAddress.AutoSize = true;
            this.lblplayerEmailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblplayerEmailAddress.Location = new System.Drawing.Point(392, 329);
            this.lblplayerEmailAddress.Name = "lblplayerEmailAddress";
            this.lblplayerEmailAddress.Size = new System.Drawing.Size(106, 18);
            this.lblplayerEmailAddress.TabIndex = 15;
            this.lblplayerEmailAddress.Text = "Email address:";
            // 
            // lblplayerAge
            // 
            this.lblplayerAge.AutoSize = true;
            this.lblplayerAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblplayerAge.Location = new System.Drawing.Point(392, 132);
            this.lblplayerAge.Name = "lblplayerAge";
            this.lblplayerAge.Size = new System.Drawing.Size(37, 18);
            this.lblplayerAge.TabIndex = 14;
            this.lblplayerAge.Text = "Age:";
            // 
            // lblplayerPhoneNumber
            // 
            this.lblplayerPhoneNumber.AutoSize = true;
            this.lblplayerPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblplayerPhoneNumber.Location = new System.Drawing.Point(392, 299);
            this.lblplayerPhoneNumber.Name = "lblplayerPhoneNumber";
            this.lblplayerPhoneNumber.Size = new System.Drawing.Size(109, 18);
            this.lblplayerPhoneNumber.TabIndex = 13;
            this.lblplayerPhoneNumber.Text = "Phone number:";
            // 
            // lblplayerLastName
            // 
            this.lblplayerLastName.AutoSize = true;
            this.lblplayerLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblplayerLastName.Location = new System.Drawing.Point(392, 102);
            this.lblplayerLastName.Name = "lblplayerLastName";
            this.lblplayerLastName.Size = new System.Drawing.Size(81, 18);
            this.lblplayerLastName.TabIndex = 18;
            this.lblplayerLastName.Text = "Last name:";
            // 
            // lblplayerFirstName
            // 
            this.lblplayerFirstName.AutoSize = true;
            this.lblplayerFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblplayerFirstName.Location = new System.Drawing.Point(392, 72);
            this.lblplayerFirstName.Name = "lblplayerFirstName";
            this.lblplayerFirstName.Size = new System.Drawing.Size(82, 18);
            this.lblplayerFirstName.TabIndex = 20;
            this.lblplayerFirstName.Text = "First name:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(14, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 18);
            this.label11.TabIndex = 20;
            this.label11.Text = "First name:";
            // 
            // txtboxSeachFirstName
            // 
            this.txtboxSeachFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxSeachFirstName.Location = new System.Drawing.Point(102, 69);
            this.txtboxSeachFirstName.Name = "txtboxSeachFirstName";
            this.txtboxSeachFirstName.Size = new System.Drawing.Size(150, 24);
            this.txtboxSeachFirstName.TabIndex = 22;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(177, 147);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 33;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(14, 102);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 18);
            this.label12.TabIndex = 18;
            this.label12.Text = "Last name:";
            // 
            // txtboxSearchLastName
            // 
            this.txtboxSearchLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxSearchLastName.Location = new System.Drawing.Point(102, 99);
            this.txtboxSearchLastName.Name = "txtboxSearchLastName";
            this.txtboxSearchLastName.Size = new System.Drawing.Size(150, 24);
            this.txtboxSearchLastName.TabIndex = 23;
            // 
            // lblplayerId
            // 
            this.lblplayerId.AutoSize = true;
            this.lblplayerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblplayerId.Location = new System.Drawing.Point(392, 42);
            this.lblplayerId.Name = "lblplayerId";
            this.lblplayerId.Size = new System.Drawing.Size(68, 18);
            this.lblplayerId.TabIndex = 20;
            this.lblplayerId.Text = "Player Id:";
            // 
            // txtplayerId
            // 
            this.txtplayerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtplayerId.Location = new System.Drawing.Point(476, 39);
            this.txtplayerId.Name = "txtplayerId";
            this.txtplayerId.Size = new System.Drawing.Size(150, 24);
            this.txtplayerId.TabIndex = 22;
            // 
            // EditPlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnUpdatePlayer);
            this.Controls.Add(this.comboBoxCountry);
            this.Controls.Add(this.comboBoxTeam);
            this.Controls.Add(this.comboBoxLeague);
            this.Controls.Add(this.comboboxPlayerPosition);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblplayerCountry);
            this.Controls.Add(this.txtboxPlayerNumber);
            this.Controls.Add(this.lblplayerTeam);
            this.Controls.Add(this.txtboxAge);
            this.Controls.Add(this.lblplayerLeague);
            this.Controls.Add(this.txtboxSearchLastName);
            this.Controls.Add(this.txtboxplayerLastName);
            this.Controls.Add(this.lblplayerPosition);
            this.Controls.Add(this.lblplayerNumber);
            this.Controls.Add(this.txtboxEmailAdress);
            this.Controls.Add(this.txtboxPhonenumber);
            this.Controls.Add(this.txtboxSeachFirstName);
            this.Controls.Add(this.txtplayerId);
            this.Controls.Add(this.txtboxplayerFirstName);
            this.Controls.Add(this.lblplayerEmailAddress);
            this.Controls.Add(this.lblplayerAge);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblplayerPhoneNumber);
            this.Controls.Add(this.lblplayerLastName);
            this.Controls.Add(this.lblplayerId);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblplayerFirstName);
            this.Name = "EditPlayerForm";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.EditPlayerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdatePlayer;
        private System.Windows.Forms.ComboBox comboBoxCountry;
        private System.Windows.Forms.ComboBox comboBoxTeam;
        private System.Windows.Forms.ComboBox comboBoxLeague;
        private System.Windows.Forms.ComboBox comboboxPlayerPosition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblplayerCountry;
        private System.Windows.Forms.TextBox txtboxPlayerNumber;
        private System.Windows.Forms.Label lblplayerTeam;
        private System.Windows.Forms.TextBox txtboxAge;
        private System.Windows.Forms.Label lblplayerLeague;
        private System.Windows.Forms.TextBox txtboxplayerLastName;
        private System.Windows.Forms.Label lblplayerPosition;
        private System.Windows.Forms.Label lblplayerNumber;
        private System.Windows.Forms.TextBox txtboxEmailAdress;
        private System.Windows.Forms.TextBox txtboxPhonenumber;
        private System.Windows.Forms.TextBox txtboxplayerFirstName;
        private System.Windows.Forms.Label lblplayerEmailAddress;
        private System.Windows.Forms.Label lblplayerAge;
        private System.Windows.Forms.Label lblplayerPhoneNumber;
        private System.Windows.Forms.Label lblplayerLastName;
        private System.Windows.Forms.Label lblplayerFirstName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtboxSeachFirstName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtboxSearchLastName;
        private System.Windows.Forms.Label lblplayerId;
        private System.Windows.Forms.TextBox txtplayerId;
    }
}