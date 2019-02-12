using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPT.Shared.Poco.DTO.API
{
    public class CompletedAssessmentDTO
    {
        public int OffenderAssessmentId { get; set; }
        public string Name { get; set; }
        public int AssessmentId { get; set; }
        public string PIN { get; set; }
        public DateTime? Started { get; set; }
        public string AssignedBy { get; set; }
        public DateTime? Completed { get; set; }
        public string CompletedBy { get; set; }
        public string results { get; set; }
        public int CCRSnapshot { get; set; }
    }
}
