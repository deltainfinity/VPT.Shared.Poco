using NPoco;

namespace VPT.Shared.Poco.Model.Accounts.Database
{
    [TableName("OrganizationGroup")]
    [PrimaryKey("OrganizationGroupID")]

    public class OrganizationGroup : BaseDatabaseModel
    {
        public OrganizationGroup()
        { }
       
        public int OrganizationGroupID { get; set; }

        public int GroupID { get; set; }

        public int OrganizationID { get; set; }

        public string DisplayName { get; set; }

    }

}
