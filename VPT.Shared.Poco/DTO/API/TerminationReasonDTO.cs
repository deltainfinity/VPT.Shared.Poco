using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API
{
    public class TerminationReasonDTO : BaseDTO
    {
        public TerminationReasonDTO(TerminationReason source)
        {
            TerminationReasonID = source.TerminationReasonID;
            OrganizationID = source.OrganizationID;
            Code = source.Code;
            DisplayName = source.DisplayName;
            Description = source.Description;
            IsActive = source.IsActive;
            StatusType = source.StatusType;
        }

        /// <summary>
        /// The TerminationReasonID of the TerminationReason
        /// </summary>
        [JsonProperty("terminationReasonID")]
        public int TerminationReasonID { get; set; }

        /// <summary>
        /// The OrganizationID
        /// </summary>
        [JsonProperty("organizationID")]
        public int OrganizationID { get; set; }

        /// <summary>
        /// The Termination Reason Code
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// The DisplayName
        /// </summary>
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// The description of TerminationReason
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        ///<summary>
        /// The TerminationReason is IsActive
        /// </summary>
        [JsonProperty("isActive")]
        public bool IsActive { get; set; }

        /// <summary>
        /// The status type of TerminationReason
        /// </summary>
        [JsonProperty("StatusType")]
        public string StatusType { get; set; }

    }
}
