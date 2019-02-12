using VPT.Shared.Poco.Model.API.RulesEngine;

namespace VPT.Shared.Poco.DTO.API.RulesEngine
{
    public class RuleTypeDTO:BaseDTO
    {
        public RuleTypeDTO() { }

        public RuleTypeDTO(RuleType ruleType):base()
        {
            RuleTypeID = ruleType.RuleTypeID;
            Name = ruleType.Name;
            Description = ruleType.Description;
        }

        public int RuleTypeID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
