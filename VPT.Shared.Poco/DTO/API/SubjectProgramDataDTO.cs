using System;
using Newtonsoft.Json;
using VPT.Shared.Poco.Enum.API;
using VPT.Shared.Poco.Model.API;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using VPT.Shared.Poco.DTO.Accounts.Aggregate;
using VPT.Shared.Poco.Enum.Accounts;

namespace VPT.Shared.Poco.DTO.API
{
    public class SubjectProgramDataDTO : BaseDTO
    {
        public SubjectProgramDataDTO()
        { }

        public SubjectProgramDataDTO(SubjectProgramMapping spmapping, ParentProgram parentProgram, Program program, string instanceDetails, List<TerminationReason> terminationReasonList, string facilitatorName, DateTime? assignedDate, string methodOfTreatmentString, string programStatusName)
           : base(spmapping)
        {
            if (spmapping == null) throw new ArgumentNullException(nameof(spmapping));
            if (parentProgram == null) throw new ArgumentNullException(nameof(parentProgram));

            SubjectProgramID = spmapping.SubjectProgramID;
            SubjectUserID = spmapping.SubjectUserID;
            ProgramID = spmapping.ProgramId;
            Program = new ParentProgramDTO(parentProgram);
            InstanceName = program.Title;

            ApprovalStatusID = spmapping.ApprovalStatus;
            DateApproved = spmapping.DateApproved.HasValue ? spmapping.DateApproved.Value.ToShortDateString() : string.Empty;
            DateReferred = spmapping.DateCreated.ToShortDateString();
            ProgramStatusID = spmapping.ProgramStatus;
            DateStarted = spmapping.DateStarted.HasValue ? spmapping.DateStarted.Value.ToString("MM/dd/yyyy") : string.Empty;
            DateEnded = spmapping.DateEnded.HasValue ? spmapping.DateEnded.Value.ToString("MM/dd/yyyy") : string.Empty;
            DateCompleted = spmapping.DateCompleted.HasValue ? spmapping.DateCompleted.Value.ToShortDateString() : string.Empty;
            MethodOfTreatments = methodOfTreatmentString;
            InstanceDetails = instanceDetails;
            FacilitatorID = program.FacilitatorID;
            IsAlreadyAssigned = true;
            TerminationReasonID1 = spmapping.TerminationReasonID1.HasValue ? spmapping.TerminationReasonID1.Value : 0;
            TerminationReasonDisplayName1 = spmapping.TerminationReasonID1.HasValue ? terminationReasonList.Where(x => x.TerminationReasonID == spmapping.TerminationReasonID1).FirstOrDefault().DisplayName : string.Empty;
            TerminationReasonID2 = spmapping.TerminationReasonID2.HasValue ? spmapping.TerminationReasonID2.Value : 0;
            TerminationReasonDisplayName2 = spmapping.TerminationReasonID2.HasValue ? terminationReasonList.Where(x => x.TerminationReasonID == spmapping.TerminationReasonID2).FirstOrDefault().DisplayName : string.Empty;
            TerminationReasonID3 = spmapping.TerminationReasonID3.HasValue ? spmapping.TerminationReasonID3.Value : 0;
            TerminationReasonDisplayName3 = spmapping.TerminationReasonID3.HasValue ? terminationReasonList.Where(x => x.TerminationReasonID == spmapping.TerminationReasonID3).FirstOrDefault().DisplayName : string.Empty;
            FacilitatorName = facilitatorName;
            AssignedDate = assignedDate.HasValue ? assignedDate : null;
            IsPerpetual = parentProgram.IsPerpetual;
            IsRecommendedProgram = spmapping.IsRecommendedProgram;
            IsSORProgram = program.IsSORProgram;
            ProgramStatusName = programStatusName;
            AssignedBy = spmapping.AssignedBy;

        }

