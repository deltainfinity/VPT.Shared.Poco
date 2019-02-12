using System;
using System.Collections.Generic;
using System.Text;

namespace VPT.Shared.Poco.DTO.Audit
{
    public class AuditFilterDTO
    {
        public string Module { get; set; }

        public string Keywords { get; set; }

        public int Duration { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public int CurrentPage = 1;

        public int PageSize = 50;
    }
}
