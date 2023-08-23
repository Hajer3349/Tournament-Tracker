using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PersonModel
    {
        /// <summary>
        /// The unique identifier for the prize.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Represents the first name of one player
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// the last name of one player
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Email address of one player
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// phone number of one player
        /// </summary>
        public string CellPhoneNumber { get; set; }

        public string FullName 
        {
          get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public PersonModel()
        {

        }

        public PersonModel(string firstName, string lastName, string email, string cellPhone)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = email;
            CellPhoneNumber = cellPhone;
        }
    }
}
