using NPoco;

namespace VPT.Shared.Poco.Model.Accounts.Database
{
    [TableName("OrganizationConfiguration")]
    [PrimaryKey("OrganizationConfigurationID")]
    /// <summary>
    /// DTO representing an organization configuration item
    /// </summary>
    public class OrganizationConfiguration : BaseDatabaseModel
    {
        /// <summary>
        /// The ID of the organization configuration item
        /// </summary>
        public int OrganizationConfigurationID { get; set; }

        /// <summary>
        /// The ID of the organization the configuration item applies too
        /// </summary>
        public int OrganizationID { get; set; }

        /// <summary>
        /// The key for the configuration item 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The value of the configuration item
        /// </summary>
        public string Value { get; set; }

    }

}
