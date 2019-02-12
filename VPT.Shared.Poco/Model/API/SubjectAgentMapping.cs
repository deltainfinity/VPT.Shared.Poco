using NPoco;
using System;
using VPT.Shared.Poco.DTO.API;

namespace VPT.Shared.Poco.Model.API
{
    [TableName("SubjectAgent")]
    [PrimaryKey("SubjectUserID, AgentUserID", AutoIncrement = false)]
    public class SubjectAgentMapping
    {
        public SubjectAgentMapping()
        { }

        public SubjectAgentMapping(SubjectAgentMappingDTO source)

        {
            SubjectUserID = source.SubjectUserID;
            AgentUserID = source.AgentUserID;
            ApprovalStatus = source.ApprovalStatus;
            DateApproved = source.DateApproved;
            CareGroupType = CareGroupType;
            ExpireDate = ExpireDate;
            Reason = Reason;
        }

        public int SubjectUserID { get; set; }

        public int AgentUserID { get; set; }

        public int ApprovalStatus { get; set; }

        public DateTime? DateApproved { get; set; }

        public int CareGroupType { get; set; }

        public DateTime? ExpireDate { get; set; }

        public string Reason { get; set; }

        public DateTime? DateCreated { get; set; }

        public string CreatedByUserID { get; set; }

        public DateTime? DateUpdated { get; set; }

        public string UpdatedByUser { get; set; }

        public bool Deleted { get; set; }

        public DateTime? DateDeleted { get; set; }

        public string DeletedByUser { get; set; }
    }
}
