using Newtonsoft.Json;

namespace VPT.Shared.Poco.FormInput
{
    public class AuthenticationFormInput
    {
        /// <summary>
        /// The user name the user entered on the login form
        /// </summary>
        [JsonProperty("username")]
        public string Username { get; set; }

        /// <summary>
        /// The password from the login form
        /// </summary>
        [JsonProperty("password")]
        public string Password { get; set; }

        /// <summary>
        /// The OAuth Token if OAuth is being used instead of credentials
        /// </summary>
        [JsonProperty("oauthToken")]
        public string OAuthToken { get; set; }

        /// <summary>
        /// The OAuth Refresn Token if OAuth is being used instead of credentials
        /// </summary>
        [JsonProperty("oauthRefreshToken")]
        public string OAuthRefreshToken { get; set; }
    }
}
