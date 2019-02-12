using NPoco;
using System;
using VPT.Shared.Poco.DTO.API;

namespace VPT.Shared.Poco.Model.API
{
    [TableName("CareGroupHistory")]
    [PrimaryKey("CareGroupHistoryID")]
    public class CareGroupHistory 
    {
        public CareGroupHistory()
        { }

        public CareGroupHistory(CareGroupHistoryDTO source)
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
        /// The person ID of Subject
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
