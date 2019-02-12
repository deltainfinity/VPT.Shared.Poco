using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API
{
    public class PathwayRecommendationSelectedDTO : BaseDTO
    {
        public PathwayRecommendationSelectedDTO()
        { }

        public PathwayRecommendationSelectedDTO(IList<PathwayRecommendationAggregateDTO> source, SelectedTreatmenPathwayDetails selectedTreatmenPathwayDetails)
        {
            TreatmentPathwayRecommendation = source;
            SelectedTreatmenPathwayDetails = selectedTreatmenPathwayDetails;
        }

        [JsonProperty("TreatmentPathwayRecommendation")]
        public IList<PathwayRecommendationAggregateDTO> TreatmentPathwayRecommendation { get; set; }

        [JsonProperty("SelectedTreatmenPathwayDetails")]
        public SelectedTreatmenPathwayDetails SelectedTreatmenPathwayDetails { get; set; }
               

    }
}
