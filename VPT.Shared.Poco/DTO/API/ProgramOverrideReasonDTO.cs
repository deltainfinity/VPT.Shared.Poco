using Newtonsoft.Json;

namespace VPT.Shared.Poco.DTO.API
{
    public class ProgramOverrideReasonDTO
    {
        public ProgramOverrideReasonDTO() { }

        /// <summary>
        /// OverrideReason
        /// </summary>
        [JsonProperty("overrideReason")]
        public string OverrideReason { get; set; }

        /// <summary>
        /// CustomOverrideReason
        /// </summary>
        [JsonProperty("customOverrideReason")]
        public string CustomOverrideReason { get; set; }
        
    }
}
