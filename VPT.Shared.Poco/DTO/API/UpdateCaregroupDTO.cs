using Newtonsoft.Json;
using System;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API
{
    public class UpdateCaregroupDTO
    {
        
        [JsonProperty("agentUserID")]
        public string AgentUserID { get; set; }

        [JsonProperty("subjectUserID")]
        public string SubjectUserID { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("caregroupType")]
        public int CaregroupType { get; set; }

        [JsonProperty("expireDate")]
        public DateTime? ExpireDate { get; set; }
    }
}
