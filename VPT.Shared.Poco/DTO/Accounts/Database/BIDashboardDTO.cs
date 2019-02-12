using Newtonsoft.Json;
using VPT.Shared.Poco.Model.Accounts.Database;

namespace VPT.Shared.Poco.DTO.Accounts.Database
{
    public class BIDashboardDTO : BaseDatabaseDTO
    {
        public BIDashboardDTO()
        { }

        public BIDashboardDTO(BIDashboard source)
            : base(source)
        {
            BIDashboardID = source.BIDashboardID;
            OrganizationID = source.OrganizationID;
            DashboardUrl = source.DashboardUrl;
            DisplayName = source.DisplayName;
            DisplayOrder = source.DisplayOrder;
            PermissionID = source.PermissionID;
            IsDefault = source.IsDefault;
        }

        [JsonProperty("biDashboardID")]
        public int BIDashboardID { get; set; }

        [JsonProperty("organizationID")]
        public int OrganizationID { get; set; }

        [JsonProperty("dashboardUrl")]
        public string DashboardUrl { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("displayOrder")]
        public int DisplayOrder { get; set; }

        [JsonProperty("permissionID")]
        public int PermissionID { get; set; }

        [JsonProperty("isDefault")]
        public bool IsDefault { get; set; }

    }
}


          


