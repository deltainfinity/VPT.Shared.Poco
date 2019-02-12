using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API
{
    public class TreatmentPathwayGoalDTO : BaseDTO
    {
        public TreatmentPathwayGoalDTO() { }
        public TreatmentPathwayGoalDTO(TreatmentPathwayGoal source)
            : base(source)
        {
            TreatmentPathwayGoalID = source.TreatmentPathwayGoalID;
            Name = source.Name;
            TreatmentPathwayID = source.TreatmentPathwayID;
        }

        [JsonProperty("treatmentPathwayID")]
        public int TreatmentPathwayGoalID { get; set; }

        [JsonProperty("name")]
        public string Name { set; get; }

        [JsonProperty("treatmentPathwayID")]
        public int TreatmentPathwayID { get; set; }

        [JsonProperty("programStatus")]
        public int ProgramStatus { get; set; }

        public bool IsDeletedWaitList { get; set; }

    }
}
