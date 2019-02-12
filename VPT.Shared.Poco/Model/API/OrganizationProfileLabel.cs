using NPoco;

namespace VPT.Shared.Poco.Model.API
{
    [TableName("OrganizationProfileLabel")]
    [PrimaryKey("OrganizationProfileID")]
    public class OrganizationProfileLabel:BaseModel
    {
        
        public int OrganizationProfileID { get; set; }

        public int ProfileLabelID { get; set; }

        public string Label { get; set; }

        public int OrganizationID { get; set; }

        public bool IsHidden { get; set; }
    }
}
