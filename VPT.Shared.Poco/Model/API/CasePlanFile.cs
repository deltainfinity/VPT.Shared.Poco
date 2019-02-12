using NPoco;

namespace VPT.Shared.Poco.Model.API
{
    [TableName("CasePlanFile")]
    [PrimaryKey("CasePlanFileID")]
    public class CasePlanFile
    {

        public CasePlanFile()
        { }
        public int CasePlanFileID { get; set; }

        public int FileID { get; set; }

        public int SubjectUserID { get; set; }
    }
}
