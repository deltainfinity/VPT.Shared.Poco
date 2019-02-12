using System;

namespace VPT.Shared.Poco.Model.API
{

    public class SORClassRoster
    {
        public SORClassRoster()
        { }

        public string StateProgramId { get; set; }
        public string TerminationDecidedBy { get; set; }
        public string PositionRemoved { get; set; }
        public string ReasonForTermination1 { get; set; }
        public string ReasonForTermination2 { get; set; }
        public string ReasonForTermination3 { get; set; }
        public string SiteID { get; set; }
        public string OffenderID { get; set; }
        public string SectionID { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string AccountExternalId { get; set; }
        public int OrganizationID { get; set; }
        public DateTime DateCreated { get; set; }

    }

}
