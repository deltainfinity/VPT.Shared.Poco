using NPoco;
using VPT.Shared.Poco.DTO.API.RulesEngine;

namespace VPT.Shared.Poco.Model.API.RulesEngine
{
    /// <summary>
    /// Rules engine rule
    /// </summary>
    [TableName("RulesEngineRuleTypeCondition")]
    [PrimaryKey("ID")]
    public class RulesEngineRuleTypeCondition
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public RulesEngineRuleTypeCondition()
        { }

        /// <summary>
        /// Copy constructor
        /// </summary>
        /// <param name="ruleTypeCondition"></param>
        public RulesEngineRuleTypeCondition(RuleTypeConditionDTO ruleTypeCondition)
        {
            ID = ruleTypeCondition.Id;
            RuleTypeId = ruleTypeCondition.RuleTypeId;
            DataType = ruleTypeCondition.DataType;
            Condition = ruleTypeCondition.Condition;
        }

        /// <summary>
        /// ID
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// Rule Type Id
        /// </summary>
        public int RuleTypeId { get; set; }
        /// <summary>
        /// Condition of Rules Engine Rule Type
        /// </summary>
        public string Condition { get; set; }
        /// <summary>
        /// Data Type
        /// </summary>
        public int DataType { get; set; }
    }
}
