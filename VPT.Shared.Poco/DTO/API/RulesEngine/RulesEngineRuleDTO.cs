using VPT.Shared.Poco.Model.API.RulesEngine;

namespace VPT.Shared.Poco.DTO.API.RulesEngine
{
    /// <summary>
    /// Rules engine rule
    /// </summary>
    public class RulesEngineRuleDTO : BaseDTO
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public RulesEngineRuleDTO()
        { }

        /// <summary>
        /// Copy constructor
        /// </summary>
        /// <param name="rulesEngineRule">RulesEngineRule model</param>
        public RulesEngineRuleDTO(RulesEngineRule rulesEngineRule, RuleTypeDTO ruleType) : base(rulesEngineRule)
        {
            RuleId = rulesEngineRule.RuleId;
            Type = ruleType;
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
        public RuleTypeDTO Type { get; set; }
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
        /// List of result objects
        /// </summary>
        public string Result { get; set; }
        /// <summary>
        /// The organization that the rule applies to
        /// </summary>
        public int OrganizationId { get; set; }
        /// <summary>
        /// The facility that the rule applies to, if any
        /// </summary>
        public int? FacilityId { get; set; }
    }
}
