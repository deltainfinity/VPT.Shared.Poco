using Newtonsoft.Json;

namespace VPT.Shared.Poco.FormInput
{
    public class UserUpdatePasswordFormInput
    {
        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("currentPassword")]
        public string CurrentPassword { get; set; }

        [JsonProperty("newPassword")]
        public string NewPassword { get; set; }
    }
}
