using NPoco;

namespace VPT.Shared.Poco.Model.Accounts.Database
{
    [TableName("ExternalIDType")]
    [PrimaryKey("OrganizationID,Type")]
    public class ExternalIDType : BaseDatabaseModel
    {
        /// <summary>
        /// The ID of the Organization that contols this external ID type
        /// </summary>
        public int OrganizationID { get; set; }

        /// <summary>
        /// A short abreviation that describe this type. For example FBI or DOC.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// The display name for this type
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The description of this type
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// This type is system managed and read only
        /// </summary>
        public bool System { get; set; }

        /// <summary>
        /// This is the primary external ID type for the organization this
        /// will be used as the system of record ID.
        /// </summary>
        public bool Primary { get; set; }
    }
}
