using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VPT.Shared.Poco.Model.API.Tether;

namespace VPT.Shared.Poco.DTO.API.Tether
{
    public class ProgramAssessmentDTO : BaseDTO
    {
        public ProgramAssessmentDTO()
        { }
        public ProgramAssessmentDTO(ProgramAssessment source)
        {
            AssessmentId = source.AssessmentID;
            ProgramCatalogId = source.ProgramCatalogID;
            ProgramAssessmentId = source.ProgramAssessmentID;
            CreatedByUserId = source.CreatedByUserID;
            Dosage = source.Dosage;
        }
        public int AssessmentId { get; set; }
        public int ProgramCatalogId { get; set; }
        public int ProgramAssessmentId { get; set; }
        public string CreatedByUserId { get; set; }
        public int Dosage { get; set; }
    }
}
