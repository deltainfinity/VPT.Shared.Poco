using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API
{
    public class CreditsDTO : BaseDTO
    {
        public CreditsDTO(Credits source)
        {
            CreditsID = source.CreditsID;
            Name = source.Name;
        }

        /// <summary>
        /// The ID of the Credit table
        /// </summary>
        [JsonProperty("creditsID")]
        public int CreditsID { get; set; }

        /// <summary>
        /// The option in the dropdown
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

    }
}