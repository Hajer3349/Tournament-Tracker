using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class createTournamentForm : Form, IPrizeRequester, ITeamRequester
    {
        private List<TeamModel> availableTeams = GlobalConfig.connection.GetAllTeams();
        private List<TeamModel> selectedTeams = new List<TeamModel>();
        private List<PrizeModel> selectedPrizes = new List<PrizeModel>();
        public createTournamentForm()
        {
            InitializeComponent();
            WireUpLists();
        }

        private void WireUpLists()
        {
            selectTeamComboBox.DataSource = null;
            selectTeamComboBox.DataSource = availableTeams;
            selectTeamComboBox.DisplayMember = nameof(TeamModel.TeamName);

            tournamentPlayersListBox.DataSource = null;
            tournamentPlayersListBox.DataSource = selectedTeams;
            tournamentPlayersListBox.DisplayMember = nameof(TeamModel.TeamName);

            prizesListBox.DataSource = null;
            prizesListBox.DataSource = selectedPrizes;
            prizesListBox.DisplayMember = nameof(PrizeModel.PlaceName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)selectTeamComboBox.SelectedItem;
            if (t != null)
            {
                availableTeams.Remove(t);
                selectedTeams.Add(t);
                WireUpLists();
            }
        }

        private void selectTeamComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void teamsRemoveButton_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)tournamentPlayersListBox.SelectedItem;
            if (t != null)
            {
                selectedTeams.Remove(t);
                availableTeams.Add(t);
                WireUpLists();
            }
        }

        private void prizesRemoveButton_Click(object sender, EventArgs e)
        {
            PrizeModel p = (PrizeModel)prizesListBox.SelectedItem;
            if (p != null)
            {
                selectedPrizes.Remove(p);
                WireUpLists();
            }
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            // Call CreatePrizeForm
            CreatePrizeForm frm = new CreatePrizeForm(this);
            frm.Show();
            
        }

        public void PrizeComplete(PrizeModel model)
        {
            // Get back from the form a prize model
            // Insert the prize model into the selected prizes list
            selectedPrizes.Add(model);
            WireUpLists();
        }

        private void createNewLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Call Create Team Form
            createTeamForm frm = new createTeamForm(this);
            frm.Show();
        }

        public void TeamComplete(TeamModel model)
        {
            // Get back from the form a Team model
            // Insert the team model into the selected teams list
            selectedTeams.Add(model);
            WireUpLists();
        }

        private void createTournamentButton_Click(object sender, EventArgs e)
        {
            // Validate data
            decimal fee = 0;

            bool feeAcceptable = decimal.TryParse(entryFeeValue.Text, out fee);

            if (!feeAcceptable)
            {
                MessageBox.Show("You need to enter a valid entry fee.", "Invalid Fee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create our Tournament model
            TournamentModel tm = new TournamentModel();

            tm.TournamentName = tournamentNameTextBox.Text;
            tm.EntryFee = fee;
            tm.EnteredTeams = selectedTeams;
            tm.Prizes = selectedPrizes;
            // Wire up our matchups

            TournamentLogic.CreateRounds(tm);

            // Create Tournament entry
            // Create all of the prizes entries
            // Create all of team entries
            GlobalConfig.connection.CreateTournament(tm);

        }
    }
}
