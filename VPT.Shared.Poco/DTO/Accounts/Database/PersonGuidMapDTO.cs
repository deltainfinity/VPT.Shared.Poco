using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPT.Shared.Poco.DTO.Accounts.Database
{
public class PersonGuidMapDTO
    {
        public int PersonId { get; set; }
        public int OrganizationId { get; set; }
        public string PersonGuid { get; set; }
    }
}
