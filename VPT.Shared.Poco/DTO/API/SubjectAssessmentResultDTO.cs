using Newtonsoft.Json;

namespace VPT.Shared.Poco.DTO.API
{
    /// <summary>
    /// DTO Object for <see cref="Models.SubjectAssessmentResult"/>
    /// </summary>
    public class SubjectAssessmentResultDTO
    {
        /// <summary>
        /// Assessment Domain Name
        /// </summary>
        [JsonProperty("tag")]
        public string Tag { get; set; }

        /// <summary>
        /// Assessment score for this domain
        /// </summary>
        [JsonProperty("score")]
        public decimal? Score { get; set; }

        /// <summary>
        /// The assessment label for this domain
        /// </summary>
        [JsonProperty("label")]
        public string Label { get; set; }
    }
}
