using NPoco;

namespace VPT.Shared.Poco.Model.Accounts.Database
{
    [TableName("Address")]
    [PrimaryKey("AddressID")]
    public class Address : BaseDatabaseModel
    {
        public Address()
        { }

        //public Contact(ContactDTO source)
        //    : base(source)
        //{
        //    PersonContactID = source.PersonContactID;
        //    PersonID = source.PersonID;
        //    Classification = source.ClassificationID;
        //    Type = source.TypeID;
        //    Primary = source.Primary;
        //    SyncToAuth0 = source.SyncToAuth0;
        //    Value = source.Value;
        //}

        public int AddressID { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string ZipCode { get; set; }

        public string County { get; set; }

        public string Country { get; set; }

        public bool IsOutsideUSAddress { get; set; }

    }

}
