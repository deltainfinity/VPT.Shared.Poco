using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API
{
    public class TreatmentPathwayDTO : BaseDTO
    {
        public TreatmentPathwayDTO() { }
        public TreatmentPathwayDTO(TreatmentPathway source)
            : base(source)
        {
            PathwayName = source.PathwayName;
            TreatmentPathwayID = source.TreatmentPathwayID;
            FileID = source.FileID;
        }
        

        [JsonProperty("treatmentPathwayID")]
        public int TreatmentPathwayID { get; set; }

        [JsonProperty("pathwayName")]
        public string PathwayName { get; set; }

        [JsonProperty("organizationID")]
        public int OrganizationID { get; set; }

        [JsonProperty("fileSrc")]
        public string FileSrc { get; set; }

        [JsonProperty("fileID")]
        public int FileID { get; set; }

        [JsonProperty("treatmentPathwayGoalID")]
        public int TreatmentPathwayGoalID { get; set; }

        [JsonProperty("treatmentPathwayGoalName")]
        public string TreatmentPathwayGoalName { get; set; }

        [JsonProperty("actionStepAggregate")]
        public List<ActionStepAggregateDTO> ActionStepAggregate { get; set; }



    }
}
