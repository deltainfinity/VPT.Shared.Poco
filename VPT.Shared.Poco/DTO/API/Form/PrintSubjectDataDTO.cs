using Newtonsoft.Json;
using VPT.Accounts.Shared.DTO.Aggregate;

namespace VPT.Shared.Poco.DTO.API.Form
{
    public class PrintSubjectDataDTO
    {
        /// <summary>
        /// The html content
        /// </summary>
        [JsonProperty("htmlContent")]
        public string HtmlContent { get; set; }

        [JsonProperty("subjectProfile")]
        public ExternalSubjectDetailsDTO SubjectProfile { get; set; }

        [JsonProperty("data")]
        public byte[] Data { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("isDownload")]
        public bool IsDownload { get; set; }

        [JsonProperty("userID")]
        public string UserID { get; set; }

        [JsonProperty("hearingID")]
        public string HearingID { get; set; }

    }
}
