using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPT.Shared.Poco.DTO.API
{
    public class CompletedGTLCoursesDTO : BaseDTO
    {
        public CompletedGTLCoursesDTO(CompletedGTLCourseRequestDTO source)
        {
            SORID = source.UserID;
            CourseID = Convert.ToInt32(source.CourseID);
            CompletionTime = Convert.ToDateTime(source.CompletionTime);
            Grade = source.Grade.ToString();
        }
        public int CompletedGTLCoursesID { get; set; }
        public string SORID { get; set; }
        public int CourseID { get; set; }
        public DateTime CompletionTime { get; set; }
        public string Grade { get; set; }
    }
}
