using System;

namespace VPT.Shared.Poco.DTO.Accounts.Aggregate
{
    public class VerifyPasscodeDTO
    {
        public VerifyPasscodeDTO() { }
        public VerifyPasscodeDTO(bool verified,DateTime dateLocked)
        {
            Verified = verified;
            DateLocked = dateLocked;

        }
        public bool Verified { get; set; }
        public DateTime? DateLocked { get; set; }
    }
}
