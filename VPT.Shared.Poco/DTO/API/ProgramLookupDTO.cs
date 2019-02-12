using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPT.Shared.Poco.DTO.API
{
    public class ProgramLookupDTO
    {
        public ProgramLookupDTO()
        { }


        /// <summary>
        /// Copy constructor to populate the classe
        /// </summary>

        public ProgramLookupDTO(List<AutoCompleteSelectListItem> AutoCompleteSelectListItem, List<ProgramInstanceLookupDTO> ProgramInstanceLookup)
        {
            this.AutoCompleteSelectListItem = AutoCompleteSelectListItem;
            this.ProgramInstanceLookup = ProgramInstanceLookup;


        }

        [JsonProperty("parentProgramLookup")]
        public List<AutoCompleteSelectListItem> AutoCompleteSelectListItem { get; set; }

        [JsonProperty("programInstanceLookup")]
        public List<ProgramInstanceLookupDTO> ProgramInstanceLookup { get; set; }
    }
}

      