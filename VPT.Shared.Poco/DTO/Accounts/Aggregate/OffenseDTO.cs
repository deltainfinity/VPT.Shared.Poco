using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPT.Shared.Poco.DTO.Accounts.Aggregate
{
    public class OffenseDTO
    {
        public OffenseDTO()
        { }

        public OffenseDTO(OffenseDTO Offense)
        {
            SentenceExternalId = Offense.SentenceExternalId;
            OffenseExternalId = Offense.OffenseExternalId;
            OffenseLegalCodeExternalId = Offense.OffenseLegalCodeExternalId;
            OffenseTitle = Offense.OffenseTitle;
            OffenseCode = Offense.OffenseCode;
            DomesticViolence = Offense.DomesticViolence;
            Qualifier = Offense.Qualifier;
            Enhancement = Offense.Enhancement;
            ArrestDate = Offense.ArrestDate;
            OffenseDisposition = Offense.OffenseDisposition;
           

    }
        public string SentenceExternalId { get; set; }
        public string OffenseExternalId { get; set; }
        public string OffenseLegalCodeExternalId { get; set; }
        public string OffenseTitle { get; set; }
        public string OffenseCode { get; set; }
        public string DomesticViolence { get; set; }
        public string Qualifier { get; set; }
        public string Enhancement { get; set; }
        public DateTime? ArrestDate { get; set; }
        public string OffenseDisposition { get; set; }
    }
}
