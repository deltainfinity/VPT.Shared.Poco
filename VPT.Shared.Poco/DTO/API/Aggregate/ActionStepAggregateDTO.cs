using Newtonsoft.Json;
using System.Collections.Generic;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API
{
    public class ActionStepAggregateDTO : BaseDTO
    {
        public ActionStepAggregateDTO()
        {
        }
        public ActionStepAggregateDTO(TreatmentPathwayGoalActionStep treatmentPathwayGoalActionStep, ParentProgram parentProgram, List<Program> programInstances, List<ProgramInstanceLookupDTO> programInstanceLookups, List<ComponentDTO> programComponents,bool isRecommendedProgram, bool isAssigned = false)
        {
            TreatmentPathwayGoalActionStep = treatmentPathwayGoalActionStep;
            Program = parentProgram;
            ProgramInstances = programInstances;
            ProgramInstanceLookups = programInstanceLookups;
            AgencySettings = parentProgram.AgencySettings;
            ProgramComponents = programComponents;
            IsRecommendedProgram =isRecommendedProgram;
            IsAssigned = isAssigned;
        }

        [JsonProperty("actionStep")]
        public TreatmentPathwayGoalActionStep TreatmentPathwayGoalActionStep { get; set; }

        [JsonProperty("program")]
        public ParentProgram Program { get; set; }

        [JsonProperty("programInstances")]
        public List<Program> ProgramInstances { get; set; }

        [JsonProperty("programInstanceLookups")]
        public List<ProgramInstanceLookupDTO> ProgramInstanceLookups { get; set; }

        [JsonProperty("programComponents")]
        public List<ComponentDTO> ProgramComponents { get; set; }

        [JsonProperty("agencySettings")]
        public int AgencySettings { get; set; }

        /// <summary>
        /// The flag specifying program is recommended or not
        /// </summary>
        [JsonProperty("isRecommendedProgram")]
        public bool IsRecommendedProgram { get; set; }

        [JsonProperty("isAssigned")]
        public bool IsAssigned { get; set; }
    }
}
