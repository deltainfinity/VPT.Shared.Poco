using NPoco;
using VPT.Shared.Poco.DTO.API.RulesEngine;

namespace VPT.Shared.Poco.Model.API.RulesEngine
{
    /// <summary>
    /// Model for a rules engine rule
    /// </summary>
    [TableName("RulesEngineRule")]
    [PrimaryKey("RuleID")]
    public class RulesEngineRule : BaseModel
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public RulesEngineRule()
        { }

        /// <summary>
        /// Copy constructor
        /// </summary>
        /// <param name="rulesEngineRule">RulesEngineRuleDTO</param>
        public RulesEngineRule(RulesEngineRuleDTO rulesEngineRule)
        {
            RuleId = rulesEngineRule.RuleId;
            Type = rulesEngineRule.Type.RuleTypeID;
            Name = rulesEngineRule.Name;
            Description = rulesEngineRule.Description;
            AppliesTo = rulesEngineRule.AppliesTo;
            Rule = rulesEngineRule.Rule;
            Result = rulesEngineRule.Result;
            OrganizationId = rulesEngineRule.OrganizationId;
            FacilityId = rulesEngineRule.FacilityId;
        }

        /// <summary>
        /// RuleID
        /// </summary>
        public int RuleId { get; set; }
        /// <summary>
        /// Type of rule
        /// </summary>
        public int Type { get; set; }
        /// <summary>
        /// Name of the rule
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Description of the rule
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Identifier for the object that the rule applies to, if any
        /// </summary>
        public string AppliesTo { get; set; }
        /// <summary>
        /// Rule
        /// </summary>
        public string Rule { get; set; }
        /// <summary>
        /// The result if the rule is true
        /// </summary>
        public string Result { get; set; }
        /// <summary>
        /// The organization that the rule applies to
        /// </summary>
        public int OrganizationId { get; set; }
        /// <summary>
        /// The facility that the rule applies to
        /// </summary>
        public int? FacilityId { get; set; }
    }
}
