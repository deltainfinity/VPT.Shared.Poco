using Newtonsoft.Json;
using VPT.Shared.Poco.Model.Accounts.Database;

namespace VPT.Shared.Poco.DTO.Accounts.Database
{
    public class OrganizationSiteMappingDTO 
    {
        public OrganizationSiteMappingDTO()
        { }

        public OrganizationSiteMappingDTO(OrganizationSiteMapping source)
        {
            OrganizationSiteMappingID = source.OrganizationSiteMappingID;
            OrganizationID = source.OrganizationID;
            SiteID = source.SiteID;
            LMSUrl = source.LMSUrl;
        }

        [JsonProperty("organizationSiteMappingID")]
        public int OrganizationSiteMappingID { get; set; }

        [JsonProperty("organizationID")]
        public int OrganizationID { get; set; }

        [JsonProperty("siteID")]
        public string SiteID { get; set; }

        [JsonProperty("LMSUrl")]
        public string LMSUrl { get; set; }
    }
}
