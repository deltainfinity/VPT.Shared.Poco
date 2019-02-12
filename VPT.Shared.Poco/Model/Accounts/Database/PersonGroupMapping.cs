using NPoco;

namespace VPT.Shared.Poco.Model.Accounts.Database
{
    [TableName("PersonGroupMapping")]
    [PrimaryKey("PersonID,GroupID")]
    public class PersonGroupMapping 
    {
        public PersonGroupMapping()
        { }

        public int PersonID { get; set; }
        public int GroupID { get; set; }
    }

}
