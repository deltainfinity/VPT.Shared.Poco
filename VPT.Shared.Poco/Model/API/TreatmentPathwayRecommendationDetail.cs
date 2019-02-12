namespace VPT.Shared.Poco.Model.API
{
    /// <summary>
    /// Class for defining a ProgramRecommendation
    /// </summary>
    public class TreatmentPathwayRecommendationDetail : BaseModel
    {
        public TreatmentPathwayRecommendationDetail()
        { }

        public string OffenderID { get; set; }

        public string Name { get; set; }

        public string SortOrder { get; set; }

        public int TreatmentPathwayID { get; set; }

        public int TreatmentPathwayTrackerID { get; set; }

        public int TreatmentPathwayRecommendationID { get; set; }

        public bool DisplayAll { get; set; }

        public int? AssessmentId { get; set; }
        public string AssessmentCompletedByExternalId { get; set; }
    }
}
