using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VPT.Shared.Poco.Model.API.Tether;

namespace VPT.Shared.Poco.DTO.API.Tether
{
    public class ProgramElementDTO 
    {
        public int Id { get; set; }
        public string InstanceId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Sequence { get; set; }
        public byte Status { get; set; }
        public byte Type { get; set; }
    }
}
