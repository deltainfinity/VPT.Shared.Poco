using System.ComponentModel.DataAnnotations;

namespace VPT.Shared.Poco.DTO.API.PDFGenerator
{
    public class HTMLToPDFDTO
    {
        /// <summary>
        /// Global PDF conversion settings
        /// </summary>
        [Required]
        public GlobalSettingsDTO GlobalSettings { get; set; }

        /// <summary>
        /// PDF document settings
        /// </summary>
        [Required]
        public DocumentSettingsDTO DocumentSettings { get; set; }

        /// <summary>
        /// The HTML to convert to PDF
        /// </summary>
        [Required]
        public string HtmlContent { get; set; }
    }
}
