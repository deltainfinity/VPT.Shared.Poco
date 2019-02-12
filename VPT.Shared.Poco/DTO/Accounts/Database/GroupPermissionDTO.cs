using Newtonsoft.Json;
using VPT.Shared.Poco.Model.Accounts.Database;

namespace VPT.Shared.Poco.DTO.Accounts.Database
{
    public class GroupPermissionDTO : BaseDatabaseDTO
    {

        public GroupPermissionDTO()
        { }

        public GroupPermissionDTO(GroupPermission source)
        {
            GroupPermissionID = source.GroupPermissionID;
            GroupID = source.GroupID;
            Permissions = source.Permissions;
            PermissionID = source.PermissionID;           
        }

        [JsonProperty("GroupPermissionID")]
        public int GroupPermissionID { get; set; }

        [JsonProperty("GroupID")]
        public int GroupID { get; set; }

        [JsonProperty("Permissions")]
        public int Permissions { get; set; }

        [JsonProperty("PermissionID")]
        public int PermissionID { get; set; }       

    }
}
