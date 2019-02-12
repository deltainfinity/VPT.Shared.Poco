using NPoco;

namespace VPT.Shared.Poco.Model.API
{
    [TableName("TreatmentPathwayProgramRecommendation")]
    [PrimaryKey("TreatmentPathwayProgramRecommendationID")]
    public class TreatmentPathwayProgramRecommendation
    {
        public TreatmentPathwayProgramRecommendation()
        { }

        public TreatmentPathwayProgramRecommendation(int treatmentPathwayRecommendationID, int parentProgramID, int treatmentPathwayID)
        {
            TreatmentPathwayRecommendationID = treatmentPathwayRecommendationID;
            ParentProgramID = parentProgramID;
            TreatmentPathwayID = treatmentPathwayID;
        }

        public int TreatmentPathwayProgramRecommendationID { get; set; }

        public int TreatmentPathwayRecommendationID { get; set; }

        public int ParentProgramID { get; set; }

        public int TreatmentPathwayID { get; set; }
    }
}

