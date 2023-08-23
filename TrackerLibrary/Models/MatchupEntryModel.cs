using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// The unique identifier for the Matchup entry.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Represents the name of one team
        /// </summary>
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// The score of one team
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// The Matchup the team came from as the winner
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}
