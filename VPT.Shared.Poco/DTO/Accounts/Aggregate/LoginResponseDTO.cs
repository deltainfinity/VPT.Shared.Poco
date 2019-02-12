using Newtonsoft.Json;

namespace VPT.Shared.Poco.DTO.Accounts.Aggregate
{
    public class LoginResponseDTO
    {
        public LoginResponseDTO()
        {
            //UserMetaData = new Auth0UserMetaDataDTO();
            //ApplicationMetaData = new Auth0AppMetaDataDTO();
        }

        /// <summary>
        /// The connection the user belongs to
        /// </summary>
        [JsonProperty("id_token")]
        public string IDToken { get; set; }

        /// <summary>
        /// The user's username. Only valid if the connection requires a username
        /// </summary>
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// The user's password (mandatory for non SMS connections)
        /// </summary>
        [JsonProperty("token_type")]
        public string TokenType { get; set; }

        /// <summary>
        /// Client specific data about the user see https://auth0.com/docs/user-profile/normalized for examples
        /// </summary>
        //[JsonProperty("user_metadata")]
        //public Auth0UserMetaDataDTO UserMetaData { get; set; }

        /// <summary>
        /// Client application specific data not really related to the user but the application the user is connecting too
        /// </summary>
        //[JsonProperty("app_metadata")]
        //public Auth0AppMetaDataDTO ApplicationMetaData { get; set; }
    }
}