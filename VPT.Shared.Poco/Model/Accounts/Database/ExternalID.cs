using NPoco;
using VPT.Shared.Poco.DTO.Accounts.Database;

namespace VPT.Shared.Poco.Model.Accounts.Database
{
    [TableName("ExternalID")]
    [PrimaryKey("PersonID,OrganizationID,Type")]
    public class ExternalID : BaseDatabaseModel
    {
        public ExternalID()
        { }

        public ExternalID(ExternalIDDTO source)
            : base(source)
        {
            PersonID = source.PersonID;
            OrganizationID = source.OrganizationID;
            Type = source.Type;
            Value = source.Value;
        }

        /// <summary>
        /// The ID of the person this external ID is linked too
        /// </summary>
        public int PersonID { get; set; }

        /// <summary>
        /// The ID of the Organization that contols this external ID type and person
        /// </summary>
        public int OrganizationID { get; set; }

        /// <summary>
        /// The type of external ID this is for this organization
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// The External ID in the foreign system
        /// </summary>
        public string Value { get; set; }
    }

}
