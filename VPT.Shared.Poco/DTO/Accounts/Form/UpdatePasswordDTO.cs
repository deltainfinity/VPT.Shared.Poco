using Newtonsoft.Json;

namespace VPT.Shared.Poco.DTO.Accounts.Form
{
    public class UpdatePasswordDTO
    {
        public UpdatePasswordDTO()
        { }

        [JsonProperty("userID")]
        public int UserID { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

    }
}
