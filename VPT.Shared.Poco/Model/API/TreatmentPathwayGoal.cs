using NPoco;
using VPT.Shared.Poco.DTO.API;

namespace VPT.Shared.Poco.Model.API
{
    [TableName("TreatmentPathwayGoal")]
   [PrimaryKey("TreatmentPathwayGoalID")]
   public class TreatmentPathwayGoal: BaseModel
    {
        public TreatmentPathwayGoal() { }

        public TreatmentPathwayGoal(TreatmentPathwayGoalDTO source)
            : base(source)
        {
            TreatmentPathwayGoalID = source.TreatmentPathwayGoalID;
            Name = source.Name;
            TreatmentPathwayID = source.TreatmentPathwayID;
        }

        public int TreatmentPathwayGoalID { get; set; }

        public string Name { get; set; }

        public int TreatmentPathwayID { get; set; }
    }
}
