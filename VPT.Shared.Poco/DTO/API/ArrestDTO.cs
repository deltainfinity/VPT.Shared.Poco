using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPT.Shared.Poco.DTO.API
{
    public class ArrestDTO
    {
        public ArrestDTO()
        { }

        public Crime[] Crimes { get; set; }
        public string Description { get; set; }
        public string DescriptionUser { get; set; }
        public DateTime DescriptionWhen { get; set; }
        public int CauseId { get; set; }
        public string State { get; set; }
        public string County { get; set; }
        public string CauseNumber { get; set; }
        public DateTime? SentenceDate { get; set; }
        public string AdultJuvenileType { get; set; }
        public string SentenceType { get; set; }
        public string Source { get; set; }
        public string CauseStatus { get; set; }
        public int LastModifiedByUserId { get; set; }
        public DateTime LastModified { get; set; }
        public string ExternalId { get; set; }
        public string Comments { get; set; }
        public string CaseNumber { get; set; }
    }
}
