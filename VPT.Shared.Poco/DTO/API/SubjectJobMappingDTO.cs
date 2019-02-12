using System;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API
{
    public class SubjectJobMappingDTO : BaseDTO
    {
#pragma warning disable 1591
        public SubjectJobMappingDTO()
#pragma warning restore 1591
        { }

#pragma warning disable 1591
        public SubjectJobMappingDTO(SubjectJobMapping source)
#pragma warning restore 1591
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
