using NPoco;
using System;
using VPT.Shared.Poco.DTO.API;

namespace VPT.Shared.Poco.Model.API
{
    /// <summary>
    /// Class for defining a ProgramRecommendation
    /// </summary>
    [TableName("ProgramRecommendation")]
    [PrimaryKey("ProgramRecommendationId")]
    public class ProgramRecommendation : OverrideTreatmentPathwayGoalActionStepBaseModel
    {
        public ProgramRecommendation()
        { }

        public ProgramRecommendation(ProgramRecommendationDTO source)
        {
            ProgramRecommendationId = source.ProgramRecommendationId;
            ParentProgramId = source.ParentProgramId;
            OffenderId = source.OffenderId;
            Status = source.Status > 0 ? source.Status : (int)Vant4gePoint.Core.Enums.ProgramRecommendationStatusType.UnAssigned;
            OverriddenDate = (DateTime?)null;
        }

        public int ProgramRecommendationId { get; set; }

        public int ParentProgramId { get; set; }

        public string OffenderId { get; set; }

        public int Status { get; set; }

        public string OverriddenReason { get; set; }

        public DateTime? OverriddenDate { get; set; }

        public string OverriddenByUserID { get; set; }

        public DateTime? AssignedDate { get; set; }

        public string AssignedByUserID { get; set; }
    }
}
