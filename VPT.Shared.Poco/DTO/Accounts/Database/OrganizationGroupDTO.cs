using Newtonsoft.Json;
using VPT.Shared.Poco.Model.Accounts.Database;

namespace VPT.Shared.Poco.DTO.Accounts.Database
{
    public class OrganizationGroupDTO : BaseDatabaseDTO
    {
        public OrganizationGroupDTO()
        { }

        public OrganizationGroupDTO(OrganizationGroup source)
            : base(source)
        {
            OrganizationGroupID = source.OrganizationGroupID;
            GroupID = source.GroupID;
            OrganizationID = source.OrganizationID;
            DisplayName = source.DisplayName;
        }

        [JsonProperty("organizationGroupID")]
        public int OrganizationGroupID { get; set; }

        [JsonProperty("groupID")]
        public int GroupID { get; set; }

        [JsonProperty("organizationID")]
        public int OrganizationID { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("isCustom")]
        public bool IsCustom { get; set; }
    }
}
