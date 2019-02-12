using Newtonsoft.Json;
using System.Collections.Generic;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API.Aggregate
{
    public class AssessmentDomainDetailsDTO
    {
     
        public AssessmentDomainDetailsDTO()
        { }
        /// <summary>
        /// Object to populate assessment domain details
        /// </summary>
        /// <param name="assessment">Assessment details</param>
        /// <param name="assessmentDomainList">The list of assessment domains</param>
        /// <param name="IsPrimary">The assessment is primary</param>



        public AssessmentDomainDetailsDTO(Assessment assessment, IList<Tag> assessmentDomainList,bool IsPrimary)
            : base()
        {
            AssessmentID = assessment.AssessmentID;
            AssessmentName = assessment.Name;
            Isprimary = IsPrimary;
            AssessmentDomains = assessmentDomainList;
        }
        /// <summary>
        /// Assessment ID
        /// </summary>
        [JsonProperty("assessmentID")]
        public int AssessmentID { get; set; }

        /// <summary>
        /// Assessment Name
        /// </summary>
        [JsonProperty("assessmentName")]
        public string AssessmentName { get; set; }
        /// <summary>
        /// Is primary assessment
        /// </summary>
        [JsonProperty("isPrimary")]
        public bool Isprimary { get; set; }

        /// <summary>
        /// List of Assessment Domain
        /// </summary>
        [JsonProperty("assessmentDomains")]
        public IList<Tag> AssessmentDomains { get; set; }
    


    }
}
