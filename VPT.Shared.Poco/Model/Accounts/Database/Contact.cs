using NPoco;
using VPT.Shared.Poco.DTO.Accounts.Database;

namespace VPT.Shared.Poco.Model.Accounts.Database
{
    [TableName("PersonContact")]
    [PrimaryKey("PersonContactID")]
    public class Contact : BaseDatabaseModel
    {
        public Contact()
        { }

        public Contact(ContactDTO source)
            : base(source)
        {
            PersonContactID = source.PersonContactID;
            PersonID = source.PersonID;
            Classification = source.ClassificationID;
            Type = source.TypeID;
            Primary = source.Primary;
            SyncToAuth0 = source.SyncToAuth0;
            Value = source.Value;
            ReasonChanged = source.ReasonChanged;
        }

        public int PersonContactID { get; set; }

        public int PersonID { get; set; }

        public int Classification { get; set; }

        public int Type { get; set; }

        public bool Primary { get; set; }

        public bool SyncToAuth0 { get; set; }

        public string Value { get; set; }

        public string ReasonChanged { get; set; }
    }

}
