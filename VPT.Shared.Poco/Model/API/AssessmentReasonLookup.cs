using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPT.Shared.Poco.Model.API
{
    public class AssessmentReasonLookup
    {
        public int ReasonID { get; set; }
        public string ReasonText { get; set; }
        public int SKUID { get; set; }
        public string HoverText { get; set; }
        public int OrganizationID { get; set; }
    }
}
