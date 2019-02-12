using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API
{
    public class GoalDTO : BaseDTO
    {
        public GoalDTO(Goal source)
        {
            GoalID = source.GoalID;
            Name = source.Name;
            Description = source.Description;
            DomainID = source.DomainID;
            IsCustom = source.IsCustom;
            AutoAssign = source.AutoAssign;
            OrganizationID = source.OrganizationID;
            IsPrison = source.IsPrison;
        }

        /// <summary>
        /// The ID of Goal
        /// </summary>
        [JsonProperty("goalID")]
        public int GoalID { get; set; }

        /// <summary>
        /// The name of Goal
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The name of Goal
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// The id of corresponding Domain
        /// </summary>
        [JsonProperty("domainID")]
        public int DomainID { get; set; }
        /// <summary>
        /// Custom goal
        /// </summary>
        [JsonProperty("isCustom")]
        public bool IsCustom { get; set; }

        ///<summary>
        ///Auto Assign Goal
        /// </summary>
         [JsonProperty("autoAssign")]
        public bool AutoAssign { get; set; }
        /// <summary>
        /// The name of Domain
        /// </summary>
        [JsonProperty("domainName")]
        public string DomainName { get; set; }
        /// <summary>
        /// The name of Assessment
        /// </summary>
        [JsonProperty("assessmentName")]
        public string AssessmentName { get; set; }
        /// <summary>
        /// The name of Assessment
        /// </summary>
        [JsonProperty("assessmentID")]
        public int AssessmentID { get; set; }
        /// <summary>
        /// The Organization ID
        /// </summary>
        [JsonProperty("organizationID")]
        public int OrganizationID { get; set; }

        [JsonProperty("isPrison")]
        public bool IsPrison { get; set; }
        
    }
}
