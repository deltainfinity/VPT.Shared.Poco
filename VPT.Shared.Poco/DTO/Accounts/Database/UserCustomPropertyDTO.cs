using Newtonsoft.Json;
using VPT.Shared.Poco.Model.Accounts.Database;

namespace VPT.Shared.Poco.DTO.Accounts.Database
{
    public class UserCustomPropertyDTO : BaseDatabaseDTO
    {
        public UserCustomPropertyDTO()
        { }

        public UserCustomPropertyDTO(UserCustomProperty source)
            : base(source)
        {
            PersonID = source.PersonID;
            OrganizationID = source.OrganizationID;
            Type = source.Type;
            Value = source.Value;
        }

        /// <summary>
        /// The person id
        /// </summary>
        [JsonProperty("personID")]
        public int PersonID { get; set; }

        /// <summary>
        /// The ID of the Organization that contols this external ID type and person
        /// </summary>
        [JsonProperty("organizationID")]
        public int OrganizationID { get; set; }

        /// <summary>
        /// The type of the propertie this is for this organization
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// The value of the propertie
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
