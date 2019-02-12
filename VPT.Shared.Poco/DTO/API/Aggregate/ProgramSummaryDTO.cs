using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VPT.Shared.Poco.Enum.API;
using VPT.Shared.Poco.Model.API;
using VPT.Accounts.Shared.DTO.Aggregate;

namespace VPT.Shared.Poco.DTO.API.Aggregate
{
    public class ProgramSummaryDTO
    {
        public ProgramSummaryDTO()
        { }
        public ProgramSummaryDTO(Program program, ParentProgram parentprogram, SubjectProgramMapping subjectprogram,string methodOfTreatmentString, Facility facility, PersonDetailsDTO programfacilitator, List<ProgramAttendanceDTO> subjectAttendance,string programstatus) : base()
        {
            Title = parentprogram.Title + " - " + program.Title;
            Site = facility!=null? facility.FacilityName:"N/A";
            Type = methodOfTreatmentString;
            Status = programstatus;
            ProgramAdministrator = programfacilitator == null ? "" : programfacilitator.LastName + ", " + programfacilitator.FirstName;
            if (parentprogram.IsPerpetual)
            {
                IsPerpetual = true;
                IsOnline = false;
                StartDate = "";
                EndDate = "";
            }
            else if (parentprogram.Platform == (int)PlatformType.Online)
            {
                IsPerpetual = false;
                IsOnline = true;
                StartDate = "";
                EndDate = "";
            }
            else
            {
                IsPerpetual = false;
                IsOnline = false;
                StartDate = program.StartDate.Value.ToString("MM/dd/yyyy");
                EndDate = program.EndDate.Value.ToString("MM/dd/yyyy");

            }
            ProgramSummary = parentprogram.Description;
            AttendanceList = subjectAttendance;

        }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("site")]
        public string Site { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("programAdministrator")]
        public string ProgramAdministrator { get; set; }
        [JsonProperty("IsPerpetual")]
        public bool IsPerpetual { get; set; }
        [JsonProperty("IsOnline")]
        public bool IsOnline { get; set; }
        [JsonProperty("startDate")]
        public string StartDate { get; set; }
        [JsonProperty("endDate")]
        public string EndDate { get; set; }
        [JsonProperty("programSummary")]
        public string ProgramSummary { get; set; }
        [JsonProperty("attendanceList")]
        public List<ProgramAttendanceDTO> AttendanceList { get; set; }
       
    }
}
