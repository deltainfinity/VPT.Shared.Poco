using NPoco;

namespace VPT.Shared.Poco.Model.API
{
    [TableName("MethodOfTreatmentLookup")]
    [PrimaryKey("MethodOfTreatmentID")]
    public class MethodOfTreatmentLookup
    {
        public int MethodOfTreatmentID { get; set; }

        public string Name { get; set; }

        public string Abbreviation { get; set; }
    }

}
