using VPT.Shared.Poco.Model.Accounts.Database;

namespace VPT.Shared.Poco.DTO.Accounts.Database
{
    /// <summary>
    /// Organization
    /// </summary>
    public class OrganizationDTO : BaseDatabaseDTO
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public OrganizationDTO()
        {}

        /// <summary>
        /// Copy constructor
        /// </summary>
        /// <param name="organization"></param>
        public OrganizationDTO(Organization organization) : base(organization)
        {
            OrganizationId = organization.OrganizationID;
            Name = organization.Name;
            DisplayName = organization.DisplayName;
            Description = organization.Description;
        }

        /// <summary>
        /// Organization ID of the organization
        /// </summary>
        public int OrganizationId { get; set; }

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
