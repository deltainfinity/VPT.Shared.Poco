using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API
{
    public class SORProgramAttendanceDTO 
    {
        public string AccountExternalId { get; set; }
        public string SiteId { get; set; }
        public string StateProgramId { get; set; }
        public string PositionId { get; set; }
        public string DateAttended { get; set; }
        public string SubjectExternalId { get; set; }
        public string NumberHoursAttended { get; set; }
        public string NumberHoursExcused { get; set; }
        public int OrganizationId { get; set; }
    }
}
