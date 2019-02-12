using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPT.Shared.Poco.DTO.API
{
    public class SORStateProgramDTO
    {
        public int StateProgramLookupID { get; set; }
        public string StateProgramID { get; set; }
        public string ProgramStatus { get; set; }
        public decimal HourlyPayRate { get; set; }
        public int Credit { get; set; }
        public bool IncentiveProgram { get; set; }
        public string StateProgramName { get; set; }

    }
}
