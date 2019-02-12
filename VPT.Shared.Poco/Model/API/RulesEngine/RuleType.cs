using NPoco;
using VPT.Shared.Poco.DTO.API.RulesEngine;

namespace VPT.Shared.Poco.Model.API.RulesEngine
{
    [TableName("RulesEngineRuleType")]
    [PrimaryKey("RuleTypeID")]
    public class RuleType:BaseModel
    {
        public RuleType() { }

        public RuleType(RuleTypeDTO ruleTypeDTO)
        {
            RuleTypeID = ruleTypeDTO.RuleTypeID;
            Name = ruleTypeDTO.Name;
            Description = ruleTypeDTO.Description;
        }

        public int RuleTypeID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
