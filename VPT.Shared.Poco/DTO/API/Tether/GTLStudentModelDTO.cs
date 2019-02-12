using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPT.Shared.Poco.DTO.API.Tether
{
    public class GTLStudentModelDTO
    {
        [JsonProperty("username")]
        public string Username { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("other")]
        public string Other { get; set; }
      
    }
}
