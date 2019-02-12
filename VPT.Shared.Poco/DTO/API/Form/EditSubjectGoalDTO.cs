using Newtonsoft.Json;
using System;

namespace VPT.Shared.Poco.DTO.API.Form
{
    public class EditSubjectGoalDTO
    {
        /// <summary>
        /// The id of subjectGoalAction
        /// </summary>
        [JsonProperty("subjectGoalActionID")]
        public int SubjectGoalActionID { get; set; }

        /// <summary>
        /// The id of subjectGoal
        /// </summary>
        [JsonProperty("subjectGoalID")]
        public int SubjectGoalID { get; set; }
        /// <summary>
        /// The id of subjectGoal
        /// </summary>
        [JsonProperty("subjectUserID")]
        public int SubjectUserID { get; set; }

        /// <summary>
        /// The id of subjectGoal
        /// </summary>
        [JsonProperty("goalName")]
        public string GoalName { get; set; }
        /// <summary>
        /// The person ID of the Subject
        /// </summary>
        [JsonProperty("startDate")]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// The ID of Goal
        /// </summary>
        [JsonProperty("endDate")]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// The ID of Goal
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// The Reason of Terminated
        /// </summary>
        [JsonProperty("terminatedReason")]
        public string TerminatedReason { get; set; }
        
        /// <summary>
        /// The Reason of On Hold
        /// </summary>
        [JsonProperty("onHoldReason")]
        public string OnHoldReason { get; set; }


    }
}
