using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPT.Shared.Poco.DTO.API.Tether
{
    public class LmsCourseDetailsDTO
    {
        public string courseID { get; set; }
        public string courseTitle { get; set; }
        public string courseDescription { get; set; }
        public string courseAvailableDate { get; set; }
        public Guid guId { get; set; }
        public string courseLink { get; set; }
    }
}
