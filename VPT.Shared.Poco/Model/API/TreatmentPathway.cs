using NPoco;
using VPT.Shared.Poco.DTO.API;

namespace VPT.Shared.Poco.Model.API
{
    [TableName("TreatmentPathway")]
    [PrimaryKey("TreatmentPathwayID")]
    public class TreatmentPathway : BaseModel
    {
        public TreatmentPathway() { }

        public TreatmentPathway(TreatmentPathwayDTO source)
            : base(source)
        {
            TreatmentPathwayID = source.TreatmentPathwayID;
            PathwayName = source.PathwayName;
            OrganizationID = source.OrganizationID;
            FileID = source.FileID;
        }

        public int TreatmentPathwayID { get; set; }

        public string PathwayName { get; set; }

        public int OrganizationID { get; set; }

        public int FileID { get; set; }
    }
}
