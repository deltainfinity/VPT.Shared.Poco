using System;
using Newtonsoft.Json;

namespace VPT.Shared.Poco.FormInput
{
    public class BaseAssessmentFormInput
    {
        /// <summary>
        /// This is the ID of the account controlling the subject this assessment
        /// data is for. This field is used for internal data exchange and will not be
        /// received from or sent to the UI via this object.
        /// </summary>
        [JsonIgnore]
        public Guid AccountID { get; set; }

        /// <summary>
        /// This is the ID of the subject this assessment data is for. This field is
        /// used for internal data exchange and will not be received from or sent to
        /// the UI via this object.
        /// </summary>
        [JsonIgnore]
        public Guid UserID { get; set; }

        /// <summary>
        /// The ID of the subject in the System of Record for the agency. This ID also needs
        /// to be entered in to the Subject's External ID field.
        /// </summary>
        [JsonProperty("subjectSystemOfRecordID")]
        public string SubjectSystemOfRecordID { get; set; }

        /// <summary>
        /// The name of the subject in the system of record
        /// </summary>
        [JsonProperty("subjectName")]
        public string SubjectName { get; set; }

        /// <summary>
        /// The name of the Assessment used
        /// </summary>
        [JsonProperty("assessmentName")]
        public string AssessmentName { get; set; }

        /// <summary>
        /// The date and time the assessment was taken on
        /// </summary>
        [JsonProperty("assessmentTakenOn")]
        public DateTime AssessmentTakenOn { get; set; }

        /// <summary>
        /// The full name of the agent that administered the assessment
        /// </summary>
        [JsonProperty("assessmentAdministeredBy")]
        public string AssessmentAdministeredBy { get; set; }
    }
}
