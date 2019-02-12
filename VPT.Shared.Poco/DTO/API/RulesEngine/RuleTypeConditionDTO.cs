using VPT.Shared.Poco.Model.API.RulesEngine;

namespace VPT.Shared.Poco.DTO.API.RulesEngine
{
    /// <summary>
    /// Rules engine rule
    /// </summary>
    public class RuleTypeConditionDTO
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public RuleTypeConditionDTO()
        { }

        /// <summary>
        /// Copy constructor
        /// </summary>
        /// <param name="rulesEngineRuleTypeCondition"></param>
        public RuleTypeConditionDTO(RulesEngineRuleTypeCondition rulesEngineRuleTypeCondition)
        {
            Id = rulesEngineRuleTypeCondition.ID;
            RuleTypeId = rulesEngineRuleTypeCondition.RuleTypeId;
            DataType = rulesEngineRuleTypeCondition.DataType;
            Condition = rulesEngineRuleTypeCondition.Condition;
        }

        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Rule Type Id
        /// </summary>
        public int RuleTypeId { get; set; }
        /// <summary>
        /// Name of the rule
        /// </summary>
        public string Condition { get; set; }
        /// <summary>
        /// Data Type
        /// </summary>
        public int DataType { get; set; }
    }
}
