using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class TournamentModel
    {
        /// <summary>
        /// The unique identifier for the Tournament.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Represents the name of one tournament
        /// </summary>
        public string TournamentName { get; set; }

        /// <summary>
        /// The fee must be paid by each player to enter the tournament
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// List of teams entering the tournament 
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; }

        /// <summary>
        /// List of prizes to be awarded to the winners of the tournament
        /// </summary>
        public List<PrizeModel> Prizes { get; set; }

        /// <summary>
        /// List of rounds in the tournament (each round contains a list of matchups)
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
