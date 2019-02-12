using NPoco;
using System;
using VPT.Shared.Poco.DTO.API;

namespace VPT.Shared.Poco.Model.API
{
    [TableName("SubjectJob")]
    public class SubjectJobMapping : BaseModel
    {
        public SubjectJobMapping()
        { }

        public SubjectJobMapping(SubjectJobMappingDTO source)
            : base(source)
        {
            SubjectUserID = source.SubjectUserID;
            JobId = source.JobId;
            ApprovalStatus = source.ApprovalStatus;
            DateApproved = source.DateApproved;
        }

        public string SubjectUserID { get; set; }

        public int JobId { get; set; }

        public int ApprovalStatus { get; set; }

        public DateTime? DateApproved { get; set; }
    }
}
