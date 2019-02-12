using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace VPT.Shared.Poco.DTO.API
{
    /// <summary>
    /// DTO object for <see cref="Models.SubjectAssessment"/>
    /// </summary>
    public class OffenderAssessmentDTO
    {
        /// <summary>
        /// The PK ID of this Subject Assessment (0 = New Record). This won't be accepted from an import.
        /// </summary>
        [JsonProperty("subjectAssessmentID")]
        public int SubjectAssessmentID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int OffenderAssessmentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        //[JsonProperty("Name")]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // [JsonProperty("AssessmentId")]
        public int AssessmentId { get; set; }
        // [JsonProperty("PIN")]

        /// <summary>
        /// 
        /// </summary>
        public string PIN { get; set; }
        // [JsonProperty("Started")]

        /// <summary>
        /// 
        /// </summary>
        public DateTime Started { get; set; }
        // [JsonProperty("CCRSnapshot")]

        /// <summary>
        /// 
        /// </summary>
        public DateTime Completed { get; set; }
        //public AssessmentResult results { get; set; } //lazy load if needed.
        //[JsonProperty("OffenderAssessmentId")]

        /// <summary>
        /// 
        /// </summary>
        public int CCRSnapshot { get; set; } //zero is false anything else is true.

        /// <summary>
        /// 
        /// </summary>
        public string CompletedBy { get; set; }

        public List<ExtendedFieldDTO> ExtendedFields { get; set; }
        public List<CompletedAssessmentDTO> CompletedAssessments { get; set; }
    }
}
