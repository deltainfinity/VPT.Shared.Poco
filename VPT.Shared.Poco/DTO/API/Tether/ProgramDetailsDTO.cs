using System;
using System.Collections.Generic;
using VPT.Shared.Poco.Model.API.Tether;

namespace VPT.Shared.Poco.DTO.API.Tether
{
    public class ProgramDetailsDTO 
    {
        public ProgramsDTO program { get; set; }
        public int subjectProgramId { get; set; }
        public IList<ProgramElementDTO> programElements { get; set; }
        public string AssignedBy { get; set; }
    }
}
