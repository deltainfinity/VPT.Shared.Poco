using Newtonsoft.Json;
using System.Globalization;
using VPT.Shared.Poco.Enum.API;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API
{
    public class APIKeyDTO
    {
        public APIKeyDTO(APIKey source)
        {
            ClientID = source.ClientID;
            ProviderId = source.ProviderId;
            UserID = source.UserID;
            KeyTypeID = source.KeyType;
            Token = source.Token;
            IssuedOn = source.IssuedOn.ToString(CultureInfo.InvariantCulture);
            CompanyName = source.CompanyName;
        }

        /// <summary>
        /// The ID of the API Key
        /// </summary>
        [JsonProperty("clientID")]
        public int ClientID { get; set; }

        /// <summary>
        /// The ID of the account that controls the API key
        /// </summary>
        [JsonProperty("providerId")]
        public int ProviderId { get; set; }

        /// <summary>
        /// The Auth0 User ID of the user that generated the API Key
        /// </summary>
        [JsonProperty("userID")]
        public int UserID { get; set; }

        /// <summary>
        /// The type of key this represents
        /// </summary>
        public int KeyTypeID { get; set; }

        /// <summary>
        /// The type of key this represents
        /// </summary>
        public string KeyTypeName => KeyTypeConstants.GetByEnum(KeyTypeID);

        /// <summary>
        /// The token that is used in authenticating a API request
        /// </summary>
        [JsonProperty("token")]
        public string Token { get; set; }

        /// <summary>
        /// The date and time (In UTC) the APIKey or OAuth token was issued.
        /// </summary>
        [JsonProperty("issuedOn")]
        public string IssuedOn { get; set; }

        /// <summary>
        /// Name of company that is issued the APIKey
        /// </summary>
        [JsonProperty("companyName")]
        public string CompanyName { get; set; }
    }
}
