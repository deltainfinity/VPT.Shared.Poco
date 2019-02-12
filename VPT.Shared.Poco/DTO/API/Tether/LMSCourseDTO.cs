using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPT.Shared.Poco.DTO.API.Tether
{
    public class LMSCourseDTO
    {
        public LMSCourseDTO() { }
        public LMSCourseDTO(GTLLMSCourseDTO source)
        {
            courseID = source.Id;
            courseTitle = source.ShortName;
            courseDescription = source.FullName;
            courseAvailableDate = source.Visible == "1" ? DateTime.Now.ToString("yyyy-MM-dd") : "";
        }
        public string courseID { get; set; }
        public string courseTitle { get; set; }
        public string courseDescription { get; set; }
        public string courseAvailableDate { get; set; }
    }
}
