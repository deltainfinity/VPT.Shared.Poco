using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VPT.Shared.Poco.Model.Accounts.Database;

namespace VPT.Shared.Poco.DTO.Accounts.Database
{
    public class ConfigurationDTO
    {
        public string OrganizationName { get; set; }
        public string OrganizationDisplayName { get; set; }
        public string OrganizationDescription { get; set; }
        public string EmailProvider { get; set; }
        public string LegalCodeLabel { get; set; }
        public string IntegratedOrganization { get; set; }
        public string AITIntegratedClient { get; set; }
        public string AITIntegrationServerUrl { get; set; }
        public string APIVPTURL { get; set; }
        public string APILMSURL { get; set; }
        public string APIAssessmentsEngineURL { get; set; }
        public int OrganizationId { get; set; }
        public int SKUID { get; set; }
        public int LoginSystem { get; set; }
        public string SystemOfRecordName { get; set; }
        public string ReasonForAssessment { get; set; }
        public AdminUser AdminUser { get; set; }

    }

   

}
