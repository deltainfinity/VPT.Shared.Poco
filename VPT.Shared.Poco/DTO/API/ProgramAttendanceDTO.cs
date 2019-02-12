using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VPT.Shared.Poco.Enum.API;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API
{
    public class ProgramAttendanceDTO :BaseDTO
    {
        

        public ProgramAttendanceDTO()
        { }

        public ProgramAttendanceDTO(ProgramAttendance source)
            : base(source)
        {
            ProgramAttendanceID = source.ProgramAttendanceID;
            Note = source.Note;
            AttendanceDate = source.AttendanceDate;
            AttendanceDateString = source.AttendanceDate.ToString("MM/dd/yyyy");
            AttendanceStatus = source.AttendanceStatus;
            IsPresentString = IntToString(AttendanceStatus);
            IsPresentStringForHistory = convertInt(AttendanceStatus);
            BehaviorRating = source.BehaviorRating;
            AttendanceStatusString = ConvertoString(source.AttendanceStatus);
            RecommendRetake = source.RecommendRetake;
            NumberHoursAttended = source.NumberHoursAttended;
            NumberHoursExcused = source.NumberHoursExcused;
            SubjectUserID = source.SubjectUserID;
        }


        public ProgramAttendanceDTO(SORProgramAttendance SORProgramAttendance,List<Program> programList, int subjectUserID, int subjectProgramID)
        {
            if (DateTime.TryParse(SORProgramAttendance.DateAttended, out DateTime dateAttended))
            {
                AttendanceDate = dateAttended;
            }
            CreatedByUserID = "SYSTEM";
            Deleted = false;
            if (Convert.ToDecimal(SORProgramAttendance.NumberHoursAttended) != 0)
            {
                AttendanceStatus = (int)ProgramAttendanceStatus.Present;
            }
            else if (Convert.ToDecimal(SORProgramAttendance.NumberHoursExcused) != 0)
            {
                AttendanceStatus = (int)ProgramAttendanceStatus.ExcusedAbsence;
            }
            else
            {
                AttendanceStatus = (int)ProgramAttendanceStatus.Absent;
            }
            ProgramID = programList.FirstOrDefault().ProgramId;
            SubjectUserID = subjectUserID;
            Note = string.Empty;
            BehaviorRating = 0;
            RecommendRetake = false;
            NumberHoursAttended = Convert.ToDecimal(SORProgramAttendance.NumberHoursAttended);
            NumberHoursExcused = Convert.ToDecimal(SORProgramAttendance.NumberHoursExcused);
            SubjectProgramID = subjectProgramID;
        }


        public int ProgramAttendanceID { get; set; }

        public int ProgramID { get; set; }
        public int SubjectUserID { get; set; }

        public string Note { get; set; }

        public DateTime AttendanceDate { get; set; }

        public string AttendanceDateString { get; set; }

        public int AttendanceStatus { get; set; }

        public string IsPresentString { get; set; }
        public string IsPresentStringForHistory { get; set; }
        public int BehaviorRating { get; set; }
        public string AttendanceStatusString { get; set; }
        public bool RecommendRetake { get; set; }
        public decimal NumberHoursAttended { get; set; }
        public decimal NumberHoursExcused { get; set; }
        public int SubjectProgramID { get; set; }

        private string IntToString(int value)
        {
            if (value == 0)
                return "No";
            else if (value == 1)
                return "Yes";
            else
                return "No (Excused)";
        }
        private string convertInt(int value)
        {
            if (value == 1)
                return "Present";
            else if (value == 0)
                return "Absent";
            else 
                return "Excused Absence";
        }
        private string ConvertoString(int value)
        {
            return ProgramAttendanceStatusConstants.GetByEnum(value);
        }
    }
}
