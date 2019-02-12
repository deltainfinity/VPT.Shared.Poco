namespace VPT.Shared.Poco.DTO.Accounts.Form
{
    public class UserInfoDTO
    {
        public UserInfoDTO()
        {

        }
        public string Token { get; set; }
        public int LoginSystem { get; set; }
        public int PersonID { get; set; }
        public string UserExternalID { get; set; }
        public int ExpiresOn { get; set; }

    }
}
