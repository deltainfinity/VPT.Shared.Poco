using Newtonsoft.Json;
using VPT.Shared.Poco.Model.Accounts.Database;

namespace VPT.Shared.Poco.DTO.Accounts.Database
{
    public class PersonRelationshipDTO :BaseDatabaseDTO
    {
        public PersonRelationshipDTO()
        { }

        public PersonRelationshipDTO(PersonRelationship source)
            : base(source)
        {
            PersonRelationshipID = source.PersonRelationshipID;
            PersonID = source.PersonID;
            RelatedPersonID = source.RelatedPersonID;              
        }

        [JsonProperty("PersonRelationshipID")]
        public int PersonRelationshipID { get; set; }

        [JsonProperty("PersonID")]
        public int PersonID { get; set; }

        [JsonProperty("RelatedPersonID")]
        public int RelatedPersonID { get; set; }       

    }
    
}
