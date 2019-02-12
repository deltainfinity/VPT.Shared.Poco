using NPoco;
using System;

namespace VPT.Shared.Poco.Model.Accounts.Database
{
    [TableName("Token")]
    [PrimaryKey("TokenID")]
    public class Token
    {
        public Token()
        { }

        public int TokenID { get; set; }
        public string IdToken { get; set; }
        public string SORToken { get; set; }
        public DateTime CreatedDate { get; set; }
               
    }

}
