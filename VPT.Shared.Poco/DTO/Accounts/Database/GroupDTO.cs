using Newtonsoft.Json;
using VPT.Shared.Poco.Model.Accounts.Database;

namespace VPT.Shared.Poco.DTO.Accounts.Database
{
    public class GroupDTO : BaseDatabaseDTO
    {
        public GroupDTO()
        { }

        public GroupDTO(Group source, string groupDisplayName)
            : base(source)
        {
            GroupID = source.GroupID;
            Name = source.Name;
            DisplayName = groupDisplayName;
            IsSystem = source.IsSystem;
            Description = source.Description;
            IsCustom = source.IsCustom;
        }

        [JsonProperty("groupID")]
        public int GroupID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("isSystem")]
        public bool IsSystem { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("isCustom")]
        public bool IsCustom { get; set; }
    }
}
