using NPoco;

namespace VPT.Shared.Poco.Model.API.RulesEngine
{
    [TableName("RulesEngineRuleTypeResultOrgMapping")]
    [PrimaryKey("ID")]
    public class RulesEngineRuleTypeResultOrgMapping
    {
        public RulesEngineRuleTypeResultOrgMapping() { }

        public RulesEngineRuleTypeResultOrgMapping(int ruleTypeResultID,int organizationID,int facilityID) {
            RulesEngineRuleTypeResultID = ruleTypeResultID;
            OrganizationID = organizationID;
            FacilityID = facilityID;
        }

        public int ID { get; set; }
        public int RulesEngineRuleTypeResultID { get; set; }
        public int OrganizationID { get; set; }
        public int FacilityID { get; set; }
    }
}
