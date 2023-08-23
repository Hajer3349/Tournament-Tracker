namespace TrackerUI
{
    partial class createTournamentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(createTournamentForm));
            this.tournamentNameLabel = new System.Windows.Forms.Label();
            this.createTournamentLabel = new System.Windows.Forms.Label();
            this.entryFeeValue = new System.Windows.Forms.TextBox();
            this.entryFeeLabel = new System.Windows.Forms.Label();
            this.tournamentNameTextBox = new System.Windows.Forms.TextBox();
            this.selectTeamLabel = new System.Windows.Forms.Label();
            this.selectTeamComboBox = new System.Windows.Forms.ComboBox();
            this.createNewLink = new System.Windows.Forms.LinkLabel();
            this.addTeamButton = new System.Windows.Forms.Button();
            this.createPrizeButton = new System.Windows.Forms.Button();
            this.tournamentPlayersListBoxLabel = new System.Windows.Forms.Label();
            this.tournamentPlayersListBox = new System.Windows.Forms.ListBox();
            this.teamsRemoveButton = new System.Windows.Forms.Button();
            this.prizesListBoxLabel = new System.Windows.Forms.Label();
            this.prizesListBox = new System.Windows.Forms.ListBox();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.prizesRemoveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tournamentNameLabel
            // 
            this.tournamentNameLabel.AutoSize = true;
            this.tournamentNameLabel.Location = new System.Drawing.Point(46, 104);
            this.tournamentNameLabel.Name = "tournamentNameLabel";
            this.tournamentNameLabel.Size = new System.Drawing.Size(247, 38);
            this.tournamentNameLabel.TabIndex = 0;
            this.tournamentNameLabel.Text = "Tournament Name";
            // 
            // createTournamentLabel
            // 
            this.createTournamentLabel.AutoSize = true;
            this.createTournamentLabel.Font = new System.Drawing.Font("Segoe UI Light", 24F);
            this.createTournamentLabel.Location = new System.Drawing.Point(44, 31);
            this.createTournamentLabel.Name = "createTournamentLabel";
            this.createTournamentLabel.Size = new System.Drawing.Size(340, 54);
            this.createTournamentLabel.TabIndex = 0;
            this.createTournamentLabel.Text = "Create Tournament";
            // 
            // entryFeeValue
            // 
            this.entryFeeValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.entryFeeValue.Location = new System.Drawing.Point(184, 223);
            this.entryFeeValue.Name = "entryFeeValue";
            this.entryFeeValue.Size = new System.Drawing.Size(112, 43);
            this.entryFeeValue.TabIndex = 1;
            this.entryFeeValue.Text = "0";
            // 
            // entryFeeLabel
            // 
            this.entryFeeLabel.AutoSize = true;
            this.entryFeeLabel.Location = new System.Drawing.Point(46, 223);
            this.entryFeeLabel.Name = "entryFeeLabel";
            this.entryFeeLabel.Size = new System.Drawing.Size(132, 38);
            this.entryFeeLabel.TabIndex = 0;
            this.entryFeeLabel.Text = "Entry Fee";
            // 
            // tournamentNameTextBox
            // 
            this.tournamentNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tournamentNameTextBox.Location = new System.Drawing.Point(53, 145);
            this.tournamentNameTextBox.Name = "tournamentNameTextBox";
            this.tournamentNameTextBox.Size = new System.Drawing.Size(343, 43);
            this.tournamentNameTextBox.TabIndex = 1;
            // 
            // selectTeamLabel
            // 
            this.selectTeamLabel.AutoSize = true;
            this.selectTeamLabel.Location = new System.Drawing.Point(46, 316);
            this.selectTeamLabel.Name = "selectTeamLabel";
            this.selectTeamLabel.Size = new System.Drawing.Size(164, 38);
            this.selectTeamLabel.TabIndex = 0;
            this.selectTeamLabel.Text = "Select Team";
            // 
            // selectTeamComboBox
            // 
            this.selectTeamComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectTeamComboBox.FormattingEnabled = true;
            this.selectTeamComboBox.Location = new System.Drawing.Point(53, 357);
            this.selectTeamComboBox.Name = "selectTeamComboBox";
            this.selectTeamComboBox.Size = new System.Drawing.Size(343, 45);
            this.selectTeamComboBox.TabIndex = 2;
            this.selectTeamComboBox.SelectedIndexChanged += new System.EventHandler(this.selectTeamComboBox_SelectedIndexChanged);
            // 
            // createNewLink
            // 
            this.createNewLink.AutoSize = true;
            this.createNewLink.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createNewLink.Location = new System.Drawing.Point(255, 316);
            this.createNewLink.Name = "createNewLink";
            this.createNewLink.Size = new System.Drawing.Size(125, 31);
            this.createNewLink.TabIndex = 3;
            this.createNewLink.TabStop = true;
            this.createNewLink.Text = "create new";
            this.createNewLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createNewLink_LinkClicked);
            // 
            // addTeamButton
            // 
            this.addTeamButton.Location = new System.Drawing.Point(115, 421);
            this.addTeamButton.Name = "addTeamButton";
            this.addTeamButton.Size = new System.Drawing.Size(195, 66);
            this.addTeamButton.TabIndex = 4;
            this.addTeamButton.Text = "Add Team";
            this.addTeamButton.UseVisualStyleBackColor = true;
            this.addTeamButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // createPrizeButton
            // 
            this.createPrizeButton.Location = new System.Drawing.Point(115, 523);
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.Size = new System.Drawing.Size(195, 66);
            this.createPrizeButton.TabIndex = 4;
            this.createPrizeButton.Text = "Create Prize";
            this.createPrizeButton.UseVisualStyleBackColor = true;
            this.createPrizeButton.Click += new System.EventHandler(this.createPrizeButton_Click);
            // 
            // tournamentPlayersListBoxLabel
            // 
            this.tournamentPlayersListBoxLabel.AutoSize = true;
            this.tournamentPlayersListBoxLabel.Location = new System.Drawing.Point(461, 104);
            this.tournamentPlayersListBoxLabel.Name = "tournamentPlayersListBoxLabel";
            this.tournamentPlayersListBoxLabel.Size = new System.Drawing.Size(209, 38);
            this.tournamentPlayersListBoxLabel.TabIndex = 0;
            this.tournamentPlayersListBoxLabel.Text = "Teams / Players";
            // 
            // tournamentPlayersListBox
            // 
            this.tournamentPlayersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tournamentPlayersListBox.FormattingEnabled = true;
            this.tournamentPlayersListBox.ItemHeight = 37;
            this.tournamentPlayersListBox.Location = new System.Drawing.Point(468, 145);
            this.tournamentPlayersListBox.Name = "tournamentPlayersListBox";
            this.tournamentPlayersListBox.Size = new System.Drawing.Size(370, 187);
            this.tournamentPlayersListBox.TabIndex = 5;
            // 
            // teamsRemoveButton
            // 
            this.teamsRemoveButton.Location = new System.Drawing.Point(858, 194);
            this.teamsRemoveButton.Name = "teamsRemoveButton";
            this.teamsRemoveButton.Size = new System.Drawing.Size(152, 95);
            this.teamsRemoveButton.TabIndex = 4;
            this.teamsRemoveButton.Text = "Remove Selected";
            this.teamsRemoveButton.UseVisualStyleBackColor = true;
            this.teamsRemoveButton.Click += new System.EventHandler(this.teamsRemoveButton_Click);
            // 
            // prizesListBoxLabel
            // 
            this.prizesListBoxLabel.AutoSize = true;
            this.prizesListBoxLabel.Location = new System.Drawing.Point(461, 361);
            this.prizesListBoxLabel.Name = "prizesListBoxLabel";
            this.prizesListBoxLabel.Size = new System.Drawing.Size(90, 38);
            this.prizesListBoxLabel.TabIndex = 0;
            this.prizesListBoxLabel.Text = "Prizes";
            // 
            // prizesListBox
            // 
            this.prizesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prizesListBox.FormattingEnabled = true;
            this.prizesListBox.ItemHeight = 37;
            this.prizesListBox.Location = new System.Drawing.Point(468, 402);
            this.prizesListBox.Name = "prizesListBox";
            this.prizesListBox.Size = new System.Drawing.Size(370, 187);
            this.prizesListBox.TabIndex = 5;
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.Location = new System.Drawing.Point(393, 629);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(277, 79);
            this.createTournamentButton.TabIndex = 4;
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.UseVisualStyleBackColor = true;
            this.createTournamentButton.Click += new System.EventHandler(this.createTournamentButton_Click);
            // 
            // prizesRemoveButton
            // 
            this.prizesRemoveButton.Location = new System.Drawing.Point(858, 436);
            this.prizesRemoveButton.Name = "prizesRemoveButton";
            this.prizesRemoveButton.Size = new System.Drawing.Size(152, 95);
            this.prizesRemoveButton.TabIndex = 4;
            this.prizesRemoveButton.Text = "Remove Selected";
            this.prizesRemoveButton.UseVisualStyleBackColor = true;
            this.prizesRemoveButton.Click += new System.EventHandler(this.prizesRemoveButton_Click);
            // 
            // createTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 740);
            this.Controls.Add(this.prizesListBox);
            this.Controls.Add(this.tournamentPlayersListBox);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.createPrizeButton);
            this.Controls.Add(this.prizesRemoveButton);
            this.Controls.Add(this.teamsRemoveButton);
            this.Controls.Add(this.addTeamButton);
            this.Controls.Add(this.createNewLink);
            this.Controls.Add(this.selectTeamComboBox);
            this.Controls.Add(this.tournamentNameTextBox);
            this.Controls.Add(this.entryFeeValue);
            this.Controls.Add(this.createTournamentLabel);
            this.Controls.Add(this.selectTeamLabel);
            this.Controls.Add(this.prizesListBoxLabel);
            this.Controls.Add(this.entryFeeLabel);
            this.Controls.Add(this.tournamentPlayersListBoxLabel);
            this.Controls.Add(this.tournamentNameLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "createTournamentForm";
            this.Text = "Create Tournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tournamentNameLabel;
        private System.Windows.Forms.Label createTournamentLabel;
        private System.Windows.Forms.TextBox entryFeeValue;
        private System.Windows.Forms.Label entryFeeLabel;
        private System.Windows.Forms.TextBox tournamentNameTextBox;
        private System.Windows.Forms.Label selectTeamLabel;
        private System.Windows.Forms.ComboBox selectTeamComboBox;
        private System.Windows.Forms.LinkLabel createNewLink;
        private System.Windows.Forms.Button addTeamButton;
        private System.Windows.Forms.Button createPrizeButton;
        private System.Windows.Forms.Label tournamentPlayersListBoxLabel;
        private System.Windows.Forms.ListBox tournamentPlayersListBox;
        private System.Windows.Forms.Button teamsRemoveButton;
        private System.Windows.Forms.Label prizesListBoxLabel;
        private System.Windows.Forms.ListBox prizesListBox;
        private System.Windows.Forms.Button createTournamentButton;
        private System.Windows.Forms.Button prizesRemoveButton;
    }
}