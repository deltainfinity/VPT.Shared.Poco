using Newtonsoft.Json;

namespace VPT.Shared.Poco.DTO.API.Aggregate
{
    public class SaveGoalDTO
    {
        [JsonProperty("goalID")]
        public int GoalID { get; set; }
        [JsonProperty("goalName")]
        public string GoalName { get; set; }
        [JsonProperty("domainID")]
        public int DomainID { get; set; }
        [JsonProperty("autoAssign")]
        public bool AutoAssign { get; set; }
        [JsonProperty("isCustom")]
        public bool IsCustom { get; set; }
        [JsonProperty("isPrison")]
        public bool IsPrison { get; set; }


    }
}
