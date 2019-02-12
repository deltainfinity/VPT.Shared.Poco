using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API
{
    public class RecommendationDTO
    {
        public RecommendationDTO()
        {
        }
        public RecommendationDTO(PrisonProgramRegistration registrationData, TreatmentPathwayGoalDTO treatmentPathwayGoal, RecommendationDTO recommendationDTO, TreatmentPathwayTracker treatmentPathwayDetails, string stateProgramID = "")
        {
            TreatmentPathwayGoal = treatmentPathwayGoal.Name;
            TreatmentPathwayGoalID = treatmentPathwayGoal.TreatmentPathwayGoalID;
            VPTProgramID = registrationData.ParentProgramId;
            LastModifiedDate = registrationData.DateCreated;
            StateProgramID = stateProgramID;
            LastModifiedBy = treatmentPathwayDetails.AssessmentCompletedByExternalId;
            PathwayCode = recommendationDTO.PathwayCode;
            PathwayOrder = recommendationDTO.PathwayOrder;
            PathwayID = recommendationDTO.PathwayID;
        }
        public string PathwayCode { get; set; }
        public string PathwayOrder { get; set; }
        public string TreatmentPathwayGoal { get; set; }
        public int  TreatmentPathwayGoalID { get; set; }
        public int PathwayID { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public int VPTProgramID { get; set; }
        public string StateProgramID { get; set; }
    }
}
