using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VPT.Shared.Poco.Model.API.Tether;

namespace VPT.Shared.Poco.DTO.API.Tether
{
    public class ProgramCatalogAssessmentDTO : BaseDTO
    {
        public ProgramCatalogAssessmentDTO(ProgramAssessment source)
        {
            AssessmentID = source.AssessmentID;
            ProgramCatalogID = source.ProgramCatalogID;
            ProgramAssessmentID = source.ProgramAssessmentID;
            Dosage = source.Dosage;
        }
        public int AssessmentID { get; set; }
        public int ProgramCatalogID { get; set; }
        public int Dosage { get; set; }
        public int ProgramAssessmentID { get; set; }


    }
}
