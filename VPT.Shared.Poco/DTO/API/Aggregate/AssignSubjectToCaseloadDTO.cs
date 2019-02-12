using Newtonsoft.Json;
using System.Collections.Generic;

namespace VPT.Shared.Poco.DTO.API.Aggregate
{
    public class AssignSubjectToCaseloadDTO
    {
        [JsonProperty("assignedSubjects")]
        public List<string> AssignedSubjects { get; set; }
        [JsonProperty("alreadyAssignedSubjects")]
        public List<string> AlreadyAssignedSubjects { get; set; }

    }
}
