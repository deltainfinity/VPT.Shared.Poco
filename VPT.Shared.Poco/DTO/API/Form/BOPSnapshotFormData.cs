using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using VPT.Shared.Poco.DTO.Accounts.Aggregate;

namespace VPT.Shared.Poco.DTO.API.Form
{
    public class BOPSnapshotFormData
    {
        public BOPSnapshotFormData()
        {

        }

        public BOPSnapshotFormData(Hearing item, string subjecExternalID, string organizationID)
        {
            AccountExternalId = organizationID;
            SubjectExternalId = subjecExternalID;
            HearingDate = item.HearingDate;
        }

        [Required]
        [JsonProperty("accountExternalId")]
        public string AccountExternalId { get; set; }

        [Required]
        [JsonProperty("subjectExternalId")]
        public string SubjectExternalId { get; set; }

        [Required]
        [JsonProperty("hearingDate")]
        public string HearingDate { get; set; }

        [Required]
        [JsonProperty("dateHearingDateAdded")]
        public string DateHearingDateAdded { get; set; }
    }
}
