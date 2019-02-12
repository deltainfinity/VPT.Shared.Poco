using Newtonsoft.Json;
using VPT.Shared.Poco.Model.Accounts.Database;

namespace VPT.Shared.Poco.DTO.Accounts.Database
{
    /// <summary>
    /// DTO representing an organization configuration item
    /// </summary>
    public class OrganizationConfigurationDTO
    {
        /// <summary>
        /// Default Constructor
        /// </summary>
        public OrganizationConfigurationDTO()
        { }

        /// <summary>
        /// Copy Constructor
        /// </summary>
        /// <param name="source">The soruce data from a data model</param>
        public OrganizationConfigurationDTO(OrganizationConfiguration source)
        {          
            Name = source.Name;
            Value = source.Value;
            OrganizationID = source.OrganizationID;   
        }

        /// <summary>
        /// Copy Constructor
        /// </summary>
        /// <param name="organizationID">The ID of the organization</param>
        /// <param name="name">The key for the configuration item</param>
        /// <param name="value">The value of the configurtation item</param>
        public OrganizationConfigurationDTO(int organizationID, string name, string value)
        {
            OrganizationID = organizationID;
            Name = name;
            Value = value;
        }

        /// <summary>
        /// The ID of the organization the configuration item applies too
        /// </summary>
        [JsonProperty("organizationGroupID")]
        public int OrganizationID { get; set; }

        /// <summary>
        /// The key for the configuration item 
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The value of the configuration item
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
