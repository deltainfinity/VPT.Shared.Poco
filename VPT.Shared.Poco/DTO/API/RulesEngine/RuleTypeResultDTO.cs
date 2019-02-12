using VPT.Shared.Poco.Model.API.RulesEngine;

namespace VPT.Shared.Poco.DTO.API.RulesEngine
{
    public class RuleTypeResultDTO
    {
        public RuleTypeResultDTO() { }

        public RuleTypeResultDTO(RulesEngineRuleTypeResult source)
        {
            ID = source.ID;
            RuleTypeID = source.RuleTypeID;
            Result = source.Result;
            Description = source.Description;
        }

        public int ID { get; set; }
        public int RuleTypeID { get; set; }
        public string Result { get; set; }
        public string Description { get; set; }
    }
}
