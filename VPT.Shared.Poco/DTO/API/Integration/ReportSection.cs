using System.Collections.Generic;

namespace VPT.Shared.Poco.DTO.API.Integration
{
    public class ReportSection
    {
        public ReportSection()
        {

        }
        public int id { get; set; }
        public string Name { get; set; }
        public Dictionary<string, List<string>> ReportText { get; set; }
    }
}
