using NPoco;
using System;
using VPT.Shared.Poco.DTO.API;

namespace VPT.Shared.Poco.Model.API
{
    [TableName("Token")]
    [PrimaryKey("ClientID")]
    public class APIKey
    {
        public APIKey()
        {
            IssuedOn = DateTime.UtcNow;
            KeyType = (int)Enum.API.KeyType.APIKey;
        }

        public APIKey(APIKeyDTO source)
        {
            ClientID = source.ClientID;
            ProviderId = source.ProviderId;
            UserID = source.UserID;
            KeyType = source.KeyTypeID;
            Token = source.Token;
            IssuedOn = DateTime.Parse(source.IssuedOn);
            CompanyName = source.CompanyName;
        }

        /// <summary>
        /// The ID of the API Key
        /// </summary>
        public int ClientID { get; set; }

        /// <summary>
        /// The ID of the account that controls the API key
        /// </summary>
        public int ProviderId { get; set; }

        /// <summary>
        /// The Auth0 User ID of the user that generated (APIKey) or controls(OAuhhToken) the api key
        /// </summary>
        public int UserID { get; set; }

        /// <summary>
        /// The type of key this represents
        /// </summary>
        public int KeyType { get; set; }

        /// <summary>
        /// The token that is used in authenticating a API request
        /// </summary>
        public string Token { get; set; }

        /// <summary>
        /// The date and time (In UTC) the APIKey or OAuth token was issued.
        /// </summary>
        public DateTime IssuedOn { get; set; }

        /// <summary>
        /// Name of company that is issued the APIKey
        /// </summary>
        public string CompanyName { get; set; }
    }
}
