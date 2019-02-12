using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPT.Shared.Poco.Model.API.Tether
{
    public class ProgramCatalogProgram
    {
        public int ProgramCatalogId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }
        public int SubjectProgramId { get; set; }
        public string CreatedByUserId { get; set; }
    }
}
