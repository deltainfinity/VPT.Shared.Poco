using Newtonsoft.Json;

namespace VPT.Shared.Poco.FormInput
{
    public class GTLLMSFormInput
    {
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("bookingID")]
        public string BookingID { get; set; }

        [JsonProperty("GTLLMSSSOUrl")]
        public string GTLLMSSSOUrl { get; set; }
    }
}
