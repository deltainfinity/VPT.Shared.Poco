using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPT.Shared.Poco.Model.API.Tether
{
    [TableName("ProgramAssessment")]
    [PrimaryKey("ProgramAssessmentID")]
    public class ProgramAssessment : BaseModel
    {
        public int AssessmentID { get; set; }
        public int ProgramCatalogID { get; set; }
        public int ProgramAssessmentID { get; set; }
        public int Dosage { get; set; }
    }
}
