using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API
{
    public class SubjectGoalDTO :BaseDTO
    {
        public SubjectGoalDTO(SubjectGoal source)
        {
            SubjectGoalID = source.SubjectGoalID;
            SubjectUserID = source.SubjectUserID;
            GoalID = source.GoalID;
            CompletedDate = source.CompletedDate;
           
        }

        /// <summary>
        /// The ID of SubjectGoal
        /// </summary>
        [JsonProperty("subjectGoalID")]
        public int SubjectGoalID { get; set; }

        /// <summary>
        /// The id of Subject
        /// </summary>
        [JsonProperty("subjectUserID")]
        public int SubjectUserID { get; set; }

        /// <summary>
        /// The id of Goal
        /// </summary>
        [JsonProperty("goalID")]
        public int GoalID { get; set; }
        /// <summary>
        /// The completed date
        /// </summary>

        [JsonProperty("completedDate")]
        public DateTime? CompletedDate { get; set; }
              
    }
}
