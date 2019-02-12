using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VPT.Shared.Poco.Enum.API;

namespace VPT.Shared.Poco.DTO.API
{
    public class CompletedGTLCourseRequestDTO : BaseDTO
    {        
        public string UserID { get; set; }
        public string CourseID { get; set; }
        public DateTime CompletionTime { get; set; }
        public CourseGrade Grade { get; set; }
    }
}
