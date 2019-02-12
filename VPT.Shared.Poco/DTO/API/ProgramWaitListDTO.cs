using Newtonsoft.Json;
using System.Collections.Generic;
using VPT.Shared.Poco.DTO.API.Form;
using VPT.Shared.Poco.FormInput;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API
{
    public class ProgramWaitListDTO : BaseDTO
    {
        public ProgramWaitListDTO()
        { }
        
        public ProgramWaitListDTO(ProgramWaitList source)
        {
            ProgramWaitListID = source.ProgramWaitListID;
            SubjectUserID = source.SubjectUserID;
            ProgramID = source.ProgramID;
        }

        public int ProgramWaitListID { get; set; }
        public List<int> SubjectUserIDs { get; set; }
        public int ProgramID { get; set; }

        /// <summary>
        /// The program Id to be updated
        /// </summary>
        [JsonProperty("oldProgramID")]
        public int OldProgramID { get; set; }

        public int SubjectUserID { get; set; }

        [JsonProperty("treatmentPathwayData")]
        public SubjectTreatmentPathwayMappingFormInput TreatmentPathwayData { get; set; }

        [JsonProperty("actionStepData")]
        public CreateActionStepDTO ActionStepData { get; set; }

        /// <summary>
        /// Is Recommended Program
        /// </summary>
        [JsonProperty("isRecommendedProgram")]
        public bool IsRecommendedProgram { get; set; }

        [JsonProperty("subjectProgramID")]
        public int SubjectProgramID { get; set; }

        [JsonProperty("assignedBy")]
        public int? AssignedBy { get; set; }
    }
}
