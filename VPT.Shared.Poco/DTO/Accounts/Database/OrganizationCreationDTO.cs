using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Data;
using VPT.Shared.Poco.Model.Accounts.Database;

namespace VPT.Shared.Poco.DTO.Accounts.Database
{
    public class OrganizationCreationDTO
    {
        public string OrganizationName { get; set; }
        public string OrganizationDisplayName { get; set; }
        public string OrganizationDescription { get; set; }
        public string APIVPTURL { get; set; }
        public int SKUID { get; set; }
        public string Auth0Email { get; set; }
        public JObject Organization { get; set; }
        public AdminUser AdminUser { get; set; }
    }

    public class OrganizationCreationSPResult
    {
        public OrganizationCreationSPResult() { }

        public int OrganizationId { get; set; }

        public int PersonId { get; set; }

    }

    public class OrganizationCreationSPParamDTO
    {
        public OrganizationCreationSPParamDTO()
        {

        }

        public OrganizationCreationSPParamDTO(OrganizationCreationDTO organizationConfiguration, string userId)
        {
            Auth0userId = userId;
            OrganizationName = organizationConfiguration.OrganizationName;
            OrganizationDisplayName = organizationConfiguration.OrganizationDisplayName;
            OrganizationDescription = organizationConfiguration.OrganizationDescription;
            var json = JsonConvert.SerializeObject(organizationConfiguration.Organization);
            DictonaryList = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
        }
        public int OrganizationId { get; set; }
        public string OrganizationName { get; set; }
        public string OrganizationDisplayName { get; set; }
        public string OrganizationDescription { get; set; }
        public int PersonId { get; set; }
        public string Auth0userId { get; set; }
        public DataTable List { get; set; }
        public Dictionary<string, string> DictonaryList = new Dictionary<string, string>();
    }

    public class NotificationCreationSPParamDTO
    {
        public NotificationCreationSPParamDTO()
        {

        }
        public NotificationCreationSPParamDTO(OrganizationCreationSPResult organizationDetails)
        {
            OrganizationId = organizationDetails.OrganizationId;
        }
        public int OrganizationId { get; set; }
    }

    public class AssessmentAccountCreationDTO
    {
        public AssessmentAccountCreationDTO(OrganizationCreationDTO dto, string userID, OrganizationCreationSPResult organizationDetails, string password)
        {
            OrganizationId = organizationDetails.OrganizationId;
            OrganizationName = dto.OrganizationName;
            Token = dto.Organization["Token"].ToString();
            Auth0userName = dto.AdminUser.Username;
            Auth0userId = userID;
            Auth0Password = password;
            Auth0Email = dto.AdminUser.Email;
            AITIntegrationServerUrl = dto.Organization["IntegrationAPIUrl"].ToString();
            APIVPTURL = dto.APIVPTURL;
            LoginSystem = int.Parse(dto.Organization["LoginSystem"].ToString());
            SKUID = dto.SKUID;
        }
        public int OrganizationId { get; set; }
        public string OrganizationName { get; set; }
        public string Token { get; set; }
        public string Auth0userName { get; set; }
        public string Auth0userId { get; set; }
        public string Auth0Password { get; set; }
        public string Auth0Email { get; set; }
        public string AITIntegrationServerUrl { get; set; }
        public string APIVPTURL { get; set; }
        public int LoginSystem { get; set; }
        public int SKUID { get; set; }
    }
}
