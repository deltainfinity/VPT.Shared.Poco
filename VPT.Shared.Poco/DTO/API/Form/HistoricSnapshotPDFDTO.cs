using Newtonsoft.Json;

namespace VPT.Shared.Poco.DTO.API.Form
{
    public class HistoricSnapshotPDFDTO
    {

        [JsonProperty("assessmentName")]
        public string AssessmentName { get; set; }

        [JsonProperty("assessmentDate")]
        public string AssessmentDate { get; set; }

        [JsonProperty("offenderCC")]
        public string OffenderCC { get; set; }

        [JsonProperty("riskLevel")]
        public string RiskLevel { get; set; }

        [JsonProperty("riskGraphBinaryData")]
        public string RiskGraphBinaryData { get; set; }

    }
}
