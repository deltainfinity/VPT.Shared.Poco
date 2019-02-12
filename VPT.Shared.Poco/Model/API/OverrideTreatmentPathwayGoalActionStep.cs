using NPoco;
using VPT.Shared.Poco.FormInput;

namespace VPT.Shared.Poco.Model.API
{
    /// <summary>
    /// Class defining a OverrideTreatmentPathwayGoalActionStep in VPT
    /// </summary>
    [PrimaryKey("OverrideTreatmentPathwayGoalActionStepID")]
    public class OverrideTreatmentPathwayGoalActionStep : OverrideTreatmentPathwayGoalActionStepBaseModel
    {
        public OverrideTreatmentPathwayGoalActionStep()
        { }

        public OverrideTreatmentPathwayGoalActionStep(OverrideTreatmentPathwayProgramForm source)
        {
            TreatmentPathwayGoalActionStepID = source.TreatmentPathwayGoalActionStepID;
            SubjectUserID = source.SubjectUserID;
            ProgramOverrideReasonID = source.ProgramOverrideReasonID;
            TreatmentPathwayID = source.TreatmentPathwayID;
            TreatmentPathwayTrackerID = source.TreatmentPathwayTrackerID;
            CustomOverrideReason = source.CustomOverrideReason;
        }

        public int OverrideTreatmentPathwayGoalActionStepID { get; set; }

        public int TreatmentPathwayGoalActionStepID { get; set; }

        public int SubjectUserID { get; set; }

        public int ProgramOverrideReasonID { get; set; }

        public int TreatmentPathwayID { get; set; }

        public int TreatmentPathwayTrackerID { get; set; }

        public string CustomOverrideReason { get; set; }
    }
}
