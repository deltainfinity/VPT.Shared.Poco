using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using VPT.Shared.Poco.DTO.Accounts.Database;
using VPT.Shared.Poco.Model.Accounts.Database;

namespace VPT.Shared.Poco.DTO.Accounts.Aggregate
{
    /// <summary>
    /// Aggregate object containing all data related to a person
    /// </summary>
    public class UserDetailsWithCreateStatusDTO
    {
        /// <summary>
        /// Public Constructor
        /// </summary>
        public UserDetailsWithCreateStatusDTO()
        { }

        /// <summary>
        /// Copy constructor used to populate the object
        /// </summary>
        /// <param name="source">The source Person entity for the DTO</param>
        /// <param name="contacts">The list of contacts for the Person</param>
        /// <param name="externalIDs">The list of external IDs for the person</param>
        /// <param name="groups">The list of Groups the person belongs too</param>
        public UserDetailsWithCreateStatusDTO(PersonDetailsDTO details , string errorMessage = "")            
        {
            Person = details;
            ErrorMessage = errorMessage;
        }

        /// <summary>
        /// List of contact records for the person
        /// </summary>
        [JsonProperty("person")]
        public PersonDetailsDTO Person { get; set; }
        
        public string ErrorMessage { get; set; }


    }
}
