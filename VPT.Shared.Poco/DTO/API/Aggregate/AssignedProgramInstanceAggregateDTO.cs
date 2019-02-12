using Newtonsoft.Json;
using System.Collections.Generic;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API.Aggregate
{
    public class AssignedProgramInstanceAggregateDTO
    {

        public AssignedProgramInstanceAggregateDTO()
        { }

        public AssignedProgramInstanceAggregateDTO(Program program, string status, List<ProgramAttendance> attendanceList, string assignType)
            : base()
        {
            ProgramID = program.ProgramId;
            ParentProgramID = program.ParentProgramID;
            ProgramName = program.Title;
            Sunday = program.Sunday;
            Monday = program.Monday;
            Tuesday = program.Tuesday;
            Wednesday = program.Wednesday;
            Thursday = program.Thursday;
            Friday = program.Friday;
            Saturday = program.Saturday;
            Schedule = program.SessionStartTime + " - " + program.SessionEndTime;
            AttendanceList = attendanceList;
            Status = status;
            ClassroomID = program.ClassroomId;
            AssignType = assignType;
        }

        [JsonProperty("programID")]
        public int ProgramID { get; set; }

        [JsonProperty("parentProgramID")]
        public int ParentProgramID { get; set; }

        [JsonProperty("programName")]
        public string ProgramName { get; set; }

        [JsonProperty("sunday")]
        public bool Sunday { get; set; }

        [JsonProperty("monday")]
        public bool Monday { get; set; }

        [JsonProperty("tuesday")]
        public bool Tuesday { get; set; }

        [JsonProperty("wednesday")]
        public bool Wednesday { get; set; }

        [JsonProperty("thursday")]
        public bool Thursday { get; set; }

        [JsonProperty("friday")]
        public bool Friday { get; set; }

        [JsonProperty("saturday")]
        public bool Saturday { get; set; }

        [JsonProperty("schedule")]
        public string Schedule { get; set; }

        [JsonProperty("scheduleDate")]
        public string ScheduleDate { get; set; }

        [JsonProperty("attendanceList")]
        public List<ProgramAttendance> AttendanceList { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("classroomID")]
        public int ClassroomID { get; set; }

        [JsonProperty("assignType")]
        public string AssignType { get; set; }

    }
}
