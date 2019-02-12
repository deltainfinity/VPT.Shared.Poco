using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API
{
    public class SubjectGoalDetailedDTO : BaseDTO
    {
        public SubjectGoalDetailedDTO(SubjectGoal source, List<SubjectGoalAction> subjectGoalActions, IEnumerable<Tag> domainLookUp, IEnumerable<Goal> goalLookUp, IEnumerable<ActionStep> actionsLookup, IEnumerable<ProgramType> goalType, IEnumerable<Program> programList, IEnumerable<SubjectProgramMapping> subjectprogramList, IEnumerable<SubjectProgramStatus> programStatuses)
            : base(source)
        {

            SubjectGoalID = source.SubjectGoalID;
            SubjectUserID = source.SubjectUserID;
            GoalID = source.GoalID;
            EndDate = source.CompletedDate.HasValue ? source.CompletedDate.Value.ToShortDateString() : string.Empty;
            ParentProgramID = source.ParentProgramID;           

            // TODO: Naico look at this, it cases a null ref exception for several subjects in test/prod which I handled but not sure that isn't going to cause other problems
            var goal = goalLookUp?.SingleOrDefault(x => x.GoalID == source.GoalID);
            if (goal != null)
            {
                GoalName = goal.Name;
                var tempDomainID = goal.DomainID;
                var domain = domainLookUp.SingleOrDefault(x => x.TagID == tempDomainID);
                if (domain != null)
                {
                    Domain = domain.Name;
                    DomainID = domain.TagID;
                }
            }

            var subjectGoalActionDetailDTOList = new List<SubjectGoalActionDetailDTO>();
            foreach (var subjectGoalAction in subjectGoalActions)
            {
                subjectGoalActionDetailDTOList.Add(new SubjectGoalActionDetailDTO(subjectGoalAction, actionsLookup, source.SubjectUserID, programList, programStatuses, subjectprogramList));
            }

            SubjectGoalActionDetails = subjectGoalActionDetailDTOList;           
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
