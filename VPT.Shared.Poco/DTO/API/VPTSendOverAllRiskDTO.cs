using System.Collections.Generic;

namespace VPT.Shared.Poco.DTO.API
{
    /// <summary>
    /// DTO for Risk Level, External ID and OrganizationID
    /// </summary>
    public class VPTSendOverAllRiskDTO
    {
        public VPTSendOverAllRiskDTO(string riskLevel, int offenderID, int organizationID)
        {
            RiskLevel = riskLevel;
            OffenderID = offenderID;
            OrganizationID = organizationID;
        }
        public string RiskLevel { get; set; }
        public int OffenderID { get; set; }
        public int OrganizationID { get; set; }
    }
}
