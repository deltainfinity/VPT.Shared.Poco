using NPoco;
using System;

namespace VPT.Shared.Poco.Model.Accounts.Database
{
    [TableName("GroupDashboard")]
    [PrimaryKey("GroupDashboardID")]

    public class GroupDashboard 
    {
        public GroupDashboard()
        { }

        public int GroupDashboardID { get; set; }

        public int GroupID { get; set; }

        public int OrganizationID { get; set; }      

        public string DashboardURL { get; set; }

        public string CreatedByUserID { get; set; }

        public DateTime DateCreated { get; set; }

    }
}



