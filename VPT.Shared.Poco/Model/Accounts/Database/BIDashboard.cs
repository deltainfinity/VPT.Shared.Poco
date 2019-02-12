using NPoco;

namespace VPT.Shared.Poco.Model.Accounts.Database
{
    [TableName("BIDashboard")]
    [PrimaryKey("BIDashboardID")]
    public class BIDashboard : BaseDatabaseModel
    {

        public BIDashboard()
        { }

        public int BIDashboardID { get; set; }

        public int OrganizationID { get; set; }

        public string DashboardUrl { get; set; }

        public string DisplayName { get; set; }

        public int DisplayOrder { get; set; }

        public int PermissionID { get; set; }

        public bool IsDefault { get; set; }
    }
}





