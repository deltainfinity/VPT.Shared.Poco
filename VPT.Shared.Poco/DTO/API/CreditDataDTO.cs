using Newtonsoft.Json;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API
{
    public class CreditDataDTO
    {
        public CreditDataDTO(CreditData completed, CreditData possible)
        {
            CompletedCreditBased = completed.CreditBased;
            PossibleCreditBased = possible.CreditBased;

            PossibleTimeBased = possible.TimeBased;
            CompletedTimeBased = completed.TimeBased;
        }

        [JsonProperty("completedTimeBased")]
        public int CompletedTimeBased { get; set; }

        [JsonProperty("completedCreditBased")]
        public int CompletedCreditBased { get; set; }

        [JsonProperty("possibleTimeBased")]
        public int PossibleTimeBased { get; set; }

        [JsonProperty("possibleCreditBased")]
        public int PossibleCreditBased { get; set; }
    }
}
