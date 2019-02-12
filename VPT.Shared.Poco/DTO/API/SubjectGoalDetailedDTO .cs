using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API
{
    public class SubjectGoalDetailedDTO : BaseDTO
    {
        public SubjectGoalDetailedDTO(SubjectGoal source)
            : base(source)
        {
                      
        }

        public SubjectGoalDetailedDTO()
        {

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

        [JsonProperty("domain")]
        public string Domain { get; set; }

        /// <summary>
        /// The id of Goal
        /// </summary>
        [JsonProperty("goalID")]
        public int GoalID { get; set; }

        [JsonProperty("goalName")]
        public string GoalName { get; set; }

        /// <summary>
        /// The id of ActionStep
        /// </summary>
        [JsonProperty("subjectGoalActionDetails")]
        public List<SubjectGoalActionDetailDTO> SubjectGoalActionDetails { get; set; }

        /// <summary>
        /// The id of ResponsiblePerson
        /// </summary>
        [JsonProperty("responsiblePersonName")]
        public string ResponsiblePersonName { get; set; }

        /// <summary>
        /// StartDate of Subject Goal
        /// </summary>
        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        /// <summary>
        /// EndDate of Subject Goal
        /// </summary>
        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        /// <summary>
        /// The status of subject Goal
        /// </summary>
        [JsonProperty("status")]
        public int Status { get; set; }        

        /// <summary>
        /// recommended programID
        /// </summary>
        [JsonProperty("parentProgramID")]
        public int? ParentProgramID { get; set; }

        /// <summary>
        /// Goal priority
        /// </summary>
        [JsonProperty("goalPriority")]
        public int GoalPriority { get; set; }

        /// <summary>
        /// The id of Domain
        /// </summary>
        [JsonProperty("domainID")]
        public int DomainID { get; set; }

        /// <summary>
        /// IsTreatment Pathway Goal
        /// </summary>
        [JsonProperty("isTreatmentPathwayGoal")]
        public bool IsTreatmentPathwayGoal { get; set; } = false;


    }
}
