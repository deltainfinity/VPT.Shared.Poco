using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace VPT.Shared.Poco.DTO.API
{
    public class ProgramDropdownDTO
    {
        /// <summary>
        /// The ID of Program
        /// </summary>
        [JsonProperty("Id")]
        public int ParentProgramId { get; set; }

        /// <summary>
        /// The Name of Program
        /// </summary>
        [JsonProperty("Name")]
        public string Title { get; set; }
    }
}
