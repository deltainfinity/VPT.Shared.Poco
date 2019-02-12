using Newtonsoft.Json;
using System.Collections.Generic;
using VPT.Shared.Poco.DTO.API;

namespace VPT.Shared.Poco.FormInput
{
    /// <summary>
    /// DTO for handling the mapping of a subject and program
    /// </summary>
    public class SubjectProgramMappingFormInput
    {
        /// <summary>
        /// The person ID of the subject
        /// </summary>
        [JsonProperty("subjectUserID")]
        public string SubjectUserID { get; set; }

        /// <summary>
        /// The ID of the program
        /// </summary>
        [JsonProperty("programID")]
        public int ProgramID { get; set; }

        /// <summary>
        /// The name of the subject
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The Auth0 User ID of the subject
        /// </summary>
        [JsonProperty("subjects")]
        public List<SubjectShortDetailsDTO> Subjects { get; set; }

        [JsonProperty("assignedBy")]
        public int? AssignedBy { get; set; }

    }
}
