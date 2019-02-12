using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VPT.Shared.Poco.Model.Accounts.Database;

namespace VPT.Shared.Poco.DTO.Accounts.Aggregate
{
    public class MatchedSubjectAggregateDTO
    {
        public MatchedSubjectAggregateDTO()
        { }

        public MatchedSubjectAggregateDTO(List<MatchedSubjectDTO> dto, string subjectExternalID)
        {
            MatchedSubjects = dto;
            SubjectExternalID = subjectExternalID;
        }

        [JsonProperty("matchedSubjects")]
        public List<MatchedSubjectDTO> MatchedSubjects { get; set; }

        [JsonProperty("subjectExternalID")]
        public string SubjectExternalID { get; set; }

    }
}
