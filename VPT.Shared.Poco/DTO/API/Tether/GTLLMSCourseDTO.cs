using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPT.Shared.Poco.DTO.API.Tether
{
    public class GTLLMSCourseDTO
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("category")]
        public string Category { get; set; }
        [JsonProperty("shortname")]
        public string ShortName { get; set; }
        [JsonProperty("fullname")]
        public string FullName { get; set; }
        [JsonProperty("visible")]
        public string Visible { get; set; }
    }
}
