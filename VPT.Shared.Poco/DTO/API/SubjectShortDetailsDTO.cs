using Newtonsoft.Json;

namespace VPT.Shared.Poco.DTO.API
{
    public class SubjectShortDetailsDTO
    {
        public SubjectShortDetailsDTO()
        { }

        public SubjectShortDetailsDTO(int subjectUserID, string name)
        {
            SubjectUserID = subjectUserID;
            Name = name;
        }

        [JsonProperty("subjectUserID")]
        public int SubjectUserID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("isAssigned")]
        public bool IsAssigned { get; set; }

        [JsonProperty("alreadyAssigned")]
        public bool AlreadyAssigned { get; set; }
    }
}
