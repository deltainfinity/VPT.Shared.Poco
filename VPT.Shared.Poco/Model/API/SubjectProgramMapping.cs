using NPoco;
using System;
using VPT.Shared.Poco.DTO.API;

namespace VPT.Shared.Poco.Model.API
{
    [TableName("SubjectProgram")]
    [PrimaryKey("SubjectProgramID")]
    public class SubjectProgramMapping : BaseModel
    {
        public SubjectProgramMapping()
        { }

        public SubjectProgramMapping(SubjectProgramEnrollment subjectProgram)
        {
            DateTime dateTime;
            if (DateTime.TryParse(subjectProgram.OffenderStartDate, out dateTime))
            {
                DateStarted = dateTime;
            }
            if (DateTime.TryParse(subjectProgram.OffenderEndDate, out dateTime))
            {
                DateEnded = dateTime;
            }
            DateCreated = DateTime.Now;

        }

        public SubjectProgramMapping(SubjectProgramMappingDTO source)
            : base(source)
        {
            SubjectProgramID = source.SubjectProgramID;
            SubjectUserID = source.SubjectUserID;
            ProgramId = source.ProgramId;
            ApprovalStatus = source.ApprovalStatus;
            DateApproved = source.DateApproved;
            ProgramStatus = source.ProgramStatusID;
            DateStarted = !string.IsNullOrEmpty(source.DateStarted) ? (DateTime?)Convert.ToDateTime(source.DateStarted) : null;
            DateEnded = !string.IsNullOrEmpty(source.DateEnded) ? (DateTime?)Convert.ToDateTime(source.DateEnded) : null;
            DateCompleted = !string.IsNullOrEmpty(source.DateCompleted) ? (DateTime?)Convert.ToDateTime(source.DateCompleted) : null;
            TerminationReasonID1 = source.TerminationReasonID1.HasValue ? source.TerminationReasonID1.Value : (int?)null;
            TerminationReasonID2 = source.TerminationReasonID2.HasValue ? source.TerminationReasonID2.Value : (int?)null;
            TerminationReasonID3 = source.TerminationReasonID3.HasValue ? source.TerminationReasonID3.Value : (int?)null;
            IsRecommendedProgram = source.IsRecommendedProgram;
            PositionID = source.PositionID;
            AssignedBy = source.AssignedBy;
        }
        public int SubjectProgramID { get; set; }
        public int SubjectUserID { get; set; }

        public int ProgramId { get; set; }

        [ResultColumn]
        public int ClassroomId { get; set; }

        public int ApprovalStatus { get; set; }

        public DateTime? DateApproved { get; set; }

        public int ProgramStatus { get; set; }

        public DateTime? DateStarted { get; set; }

        public DateTime? DateEnded { get; set; }

        public DateTime? DateCompleted { get; set; }

        public int? TerminationReasonID1 { get; set; }

        public int? TerminationReasonID2 { get; set; }

        public int? TerminationReasonID3 { get; set; }

        public bool IsRecommendedProgram { get; set; }

        public string PositionID { get; set; }
        public int? AssignedBy { get; set; }
    }
}
