using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPT.Shared.Poco.DTO.API
{
    public class SORProgramDTO
    {
        public string AccountExternalId { get; set; }
        public string StateProgramId { get; set; }
        public string SiteID { get; set; }
        public string SiteName { get; set; }
        public string SubjectExternalId { get; set; }
        public string PositionId { get; set; }
        public string PositionType { get; set; }
        public string EffectiveDateFrom { get; set; }
        public string BasePayRate { get; set; }
        public string HighestCustodyLevel { get; set; }
        public string PositionDescription1 { get; set; }
        public string PositionDescription2 { get; set; }
        public string PositionDescription3 { get; set; }
        public string PositionDescription4 { get; set; }
        public string PositionDescription5 { get; set; }
        public string PositionDescription6 { get; set; }
        public string PositionDescription7 { get; set; }
        public string IncentivePayFlag { get; set; }
        public string Monday { get; set; }
        public string Tuesday { get; set; }
        public string Wednesday { get; set; }
        public string Thursday { get; set; }
        public string Friday { get; set; }
        public string Saturday { get; set; }
        public string Sunday { get; set; }
        public string Supervisor { get; set; }
        public string SupervisionName { get; set; }
        public string OffenderStartDate { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string StartTime2 { get; set; }
        public string EndTime2 { get; set; }
        public string OffenderEndDate { get; set; }
        public string EffectiveDateTo { get; set; }
        public string JobLocation { get; set; }
        public string TerminationDecidedBy { get; set; }
        public string TerminationDate { get; set; }
        public string TerminationReason1 { get; set; }
        public string TerminationReason2 { get; set; }
        public string TerminationReason3 { get; set; }
        public int OrganizationId { get; set; }
        public int ClassSize { get; set; }

    }
}
