using NPoco;
using VPT.Shared.Poco.DTO.API;

namespace VPT.Shared.Poco.Model.API
{
    [TableName("CasePlanSnapshot")]
    [PrimaryKey("CasePlanID")]
    public class CasePlanSnapshot : BaseModel
    {
        public CasePlanSnapshot()
        { }

        public CasePlanSnapshot(CasePlanSnapshotDTO source)
            : base(source)
        {
            CasePlanID = source.CasePlanID;
            SubjectUserID = source.SubjectUserID;
            CasePlanSnapshotData = source.CasePlanSnapshotData;
            CasePlanSnapshotVersion = source.CasePlanSnapshotVersion;
        }

        /// <summary>
        /// The ID of the Case plan
        /// </summary>
        public int CasePlanID { get; set; }

        /// <summary>
        /// The id of Subject
        /// </summary>
        public int SubjectUserID { get; set; }

        /// <summary>
        /// The case plan snapshot data
        /// </summary>
        public string CasePlanSnapshotData { get; set; }

        /// <summary>
        /// The CasePlan Snapshot Version
        /// </summary>
        public int CasePlanSnapshotVersion { get; set; }

    }
}
