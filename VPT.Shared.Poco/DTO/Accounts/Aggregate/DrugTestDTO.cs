using System.Collections.Generic;

namespace VPT.Shared.Poco.DTO.Accounts.Aggregate
{
    public class DrugTestDTO
    {
        public string TestDate { get; set; }
        public string TestSite { get; set; }
        public List<DrugsDto> Drugs { get; set; }
    }
    public class DrugsDto
    {
        public string DrugClass { get; set; }
        public string Drug { get; set; }
        public string TestResult { get; set; }
    }

}
   

