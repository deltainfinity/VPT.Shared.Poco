using NPoco;
using VPT.Shared.Poco.DTO.API;

namespace VPT.Shared.Poco.Model.API
{
    [TableName("OverrideTreatmentPathway")]
    [PrimaryKey("OverrideTreatmentPathwayID")]
    public class OverrideTreatmentPathway : OverrideTreatmentPathwayGoalActionStepBaseModel
    {
        public OverrideTreatmentPathway()
        { }
        
        public OverrideTreatmentPathway(OverrideTreatmentPathwayDTO source)
        {
            TreatmentPathwayID = source.TreatmentPathwayID;
            TreatmentPathwayTrackerID = source.TreatmentPathwayTrackerID;
            SubjectUserID = source.SubjectUserID;
            TreatmentPathwayOverrideReasonID = source.TreatmentPathwayOverrideReasonID;
            CustomOverrideReason = source.CustomOverrideReason;
        }

        public int OverrideTreatmentPathwayID { get; set; }

        public int TreatmentPathwayID { get; set; }

        public int TreatmentPathwayTrackerID { get; set; }

        public int SubjectUserID { get; set; }

        public int TreatmentPathwayOverrideReasonID { get; set; }

        public string CustomOverrideReason { get; set; }
    }
}
