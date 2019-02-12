using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPT.Shared.Poco.DTO.API
{
    public class PathwayRecommendationRequestDTO
    {
        public string OffenderID { get; set; }
        public string Name { get; set; }
        public string SortOrder { get; set; }
        public string PathwayCode { get; set; }
        public int OrganizationID { get; set; }
        public string IDToken { get; set; }
    }
}
