using Newtonsoft.Json;
using System;

namespace VPT.Shared.Poco.DTO.API.Form
{
    public class CreateActionStepDTO
    {
        /// <summary>
        /// The Action step ID
        /// </summary>
        [JsonProperty("actionStepID")]
        public int ActionStepID { get; set; }
        /// <summary>
        /// The name of Custom Action step name
        /// </summary>
        [JsonProperty("customActionStepName")]
        public string CustomActionStepName { get; set; }
        /// <summary>
        /// Custom Action 
        /// </summary>
        [JsonProperty("isCustom")]
        public bool IsCustom { get; set; }
        /// <summary>
        /// The person ID of the Agent
        /// </summary>
        [JsonProperty("responsiblePersonUserID")]
        public int ResponsiblePersonUserID { get; set; }
        /// <summary>
        /// The status of action step
        /// </summary>
        [JsonProperty("status")]
        public int Status { get; set; }

        /// <summary>
        /// The Subject Goal ID
        /// </summary>
        [JsonProperty("subjectGoalID")]
        public int SubjectGoalID { get; set; }

        /// <summary>
        /// The Subject User ID
        /// </summary>
        [JsonProperty("subjectUserID")]
        public int SubjectUserID { get; set; }

        /// <summary>
        /// The Program ID 
        /// </summary>
        [JsonProperty("programID")]
        public int ProgramID { get; set; }

        /// <summary>
        /// The User ID 
        /// </summary>
        [JsonProperty("userID")]
        public string UserID { get; set; }

        /// <summary>
        /// The Goal ID
        /// </summary>
        [JsonProperty("goalID")]
        public int GoalID { get; set; }

        /// <summary>
        /// The Start date
        /// </summary>
        [JsonProperty("startDate")]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// The End Date
        /// </summary>
        [JsonProperty("endDate")]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// The Request Instance ID
        /// </summary>
        [JsonProperty("requestInstanceID")]
        public int? RequestInstanceID { get; set; }

    }
}
