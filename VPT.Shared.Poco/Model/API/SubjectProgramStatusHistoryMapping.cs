using NPoco;
using System;
using VPT.Shared.Poco.DTO.API;

namespace VPT.Shared.Poco.Model.API
{

    [TableName("SubjectProgramStatusHistory")]
    [PrimaryKey("SubjectProgramStatusHistoryID")]
    public class SubjectProgramStatusHistoryMapping
    {
        public SubjectProgramStatusHistoryMapping()
        { }

        public SubjectProgramStatusHistoryMapping(SubjectProgramStatusHistoryDTO source)

        {
            SubjectProgramStatusHistoryID = source.SubjectProgramStatusHistoryID;
            Status = source.Status;
            StartDate = !string.IsNullOrEmpty(source.DateStarted) ? (DateTime?)Convert.ToDateTime(source.DateStarted) : null;
            EndDate = !string.IsNullOrEmpty(source.DateEnded) ? (DateTime?)Convert.ToDateTime(source.DateEnded) : null;
            SubjectProgramID = source.SubjectProgramID;
        }

        public SubjectProgramStatusHistoryMapping(int programStatus,
                             DateTime? startDate, DateTime? endDate, int subjectProgramID, string createdByUserID = "SYSTEM")
        {
            Status = programStatus;
            StartDate = startDate ?? null;
            EndDate = endDate ?? null;
            DateCreated = DateTime.Now;
            CreatedByUserID = createdByUserID;
            SubjectProgramID = subjectProgramID;
        }

        public int SubjectProgramStatusHistoryID { get; set; }

        [ResultColumn]
        public string SubjectUserID { get; set; }

        [ResultColumn]
        public int ProgramId { get; set; }

        public int Status { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public int SubjectProgramID { get; set; }

        public string CreatedByUserID { get; set; }

        public bool Deleted { get; set; }

        public DateTime? DateDeleted { get; set; }

        public DateTime DateCreated { get; set; }

    }
}
