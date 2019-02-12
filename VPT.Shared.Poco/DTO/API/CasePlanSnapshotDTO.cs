using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API
{
   public class CasePlanSnapshotDTO : BaseDTO
    {
        public CasePlanSnapshotDTO()
        {
        }
        public CasePlanSnapshotDTO(CasePlanSnapshot source)
        {
            CasePlanID = source.CasePlanID;
            SubjectUserID = source.SubjectUserID;
            CasePlanSnapshotData = source.CasePlanSnapshotData;
            CasePlanSnapshotVersion = source.CasePlanSnapshotVersion;
        }

        /// <summary>
        /// The ID of case plan
        /// </summary>
        [JsonProperty("casePlanID")]
        public int CasePlanID { get; set; }

        /// <summary>
        /// The id of subject
        /// </summary>
        [JsonProperty("subjectUserID")]
        public int SubjectUserID { get; set; }

        /// <summary>
        /// The case plan snapshot data
        /// </summary>
        public string CasePlanSnapshotData { get; set; }

        /// <summary>
        /// The external id of subject
        /// </summary>
        [JsonProperty("externalID")]
        public string ExternalID { get; set; }

        /// <summary>
        /// The CasePlan Snapshot Version
        /// </summary>
        public int CasePlanSnapshotVersion { get; set; }
    }
}
