using NPoco;
using System;
using VPT.Shared.Poco.DTO.API;

namespace VPT.Shared.Poco.Model.API
{
    [TableName("SubjectAssessment")]
    [PrimaryKey("SubjectAssessmentID")]
    public class SubjectAssessment
    {
        public SubjectAssessment()
        { }

        public SubjectAssessment(SubjectAssessmentDTO source)

        {
            SubjectAssessmentID = source.SubjectAssessmentID;
            SubjectUserID = source.SubjectUserID;
            SORSubjectID = source.SORSubjectID;
            SORAssessmentID = source.SORAssessmentID;
            AssessmentName = source.AssessmentName;
            AssessmentTakenOn = source.AssessmentTakenOn;
            AssessmentAdministeredBy = source.AssessmentAdministeredBy;
            OverallRisk = source.OverallRisk;


        }

        /// <summary>
        /// The PK ID of this Subject Assessment (0 = New Record)
        /// </summary>
        public int SubjectAssessmentID { get; set; }

        /// <summary>
        /// The person ID of the subject
        /// </summary>
        public int SubjectUserID { get; set; }

        /// <summary>
        /// The Subject ID in the Client's System of Record
        /// </summary>
        public string SORSubjectID { get; set; }

        /// <summary>
        /// The ID of the Assessment in the Client's System of Record
        /// </summary>
        public string SORAssessmentID { get; set; }

        /// <summary>
        /// The name of the assessment
        /// </summary>
        public string AssessmentName { get; set; }

        /// <summary>
        /// The date and time the assessment was taken
        /// </summary>
        public DateTime AssessmentTakenOn { get; set; }

        /// <summary>
        /// Who the assessment was administered by (Full name please)
        /// </summary>
        public string AssessmentAdministeredBy { get; set; }
        /// <summary>
        /// Overall Risk of Subject
        /// </summary>
        public string OverallRisk { get; set; }
    }
}
