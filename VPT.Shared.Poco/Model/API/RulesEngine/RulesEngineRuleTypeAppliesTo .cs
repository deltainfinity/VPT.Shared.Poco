using NPoco;
using VPT.Shared.Poco.DTO.API.RulesEngine;

namespace VPT.Shared.Poco.Model.API.RulesEngine
{
    [TableName("RulesEngineRuleTypeAppliesTo")]
    [PrimaryKey("ID")]
    public class RulesEngineRuleTypeAppliesTo
    {
        public RulesEngineRuleTypeAppliesTo() { }
        public RulesEngineRuleTypeAppliesTo(RuleTypeAppliesToDTO ruleTypeAppliesToDTO)
        {
            ID = ruleTypeAppliesToDTO.ID;
            RuleTypeID = ruleTypeAppliesToDTO.RuleTypeID;
            AppliesTo = ruleTypeAppliesToDTO.AppliesTo;
            Description = ruleTypeAppliesToDTO.Description;
        }

        public int ID { get; set; }
        public int RuleTypeID { get; set; }
        public string AppliesTo { get; set; }
        public string Description { get; set; }
    }
}
