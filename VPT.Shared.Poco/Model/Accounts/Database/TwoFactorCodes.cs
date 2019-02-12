using NPoco;
using System;
using VPT.Shared.Poco.DTO.Accounts.Database;

namespace VPT.Shared.Poco.Model.Accounts.Database
{
    [TableName("TwoFactorCodes")]
    [PrimaryKey("CodeID")]
    public class TwoFactorCodes
    {
        public TwoFactorCodes() { }

        public TwoFactorCodes(TwoFactorCodeDTO twoFactorCodeDTO)
        {
            CodeID = twoFactorCodeDTO.CodeID;
            PersonID = twoFactorCodeDTO.PersonID;
            OrganizationID = twoFactorCodeDTO.OrganizationID;
            Code = twoFactorCodeDTO.Code;
            DateCreated = twoFactorCodeDTO.DateCreated;
            DateExpired = twoFactorCodeDTO.DateExpired;
        }

        public int CodeID { get; set; }
        public int PersonID { get; set; }
        public int OrganizationID { get; set; }
        public int Code { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateExpired { get; set; }
    }
}
