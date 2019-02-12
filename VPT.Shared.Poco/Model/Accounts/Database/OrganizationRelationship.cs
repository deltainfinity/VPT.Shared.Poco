using NPoco;

namespace VPT.Shared.Poco.Model.Accounts.Database
{
    [TableName("OrganizationGroup")]
    [PrimaryKey("OrganizationRelationshipID")]
    public class OrganizationRelationship : BaseDatabaseModel
    {
        public OrganizationRelationship()
        { }       

        public int OrganizationRelationshipID { get; set; }

        public int SourceOrganizationID { get; set; }

        public int DestinationOrganizationID { get; set; }

        public string Status { get; set; }
      
    }
}
