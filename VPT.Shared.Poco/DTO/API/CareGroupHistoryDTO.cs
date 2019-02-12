using System;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API
{
    public class CareGroupHistoryDTO 
    {
        public CareGroupHistoryDTO(CareGroupHistory source)
        {
            CareGroupHistoryID = source.CareGroupHistoryID;
            SubjectUserID = source.SubjectUserID;
            AgentUserID = source.AgentUserID;
            CareGroupType = source.CareGroupType;
            Reason = source.Reason;
            DateCreated = source.DateCreated;

        }
        /// <summary>
        /// The ID of the Care Group History
        /// </summary>
        public int CareGroupHistoryID { get; set; }

        /// <summary>
        /// Theperson ID of Subject
        /// </summary>
        public int SubjectUserID { get; set; }

        /// <summary>
        /// The person ID of Agent
        /// </summary>
        public int AgentUserID { get; set; }

        ///<summary>
        /// Care Group Type
        /// </summary>
        public int CareGroupType { get; set; }

        ///<summary>
        /// Reason for adding temporary care group agent 
        /// </summary>
        public string Reason { get; set; }

        ///<summary>
        /// Date Created
        /// </summary>
        public DateTime DateCreated { get; set; }

    }
}
