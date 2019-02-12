using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API
{
    public class SubjectAgentMappingDTO : BaseDTO
    {

        public SubjectAgentMappingDTO()

        {
        }


        public SubjectAgentMappingDTO(SubjectAgentMapping source)
        {
            SubjectUserID = source.SubjectUserID;
            AgentUserID = source.AgentUserID;
            ApprovalStatus = source.ApprovalStatus;
            DateApproved = source.DateApproved;
            CareGroupType = CareGroupType;
            ExpireDate = ExpireDate;
            Reason = Reason;
        }

        /// <summary>
        /// The subject user person ID
        /// </summary>
        [JsonProperty("subjectUserID")]
        public int SubjectUserID { get; set; }

        /// <summary>
        /// The agent user person ID
        /// </summary>
        [JsonProperty("agentUserID")]
        public int AgentUserID { get; set; }

        /// <summary>
        /// The status of approval
        /// </summary>
        [JsonProperty("approvalStatus")]
        public int ApprovalStatus { get; set; }

        /// <summary>
        /// The approved date
        /// </summary>
        [JsonProperty("dateApproved")]
        public DateTime? DateApproved { get; set; }

        /// <summary>
        /// Type of caregroup 
        /// </summary>
        [JsonProperty("careGroupType")]
        public int CareGroupType { get; set; }

        /// <summary>
        /// Date of expiry of temporary care group member
        /// </summary>
        [JsonProperty("expireDate")]
        public DateTime? ExpireDate { get; set; }

        /// <summary>
        /// Reason for adding temporary care group member
        /// </summary>
        [JsonProperty("reason")]
        public string Reason { get; set; }

    }
}
