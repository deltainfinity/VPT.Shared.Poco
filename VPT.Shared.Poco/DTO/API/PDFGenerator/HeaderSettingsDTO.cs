﻿namespace VPT.Shared.Poco.DTO.API.PDFGenerator
{
    /// <summary>
    /// Header settings
    /// 
    /// Text in Left, Right, and Center sections will be replaced as follows:
    ///
    /// [page]       Replaced by the number of the pages currently being printed
    /// [frompage]   Replaced by the number of the first page to be printed
    /// [topage]     Replaced by the number of the last page to be printed
    /// [webpage]    Replaced by the URL of the page being printed
    /// [section]    Replaced by the name of the current section
    /// [subsection] Replaced by the name of the current subsection
    /// [date]       Replaced by the current date in system local format
    /// [isodate]    Replaced by the current date in ISO 8601 extended format
    /// [time]       Replaced by the current time in system local format
    /// [title]      Replaced by the title of the of the current page object
    /// [doctitle]   Replaced by the title of the output document
    /// [sitepage]   Replaced by the number of the page in the current site being converted
    /// [sitepages]  Replaced by the number of pages in the current site being converted
    /// </summary>
    public class HeaderSettingsDTO
    {
        /// <summary>
        /// The text to print in the center part of the header.
        /// </summary>
        public string Center { get; set; }

        /// <summary>
        /// The text to print in the left part of the header.
        /// </summary>
        public string Left { get; set; }

        /// <summary>
        /// The text to print in the right part of the header.
        /// </summary>
        public string Right { get; set; }

        /// <summary>
        /// The name of the font to use for the header. Default = "Arial".
        /// Null = default
        /// </summary>
        public string FontName { get; set; }

        /// <summary>
        /// The font size to use for the header. Default = 12.
        /// Null = default
        /// </summary>
        public int? FontSize { get; set; }

        /// <summary>
        /// Whether a line should be printed under the header. Default = false
        /// Null = default
        /// </summary>
        public bool? Line { get; set; }

        /// <summary>
        /// The amount of space to put between the header and the content, e.g. "1.8".
        /// Be aware that if this is too large the header will be printed outside the pdf document.
        /// This can be corrected with the margin.top setting. Default = 0.00
        /// Null = default
        /// </summary>
        public double? Spacing { get; set; }

        /// <summary>
        /// Url for a HTML document to use for the footer. Default = ""
        /// Null = default
        /// If you specify this value then any values in Left, Right, and Center will be disregarded
        /// </summary>
        public string HtmlUrl { get; set; }
    }
}
