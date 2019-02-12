using NPoco;
using System;
using VPT.Shared.Poco.DTO.API;

namespace VPT.Shared.Poco.Model.API
{
    [TableName("BOPSnapshot")]
    [PrimaryKey("BOPSnapshotID")]
    public class BOPSnapshot
    {
        public BOPSnapshot()
        { }

        public BOPSnapshot(BOPSnapshotDTO source)
        {
            BOPSnapshotID = source.BOPSnapshotID;
            OffenderID = source.OffenderID;
            HearingDate = source.HearingDate;
            DateCreated = source.DateCreated;
            BOPDashboard = source.BOPDashboard;

        }

        /// <summary>
        /// The ID of the BOPSnapshot
        /// </summary>
        public int BOPSnapshotID { get; set; }

        /// <summary>
        /// The ID of the Offender
        /// </summary>
        public string OffenderID { get; set; }

        /// <summary>
        /// The date of hearing
        /// </summary>
        public DateTime HearingDate { get; set; }

        /// <summary>
        /// The date created
        /// </summary>
        public DateTime DateCreated { get; set; }

        /// <summary>
        ///  BOPDashboard
        /// </summary>
        public string BOPDashboard { get; set; }

        /// <summary>
        /// The program  assigned
        /// </summary>
        public string AssignedProgram { get; set; }

        /// <summary>
        /// CCR
        /// </summary>
        public string CCR { get; set; }

        /// <summary>
        /// DrugTest
        /// </summary>
        public string DrugTest { get; set; }

        /// <summary>
        /// Pathway
        /// </summary>
        public string Pathway { get; set; }
    }
}
