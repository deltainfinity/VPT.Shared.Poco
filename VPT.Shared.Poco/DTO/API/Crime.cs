using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPT.Shared.Poco.DTO.API
{
    public class Crime
    {
        public int CrimeId { get; set; }
        public string CrimeTitle { get; set; }
        public string LegalCode { get; set; }
        public int LegalCodeId { get; set; }
        public string DomesticViolenceFlag { get; set; }
        public string Anticipatory { get; set; }
        public string Enhancement { get; set; }
        public DateTime? OffenseDate { get; set; }
        public int LastModifiedByUserId { get; set; }
        public DateTime LastModified { get; set; }
        public string ExternalId { get; set; }
        public string Source { get; set; }
        public string LegalCodeType { get; set; }
        public string DV_Type { get; set; }
        public string IsAssaultOffense { get; set; }
        public int SeverityIndex { get; set; }
    }
}
