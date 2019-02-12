using Newtonsoft.Json;

namespace VPT.Shared.Poco.FormInput
{
    public class RiskLevelImportFormInput : BaseAssessmentFormInput
    {
        /// <summary>
        /// The risk score from the assessment
        /// </summary>
        [JsonProperty("riskLevelScore")]
        public float RiskLevelScore { get; set; }

        /// <summary>
        /// The risk label applied from the score for example high, medium, low.
        /// </summary>
        [JsonProperty("riskLevelText")]
        public string RiskLevelText { get; set; }
    }
}
