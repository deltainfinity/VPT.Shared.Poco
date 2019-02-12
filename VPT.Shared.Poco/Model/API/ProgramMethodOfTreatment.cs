using NPoco;

namespace VPT.Shared.Poco.Model.API
{
    [TableName("ProgramMethodOfTreatment")]
    [PrimaryKey("ProgramMethodOfTreatmentID")]
    public class ProgramMethodOfTreatment
    {
        public ProgramMethodOfTreatment()
        { }

        public int ProgramMethodOfTreatmentID { get; set; }

        public int MethodOfTreatmentID { get; set; }

        public int ParentProgramID { get; set; }
    }
}
