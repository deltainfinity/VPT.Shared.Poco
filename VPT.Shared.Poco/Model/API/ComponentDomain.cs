using NPoco;
using VPT.Shared.Poco.DTO.API;

namespace VPT.Shared.Poco.Model.API
{
    [TableName("ComponentDomain")]
    [PrimaryKey("ComponentDomainID")]
    public class ComponentDomain
    {
        public ComponentDomain()
        { }

        public ComponentDomain(ComponentDomainDTO source)
        {
            ComponentDomainID = source.ComponentDomainID;
            ComponentID = source.ComponentID;
            DomainID = source.DomainID;
        }

        /// <summary>
        /// The ID of the component domian
        /// </summary>
        public int ComponentDomainID { get; set; }

        /// <summary>
        /// The ID of the component
        /// </summary>
        public int ComponentID { get; set; }

        /// <summary>
        /// The ID of domain
        /// </summary>
        public int DomainID { get; set; }
    }
}
