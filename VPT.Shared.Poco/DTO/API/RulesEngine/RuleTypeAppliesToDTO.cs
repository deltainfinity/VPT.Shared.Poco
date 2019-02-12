using VPT.Shared.Poco.Model.API.RulesEngine;

namespace VPT.Shared.Poco.DTO.API.RulesEngine
{
    public class RuleTypeAppliesToDTO
    {
        public RuleTypeAppliesToDTO() { }

        public RuleTypeAppliesToDTO(RulesEngineRuleTypeAppliesTo rulesEngineRuleTypeAppliesTo)
        {
            ID = rulesEngineRuleTypeAppliesTo.ID;
            RuleTypeID = rulesEngineRuleTypeAppliesTo.RuleTypeID;
            AppliesTo = rulesEngineRuleTypeAppliesTo.AppliesTo;
            Description = rulesEngineRuleTypeAppliesTo.Description;
        }
        public int ID { get; set; }
        public int RuleTypeID { get; set; }
        public string AppliesTo { get; set; }
        public string Description { get; set; }
    }
}
