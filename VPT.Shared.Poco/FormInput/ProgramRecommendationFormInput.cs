using Newtonsoft.Json;

namespace VPT.Shared.Poco.FormInput
{
    public class ProgramRecommendationFormInput
    {
        /// <summary>
        /// The person ID of the Subject
        /// </summary>
        [JsonProperty("subjectUserID")]
        public string SubjectUserID { get; set; }

        /// <summary>
        /// Parent Program ID
        /// </summary>
        [JsonProperty("programRecommendationID")]
        public int programRecommendationID { get; set; }

        /// <summary>
        /// Parent Program ID
        /// </summary>
        [JsonProperty("parentProgramID")]
        public int ParentProgramID { get; set; }

        /// <summary>
        /// The status of ProgramRecommendation 
        /// </summary>
        [JsonProperty("status")]
        public int Status { get; set; }

        /// <summary>
        /// The subject is present or not
        /// </summary>
        [JsonProperty("overriddenReason")]
        public string OverriddenReason { get; set; }

    }
}
