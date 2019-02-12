using Newtonsoft.Json;

namespace VPT.Shared.Poco.DTO.API.Form
{
   public class PrintCasePlanDTO
    {
        /// <summary>
        /// The html content
        /// </summary>
        [JsonProperty("htmlContent")]
        public string HtmlContent { get; set; }

        [JsonProperty("footerImageUrl")]
        public string FooterImageUrl { get; set; }
                
        [JsonProperty("systemOfRecordsLabel")]
        public string SystemOfRecordsLabel { get; set; }

        [JsonProperty("Subject")]
        public SubjectDTO Subject { get; set; }

        [JsonProperty("data")]
        public byte[] Data { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("isDownload")]
        public bool IsDownload { get; set; }

        [JsonProperty("userID")]
        public int UserID { get; set; }

    }
}