        public SubjectProgramDataDTO(SubjectProgramMapping spmapping, ParentProgram parentProgram, string methodOfTreatmentString)
            : base(spmapping)
        {
            if (spmapping == null) throw new ArgumentNullException(nameof(spmapping));
            if (parentProgram == null) throw new ArgumentNullException(nameof(parentProgram));

            SubjectProgramID = spmapping.SubjectProgramID;
            SubjectUserID = spmapping.SubjectUserID;
            ProgramID = spmapping.ProgramId;
            Program = new ParentProgramDTO(parentProgram);

            ApprovalStatusID = spmapping.ApprovalStatus;
            DateApproved = spmapping.DateApproved.HasValue ? spmapping.DateApproved.Value.ToShortDateString() : string.Empty;
            DateReferred = spmapping.DateCreated.ToShortDateString();
            ProgramStatusID = spmapping.ProgramStatus;
            DateStarted = spmapping.DateStarted.HasValue ? spmapping.DateStarted.Value.ToString("MM/dd/yyyy") : string.Empty;
            DateEnded = spmapping.DateEnded.HasValue ? spmapping.DateEnded.Value.ToString("MM/dd/yyyy") : string.Empty;
            DateCompleted = spmapping.DateCompleted.HasValue ? spmapping.DateCompleted.Value.ToShortDateString() : string.Empty;
            MethodOfTreatments = methodOfTreatmentString;
            AssignedBy = spmapping.AssignedBy;
        }

        public SubjectProgramDataDTO(ParentProgram parentProgram, Program program, string instanceDetails, string methodOfTreatmentString, int programStatus = 0)
        {
            ProgramID = program.ProgramId;
            Program = new ParentProgramDTO(parentProgram);
            InstanceName = program.Title;
            MethodOfTreatments = methodOfTreatmentString;
            InstanceDetails = instanceDetails;
            IsAlreadyAssigned = false;
            FacilitatorID = program.FacilitatorID;
            DateStarted = program.StartDate.HasValue ? program.StartDate.Value.ToString("MM/dd/yyyy") : string.Empty;
            DateEnded = program.EndDate.HasValue ? program.EndDate.Value.ToString("MM/dd/yyyy") : string.Empty;
            ProgramStatusID = programStatus;
            IsSORProgram = program.IsSORProgram;
            OpenSeats = program.NumberofSeats;
        }

