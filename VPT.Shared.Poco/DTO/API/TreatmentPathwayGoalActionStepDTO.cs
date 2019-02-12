using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API
{
    public class TreatmentPathwayGoalActionStepDTO : BaseDTO
    {
        public TreatmentPathwayGoalActionStepDTO() { }
        public TreatmentPathwayGoalActionStepDTO(TreatmentPathwayGoalActionStep source)
        {
            TreatmentPathwayGoalActionStepID = source.TreatmentPathwayGoalActionStepID;
            TreatmentPathwayGoalID = source.TreatmentPathwayGoalID;
            ActionStep = source.ActionStep;
            ParentProgramId = source.ParentProgramId;
        }
        

        [JsonProperty("treatmentPathwayGoalActionStepID")]
        public int TreatmentPathwayGoalActionStepID { get; set; }

        [JsonProperty("treatmentPathwayGoalID")]
        public int TreatmentPathwayGoalID { get; set; }

        [JsonProperty("actionStep")]
        public string ActionStep { get; set; }
        public int ParentProgramId { get; set; }

        public int TreatmentPathwayID { get; set; }
        public string TreatmentPathwayGoalName { get; set; }
    }
}
