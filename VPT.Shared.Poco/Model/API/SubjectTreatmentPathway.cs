using NPoco;
using System;

namespace VPT.Shared.Poco.Model.API
{
    [TableName("SubjectTreatmentPathway")]
    [PrimaryKey("SubjectTreatmentPathwayID")]
    public class SubjectTreatmentPathway
    {
        public SubjectTreatmentPathway()
        { }

        public int SubjectTreatmentPathwayID { get; set; }

        public int TreatmentPathwayTrackerID { get; set; }

        public int TreatmentPathwayID { get; set; }

        public int Status { get; set; }

        public int TreatmentPathwayGoalID { get; set; }

        public int? TreatmentPathwayGoalActionStepID { get; set; }

        public int? SubjectProgramID { get; set; }

        public int? ProgramWaitListID { get; set; }

        public int SubjectUserID { get; set; }

        public DateTime? DateCreated { get; set; }

        public string CreatedByUserID { get; set; }

        public DateTime? DateUpdated { get; set; }

        public string UpdatedByUserID { get; set; }
    }
}