        public SubjectProgramDataDTO(SubjectProgramMapping spmapping, string positionID)
        {
            SubjectProgramID = spmapping.SubjectProgramID;
            SubjectUserID = spmapping.SubjectUserID;
            ProgramID = spmapping.ProgramId;
            ApprovalStatusID = spmapping.ApprovalStatus;
            DateApproved = spmapping.DateApproved.HasValue ? spmapping.DateApproved.Value.ToShortDateString() : string.Empty;
            DateReferred = spmapping.DateCreated.ToShortDateString();
            ProgramStatusID = spmapping.ProgramStatus;
            DateStarted = spmapping.DateStarted.HasValue ? spmapping.DateStarted.Value.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture) : string.Empty;
            DateEnded = spmapping.DateEnded.HasValue ? spmapping.DateEnded.Value.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture) : string.Empty;
            DateCompleted = spmapping.DateCompleted.HasValue ? spmapping.DateCompleted.Value.ToShortDateString() : string.Empty;
            TerminationReasonID1 = spmapping.TerminationReasonID1.HasValue ? spmapping.TerminationReasonID1.Value : 0;
            TerminationReasonID2 = spmapping.TerminationReasonID2.HasValue ? spmapping.TerminationReasonID2.Value : 0;
            TerminationReasonID3 = spmapping.TerminationReasonID3.HasValue ? spmapping.TerminationReasonID3.Value : 0;
            IsRecommendedProgram = spmapping.IsRecommendedProgram;
            PositionID = positionID;
            AssignedBy = spmapping.AssignedBy;
        }

        public SubjectProgramDataDTO(ProgramWaitList programWaitlist, SubjectDTO subjectDTO, List<AssignedByLookup> assignedByLookup)
        {
            AssignedBy = programWaitlist.AssignedBy;
            AssignedByName = assignedByLookup.Where(x => x.ID == programWaitlist.AssignedBy).Select(x => x.AssignedBy).FirstOrDefault();
            AssignedByPriority = assignedByLookup.Where(x => x.ID == programWaitlist.AssignedBy).Select(x => x.Priority).FirstOrDefault();
            ProgramWaitListID = programWaitlist.ProgramWaitListID;
            subject = subjectDTO;
        }

        /// <summary>
        /// Suujetc program ID
        /// </summary>
        [JsonProperty("subjectProgramID")]
        public int SubjectProgramID { get; set; }
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
        /// The date and time the subject approved the program
        /// </summary>
        [JsonProperty("instanceName")]
        public string InstanceName { get; set; }

        /// <summary>
        /// The status of the approval of the subject to join the program
        /// </summary>
        [JsonProperty("approvalStatusID")]
        public int ApprovalStatusID { get; set; }

        /// <summary>
        /// The status of the approval of the subject to join the program
        /// </summary>
        [JsonProperty("approvalStatusName")]
        public string ApprovalStatusName => ApprovalStatusConstants.GetByEnum(ApprovalStatusID);

        /// <summary>
        /// The date and time the subject approved the program
        /// </summary>
        [JsonProperty("dateApproved")]
        public string DateApproved { get; set; }

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
        /// The program information
        /// </summary>
        [JsonProperty("program")]
        public ParentProgramDTO Program { get; set; }

        [JsonProperty("methodOfTreatments")]
        string MethodOfTreatments { get; set; }

        /// <summary>
        /// The program insatance details
        /// </summary>
        [JsonProperty("InstanceDetails")]
        public string InstanceDetails { get; set; }

        /// <summary>
        /// The program insatance details
        /// </summary>
        [JsonProperty("IsAlreadyAssigned")]
        public bool IsAlreadyAssigned { get; set; }

        [JsonProperty("facilitatorName")]
        public string FacilitatorName { get; set; }

        [JsonProperty("facilitatorID")]
        public int FacilitatorID { get; set; }

        /// <summary>
        /// The TerminationReasonID1
        /// </summary>
        [JsonProperty("terminationReasonID1")]
        public int? TerminationReasonID1 { get; set; }

        /// <summary>
        /// The TerminationReasonID2
        /// </summary>
        [JsonProperty("terminationReasonID2")]
        public int? TerminationReasonID2 { get; set; }

        /// <summary>
        /// The TerminationReasonID3
        /// </summary>
        [JsonProperty("terminationReasonID3")]
        public int? TerminationReasonID3 { get; set; }

        /// <summary>
        /// The TerminationReasonDisplayName1
        /// </summary>
        [JsonProperty("terminationReasonDisplayName1")]
        public string TerminationReasonDisplayName1 { get; set; }

        /// <summary>
        /// The TerminationReasonDisplayName2
        /// </summary>
        [JsonProperty("terminationReasonDisplayName2")]
        public string TerminationReasonDisplayName2 { get; set; }

        /// <summary>
        /// The TerminationReasonDisplayName3
        /// </summary>
        [JsonProperty("terminationReasonDisplayName3")]
        public string TerminationReasonDisplayName3 { get; set; }

        /// <summary>
        /// The date when program status was changed to assigned
        /// </summary>
        [JsonProperty("assignedDate")]
        public DateTime? AssignedDate { get; set; }
        /// <summary>
        /// Perpetual flag
        /// </summary>
        [JsonProperty("isPerpetual")]
        public bool IsPerpetual { get; set; }

        /// <summary>
        /// In waiting list
        /// </summary>
        [JsonProperty("isWaitListed")]
        public bool IsWaitListed = false;

        /// <summary>
        /// Is Recommended Program
        /// </summary>
        [JsonProperty("isRecommendedProgram")]
        public bool IsRecommendedProgram { get; set; }

        /// <summary>
        /// The ID of the Program
        /// </summary>
        [JsonProperty("oldProgramID")]
        public int OldProgramID { get; set; }

        /// <summary>
        /// The ID position for SOR instance
        /// </summary>
        [JsonProperty("positionID")]
        public string PositionID { get; set; }

        /// <summary>
        /// IS SOR program
        /// </summary>
        [JsonProperty("isSORProgram")]
        public bool IsSORProgram { get; set; }

        /// <summary>
        /// The ProgramOverrideReasonID
        /// </summary>
        [JsonProperty("programOverrideReason")]
        public string ProgramOverrideReason { get; set; }

        /// <summary>
        /// The Assigned By for program instance.
        /// </summary>
        [JsonProperty("assignedBy")]
        public int? AssignedBy { get; set; }

        /// <summary>
        /// The Assigned By Name for program instance.
        /// </summary>
        [JsonProperty("assignedByName")]
        public string AssignedByName { get; set; }

        /// <summary>
        /// The Program wait list id.
        /// </summary>
        [JsonProperty("programWaitListID")]
        public int ProgramWaitListID { get; set; }
        public string Location { get; set; }
        public string TreatmentPathwayGoalName { get; set; }
        public string DomainString { get; set; }
        public int OpenSeats { get; set; }
        public SubjectDTO subject { get; set; }
        public int AssignedByPriority { get; set; }
    }
}
