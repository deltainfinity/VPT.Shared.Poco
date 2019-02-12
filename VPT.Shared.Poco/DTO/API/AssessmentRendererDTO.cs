using Newtonsoft.Json;
using VPT.Shared.Poco.DTO.API.Integration;

namespace VPT.Shared.Poco.DTO.API
{
    public class AssessmentRendererDTO
    {
        public AssessmentRendererDTO() { }

        /// <summary>
        /// OffenderName
        /// </summary>
        [JsonProperty("offenderName")]
        public string OffenderName { get; set; }

        /// <summary>
        /// OffenderDOC
        /// </summary>
        [JsonProperty("offenderDOC")]
        public string OffenderDOC { get; set; }

        /// <summary>
        /// AssessmentFullData
        /// </summary>
        [JsonProperty("assessmentFullData")]
        public AssessmentDTO AssessmentFullData { get; set; }

        /// <summary>
        /// AssessmentResults
        /// </summary>
        [JsonProperty("assessmentResults")]
        public AssessmentResultsDTO AssessmentResults { get; set; }

    }
}
