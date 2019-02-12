using NPoco;
using System;
using VPT.Shared.Poco.DTO.API;

namespace VPT.Shared.Poco.Model.API
{
    [TableName("RNRAssessmentResult")]
    [PrimaryKey("ResultId")]
    /// <summary>
    /// Class for defining the storage of results from the RNR Assessment
    /// </summary>
    public class RNRAssessmentResult
    {
        public RNRAssessmentResult()
        { }

        public RNRAssessmentResult(RNRAssessmentResultDTO source)
        {
            ResultId = source.RNRAssessmentResultId;
            SubjectUserID = source.SubjectUserID;
            Result = source.Result;
            DateCreated = DateTime.Parse(source.DateCreated + ' ' + source.TimeCreated);
        }

        /// <summary>
        /// The PK ID for these results
        /// </summary>
        public int ResultId { get; set; }

        /// <summary>
        /// The person ID these results apply too
        /// </summary>
        public int SubjectUserID { get; set; }

        /// <summary>
        /// JSON dump of the results from the RNR tool
        /// </summary>
        public string Result { get; set; }

        /// <summary>
        /// The date and time the the record was created
        /// </summary>
        public DateTime DateCreated { get; set; }
    }
}
