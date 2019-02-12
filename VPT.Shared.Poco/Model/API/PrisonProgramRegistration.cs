using NPoco;
using System;

namespace VPT.Shared.Poco.Model.API
{
    [TableName("PrisonProgramRegistration")]
    [PrimaryKey("PrisonProgramRegistrationID")]
    public class PrisonProgramRegistration
    {
        public PrisonProgramRegistration()
        { }

        public int PrisonProgramRegistrationID { get; set; }

        public int SubjectTreatmentPathwayID { get; set; }

        public int SubjectUserID { get; set; }

        public int ParentProgramId { get; set; }

        public bool IsRecommendedProgram { get; set; }

        public bool IsOverridden { get; set; }

        public DateTime DateCreated { get; set; }

        public string CreatedByUserID { get; set; }

        public bool Deleted { get; set; }

        public string DeletedByUserID { get; set; }
    }
}
