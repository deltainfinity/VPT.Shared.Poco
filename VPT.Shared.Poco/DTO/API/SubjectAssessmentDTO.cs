using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API
{
    /// <summary>
    /// DTO object for <see cref="Models.SubjectAssessment"/>
    /// </summary>
    public class SubjectAssessmentDTO
    {
        public SubjectAssessmentDTO()
        { }

        public SubjectAssessmentDTO(SubjectAssessment source)
            
        {
            SubjectAssessmentID = source.SubjectAssessmentID;
            SubjectUserID = source.SubjectUserID;
            SORSubjectID = source.SORSubjectID;
            SORAssessmentID = source.SORAssessmentID;
            AssessmentName = source.AssessmentName;
            AssessmentTakenOn = source.AssessmentTakenOn;
            AssessmentAdministeredBy = source.AssessmentAdministeredBy;
            OverallRisk = source.OverallRisk;
            if (source.AssessmentTakenOn != null)
                AssessmentNameDate = source.AssessmentName + " " + source.AssessmentTakenOn.ToString("MM/dd/yyyy");
        }

        /// <summary>
        /// The PK ID of this Subject Assessment (0 = New Record). This won't be accepted from an import.
        /// </summary>
        [JsonProperty("subjectAssessmentID")]
        public int SubjectAssessmentID { get; set; }

        /// <summary>
        /// The person ID of the subject. This won't be accepted from an import.
        /// </summary>
        [JsonProperty("subjectUserID")]
        public int SubjectUserID { get; set; }

        /// <summary>
        /// The Subject ID in the Client's System of Record
        /// </summary>
        [JsonProperty("sorSubjectID")]
        public string SORSubjectID { get; set; }

        /// <summary>
        /// The ID of the Assessment in the Client's System of Record
        /// </summary>
        [JsonProperty("sorAssessmentID")]
        public string SORAssessmentID { get; set; }

        /// <summary>
        /// The name of the assessment
        /// </summary>
        [JsonProperty("assessmentName")]
        public string AssessmentName { get; set; }

        /// <summary>
        /// The date and time the assessment was taken
        /// </summary>
        [JsonProperty("assessmentTakenOn")]
        public DateTime AssessmentTakenOn { get; set; }

        /// <summary>
        /// Who the assessment was administered by (Full name please)
        /// </summary>
        [JsonProperty("assessmentAdministeredBy")]
        public string AssessmentAdministeredBy { get; set; }

        /// <summary>
        /// The domain results for the Assessment
        /// </summary>
        [JsonProperty("assessmentResults")]
        public List<SubjectAssessmentResultDTO> AssessmentResults { get; set; }

        /// <summary>
        /// The name of the assessment
        /// </summary>
        public string ActualAssessmentName { get; set; }
        /// <summary>
        /// The Overall Risk of Subject
        /// </summary>
        public string OverallRisk { get;  set; }

        /// <summary>
        /// The date and time the assessment was taken
        /// </summary>
        [JsonProperty("assessmentNameDate")]
        public string AssessmentNameDate { get; set; }

        /// <summary>
        /// Used when being sent in from external source ( such as the message bus )
        /// </summary>
        public string AccountExternalId { get; set; }
    }
}
