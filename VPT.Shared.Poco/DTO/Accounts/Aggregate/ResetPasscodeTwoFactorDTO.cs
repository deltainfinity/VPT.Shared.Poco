using VPT.Shared.Poco.DTO.Accounts.Database;

namespace VPT.Shared.Poco.DTO.Accounts.Aggregate
{
    public class ResetPasscodeTwoFactorDTO
    {
        public TwoFactorCodeDTO TwoFactorData { get; set; }
        public string Passcode { get; set; }
    }
}
