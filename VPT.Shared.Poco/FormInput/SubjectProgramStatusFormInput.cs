using Newtonsoft.Json;

namespace VPT.Shared.Poco.FormInput
{
    public class SubjectProgramStatusFormInput
    {
        /// <summary>
        /// The Auth0 User ID of the Agent
        /// </summary>
        [JsonProperty("programID")]
        public int ProgramID { get; set; }

        /// <summary>
        /// The person ID of the Aubject
        /// </summary>
        [JsonProperty("subjectUserID")]
        public int SubjectUserID { get; set; }

        /// <summary>
        /// The subject program id
        /// </summary>
        [JsonProperty("subjectProgramID")]
        public int SubjectProgramID { get; set; }
        /// <summary>
        /// The name of the Subject
        /// </summary>
        [JsonProperty("sessionCompleteStatus")]
        public bool SessionCompleteStatus { get; set; }
    }
}
