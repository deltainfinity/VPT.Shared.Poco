using System;

namespace VPT.Shared.Poco.Model.API
{
    public class SelectedTreatmenPathwayDetails
    {
        public SelectedTreatmenPathwayDetails()
        { }

        public int SubjectTreatmentPathwayID { get; set; }

        public int TreatmentPathwayID { get; set; }

        public int TreatmentPathwayTrackerID { get; set; }

        public int TreatmentPathwayStatus { get; set; }

        public int ActionStepID { get; set; }

        public int ProgramID { get; set; }

        public int GoalID { get; set; }

        public int ParentProgramID { get; set; }

        public int ProgramStatus { get; set; }

        public string ProgramStatusName { get; set; }

        public DateTime ProgramAssignedDate { get; set; }

        public DateTime DateCreated { get; set; }

        public string CreatedByUserID { get; set; }

        public bool IsOverridden { get; set; }

        public int SubjectProgramID { get; set; }

        public bool IsActiveProgramStatus { get; set; }
        
        public bool Deleted { get; set; }

        public int? AssignedBy { get; set; }
        public string AssignedByName { get; set; }

    }
}
