using Newtonsoft.Json;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API
{
    public class RNRAssessmentResultDTO
    {
        public RNRAssessmentResultDTO()
        { }

        public RNRAssessmentResultDTO(RNRAssessmentResult source)
        {
            RNRAssessmentResultId = source.ResultId;
            SubjectUserID = source.SubjectUserID;
            Result = source.Result;
        }

        /// <summary>
        /// The PK ID for these results
        /// </summary>
        public int RNRAssessmentResultId { get; set; }

        /// <summary>
        /// The person ID these results apply too
        /// </summary>
        public int SubjectUserID { get; set; }

        /// <summary>
        /// JSON dump of the results from the RNR tool
        /// </summary>
        public string Result { get; set; }

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
