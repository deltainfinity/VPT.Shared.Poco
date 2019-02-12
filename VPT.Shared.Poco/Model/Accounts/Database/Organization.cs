using NPoco;
using VPT.Shared.Poco.DTO.Accounts.Database;

namespace VPT.Shared.Poco.Model.Accounts.Database
{
    /// <summary>
    /// Organization
    /// </summary>
    [TableName("Organization")]
    [PrimaryKey("OrganizationID")]
    public class Organization : BaseDatabaseModel
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public Organization()
        { }

        /// <summary>
        /// Copy constructor
        /// </summary>
        /// <param name="organization">OrganizationDTO</param>
        public Organization(OrganizationDTO organization)
        {
            OrganizationID = organization.OrganizationId;
            Name = organization.Name;
            DisplayName = organization.DisplayName;
            Description = organization.Description;
        }

        /// <summary>
        /// Organization ID that identified the organization
        /// </summary>
        public int OrganizationID { get; set; }

        /// <summary>
        /// Name of the organization
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Display name of the organization
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Description of the organization
        /// </summary>
        public string Description { get; set; }

    }
}