using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchupModel
    {
        /// <summary>
        /// The unique identifier for the Matchup.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Represents the list of matchups for one round
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

        /// <summary>
        /// the winner team for one matchup
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// Represents the round number
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
