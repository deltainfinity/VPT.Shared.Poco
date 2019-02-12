using Newtonsoft.Json;
using System.Collections.Generic;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API
{
    public class GoalAggregateDTO : BaseDTO
    {
        public GoalAggregateDTO()
        {
        }
        public GoalAggregateDTO(TreatmentPathwayGoal source, List<ActionStepAggregateDTO> actionSteps)
        {
            GoalID = source.TreatmentPathwayGoalID;
            Name = source.Name;
            ActionSteps = actionSteps;
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

        [JsonProperty("actionSteps")]
        public List<ActionStepAggregateDTO> ActionSteps { get; set; }
        
    }
}
