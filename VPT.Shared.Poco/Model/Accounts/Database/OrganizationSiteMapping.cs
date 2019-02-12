using NPoco;

namespace VPT.Shared.Poco.Model.Accounts.Database
{
    [TableName("OrganizationConfiguration")]
    [PrimaryKey("OrganizationSiteMappingID")]
    /// <summary>
    /// Model representing an organization site mapping
    /// </summary>
    public class OrganizationSiteMapping 
    {
        /// <summary>
        /// The ID of the Organization site mapping  item
        /// </summary>
        public int OrganizationSiteMappingID { get; set; }

        /// <summary>
        /// The ID of the organization the configuration item applies too
        /// </summary>
        public int OrganizationID { get; set; }

        /// <summary>
        /// The id of site in the particular organization
        /// </summary>
        public string SiteID { get; set; }

        /// <summary>
        /// The LMS url of the organization site
        /// </summary>
        public string LMSUrl { get; set; }

    }

}
