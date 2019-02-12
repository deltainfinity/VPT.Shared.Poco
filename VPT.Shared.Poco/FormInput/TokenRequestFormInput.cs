using Newtonsoft.Json;

namespace VPT.Shared.Poco.FormInput
{
    public class TokenRequestFormInput
    {
        [JsonProperty("agentUserID")]
        public int AgentUserID { get; set; }

        [JsonProperty("companyName")]
        public string CompanyName { get; set; }
    }
}
