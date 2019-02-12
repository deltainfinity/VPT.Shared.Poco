using Newtonsoft.Json;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API
{
    public class OverrideTreatmentPathwayDTO
    {
        [JsonProperty("treatmentPathwayID")]
        public int TreatmentPathwayID { get; set; }
        [JsonProperty("treatmentPathwayTrackerID")]
        public int TreatmentPathwayTrackerID { get; set; }
        [JsonProperty("subjectUserID")]
        public int SubjectUserID { get; set; }
        [JsonProperty("treatmentPathwayOverrideReasonID")]
        public int TreatmentPathwayOverrideReasonID { get; set; }
        [JsonProperty("customOverrideReason")]
        public string CustomOverrideReason { get; set; }
    }
}
