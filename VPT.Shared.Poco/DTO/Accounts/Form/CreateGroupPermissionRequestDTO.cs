using Newtonsoft.Json;
using System.Collections.Generic;
using VPT.Shared.Poco.DTO.Accounts.Database;

namespace VPT.Shared.Poco.DTO.Accounts.Form
{
    public class CreateGroupPermissionRequestDTO
    {
        /// <summary>
        /// The display name of organization group
        /// </summary>
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// The group type
        /// </summary>
        [JsonProperty("groupType")]
        public GroupType GroupType { get; set; }

        /// <summary>
        /// The features
        /// </summary>
        [JsonProperty("features")]
        public List<FeatureDTO> Features { get; set; }
        
        /// <summary>
        /// The default group
        /// </summary>
        [JsonProperty("defaultGroup")]
        public GroupDTO DefaultGroup { get; set; }

        /// <summary>
        /// The id for edit
        /// </summary>
        [JsonProperty("organizationGroupID")]
        public int OrganizationGroupID { get; set; }

        /// <summary>
        /// The id 
        /// </summary>
        [JsonProperty("groupID")]
        public int GroupID { get; set; }

        /// <summary>
        /// The Dashboard URL of GroupDashboard 
        /// </summary>
        [JsonProperty("dashboardURL")]
        public string DashboardURL { get; set; }     

    }

    public class GroupType
    {
        public string id;
        public string value;
    }

}
