using Newtonsoft.Json;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API
{
    public class ActionStepDTO : BaseDTO
    {
        public ActionStepDTO(ActionStep source)
        {
            ActionStepID = source.ActionStepID;
            Name = source.Name;
            Description = source.Description;
            IsCustom = source.IsCustom;
            GoalID = source.GoalID;
            IsOffenderResponsible = source.IsOffenderResponsible;
            ParentProgramID = source.ParentProgramID;
            ActionStepTypeID = source.ActionStepTypeID;
            ActionStepType = source.ActionStepType;

        }

        /// <summary>
        /// The ID of ActionStep
        /// </summary>
        [JsonProperty("actionStepID")]
        public int ActionStepID { get; set; }

        /// <summary>
        /// The name of ActionStep
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The name of ActionStep
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Custom ActionStep
        /// </summary>

        [JsonProperty("isCustom")]
        public bool IsCustom { get; set; }
        /// <summary>
        /// Goal ID
        /// </summary>

        [JsonProperty("goalID")]
        public int GoalID { get; set; }

        [JsonProperty("isOffenderResponsible")]
        public bool IsOffenderResponsible { get; set; }

        [JsonProperty("parentProgramID")]
        public int ParentProgramID { get; set; }

        [JsonProperty("actionStepTypeID")]
        public int ActionStepTypeID { get; set; }

        [JsonProperty("actionStepType")]
        public string ActionStepType { get; set; }

    }
}
