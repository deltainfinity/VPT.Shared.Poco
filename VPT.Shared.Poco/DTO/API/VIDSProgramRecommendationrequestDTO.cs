using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPT.Shared.Poco.DTO.API
{
    public class VIDSProgramRecommendationrequestDTO
    {
        public string OffenderID { get; set; }
        public string Name { get; set; }
        public int SortOrder { get; set; }
        public string UserName { get; set; }
        public int CourseID { get; set; }
    }
}
