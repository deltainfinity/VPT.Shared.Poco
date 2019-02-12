using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VPT.Shared.Poco.Model.API.Tether;

namespace VPT.Shared.Poco.DTO.API.Tether
{
    public class ProgramsDTO 
    {
        public int ProgramCatalogId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Completed { get; set; }
    }
}
