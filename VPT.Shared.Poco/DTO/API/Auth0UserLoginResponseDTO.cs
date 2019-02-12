using Newtonsoft.Json;

namespace VPT.Shared.Poco.DTO.API
{
    public class Auth0UserLoginResponseDTO
    {
        public Auth0UserLoginResponseDTO()
        {}

        /// <summary>
        /// ID of the Token
        /// </summary>
        [JsonProperty("id_token")]
        public string IDToken { get; set; }

        /// <summary>
        /// The access Token
        /// </summary>
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// The Type of the Token
        /// </summary>
        [JsonProperty("token_type")]
        public string TokenType { get; set; }      
        
    }
}
