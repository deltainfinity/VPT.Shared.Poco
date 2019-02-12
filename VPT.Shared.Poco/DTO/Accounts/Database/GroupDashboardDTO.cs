using Newtonsoft.Json;
using System;
using VPT.Shared.Poco.Model.Accounts.Database;

namespace VPT.Shared.Poco.DTO.Accounts.Database
{
    public class GroupDashboardDTO 
    {
        public GroupDashboardDTO()
        { }

        public GroupDashboardDTO(GroupDashboard source)
        {
            GroupDashboardID = source.GroupDashboardID;
            GroupID = source.GroupID;
            OrganizationID = source.OrganizationID;
            DashboardURL = source.DashboardURL;
            DateCreated = source.DateCreated;
            CreatedByUserID = source.CreatedByUserID;
        }

        [JsonProperty("groupDashboardID")]
        public int GroupDashboardID { get; set; }

        [JsonProperty("groupID")]
        public int GroupID { get; set; }

        [JsonProperty("organizationID")]
        public int OrganizationID { get; set; }

        [JsonProperty("dashboardURL")]
        public string DashboardURL { get; set; }

        public DateTime DateCreated { get; set; }
        public string CreatedByUserID { get; set; }

    }
}


       