using Newtonsoft.Json;

namespace VPT.Shared.Poco.FormInput
{
    /// <summary>
    /// DTO for handling the mappings of a subject and a job
    /// </summary>
    public class SubjectJobMappingFormInput
    {
        /// <summary>
        /// The person ID of the subject
        /// </summary>
        [JsonProperty("subjectUserID")]
        public int SubjectUserID { get; set; }

        /// <summary>
        /// The ID of the Job
        /// </summary>
        [JsonProperty("jobID")]
        public int JobID { get; set; }
    }
}
