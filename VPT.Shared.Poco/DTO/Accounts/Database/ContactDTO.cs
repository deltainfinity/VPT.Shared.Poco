using Newtonsoft.Json;
using VPT.Shared.Poco.Enum.Accounts;
using VPT.Shared.Poco.Model.Accounts.Database;

namespace VPT.Shared.Poco.DTO.Accounts.Database
{
    public class ContactDTO : BaseDatabaseDTO
    {
        public ContactDTO()
        { }

        public ContactDTO(Contact source)
            : base(source)
        {
            PersonContactID = source.PersonContactID;
            PersonID = source.PersonID;
            ClassificationID = source.Classification;
            TypeID = source.Type;
            Primary = source.Primary;
            SyncToAuth0 = source.SyncToAuth0;
            Value = source.Value;
            ReasonChanged = source.ReasonChanged;
        }

        [JsonProperty("personContactID")]
        public int PersonContactID { get; set; }

        [JsonProperty("personID")]
        public int PersonID { get; set; }

        [JsonProperty("classificationID")]
        public int ClassificationID { get; set; }

        [JsonProperty("classificationName")]
        public string ClassificationName => ContactClassificationConstants.GetByEnum(ClassificationID);

        [JsonProperty("typeID")]
        public int TypeID { get; set; }

        [JsonProperty("typeName")]
        public string TypeName => ContactTypeConstants.GetByEnum(TypeID);

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("syncToAuth0")]
        public bool SyncToAuth0 { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("reasonChanged")]
        public string ReasonChanged { get; set; }
    }
}
