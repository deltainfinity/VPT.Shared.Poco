using System;

namespace VPT.Shared.Poco.DTO.API.Integration
{
    public class OffenderHistorySnapshotDTO
    {
        public int OffenderID { get; set; }

        public int OrganizationID { get; set; }

        public string AggressionViolence { get; set; }

        public DateTime DispositionDate { get; set; }

        public int OffenderHistoryID { get; set; }

        public string DVFlag { get; set; }

        public string LegalCodeType { get; set; }
    }
}
