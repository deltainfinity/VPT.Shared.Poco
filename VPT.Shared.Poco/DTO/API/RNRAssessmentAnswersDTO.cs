using Newtonsoft.Json;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API
{
    public class RNRAssessmentAnswersDTO
    {
        public RNRAssessmentAnswersDTO()
        { }

        public RNRAssessmentAnswersDTO(RNRAssessmentAnswers source)
        {
            RNRAssessmentAnswersId = source.AnswersId;
            SubjectUserID = source.SubjectUserID;
            Answers = source.Answers;
            DateCreated = source.DateCreated.ToShortDateString();
            TimeCreated = source.DateCreated.ToShortTimeString();
        }

        /// <summary>
        /// The PK ID of these answers
        /// </summary>
        public int RNRAssessmentAnswersId { get; set; }

        /// <summary>
        /// The person ID these answers apply too
        /// </summary>
        public string SubjectUserID { get; set; }

        /// <summary>
        /// JSON dump of the questions answer from the UI
        /// </summary>
        public string Answers { get; set; }

        /// <summary>
        /// Date the record was created.
        /// </summary>
        [JsonProperty("dateCreated")]
        public string DateCreated { get; set; }

        /// <summary>
        /// Time the record was created.
        /// </summary>
        [JsonProperty("timeCreated")]
        public string TimeCreated { get; set; }
    }
}
