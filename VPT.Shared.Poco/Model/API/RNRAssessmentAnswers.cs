using NPoco;
using System;
using VPT.Shared.Poco.DTO.API;

namespace VPT.Shared.Poco.Model.API
{
    [TableName("RNRAssessmentAnswers")]
    [PrimaryKey("AnswersId")]
    /// <summary>
    /// Class for defining subject answers for the RNR Assessment
    /// </summary>
    public class RNRAssessmentAnswers
    {
        public RNRAssessmentAnswers()
        { }

        public RNRAssessmentAnswers(RNRAssessmentAnswersDTO source)
        {
            AnswersId = source.RNRAssessmentAnswersId;
            SubjectUserID = source.SubjectUserID;
            Answers = source.Answers;
            DateCreated = DateTime.Parse(source.DateCreated + ' ' + source.TimeCreated);
        }

        /// <summary>
        /// The PK ID of these answers
        /// </summary>
        public int AnswersId { get; set; }

        /// <summary>
        /// The person ID these answers apply too
        /// </summary>
        public string SubjectUserID { get; set; }

        /// <summary>
        /// JSON bump of the questions answer from the UI
        /// </summary>
        public string Answers { get; set; }

        /// <summary>
        /// The date and time the the record was created
        /// </summary>
        public DateTime DateCreated { get; set; }
    }
}
