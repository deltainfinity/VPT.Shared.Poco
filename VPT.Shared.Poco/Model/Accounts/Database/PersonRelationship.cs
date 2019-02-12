using NPoco;
using VPT.Shared.Poco.DTO.Accounts.Database;

namespace VPT.Shared.Poco.Model.Accounts.Database
{
    [TableName("PersonRelationship")]
    [PrimaryKey("PersonRelationshipID")]
    public class PersonRelationship : BaseDatabaseModel
    {
        public PersonRelationship()
        { }

        public PersonRelationship(PersonRelationshipDTO source)
            : base(source)
        {
            PersonRelationshipID = source.PersonRelationshipID;
            PersonID = source.PersonID;
            RelatedPersonID = source.RelatedPersonID;   
        }

        public int PersonRelationshipID { get; set; }

        public int PersonID { get; set; }

        public int RelatedPersonID { get; set; }

    }

}
