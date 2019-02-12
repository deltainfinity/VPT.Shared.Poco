using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VPT.Shared.Poco.DTO.API.Form
{
    public class AttendanceReportFilterDTO
    {
        [JsonProperty("selectedDistricts")]
        public List<string> SelectedDistricts { get; set; }

        [JsonProperty("selectedSites")]
        public List<string> SelectedSites { get; set; }

        [JsonProperty("selectedProgram")]
        public int? selectedProgram { get; set; }

        [JsonProperty("selectedProgramInstance")]
        public int? selectedProgramInstance { get; set; }

        [JsonProperty("from")]
        public DateTime From { get; set; }
        
        [JsonProperty("to")]
        public DateTime To { get; set; }

    }
}
