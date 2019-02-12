using NPoco;

namespace VPT.Shared.Poco.Model.API
{
    /// <summary>
    /// Class for defining a TreatmentPathwayRecommendation
    /// </summary>
    ///
    [TableName("TreatmentPathwayRecommendation")]
    [PrimaryKey("TreatmentPathwayRecommendationID")]
    public class TreatmentPathwayRecommendation 
    {
        public TreatmentPathwayRecommendation()
        { }

        public int TreatmentPathwayRecommendationID { get; set; }

        public int TreatmentPathwayTrackerID { get; set; }

        public string Name { get; set; }

        public string SortOrder { get; set; }
    }
}
