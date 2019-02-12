using Newtonsoft.Json;
using System.Collections.Generic;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API
{
    public class SubjectIncompatiblesDTO
    {
        /// <summary>
        /// Subject Incompatibles DTO
        /// </summary>
        /// <param name="subjectIncompatiblesList"></param>
        public SubjectIncompatiblesDTO(List<SubjectIncompatibles> subjectIncompatiblesList)
        {
            SubjectIncompatiblesList = subjectIncompatiblesList;
        }

        /// <summary>
        /// Subject Incompatibles List
        /// </summary>
        [JsonProperty("subjectIncompatiblesList")]
        public List<SubjectIncompatibles> SubjectIncompatiblesList { get; set; }
    }
}
