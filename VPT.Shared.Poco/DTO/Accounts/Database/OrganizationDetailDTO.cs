using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPT.Shared.Poco.DTO.Accounts.Database
{
public class OrganizationDetailDTO
    {
        public string OrganizationName { get; set; }
        public string OrganizationDisplayName { get; set; }
        public string OrganizationDescription { get; set; }
        public string EmailProvider { get; set; }
        public string Auth0userName { get; set; }
        public string Auth0userId { get; set; }
        public string Auth0Password { get; set; }
        public string Auth0Email { get; set; }
        public string LegalCodeLabel { get; set; }
        public string IntegratedOrganization { get; set; }
        public string AITIntegratedClient { get; set; }
        public string AITIntegrationServerUrl { get; set; }
        public string APIVPTURL { get; set; }
        public string APILMSURL { get; set; }
        public string APIAssessmentsEngineURL { get; set; }
        public string Token { get; set; }
        public int OrganizationId { get; set; }
        public int PersonId { get; set; }
        public int SKUID { get; set; }
        public int LoginSystem { get; set; }
        public string SystemOfRecordName { get; set; }
        public string ReasonForAssessment { get; set; }
    }
}
