using NPoco;
using VPT.Shared.Poco.DTO.API.RulesEngine;

namespace VPT.Shared.Poco.Model.API.RulesEngine
{
    [TableName("RulesEngineRuleTypeResult")]
    [PrimaryKey("ID")]
    public class RulesEngineRuleTypeResult
    {
        public RulesEngineRuleTypeResult() { }

        public RulesEngineRuleTypeResult(RuleTypeResultDTO source)
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
