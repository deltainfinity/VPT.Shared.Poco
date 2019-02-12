using Newtonsoft.Json;
using System.Collections.Generic;
using VPT.Shared.Poco.DTO.API.Aggregate;
using VPT.Shared.Poco.Enum.API;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API
{
    public class AssignedProgramDetailsForVIDSAggregateDTO  
    {
        public AssignedProgramDetailsForVIDSAggregateDTO()
        { }
        public AssignedProgramDetailsForVIDSAggregateDTO(ParentProgram parentProgram,List<string> goalName,List<string> pathwayName,List<AssignedProgramInstanceAggregateDTO> programList)
        {
            ParentProgramID = parentProgram.ParentProgramId;
            ParentProgramName = parentProgram.Title;
            NumberOfSessions = parentProgram.NumberOfSessions;
            Platform = PlatformTypeConstants.GetByEnum(parentProgram.Platform);
            GoalNameList = goalName;
            TreatmentpathwayList = pathwayName;
            ProgramList = programList;
        }

        [JsonProperty("parentProgramID")]
        public int ParentProgramID { get; set; }

        [JsonProperty("parentProgramName")]
        public string ParentProgramName { get; set; }


        [JsonProperty("numberOfSessions")]
        public int NumberOfSessions { get; set; }

        [JsonProperty("platform")]
        public string Platform { get; set; }

        [JsonProperty("goalNameList")]
        public List<string> GoalNameList { get; set; }

        [JsonProperty("treatmentpathwayList")]
        public List<string> TreatmentpathwayList { get; set; }

        [JsonProperty("programList")]
        public List<AssignedProgramInstanceAggregateDTO> ProgramList { get; set; }

    }
}