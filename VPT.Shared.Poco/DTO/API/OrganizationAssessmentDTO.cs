using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API
{
    public class OrganizationAssessmentDTO : BaseDTO
    {
        public OrganizationAssessmentDTO(OrganizationAssessment source)
        {
            OrganizationAssessmentID = source.OrganizationAssessmentID;
            OrganizationID = source.OrganizationID;
            AssessmentID = source.AssessmentID;

        }

        /// <summary>
        /// The ID of the Orgnanization Assessment
        /// </summary>
        [JsonProperty("organizationAssessmentID")]
        public int OrganizationAssessmentID { get; set; }

        /// <summary>
        /// The id of Organization
        /// </summary>
        [JsonProperty("organizationID")]
        public int OrganizationID { get; set; }
        /// <summary>
        /// The id of Assessment
        /// </summary>
        [JsonProperty("assessmentID")]
        public int AssessmentID { get; set; }



    }
}
