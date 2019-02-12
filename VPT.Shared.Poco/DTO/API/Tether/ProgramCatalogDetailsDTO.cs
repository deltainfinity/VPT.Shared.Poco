using System;
using System.Collections.Generic;
using VPT.Shared.Poco.Model.API.Tether;

namespace VPT.Shared.Poco.DTO.API.Tether
{
    public class ProgramCatalogDetailsDTO : BaseDTO
    {
        public ProgramCatalogDetailsDTO() {}
        public int ProgramCatalogId { get; set; }        
        public string Name { get; set; }
        public string Description { get; set; }        
        public List<CourseCatalogDTO> Courses { get; set; }
        public List<ProgramCatalogAssessmentDTO> Assessments { get; set; }
        public int Dosage { get; set; }

    }
}
