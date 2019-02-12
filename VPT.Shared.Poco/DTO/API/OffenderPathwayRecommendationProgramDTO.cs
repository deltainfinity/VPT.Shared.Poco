using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPT.Shared.Poco.DTO.API
{
    public class OffenderPathwayRecommendationProgramDTO
    {
        public OffenderPathwayRecommendationProgramDTO()
        {           
        }
        public string OffenderID { get; set; }
        public int AssessmentID { get; set; }
        public RecommendationDTO RecommendationDTO { get; set; }
    }
}
