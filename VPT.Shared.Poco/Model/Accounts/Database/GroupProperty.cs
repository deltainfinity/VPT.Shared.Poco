using NPoco;

namespace VPT.Shared.Poco.Model.Accounts.Database
{
    [TableName("GroupProperty")]
    [PrimaryKey("GroupPropertyID")]
    public class GroupProperty : BaseDatabaseModel
    {
        public GroupProperty()
        { }

        public int GroupPropertyID { get; set; }

        public int GroupID { get; set; }

        public int OrganizationID { get; set; }      

        public string Name { get; set; }

        public string Value { get; set; }
    }
}


