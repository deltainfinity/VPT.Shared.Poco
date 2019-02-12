using System;
using Newtonsoft.Json;

namespace VPT.Shared.Poco.DTO.Accounts.Form
{
    public class ExternalSystemUserDetailsRequestDTO
    {
        public ExternalSystemUserDetailsRequestDTO()
        {

        }

        public ExternalSystemUserDetailsRequestDTO(ExternalSystemUserDetailsRequestDTO model)
        {
            if (model == null) return;

            ACCOUNT_EXTERNAL_ID = model.ACCOUNT_EXTERNAL_ID.Trim();
            AUTHENTICATION_TOKEN = model.AUTHENTICATION_TOKEN.Trim();
            SUBJECT_EXTERNAL_ID = model.SUBJECT_EXTERNAL_ID.Trim();
            USER_EXTERNAL_ID = model.USER_EXTERNAL_ID.Trim();
        }

        [JsonProperty("ACCOUNT_EXTERNAL_ID")]
        public string ACCOUNT_EXTERNAL_ID { get; set; }

        [JsonProperty("USER_EXTERNAL_ID")]
        public string USER_EXTERNAL_ID { get; set; }

        [JsonProperty("SUBJECT_EXTERNAL_ID")]
        public string SUBJECT_EXTERNAL_ID { get; set; }

        [JsonProperty("AUTHENTICATION_TOKEN")]
        public string AUTHENTICATION_TOKEN { get; set; }
    }
}
