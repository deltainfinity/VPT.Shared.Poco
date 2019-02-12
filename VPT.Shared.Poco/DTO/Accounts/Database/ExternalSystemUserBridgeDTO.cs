using System;
using Newtonsoft.Json;
using VPT.Shared.Poco.Enum.Accounts;
using VPT.Shared.Poco.Model.Accounts.Database;

namespace VPT.Shared.Poco.DTO.Accounts.Database
{
    public class ExternalSystemUserBridgeDTO 
    {
        /// <summary>
        /// Default Constructor
        /// </summary>
        public ExternalSystemUserBridgeDTO()
        { }

        /// <summary>
        /// Copy constructor to populate the object
        /// </summary>
        /// <param name="source">The source Person entity for the DTO</param>
        public ExternalSystemUserBridgeDTO(ExternalSystemUserBridge source)
        {
            ExternalSystemUserBridgeID = source.ExternalSystemUserBridgeID;
            ExternalUserID = source.ExternalUserID;
            PersonID = source.PersonID;
            CreatedByUserID = source.CreatedByUserID;
            DateCreated = source.DateCreated;
        }

        public ExternalSystemUserBridgeDTO(string externalUserID, int personID, string createdByUserID)
        {
            ExternalUserID = externalUserID;
            PersonID = personID;
            CreatedByUserID = createdByUserID;
            //DateCreated = source.DateCreated;
        }

        /// <summary>
        /// The External ID of the integrated system
        /// </summary>
        [JsonProperty("externalSystemUserBridgeID")]
        public int ExternalSystemUserBridgeID { get; set; }

        /// <summary>
        /// The id of that created the person.
        /// </summary>
        [JsonProperty("externalUserID")]
        public string ExternalUserID { get; set; }

        /// <summary>
        /// The ID for the person.
        /// </summary>
        [JsonProperty("PersonID")]
        public int PersonID { get; set; }

        /// <summary>
        /// DateCreated
        /// </summary>
        [JsonProperty("dateCreated")]
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// CreatedByUserID
        /// </summary>
        [JsonProperty("createdByUserID")]
        public string CreatedByUserID { get; set; }

    }
}
