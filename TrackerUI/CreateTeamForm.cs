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
    public partial class createTeamForm : Form
    {
        private List<PersonModel> availableTeamMembers = GlobalConfig.connection.GetAllPeople();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();

        private ITeamRequester CallingForm;
        public createTeamForm(ITeamRequester caller)
        {
            InitializeComponent();
            //CreateSampleData();
            WireUp();
            CallingForm = caller;
        }

        private void CreateSampleData()
        {
            availableTeamMembers.Add(new PersonModel { FirstName = "Turkey", LastName = "AL Harrasi" });
            availableTeamMembers.Add(new PersonModel { FirstName = "Farah", LastName = "AL Nidabi" });

            selectedTeamMembers.Add(new PersonModel { FirstName = "Mohammed", LastName = "AL Nidabi" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "Dimah", LastName = "AL Raqaishi" });
        }

        private void WireUp()
        {
            selectTeamMemberComboBox.DataSource = null;
            selectTeamMemberComboBox.DataSource = availableTeamMembers;
            selectTeamMemberComboBox.DisplayMember = "FullName";

            teamMembersListBox.DataSource = null;
            teamMembersListBox.DataSource = selectedTeamMembers;
            teamMembersListBox.DisplayMember = "FullName";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel person = new PersonModel
                (firstNameTextBox.Text,
                lastNameTextBox.Text,
                emailTextBox.Text,
                cellPhoneTextBox.Text);
                

                person = GlobalConfig.connection.CreatePerson(person);

                selectedTeamMembers.Add(person);
                WireUp();

                firstNameTextBox.Text = "";
                lastNameTextBox.Text = "";
                emailTextBox.Text = "";
                cellPhoneTextBox.Text = "";

            }
            else 
            {
                MessageBox.Show("You need to insert all fields");
            }
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(firstNameTextBox.Text))
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(lastNameTextBox.Text))
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(emailTextBox.Text))
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(cellPhoneTextBox.Text))
            {
                return false;
            }

            return true;
        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)selectTeamMemberComboBox.SelectedItem;
            if (p != null)
            {
                availableTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);
                WireUp(); 
            }
        }

        private void selectTeamMemberComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void teamMembersRemoveButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)teamMembersListBox.SelectedItem;
            if (p != null)
            {
                selectedTeamMembers.Remove(p);
                availableTeamMembers.Add(p);
                WireUp(); 
            }
        }

        private void createTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = new TeamModel();
            t.TeamName = teamNameTextBox.Text;
            t.TeamMembers = selectedTeamMembers;

            GlobalConfig.connection.CreateTeam(t);

            CallingForm.TeamComplete(t);
            this.Close();
        }
    }
}
