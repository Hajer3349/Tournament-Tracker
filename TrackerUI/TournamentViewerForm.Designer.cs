namespace TrackerUI
{
    partial class tournamentViewerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tournamentViewerForm));
            this.tournamentLabel = new System.Windows.Forms.Label();
            this.tournamentNameLabel = new System.Windows.Forms.Label();
            this.roundLabel = new System.Windows.Forms.Label();
            this.roundComboBox = new System.Windows.Forms.ComboBox();
            this.unplayedCheckBox = new System.Windows.Forms.CheckBox();
            this.matchupListBox = new System.Windows.Forms.ListBox();
            this.teanOneLabel = new System.Windows.Forms.Label();
            this.scoreOneLabel = new System.Windows.Forms.Label();
            this.scoreOneValue = new System.Windows.Forms.TextBox();
            this.teamTwoLabel = new System.Windows.Forms.Label();
            this.scoreTwoLabel = new System.Windows.Forms.Label();
            this.scoreTwoValue = new System.Windows.Forms.TextBox();
            this.VSLabel = new System.Windows.Forms.Label();
            this.scoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tournamentLabel
            // 
            this.tournamentLabel.AutoSize = true;
            this.tournamentLabel.Font = new System.Drawing.Font("Segoe UI Light", 24F);
            this.tournamentLabel.Location = new System.Drawing.Point(38, 32);
            this.tournamentLabel.Name = "tournamentLabel";
            this.tournamentLabel.Size = new System.Drawing.Size(186, 45);
            this.tournamentLabel.TabIndex = 0;
            this.tournamentLabel.Text = "Tournament:";
            // 
            // tournamentNameLabel
            // 
            this.tournamentNameLabel.AutoSize = true;
            this.tournamentNameLabel.Font = new System.Drawing.Font("Segoe UI Light", 24F);
            this.tournamentNameLabel.Location = new System.Drawing.Point(230, 32);
            this.tournamentNameLabel.Name = "tournamentNameLabel";
            this.tournamentNameLabel.Size = new System.Drawing.Size(130, 45);
            this.tournamentNameLabel.TabIndex = 0;
            this.tournamentNameLabel.Text = "<none>";
            // 
            // roundLabel
            // 
            this.roundLabel.AutoSize = true;
            this.roundLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundLabel.Location = new System.Drawing.Point(39, 111);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(94, 37);
            this.roundLabel.TabIndex = 1;
            this.roundLabel.Text = "Round";
            // 
            // roundComboBox
            // 
            this.roundComboBox.FormattingEnabled = true;
            this.roundComboBox.Location = new System.Drawing.Point(162, 112);
            this.roundComboBox.Name = "roundComboBox";
            this.roundComboBox.Size = new System.Drawing.Size(255, 38);
            this.roundComboBox.TabIndex = 2;
            // 
            // unplayedCheckBox
            // 
            this.unplayedCheckBox.AutoSize = true;
            this.unplayedCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unplayedCheckBox.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unplayedCheckBox.Location = new System.Drawing.Point(162, 156);
            this.unplayedCheckBox.Name = "unplayedCheckBox";
            this.unplayedCheckBox.Size = new System.Drawing.Size(209, 41);
            this.unplayedCheckBox.TabIndex = 3;
            this.unplayedCheckBox.Text = "Unplayed Only";
            this.unplayedCheckBox.UseVisualStyleBackColor = true;
            // 
            // matchupListBox
            // 
            this.matchupListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchupListBox.FormattingEnabled = true;
            this.matchupListBox.ItemHeight = 30;
            this.matchupListBox.Location = new System.Drawing.Point(47, 250);
            this.matchupListBox.Name = "matchupListBox";
            this.matchupListBox.Size = new System.Drawing.Size(370, 272);
            this.matchupListBox.TabIndex = 4;
            this.matchupListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // teanOneLabel
            // 
            this.teanOneLabel.AutoSize = true;
            this.teanOneLabel.Location = new System.Drawing.Point(447, 247);
            this.teanOneLabel.Name = "teanOneLabel";
            this.teanOneLabel.Size = new System.Drawing.Size(135, 30);
            this.teanOneLabel.TabIndex = 5;
            this.teanOneLabel.Text = "<team one>";
            // 
            // scoreOneLabel
            // 
            this.scoreOneLabel.AutoSize = true;
            this.scoreOneLabel.Location = new System.Drawing.Point(449, 313);
            this.scoreOneLabel.Name = "scoreOneLabel";
            this.scoreOneLabel.Size = new System.Drawing.Size(68, 30);
            this.scoreOneLabel.TabIndex = 5;
            this.scoreOneLabel.Text = "Score";
            // 
            // scoreOneValue
            // 
            this.scoreOneValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scoreOneValue.Location = new System.Drawing.Point(541, 308);
            this.scoreOneValue.Name = "scoreOneValue";
            this.scoreOneValue.Size = new System.Drawing.Size(100, 36);
            this.scoreOneValue.TabIndex = 6;
            // 
            // teamTwoLabel
            // 
            this.teamTwoLabel.AutoSize = true;
            this.teamTwoLabel.Location = new System.Drawing.Point(449, 425);
            this.teamTwoLabel.Name = "teamTwoLabel";
            this.teamTwoLabel.Size = new System.Drawing.Size(134, 30);
            this.teamTwoLabel.TabIndex = 5;
            this.teamTwoLabel.Text = "<team two>";
            // 
            // scoreTwoLabel
            // 
            this.scoreTwoLabel.AutoSize = true;
            this.scoreTwoLabel.Location = new System.Drawing.Point(449, 491);
            this.scoreTwoLabel.Name = "scoreTwoLabel";
            this.scoreTwoLabel.Size = new System.Drawing.Size(68, 30);
            this.scoreTwoLabel.TabIndex = 5;
            this.scoreTwoLabel.Text = "Score";
            // 
            // scoreTwoValue
            // 
            this.scoreTwoValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scoreTwoValue.Location = new System.Drawing.Point(541, 486);
            this.scoreTwoValue.Name = "scoreTwoValue";
            this.scoreTwoValue.Size = new System.Drawing.Size(100, 36);
            this.scoreTwoValue.TabIndex = 6;
            // 
            // VSLabel
            // 
            this.VSLabel.AutoSize = true;
            this.VSLabel.Location = new System.Drawing.Point(534, 376);
            this.VSLabel.Name = "VSLabel";
            this.VSLabel.Size = new System.Drawing.Size(57, 30);
            this.VSLabel.TabIndex = 5;
            this.VSLabel.Text = "-VS-";
            // 
            // scoreButton
            // 
            this.scoreButton.Location = new System.Drawing.Point(669, 363);
            this.scoreButton.Name = "scoreButton";
            this.scoreButton.Size = new System.Drawing.Size(138, 63);
            this.scoreButton.TabIndex = 7;
            this.scoreButton.Text = "Score";
            this.scoreButton.UseVisualStyleBackColor = true;
            // 
            // tournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(930, 598);
            this.Controls.Add(this.scoreButton);
            this.Controls.Add(this.scoreTwoValue);
            this.Controls.Add(this.scoreOneValue);
            this.Controls.Add(this.scoreTwoLabel);
            this.Controls.Add(this.VSLabel);
            this.Controls.Add(this.teamTwoLabel);
            this.Controls.Add(this.scoreOneLabel);
            this.Controls.Add(this.teanOneLabel);
            this.Controls.Add(this.matchupListBox);
            this.Controls.Add(this.unplayedCheckBox);
            this.Controls.Add(this.roundComboBox);
            this.Controls.Add(this.roundLabel);
            this.Controls.Add(this.tournamentNameLabel);
            this.Controls.Add(this.tournamentLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "tournamentViewerForm";
            this.Text = "Tournament Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tournamentLabel;
        private System.Windows.Forms.Label tournamentNameLabel;
        private System.Windows.Forms.Label roundLabel;
        private System.Windows.Forms.ComboBox roundComboBox;
        private System.Windows.Forms.CheckBox unplayedCheckBox;
        private System.Windows.Forms.ListBox matchupListBox;
        private System.Windows.Forms.Label teanOneLabel;
        private System.Windows.Forms.Label scoreOneLabel;
        private System.Windows.Forms.TextBox scoreOneValue;
        private System.Windows.Forms.Label teamTwoLabel;
        private System.Windows.Forms.Label scoreTwoLabel;
        private System.Windows.Forms.TextBox scoreTwoValue;
        private System.Windows.Forms.Label VSLabel;
        private System.Windows.Forms.Button scoreButton;
    }
}

