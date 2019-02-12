using NPoco;

namespace VPT.Shared.Poco.Model.API.RulesEngine
{
    [TableName("RulesEngineRuleTypeAppliesToOrgMapping")]
    [PrimaryKey("ID")]
    public class RulesEngineRuleTypeAppliesToOrgMapping
    {
        public RulesEngineRuleTypeAppliesToOrgMapping() { }

        public RulesEngineRuleTypeAppliesToOrgMapping(int ruleTypeApplieId, int organizationID,int facilityID)
        {
            RulesEngineRuleTypeAppliesToID = ruleTypeApplieId;
            OrganizationID = organizationID;
            FacilityID = facilityID;
        }

        public int ID { get; set; }
        public int RulesEngineRuleTypeAppliesToID { get; set; }
        public int OrganizationID { get; set; }
        public int FacilityID { get; set; }
    }
}
