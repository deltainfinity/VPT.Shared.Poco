using System;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API
{
    public class BOPSnapshotDTO
    {
        public BOPSnapshotDTO()
        { }

        public BOPSnapshotDTO(BOPSnapshot source)
        {
            BOPSnapshotID = source.BOPSnapshotID;
            OffenderID = source.OffenderID;
            HearingDate = source.HearingDate;
            DateCreated = source.DateCreated;
            BOPDashboard = source.BOPDashboard;
        }

        public int BOPSnapshotID { get; set; }
        public string OffenderID { get; set; }
        public DateTime HearingDate { get; set; }
        public DateTime DateCreated { get; set; }
        public string BOPDashboard { get; set; }
        public string AssignedProgram { get; set; }
        public string CCR { get; set; }
        public string DrugTest { get; set; }
        public string Pathway { get; set; }

    }
}
