using System;
using Newtonsoft.Json;
using VPT.Shared.Poco.DTO.Accounts.Aggregate;
using VPT.Shared.Poco.DTO.Accounts.Database;
using System.Collections.Generic;

namespace VPT.Shared.Poco.DTO.Accounts.Form
{
    public class CreateUserRequestDTO
    {

        /// <summary>
        /// The created User details
        /// </summary>
        [JsonProperty("user")]
        public PersonDetailsDTO User { get; set; }

        /// <summary>
        /// The created Subject details
        /// </summary>
        //[JsonProperty("subject")]
        //public PersonDetailsDTO Subject { get; set; }

        /// <summary>
        /// The Subject details from integration API
        /// </summary>
        //[JsonProperty("externalSubject")]
        //public ExternalSubjectDetailsDTO ExternalSubject { get; set; }

        /// <summary>
        /// The integrated userID
        /// </summary>
        //[JsonProperty("agentUserID")]
        //public string AgentUserID { get; set; }

          /// <summary>
        /// The created Subject details
        /// </summary>
        [JsonProperty("subjectExternalIDs")]
        public List<ExternalIDDTO> SubjectExternalIDs { get; set; }

         /// <summary>
        /// The Subject details from integration API
        /// </summary>
        [JsonProperty("subjectProfileWithSite")]
        public ExternalSubjectDetailsDTO SubjectProfileWithSite { get; set; }

        /// <summary>
        /// Whether the subject user is already created 
        /// </summary>
        [JsonProperty("isNewSubject")]
        public bool IsNewSubject { get; set; }

        /// <summary>
        /// Whether the staff user is already created
        /// </summary>
        [JsonProperty("isNewStaffuser")]
        public bool IsNewStaffuser { get; set; }

        /// <summary>
        /// To check the subject is matched or not
        /// </summary>
        [JsonProperty("isMatchedSubject")]
        public bool IsMatchedSubject { get; set; } = false;

        /// <summary>
        /// The SiteID from Tablet for SCORE integration
        /// </summary>
        [JsonProperty("gtlSiteID")]
        public string GTLSiteID { get; set; } = null;

        /// <summary>
        /// Sentences from integration API
        /// </summary>
        [JsonProperty("sentences")]
        public List<SentencesDTO> Sentences { get; set; }

    }
}
