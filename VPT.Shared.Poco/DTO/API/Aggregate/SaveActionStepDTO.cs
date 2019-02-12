using Newtonsoft.Json;

namespace VPT.Shared.Poco.DTO.API.Aggregate
{
    public class SaveActionStepDTO
    {
        public SaveActionStepDTO()
        { }

        [JsonProperty("goalID")]
        public int GoalID { get; set; }
        [JsonProperty("actionStepID")]
        public int ActionStepID { get; set; }
        [JsonProperty("actionStepName")]
        public string ActionStepName { get; set; }
        [JsonProperty("isOffenderResponsible")]
        public bool IsOffenderResponsible { get; set; }

        [JsonProperty("parentProgramID")]
        public int ParentProgramID { get; set; }

        [JsonProperty("actionStepType")]
        public int ActionStepType { get; set; }

    }
}
