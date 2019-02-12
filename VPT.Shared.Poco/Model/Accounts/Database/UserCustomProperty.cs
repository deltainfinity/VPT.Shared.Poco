using NPoco;
using VPT.Shared.Poco.DTO.Accounts.Database;

namespace VPT.Shared.Poco.Model.Accounts.Database
{
    [TableName("UserCustomProperties")]
    [PrimaryKey("PersonID,OrganizationID,Type")]
    public class UserCustomProperty : BaseDatabaseModel
    {
        public UserCustomProperty()
        { }

        public UserCustomProperty(UserCustomPropertyDTO source)
            : base(source)
        {
            PersonID = source.PersonID;
            OrganizationID = source.OrganizationID;
            Type = source.Type;
            Value = source.Value;
        }

        /// <summary>
        /// The ID of the person 
        /// </summary>
        public int PersonID { get; set; }

        /// <summary>
        /// The ID of the Organization that contols this external ID type and person
        /// </summary>
        public int OrganizationID { get; set; }

        /// <summary>
        /// The type of propertie this is for this organization
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// The value of the propertie
        /// </summary>
        public string Value { get; set; }
    }
}
