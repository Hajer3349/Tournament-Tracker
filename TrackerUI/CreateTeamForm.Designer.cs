namespace TrackerUI
{
    partial class createTeamForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(createTeamForm));
            this.createTeamLabel = new System.Windows.Forms.Label();
            this.selectTeamMemberComboBox = new System.Windows.Forms.ComboBox();
            this.teamNameTextBox = new System.Windows.Forms.TextBox();
            this.selectTeamMemberLabel = new System.Windows.Forms.Label();
            this.teamNameLabel = new System.Windows.Forms.Label();
            this.addMemberButton = new System.Windows.Forms.Button();
            this.addNewMemberGroupBox = new System.Windows.Forms.GroupBox();
            this.cellPhoneLabel = new System.Windows.Forms.Label();
            this.createMemberButton = new System.Windows.Forms.Button();
            this.emailLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.cellPhoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.teamMembersListBox = new System.Windows.Forms.ListBox();
            this.createTeamButton = new System.Windows.Forms.Button();
            this.teamMembersRemoveButton = new System.Windows.Forms.Button();
            this.addNewMemberGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // createTeamLabel
            // 
            this.createTeamLabel.AutoSize = true;
            this.createTeamLabel.Font = new System.Drawing.Font("Segoe UI Light", 24F);
            this.createTeamLabel.Location = new System.Drawing.Point(12, 20);
            this.createTeamLabel.Name = "createTeamLabel";
            this.createTeamLabel.Size = new System.Drawing.Size(230, 54);
            this.createTeamLabel.TabIndex = 1;
            this.createTeamLabel.Text = "Create Team";
            // 
            // selectTeamMemberComboBox
            // 
            this.selectTeamMemberComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectTeamMemberComboBox.FormattingEnabled = true;
            this.selectTeamMemberComboBox.Location = new System.Drawing.Point(21, 257);
            this.selectTeamMemberComboBox.Name = "selectTeamMemberComboBox";
            this.selectTeamMemberComboBox.Size = new System.Drawing.Size(436, 45);
            this.selectTeamMemberComboBox.TabIndex = 6;
            this.selectTeamMemberComboBox.SelectedIndexChanged += new System.EventHandler(this.selectTeamMemberComboBox_SelectedIndexChanged);
            // 
            // teamNameTextBox
            // 
            this.teamNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teamNameTextBox.Location = new System.Drawing.Point(21, 143);
            this.teamNameTextBox.Name = "teamNameTextBox";
            this.teamNameTextBox.Size = new System.Drawing.Size(436, 43);
            this.teamNameTextBox.TabIndex = 5;
            // 
            // selectTeamMemberLabel
            // 
            this.selectTeamMemberLabel.AutoSize = true;
            this.selectTeamMemberLabel.Location = new System.Drawing.Point(14, 216);
            this.selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            this.selectTeamMemberLabel.Size = new System.Drawing.Size(277, 38);
            this.selectTeamMemberLabel.TabIndex = 3;
            this.selectTeamMemberLabel.Text = "Select Team Member";
            // 
            // teamNameLabel
            // 
            this.teamNameLabel.AutoSize = true;
            this.teamNameLabel.Location = new System.Drawing.Point(14, 102);
            this.teamNameLabel.Name = "teamNameLabel";
            this.teamNameLabel.Size = new System.Drawing.Size(164, 38);
            this.teamNameLabel.TabIndex = 4;
            this.teamNameLabel.Text = "Team Name";
            // 
            // addMemberButton
            // 
            this.addMemberButton.Location = new System.Drawing.Point(117, 301);
            this.addMemberButton.Name = "addMemberButton";
            this.addMemberButton.Size = new System.Drawing.Size(247, 52);
            this.addMemberButton.TabIndex = 7;
            this.addMemberButton.Text = "Add Member";
            this.addMemberButton.UseVisualStyleBackColor = true;
            this.addMemberButton.Click += new System.EventHandler(this.addMemberButton_Click);
            // 
            // addNewMemberGroupBox
            // 
            this.addNewMemberGroupBox.Controls.Add(this.cellPhoneLabel);
            this.addNewMemberGroupBox.Controls.Add(this.createMemberButton);
            this.addNewMemberGroupBox.Controls.Add(this.emailLabel);
            this.addNewMemberGroupBox.Controls.Add(this.lastNameLabel);
            this.addNewMemberGroupBox.Controls.Add(this.cellPhoneTextBox);
            this.addNewMemberGroupBox.Controls.Add(this.emailTextBox);
            this.addNewMemberGroupBox.Controls.Add(this.lastNameTextBox);
            this.addNewMemberGroupBox.Controls.Add(this.firstNameTextBox);
            this.addNewMemberGroupBox.Controls.Add(this.firstNameLabel);
            this.addNewMemberGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewMemberGroupBox.Location = new System.Drawing.Point(21, 360);
            this.addNewMemberGroupBox.Name = "addNewMemberGroupBox";
            this.addNewMemberGroupBox.Size = new System.Drawing.Size(436, 355);
            this.addNewMemberGroupBox.TabIndex = 8;
            this.addNewMemberGroupBox.TabStop = false;
            this.addNewMemberGroupBox.Text = "Add New Member";
            // 
            // cellPhoneLabel
            // 
            this.cellPhoneLabel.AutoSize = true;
            this.cellPhoneLabel.Location = new System.Drawing.Point(6, 217);
            this.cellPhoneLabel.Name = "cellPhoneLabel";
            this.cellPhoneLabel.Size = new System.Drawing.Size(142, 38);
            this.cellPhoneLabel.TabIndex = 3;
            this.cellPhoneLabel.Text = "CellPhone";
            // 
            // createMemberButton
            // 
            this.createMemberButton.Location = new System.Drawing.Point(96, 283);
            this.createMemberButton.Name = "createMemberButton";
            this.createMemberButton.Size = new System.Drawing.Size(247, 52);
            this.createMemberButton.TabIndex = 7;
            this.createMemberButton.Text = "Create Member";
            this.createMemberButton.UseVisualStyleBackColor = true;
            this.createMemberButton.Click += new System.EventHandler(this.createMemberButton_Click);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(6, 163);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(83, 38);
            this.emailLabel.TabIndex = 3;
            this.emailLabel.Text = "Email";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(6, 109);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(147, 38);
            this.lastNameLabel.TabIndex = 3;
            this.lastNameLabel.Text = "Last Name";
            // 
            // cellPhoneTextBox
            // 
            this.cellPhoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cellPhoneTextBox.Location = new System.Drawing.Point(186, 215);
            this.cellPhoneTextBox.Name = "cellPhoneTextBox";
            this.cellPhoneTextBox.Size = new System.Drawing.Size(244, 43);
            this.cellPhoneTextBox.TabIndex = 5;
            this.cellPhoneTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // emailTextBox
            // 
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailTextBox.Location = new System.Drawing.Point(186, 161);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(244, 43);
            this.emailTextBox.TabIndex = 5;
            this.emailTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lastNameTextBox.Location = new System.Drawing.Point(186, 107);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(244, 43);
            this.lastNameTextBox.TabIndex = 5;
            this.lastNameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstNameTextBox.Location = new System.Drawing.Point(186, 55);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(244, 43);
            this.firstNameTextBox.TabIndex = 5;
            this.firstNameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(6, 57);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(151, 38);
            this.firstNameLabel.TabIndex = 3;
            this.firstNameLabel.Text = "First Name";
            // 
            // teamMembersListBox
            // 
            this.teamMembersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teamMembersListBox.FormattingEnabled = true;
            this.teamMembersListBox.ItemHeight = 37;
            this.teamMembersListBox.Location = new System.Drawing.Point(550, 143);
            this.teamMembersListBox.Name = "teamMembersListBox";
            this.teamMembersListBox.Size = new System.Drawing.Size(370, 557);
            this.teamMembersListBox.TabIndex = 9;
            // 
            // createTeamButton
            // 
            this.createTeamButton.Location = new System.Drawing.Point(412, 730);
            this.createTeamButton.Name = "createTeamButton";
            this.createTeamButton.Size = new System.Drawing.Size(195, 69);
            this.createTeamButton.TabIndex = 7;
            this.createTeamButton.Text = "Create Team";
            this.createTeamButton.UseVisualStyleBackColor = true;
            this.createTeamButton.Click += new System.EventHandler(this.createTeamButton_Click);
            // 
            // teamMembersRemoveButton
            // 
            this.teamMembersRemoveButton.Location = new System.Drawing.Point(944, 382);
            this.teamMembersRemoveButton.Name = "teamMembersRemoveButton";
            this.teamMembersRemoveButton.Size = new System.Drawing.Size(152, 95);
            this.teamMembersRemoveButton.TabIndex = 10;
            this.teamMembersRemoveButton.Text = "Remove Selected";
            this.teamMembersRemoveButton.UseVisualStyleBackColor = true;
            this.teamMembersRemoveButton.Click += new System.EventHandler(this.teamMembersRemoveButton_Click);
            // 
            // createTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1131, 824);
            this.Controls.Add(this.teamMembersRemoveButton);
            this.Controls.Add(this.teamMembersListBox);
            this.Controls.Add(this.createTeamButton);
            this.Controls.Add(this.addNewMemberGroupBox);
            this.Controls.Add(this.addMemberButton);
            this.Controls.Add(this.selectTeamMemberComboBox);
            this.Controls.Add(this.teamNameTextBox);
            this.Controls.Add(this.selectTeamMemberLabel);
            this.Controls.Add(this.teamNameLabel);
            this.Controls.Add(this.createTeamLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "createTeamForm";
            this.Text = "Create Team";
            this.addNewMemberGroupBox.ResumeLayout(false);
            this.addNewMemberGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label createTeamLabel;
        private System.Windows.Forms.ComboBox selectTeamMemberComboBox;
        private System.Windows.Forms.TextBox teamNameTextBox;
        private System.Windows.Forms.Label selectTeamMemberLabel;
        private System.Windows.Forms.Label teamNameLabel;
        private System.Windows.Forms.Button addMemberButton;
        private System.Windows.Forms.GroupBox addNewMemberGroupBox;
        private System.Windows.Forms.Label cellPhoneLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Button createMemberButton;
        private System.Windows.Forms.TextBox cellPhoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.ListBox teamMembersListBox;
        private System.Windows.Forms.Button createTeamButton;
        private System.Windows.Forms.Button teamMembersRemoveButton;
    }
}