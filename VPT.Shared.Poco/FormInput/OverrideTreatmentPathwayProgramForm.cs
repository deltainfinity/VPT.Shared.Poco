using Newtonsoft.Json;

namespace VPT.Shared.Poco.FormInput
{
    public class OverrideTreatmentPathwayProgramForm
    {
        [JsonProperty("treatmentPathwayGoalActionStepID")]
        public int TreatmentPathwayGoalActionStepID { get; set; }

        [JsonProperty("treatmentPathwayID")]
        public int TreatmentPathwayID { get; set; }

        [JsonProperty("treatmentPathwayTrackerID")]
        public int TreatmentPathwayTrackerID { get; set; }

        [JsonProperty("subjectUserID")]
        public int SubjectUserID { get; set; }

        [JsonProperty("programOverrideReasonID")]
        public int ProgramOverrideReasonID { get; set; }

        [JsonProperty("customOverrideReason")]
        public string CustomOverrideReason { get; set; }
    }
}
