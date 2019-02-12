using Newtonsoft.Json;
using VPT.Shared.Poco.Model.Accounts.Database;

namespace VPT.Shared.Poco.DTO.Accounts.Database
{
    public class GroupPropertyDTO : BaseDatabaseDTO
    {
        public GroupPropertyDTO()
        { }

        public GroupPropertyDTO(GroupProperty source)
            : base(source)
        {
            GroupPropertyID = source.GroupPropertyID;
            GroupID = source.GroupID;
            OrganizationID = source.OrganizationID;
            Name = source.Name;
            Value = source.Value;
        }

        [JsonProperty("groupPropertyID")]
        public int GroupPropertyID { get; set; }

        [JsonProperty("groupID")]
        public int GroupID { get; set; }

        [JsonProperty("organizationID")]
        public int OrganizationID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

    }
}


       