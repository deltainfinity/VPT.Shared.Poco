using NPoco;

namespace VPT.Shared.Poco.Model.Accounts.Database
{
    [TableName("PersonAddressMapping")]
    [PrimaryKey("PersonID , AddressID , Type")]
    public class PersonAddressMapping 
    {
        public PersonAddressMapping()
        { }

        //public Contact(ContactDTO source)
        //    : base(source)
        //{
        //    AddressID = source.AddressID;
        //    PersonID = source.PersonID;
        //}

        public int PersonID { get; set; }

        public int AddressID { get; set; }

        public int Type { get; set; }
    }

}
