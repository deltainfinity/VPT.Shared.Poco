using System;
using Newtonsoft.Json;
using VPT.Shared.Poco.Enum.API;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API
{
    public class SubjectProgramStatusHistoryDTO : BaseDTO
    {
        public SubjectProgramStatusHistoryDTO()
        { }

        public SubjectProgramStatusHistoryDTO(SubjectProgramStatusHistoryMapping spmapping)
        {
            if (spmapping == null) throw new ArgumentNullException(nameof(spmapping));

            SubjectProgramStatusHistoryID = spmapping.SubjectProgramStatusHistoryID;
            Status = spmapping.Status;
            DateStarted = spmapping.StartDate.HasValue ? spmapping.StartDate.Value.ToString("MM/dd/yyyy") : string.Empty;
            DateEnded = spmapping.EndDate.HasValue ? spmapping.EndDate.Value.ToString("MM/dd/yyyy") : string.Empty;
            SubjectProgramID = spmapping.SubjectProgramID; 
        }

        //public SubjectProgramDataDTO(SubjectProgramMapping spmapping, ParentProgram parentProgram)
        //    : base(spmapping)
        //{
        //    if (spmapping == null) throw new ArgumentNullException(nameof(spmapping));
        //    if (parentProgram == null) throw new ArgumentNullException(nameof(parentProgram));

        //    SubjectUserID = spmapping.SubjectUserID;
        //    ProgramID = spmapping.ProgramId;
        //    Program = new ParentProgramDTO(parentProgram);

        //    ApprovalStatusID = spmapping.ApprovalStatus;
        //    DateApproved = spmapping.DateApproved.HasValue ? spmapping.DateApproved.Value.ToShortDateString() : string.Empty;
        //    DateReferred = spmapping.DateCreated.ToShortDateString();
        //    ProgramStatusID = spmapping.ProgramStatus;
        //    DateStarted = spmapping.DateStarted.HasValue ? spmapping.DateStarted.Value.ToString("MM/dd/yyyy") : string.Empty;
        //    DateEnded = spmapping.DateEnded.HasValue ? spmapping.DateEnded.Value.ToString("MM/dd/yyyy") : string.Empty;
        //    DateCompleted = spmapping.DateCompleted.HasValue ? spmapping.DateCompleted.Value.ToShortDateString() : string.Empty;
        //    TypeName = parentProgram.TypeName;
        //}

        /// <summary>
        /// The primary ID of the history item
        /// </summary>
        [JsonProperty("subjectProgramStatusHistoryID")]
        public int SubjectProgramStatusHistoryID { get; set; }

        /// <summary>
        /// The person ID of the Subject
        /// </summary>
        [JsonProperty("subjectUserID")]
        public string SubjectUserID { get; set; }

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
        /// Subject Program ID
        /// </summary>
        [JsonProperty("subjectProgramID")]
        public int SubjectProgramID { get; set; }

    }
}
