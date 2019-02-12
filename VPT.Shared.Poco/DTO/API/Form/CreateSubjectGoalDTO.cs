using Newtonsoft.Json;
using System.Collections.Generic;

namespace VPT.Shared.Poco.DTO.API.Form
{
    public class CreateSubjectGoalDTO
    {
        /// <summary>
        /// The id of domain
        /// </summary>
        [JsonProperty("domainID")]
        public int DomainID { get; set; }

        /// <summary>
        /// The person ID of the Subject
        /// </summary>
        [JsonProperty("subjectUserID")]
        public int SubjectUserID { get; set; }

        /// <summary>
        /// The ID of Goal
        /// </summary>
        [JsonProperty("goalID")]
        public int GoalID { get; set; }
        /// <summary>
        /// The name of Custom Goal
        /// </summary>
        [JsonProperty("customGoalName")]
        public string CustomGoalName { get; set; }
        /// <summary>
        /// isCustom Flag
        /// </summary>
        [JsonProperty("isCustom")]
        public bool IsCustom { get; set; }
        /// <summary>
        /// The List of the ActionStep
        /// </summary>
        [JsonProperty("actionStepList")]
        public List<CreateActionStepDTO> ActionStepList { get; set; }
       
        /// <summary>
        /// The status of subject goal
        /// </summary>
        [JsonProperty("status")]
        public int Status { get; set; }      
      
    }
}
