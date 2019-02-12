using NPoco;
using System;
using VPT.Shared.Poco.DTO.API;

namespace VPT.Shared.Poco.Model.API
{
    [TableName("ProgramAttendance")]
    [PrimaryKey("ProgramAttendanceID")]
    public class ProgramAttendance : BaseModel
    {
        public ProgramAttendance()
        { }
        public ProgramAttendance(ProgramAttendanceDTO source)
             : base(source)
        {
            ProgramAttendanceID = source.ProgramAttendanceID;
            Note = source.Note;
            AttendanceDate = source.AttendanceDate;
            AttendanceStatus = source.AttendanceStatus;
            BehaviorRating = source.BehaviorRating;
            RecommendRetake = source.RecommendRetake;
            NumberHoursAttended = source.NumberHoursAttended;
            NumberHoursExcused = source.NumberHoursExcused;
            SubjectProgramID = source.SubjectProgramID;
        }

        public int ProgramAttendanceID { get; set; }

        public string Note { get; set; }

        [ResultColumn]
        public int SubjectUserID { get; set; }

        public DateTime AttendanceDate { get; set; }

        public int AttendanceStatus { get; set; }

        public int BehaviorRating { get; set; }

        public bool RecommendRetake { get; set; }

        public decimal NumberHoursAttended { get; set; }

        public decimal NumberHoursExcused { get; set; }

        public int SubjectProgramID { get; set; }
    }
}
