using System;
using VPT.Shared.Poco.Model.Accounts.Database;

namespace VPT.Shared.Poco.DTO.Accounts.Database
{
    public class TwoFactorCodeDTO
    {
        public TwoFactorCodeDTO() { }

        public TwoFactorCodeDTO(TwoFactorCodes twoFactorCodes)
        {
            CodeID = twoFactorCodes.CodeID;
            PersonID = twoFactorCodes.PersonID;
            OrganizationID = twoFactorCodes.OrganizationID;
            Code = twoFactorCodes.Code;
            DateCreated = twoFactorCodes.DateCreated;
            DateExpired = twoFactorCodes.DateExpired;
        }

        public int CodeID { get; set; }
        public int PersonID { get; set; }
        public int OrganizationID { get; set; }
        public int Code { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateExpired { get; set; }
    }
}
