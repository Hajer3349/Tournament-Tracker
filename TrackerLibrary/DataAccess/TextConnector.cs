using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess.TextHelpers;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        private const string PrizesFile = "PrizeModels.csv";
        private const string PeopleFile = "PersonModels.csv";
        private const string TeamsFile = "TeamModels.csv";
        private const string TournamentsFile = "TournamentModels.csv";
        private const string MatchupsFile = "MatchupModels.csv";
        public PersonModel CreatePerson(PersonModel model)
        {
            List<PersonModel> people = PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();

            int currentId = 1;
            if (people.Count > 0)
            {
                currentId = people.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;

            people.Add(model);
            people.SaveToPersonFile(PeopleFile);
            return model;

        }

      
        public PrizeModel CreatePrize(PrizeModel model)
        {
            // load prizes from the text file
            // convert the prizes from string to PrizeModels (extension methods)
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            // find the Max ID
            // add Max Id + 1 to the new model
            int currentId = 1;

            if (prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1; 
            }

            model.Id = currentId;
            // To complete the assigning Id procedure, the below statement must be added so in case of more than one 
            // parameter (more than one record at a time) are passed in the Id will not be the same, but in the current context it's not necessary
            //currentId += 1;
            prizes.Add(model);

            // convert the prizes from PrizeModel to string 
            // insert the prizes to the text file (extension method)
            prizes.SaveToPrizeFile(PrizesFile);

            return model;
            
        }

        public TeamModel CreateTeam(TeamModel model)
        {
            List<TeamModel> teams = TeamsFile.FullFilePath().LoadFile().ConvertToTeamModels(PeopleFile);

            int currentId = 1;
            if (teams.Count > 0)
            {
                currentId = teams.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;

            teams.Add(model);
            teams.SaveToTeamFile(TeamsFile);
            return model;
        }

        public void CreateTournament(TournamentModel model)
        {
            List<TournamentModel> tournaments = TournamentsFile.FullFilePath().LoadFile().ConvertToTournamentModels(TeamsFile, PeopleFile, PrizesFile, MatchupsFile);
            
            int currentId = 1;
            if (tournaments.Count > 0)
            {
                currentId = tournaments.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;

            tournaments.Add(model);
            tournaments.SaveToTournamentFile(TournamentsFile);
        }

        public List<PersonModel> GetAllPeople()
        {
            return PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();
        }

        public List<TeamModel> GetAllTeams()
        {
           return TeamsFile.FullFilePath().LoadFile().ConvertToTeamModels(PeopleFile);
        }
    }
}
