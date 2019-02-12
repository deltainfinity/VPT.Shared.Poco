using Newtonsoft.Json;
using System.Collections.Generic;
using VPT.Shared.Poco.DTO.Accounts.Aggregate;
using VPT.Shared.Poco.DTO.Accounts.Database;

namespace VPT.Shared.Poco.DTO.API.Aggregate
{
    /// <summary>
    /// Aggregate object containing Person Details For Instances
    /// </summary> 
    public class AssignedSubjectDetailsDTO
    {
        public AssignedSubjectDetailsDTO(PersonDetailsDTO person)
        {
            PersonID = person.PersonID;
            FirstName = person.FirstName;
            MiddleName = person.MiddleName;
            LastName = person.LastName;
            ExternalIDs = person.ExternalIDs;
        }
        /// <summary>
        /// The ID of the person
        /// </summary>
        [JsonProperty("personID")]
        public int PersonID { get; set; }

        /// <summary>
        /// The first name of the person
        /// </summary>
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// The middle name of the person
        /// </summary>
        [JsonProperty("middleName")]
        public string MiddleName { get; set; }

        /// <summary>
        /// The last name of the person
        /// </summary>
        [JsonProperty("lastName")]
        public string LastName { get; set; }

        /// <summary>
        /// The full name of the person in first name first format
        /// </summary>
        [JsonProperty("fullNameFirstNameFirstFormat")]
        public string FullNameFirstNameFirstFormat => FirstName + " " + LastName;

        /// <summary>
        /// List of external IDs for the person
        /// </summary>
        [JsonProperty("externalIDs")]
        public IList<ExternalIDDTO> ExternalIDs { get; set; }
    }
}
