using Newtonsoft.Json;

namespace VPT.Shared.Poco.FormInput
{
    /// <summary>
    /// DTO for handling the mapping of a prisom subject and treatment pathway program
    /// </summary>
    public class PrisonSubjectTreatmentPathwayMappingFormInput
    {
        /// <summary>
        /// The person ID of the subject
        /// </summary>
        [JsonProperty("subjectUserID")]
        public int SubjectUserID { get; set; }

        /// <summary>
        /// The ID of the program
        /// </summary>
        [JsonProperty("parentProgramID")]
        public int ParentProgramID { get; set; }

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
    }
}
