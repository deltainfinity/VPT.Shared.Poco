using System;
using System.Collections.Generic;
using VPT.Shared.Poco.Enum.API;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API.Aggregate
{
    public class BOPProgramDTO
    {
        public BOPProgramDTO()
        { }
        public BOPProgramDTO(ParentProgram source, string assignedUser, Program assignedProgramInstances, List<ProgramAttendance> subjectAttendance, SubjectProgramMapping subjectprogram, string methodOfTreatments, string programStatus,string assignedTreatmentPathway,DateTime? assignedDate) : base()
        {
            ParentProgramId = source.ParentProgramId;
            SubjectProgramID = subjectprogram.SubjectProgramID;
            ProgramTypes = methodOfTreatments;
            ProgramStartDate = subjectprogram.DateStarted.HasValue ? subjectprogram.DateStarted.Value.ToString("MM/dd/yyyy") : null ;
            ProgramEndDate = subjectprogram.DateEnded.HasValue ? subjectprogram.DateEnded.Value.ToString("MM/dd/yyyy") : null ;
            Dosage = source.Dosage;
            AgencySetting = AgencySettingsConstants.GetByEnum(source.AgencySettings);
            TreatmentPathway = assignedTreatmentPathway;
            AssignedDate = assignedDate;
            if (assignedProgramInstances != null && assignedProgramInstances.ParentProgramID == ParentProgramId)
            {
                Title = source.Title + " - " + assignedProgramInstances.Title;
                ProgramID = assignedProgramInstances.ProgramId;
                if (source.IsPerpetual)
                {
                    Schedule = "Open";
                    ScheduleDate = "";
                }
                else if (source.Platform == (int)PlatformType.Online)
                {
                    Schedule = "Open(Online)";
                    ScheduleDate = "";
                }
                else
                {
                    Schedule = "Closed";
                    ScheduleDate = "(" + assignedProgramInstances.StartDate.Value.ToString("MM/dd/yyyy") + " - " + assignedProgramInstances.EndDate.Value.ToString("MM/dd/yyyy") + ")";

                }
            }
            else
            {
                Title = source.Title;
                Schedule = "N/A";
            }
            Status = programStatus.ToUpper();
            if (assignedProgramInstances != null)
            {
                IsAssigned = true;
            }
            else
                IsAssigned = false;

            AssignedByUser = assignedUser;
        }

        public int SubjectProgramID { get; set; }
        public int ParentProgramId { get; set; }
        public string Title { get; set; }
        public string ProgramStartDate { get; set; }
        public string ProgramEndDate { get; set; }
        public int ProgramRecommendationID { get; set; }
        public string OffenderID { get; set; }
        public string Status { get; set; }
        public string OverriddenReason { get; set; }
        public DateTime? OverriddenDate { get; set; }
        public string OverriddenByUserID { get; set; }
        public DateTime? AssignedDate { get; set; }
        public string AssignedByUserID { get; set; }
        public string AssignedByUser { get; set; }
        public string Schedule { get; set; }
        public string ScheduleDate { get; set; }
        public bool IsAssigned { get; set; }
        public int ProgramID { get; set; }
        public string ProgramTypes { get; set; }
        public decimal Dosage { get; set; }
        public string AgencySetting { get; set; }
        public string TreatmentPathway { get; set; }

    }
}
