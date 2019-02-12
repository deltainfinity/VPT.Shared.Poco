using Newtonsoft.Json;

namespace VPT.Shared.Poco.FormInput
{
    /// <summary>
    /// DTO for handling the mapping of a subject and program
    /// </summary>
    public class SubjectTreatmentPathwayMappingFormInput
    {
        /// <summary>
        /// The person ID of the subject
        /// </summary>
        [JsonProperty("subjectUserID")]
        public int SubjectUserID { get; set; }

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
        /// The ID of the treatment pathway
        /// </summary>
        [JsonProperty("treatmentPathwayID")]
        public int TreatmentPathwayID { get; set; }

        /// <summary>
        /// The ID of the treatment pathway tracker
        /// </summary>
        [JsonProperty("treatmentPathwayTrackerID")]
        public int TreatmentPathwayTrackerID { get; set; }

        /// <summary>
        /// The ID of the goal
        /// </summary>
        [JsonProperty("goalID")]
        public int GoalID { get; set; }

        /// <summary>
        /// The ID of the action step
        /// </summary>
        [JsonProperty("actionStepID")]
        public int ActionStepID { get; set; }

        /// <summary>
        /// The flag specifying program is recommended or not
        /// </summary>
        [JsonProperty("isRecommendedProgram")]
        public bool IsRecommendedProgram { get; set; }

        /// <summary>
        /// The ID of assigned by
        /// </summary>
        [JsonProperty("assignedBy")]
        public int AssignedBy { get; set; }
    }
}
