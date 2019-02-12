using System;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API
{
    public class TreatmentPathwayRecommendationDetailDTO : BaseDTO
    {
        public TreatmentPathwayRecommendationDetailDTO()
        { }

        public TreatmentPathwayRecommendationDetailDTO(TreatmentPathwayRecommendationDetail source)
            : base(source)
        {
            TreatmentPathwayRecommendationID = source.TreatmentPathwayRecommendationID;
            OffenderID = source.OffenderID;
            Name = source.Name;
            SortOrder = source.SortOrder;
        }

        public int TreatmentPathwayRecommendationID { get; set; }
        public string OffenderID { get; set; }
        public string Name { get; set; }
        public string SortOrder { get; set; }
    }
}
