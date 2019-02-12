using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using VPT.Shared.Poco.Enum.API;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API
{
    public class SubjectProgramMappingDTO : BaseDTO
    {
        public SubjectProgramMappingDTO()
        { }

        public SubjectProgramMappingDTO(SubjectProgramMapping source)
            : base(source)
        {
            SubjectProgramID = source.SubjectProgramID;
            SubjectUserID = source.SubjectUserID;
            ProgramId = source.ProgramId;
            ApprovalStatus = source.ApprovalStatus;
            DateApproved = source.DateApproved;
            DateReferred = source.DateCreated.ToShortDateString();
            ProgramStatusID = source.ProgramStatus;
            DateStarted = source.DateStarted.HasValue ? source.DateStarted.Value.ToShortDateString() : string.Empty;
            DateEnded = source.DateEnded.HasValue ? source.DateEnded.Value.ToShortDateString() : string.Empty;
            DateCompleted = source.DateCompleted.HasValue ? source.DateCompleted.Value.ToShortDateString() : string.Empty;
            TerminationReasonID1 = source.TerminationReasonID1.HasValue ? source.TerminationReasonID1.Value : (int?)null;
            TerminationReasonID2 = source.TerminationReasonID2.HasValue ? source.TerminationReasonID2.Value : (int?)null;
            TerminationReasonID3 = source.TerminationReasonID3.HasValue ? source.TerminationReasonID3.Value : (int?)null;
            IsRecommendedProgram = source.IsRecommendedProgram;
            PositionID = source.PositionID;
            AssignedBy = source.AssignedBy;
        }


        public SubjectProgramMappingDTO(SubjectProgramMapping source, IEnumerable<SubjectProgramStatus> programStatuses)
          : base(source)
        {
            SubjectProgramID = source.SubjectProgramID;
            SubjectUserID = source.SubjectUserID;
            ProgramId = source.ProgramId;
            ApprovalStatus = source.ApprovalStatus;
            DateApproved = source.DateApproved;
            DateReferred = source.DateCreated.ToShortDateString();
            ProgramStatusID = source.ProgramStatus;
            ProgramStatusName = programStatuses != null ? programStatuses.Where(x => x.ProgramStatusID == source.ProgramStatus).Select(x => x.Name).FirstOrDefault() : string.Empty;
            DateStarted = source.DateStarted.HasValue ? source.DateStarted.Value.ToShortDateString() : string.Empty;
            DateEnded = source.DateEnded.HasValue ? source.DateEnded.Value.ToShortDateString() : string.Empty;
            DateCompleted = source.DateCompleted.HasValue ? source.DateCompleted.Value.ToShortDateString() : string.Empty;
            TerminationReasonID1 = source.TerminationReasonID1.HasValue ? source.TerminationReasonID1.Value : (int?)null;
            TerminationReasonID2 = source.TerminationReasonID2.HasValue ? source.TerminationReasonID2.Value : (int?)null;
            TerminationReasonID3 = source.TerminationReasonID3.HasValue ? source.TerminationReasonID3.Value : (int?)null;
            IsRecommendedProgram = source.IsRecommendedProgram;
            PositionID = source.PositionID;
            DateStartedString = source.DateStarted.HasValue ? source.DateStarted.Value.ToString("MM/dd/yyyy") : string.Empty;
            DateEndedString = source.DateEnded.HasValue ? source.DateEnded.Value.ToString("MM/dd/yyyy") : string.Empty;
            AssignedBy = source.AssignedBy;
        }

        /// <summary>
        /// The primary key of SubjectProgram table
        /// </summary>
        [JsonProperty("subjectProgramID")]
        public int SubjectProgramID { get; set; }

        /// <summary>
        /// The Auith 0 User ID of the Subject
        /// </summary>
        [JsonProperty("subjectUserID")]
        public int SubjectUserID { get; set; }

        /// <summary>
        /// The ID of the Program
        /// </summary>
        [JsonProperty("programID")]
        public int ProgramId { get; set; }

        /// <summary>
        /// The status of the approval of the subject to join the program
        /// </summary>
        // TODO: Rename to our naming convention for enums in DTOs.
        [JsonProperty("approvalStatus")]
        public int ApprovalStatus { get; set; }

        /// <summary>
        /// The status of the approval of the subject to join the program
        /// </summary>
        [JsonProperty("approvalStatusName")]
        public string ApprovalStatusName => ApprovalStatusConstants.GetByEnum(ApprovalStatus);

        /// <summary>
        /// The date and time the subject approved the program
        /// </summary>
        // TODO: Refactor to our conventions and needs for dates in DTOs.
        public DateTime? DateApproved { get; set; }

        /// <summary>
        /// The date and time the subject was referred to the program
        /// </summary>
        [JsonProperty("dateReferred")]
        public string DateReferred { get; set; }

        /// <summary>
        /// The Subject's status in the program
        /// </summary>
        [JsonProperty("programStatusID")]
        public int ProgramStatusID { get; set; }
        /// <summary>
        /// The Subject's status in the program
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
        /// The date the subject completed the program
        /// </summary>
        [JsonProperty("dateCompleted")]
        public string DateCompleted { get; set; }

        /// <summary>
        /// The Subject termination reason id 1
        /// </summary>
        [JsonProperty("terminationReasonID1")]
        public int? TerminationReasonID1 { get; set; }

        /// <summary>
        /// The Subject termination reason id 2
        /// </summary>
        [JsonProperty("terminationReasonID2")]
        public int? TerminationReasonID2 { get; set; }

        /// <summary>
        /// The Subject termination reason id 3
        /// </summary>
        [JsonProperty("terminationReasonID3")]
        public int? TerminationReasonID3 { get; set; }

        /// <summary>
        /// The flag specifying program is recommended or not
        /// </summary>
        [JsonProperty("isRecommendedProgram")]
        public bool IsRecommendedProgram { get; set; }

        /// <summary>
        /// Position ID of subject 
        /// </summary>
        [JsonProperty("positionID")]
        public string PositionID { get; set; }

        /// <summary>
        /// The ID of assigned by
        /// </summary>
        [JsonProperty("actionStepID")]
        public int? AssignedBy { get; set; }

        public string DateStartedString { get; set; }
        public string DateEndedString { get; set; }
    }
}
