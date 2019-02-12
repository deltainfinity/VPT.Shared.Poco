using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using VPT.Shared.Poco.Constants;
using VPT.Shared.Poco.DTO.Accounts.Aggregate;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API
{
    public class SubjectProgramAttendanceHistoryDTO
    {
        public SubjectProgramAttendanceHistoryDTO()
        { }

        public SubjectProgramAttendanceHistoryDTO(IEnumerable<SubjectProgramStatusHistoryMapping> spmapping, List<ProgramAttendanceDTO> attendance, SubjectProgramMapping subjectProgramMapping,PersonDetailsDTO facilitator,Program program, Facility facility,List<SubjectProgramStatus> programStatusList)
        {
            if (spmapping == null) throw new ArgumentNullException(nameof(spmapping));
            if (attendance == null) throw new ArgumentNullException(nameof(attendance));
            var assigned = programStatusList.Where(y => y.Name == SubjectProgramStatuseConstants.Assigned).Select(y => y.ProgramStatusID).FirstOrDefault();
            var inProgress = programStatusList.Where(y => y.Name == SubjectProgramStatuseConstants.InProgress).Select(y => y.ProgramStatusID).FirstOrDefault();
            var completed = programStatusList.Where(y => y.Name == SubjectProgramStatuseConstants.Completed).Select(y => y.ProgramStatusID).FirstOrDefault();
            var terminated = programStatusList.Where(y => y.Name == SubjectProgramStatuseConstants.Terminated).Select(y => y.ProgramStatusID).FirstOrDefault();

            DateAssigned = spmapping.Where(x => x.Status == assigned).Count() > 0 ? spmapping.Where(x => x.Status == assigned).FirstOrDefault().DateCreated.ToString("MM/dd/yyyy") : string.Empty;
            DateStarted = spmapping.Where(x => x.Status == inProgress).Count() > 0 ? spmapping.Where(x => x.Status == inProgress).FirstOrDefault().DateCreated.ToString("MM/dd/yyyy") : string.Empty;
            DateEnded = spmapping.Where(x => x.Status == completed || x.Status == terminated).Count() > 0 ? spmapping.Where(x => x.Status == completed || x.Status == terminated).FirstOrDefault().DateCreated.ToString("MM/dd/yyyy") : string.Empty;
            AttendanceList = attendance;
            Status = subjectProgramMapping.ProgramStatus;
            ProgramStatusName = programStatusList.Where(y => y.ProgramStatusID == Status).Select(y => y.Name).FirstOrDefault();
             SubjectUserID = subjectProgramMapping.SubjectUserID;
            ProgramID = subjectProgramMapping.ProgramId;
            Facilitator = facilitator==null?"":facilitator.FullNameFirstNameFirstFormat;
            ProgramStartDate = program.StartDate.HasValue?program.StartDate.Value.ToString("MM/dd/yyyy"):string.Empty;
            Facility = facility == null ? "N/A": facility.FacilityCode;
        }

        /// <summary>
        /// The person ID of the Subject
        /// </summary>
        [JsonProperty("subjectUserID")]
        public int SubjectUserID { get; set; }

        /// <summary>
        /// The ID of the Program
        /// </summary>
        [JsonProperty("programID")]
        public int ProgramID { get; set; }


        /// <summary>
        /// The Subject's status in the program
        /// </summary>
        [JsonProperty("status")]
        public int Status { get; set; }

          /// <summary>
        /// The Subject's status name in the program
        /// </summary>
        [JsonProperty("programStatusName")]
       public string ProgramStatusName { get; set; }


        /// <summary>
        /// The date the subject started the program
        /// </summary>
        [JsonProperty("dateStarted")]
        public string DateStarted { get; set; }

        /// <summary>
        /// The date the subject ended the program
        /// </summary>
        [JsonProperty("dateEnded")]
        public string DateEnded { get; set; }

        /// <summary>
        /// The date the subject ended the program
        /// </summary>
        [JsonProperty("dateAssigned")]
        public string DateAssigned { get; set; }

        /// <summary>
        /// The attendance list
        /// </summary> 
        [JsonProperty("attendanceList")]
        public List<ProgramAttendanceDTO> AttendanceList { get; set; }
        /// <summary>
        /// The facilitator name
        /// </summary> 
        [JsonProperty("facilitator")]
        public string Facilitator { get; set; }
        /// <summary>
        /// The start date of program
        /// </summary> 
        [JsonProperty("programStartDate")]
        public string ProgramStartDate { get; set; }

        /// <summary>
        /// Facility details
        /// </summary>
        [JsonProperty("facility")]
        public string Facility { get; set; }

    }
}
