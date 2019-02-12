using Newtonsoft.Json;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API
{
    public class PathwayRecommendationAggregateDTO : BaseDTO
    {
        public PathwayRecommendationAggregateDTO()
        { }

        public PathwayRecommendationAggregateDTO(TreatmentPathwayRecommendationDetail source, GoalAggregateDTO goalAggregate, string treatmentPathwayStatus, string overrideReason, string overrideCustomReason)
            : base(source)
        {
            TreatmentPathwayRecommendationID = source.TreatmentPathwayRecommendationID;
            OffenderID = source.OffenderID;
            Name = source.Name;
            SortOrder = source.SortOrder;
            TreatmentPathwayID = source.TreatmentPathwayID;
            TreatmentPathwayTrackerID = source.TreatmentPathwayTrackerID;
            GoalAggregate = goalAggregate;
            TreatmentPathwayStatus = treatmentPathwayStatus;
            OverrideReason = overrideReason;
            OverrideCustomReason = overrideCustomReason;
        }

        [JsonProperty("TreatmentPathwayRecommendationID")]
        public int TreatmentPathwayRecommendationID { get; set; }

        [JsonProperty("TreatmentPathwayID")]
        public int TreatmentPathwayID { get; set; }

        [JsonProperty("TreatmentPathwayTrackerID")]
        public int TreatmentPathwayTrackerID { get; set; }

        [JsonProperty("OffenderID")]
        public string OffenderID { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("SortOrder")]
        public string SortOrder { get; set; }

        [JsonProperty("GoalAggregate")]
        public GoalAggregateDTO GoalAggregate { get; set; }

        [JsonProperty("TreatmentPathwayStatus")]
        public string TreatmentPathwayStatus { get; set; }

        [JsonProperty("OverrideReason")]
        public string OverrideReason { get; set; }

        [JsonProperty("OverrideCustomReason")]
        public string OverrideCustomReason { get; set; }

    }
}
