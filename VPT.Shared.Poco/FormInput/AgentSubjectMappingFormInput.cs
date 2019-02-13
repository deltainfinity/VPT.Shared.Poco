using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VPT.Shared.Poco.FormInput
{
    /// <summary>
    /// Agent to Subject Mapping input data
    /// </summary>
    public class AgentSubjectMappingFormInput
    {
        /// <summary>
        /// The person ID of the Agent
        /// </summary>
        [JsonProperty("agentUserID")]
        public int AgentUserID { get; set; }

        /// <summary>
        /// The Auth0 User ID of the Aubject
        /// </summary>
        [JsonProperty("subjectList")]
        public List<subjectData> SubjectList { get; set; }

        /// <summary>
        /// The name of the Subject
        /// </summary>
        [JsonProperty("careGroupType")]
        public int CareGroupType { get; set; }

        /// <summary>
        /// Reason for adding to care group
        /// </summary>
        [JsonProperty("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// Expiry Date of agent
        /// </summary>
        [JsonProperty("expireDate")]
        public DateTime? ExpireDate { get; set; }

    }

    public class subjectData
    {
        /// <summary>
        /// The person ID of the Aubject
        /// </summary>
        [JsonProperty("subjectUserID")]
        public int SubjectUserID { get; set; }
        /// <summary>
        /// The name of the Subject
        /// </summary>
        [JsonProperty("subjectName")]
        public string SubjectName { get; set; }
    }
}

