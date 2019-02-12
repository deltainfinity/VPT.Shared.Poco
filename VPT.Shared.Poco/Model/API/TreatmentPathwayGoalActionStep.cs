using NPoco;
using VPT.Shared.Poco.DTO.API;

namespace VPT.Shared.Poco.Model.API
{
    [TableName("TreatmentPathwayGoalActionStep")]
    [PrimaryKey("TreatmentPathwayGoalActionStepID")]
    public class TreatmentPathwayGoalActionStep
    {
        public TreatmentPathwayGoalActionStep() { }

        public TreatmentPathwayGoalActionStep(TreatmentPathwayGoalActionStepDTO source)
        {
            TreatmentPathwayGoalActionStepID = source.TreatmentPathwayGoalActionStepID;
            TreatmentPathwayGoalID = source.TreatmentPathwayGoalID;
            ActionStep = source.ActionStep;
        }

        public int TreatmentPathwayGoalActionStepID { get; set; }

        public int TreatmentPathwayGoalID { get; set; }

        public string ActionStep { get; set; }

        public int ParentProgramId { get; set; }
    }
}
