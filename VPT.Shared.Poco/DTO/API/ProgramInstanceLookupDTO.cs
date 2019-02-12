using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPT.Shared.Poco.DTO.API
{

    public class ProgramInstanceLookupDTO
    {
        public int ParentProgramID { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }

        public int SortOrder { get; set; }

        public String InstanceDetails { get; set; }

        public int FacilityID { get; set; }
    }
}
