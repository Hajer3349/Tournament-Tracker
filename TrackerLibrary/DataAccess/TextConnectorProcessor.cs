using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess.TextHelpers
{
    public static class TextConnectorProcessor
    {
        public static string FullFilePath(this string fileName)
        {
            return $"{ ConfigurationManager.AppSettings["filePath"] }\\{ fileName }";
        }

        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file)) 
            { 
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        }

        public static List<PrizeModel> ConvertToPrizeModels(this List<string> lines)
        {
            List<PrizeModel> output = new List<PrizeModel>();
            
            
                
                foreach (string line in lines)
                {
                    string[] cols = line.Split(',');
                    PrizeModel p = new PrizeModel();
                    p.Id = int.Parse(cols[0]);
                    p.PlaceNumber = int.Parse(cols[1]);
                    p.PlaceName = cols[2];
                    p.PrizeAmount = decimal.Parse(cols[3]);
                    p.PrizePercentage = double.Parse(cols[4]);

                    output.Add(p);
                } 
            
            return output;
        }

        public static List<PersonModel> ConvertToPersonModels(this List<string> lines)
        {
            List<PersonModel> output = new List<PersonModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                PersonModel p = new PersonModel();
                p.Id = int.Parse(cols[0]);
                p.FirstName = cols[1];
                p.LastName = cols[2];
                p.EmailAddress = cols[3];
                p.CellPhoneNumber = cols[4];
                output.Add(p);
            }
            return output;
        }

        public static List<TeamModel> ConvertToTeamModels(this List<string> lines, string peopleFileName)
        {
            // 1,Hajer's Team,2|4|6
            List<TeamModel> output = new List<TeamModel>();
            List<PersonModel> people = peopleFileName.FullFilePath().LoadFile().ConvertToPersonModels();
            foreach (string line in lines)
            {
                TeamModel t = new TeamModel();
                string[] cols = line.Split(',');
                t.Id = int.Parse(cols[0]);
                t.TeamName = cols[1];

                string[] personIds = cols[2].Split('|');

                foreach (string id in personIds)
                {
                    t.TeamMembers.Add(people.Where(x => x.Id == int.Parse(id)).First());
                }
                output.Add(t);
            }
            return output;
        }

        public static List<TournamentModel> ConvertToTournamentModels(this List<string> lines, string teamsFileName, string peopleFileName, string prizesFileName, string matchupsFileName)
        {
            // id, TournamentName, EntryFee, EnteredTeamsIds, PrizesIds, MatchupIds|MatchupIds|MatchupIds (Rounds)
            // 1, Beisball Game, 10, id|id|id|id, id|id|id, id^id^id|id^id^id|id^id

            List<TournamentModel> output = new List<TournamentModel>();
            List<TeamModel> teams = teamsFileName.FullFilePath().LoadFile().ConvertToTeamModels(peopleFileName);
            List<PrizeModel> prizes = prizesFileName.FullFilePath().LoadFile().ConvertToPrizeModels();
            

            foreach (string line in lines)
            {
                TournamentModel t = new TournamentModel();
                string[] cols = line.Split(',');
                t.Id = int.Parse(cols[0]);
                t.TournamentName = cols[1];
                t.EntryFee = decimal.Parse(cols[2]);

                string[] teamIds = cols[3].Split('|');
                foreach (string id in teamIds)
                {
                    t.EnteredTeams.Add(teams.Where(x => x.Id == int.Parse(id)).First());
                }

                string[] prizeIds = cols[4].Split('|');
                foreach (string id in prizeIds)
                {
                    t.Prizes.Add(prizes.Where(x => x.Id == int.Parse(id)).First());
                }

               // TODO - Capture rounds information

                output.Add(t);
            }
            return output;
        }

        public static void SaveToPrizeFile(this List<PrizeModel> models, string fileName)
        {
            List<string> lines = new List<string>();
            foreach (PrizeModel p in models)
            {
                lines.Add($"{p.Id},{p.PlaceNumber},{p.PlaceName},{p.PrizeAmount},{p.PrizePercentage}");
                
            }
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }


        public static void SaveToPersonFile(this List<PersonModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (PersonModel p in models)
            {
               lines.Add($"{ p.Id },{ p.FirstName },{ p.LastName },{ p.EmailAddress },{ p.CellPhoneNumber }");
            }

            File.WriteAllLines (fileName.FullFilePath(), lines);
        }

        public static void SaveToTeamFile(this List<TeamModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (TeamModel t in models)
            {
                lines.Add($"{ t.Id },{ t.TeamName },{ ConvertPeopleListToString(t.TeamMembers) }");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static void SaveToTournamentFile(this List<TournamentModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (TournamentModel t in models)
            {
                lines.Add($@"{t.Id},{t.TournamentName},{t.EntryFee},
                             { ConvertTeamListToString(t.EnteredTeams) },
                             { ConvertPrizeListToString(t.Prizes) },
                             { ConvertRoundListToString(t.Rounds) }");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static string ConvertPeopleListToString(List<PersonModel> person)
        {
            string output = "";
            if (person.Count == 0)
            {
                return "";
            }
            foreach (PersonModel p in person)
            {
                output += $"{p.Id}|";
                
            }
            output = output.Substring(0, output.Length - 1);
            
            return output;
        }

        public static string ConvertTeamListToString(List<TeamModel> team)
        {
            string output = "";
            if (team.Count == 0)
            {
                return "";
            }
            foreach (TeamModel t in team)
            {
                output += $"{t.Id}|";
            }
            output = output.Substring(0, output.Length - 1);

            return output;
        }

        public static string ConvertPrizeListToString(List<PrizeModel> prize)
        {
            string output = "";
            if (prize.Count == 0)
            {
                return "";
            }
            foreach (PrizeModel p in prize)
            {
                output += $"{p.Id}|";
            }
            output = output.Substring(0, output.Length - 1);

            return output;
        }

        public static string ConvertMatchupListToString(List<MatchupModel> matchup)
        {
            string output = "";
            if (matchup.Count == 0)
            {
                return "";
            }
            foreach (MatchupModel m in matchup)
            {
                output += $"{m.Id}^";
            }
            output = output.Substring(0, output.Length - 1);

            return output;
        }

        public static string ConvertRoundListToString(List<List<MatchupModel>> round)
        {
            string output = "";
            if (round.Count == 0)
            {
                return "";
            }
            foreach (List<MatchupModel> r in round)
            {
                output += $"{ConvertMatchupListToString(r)}|";
            }
            output = output.Substring(0, output.Length - 1);

            return output;
        }
    }
}
