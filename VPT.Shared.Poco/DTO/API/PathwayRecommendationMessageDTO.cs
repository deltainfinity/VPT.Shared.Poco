namespace VPT.Shared.Poco.DTO.API
{
    using System.Collections.Generic;
    public class PathwayRecommendationMessageDTO
    {
        public int AssessmentID { get; set; }
        public string AssessmentCompletedByExternalId { get; set; }
        public List<PathwayRecommendationRequestDTO> PathwayRecommendations { get; set; }
    }
}
