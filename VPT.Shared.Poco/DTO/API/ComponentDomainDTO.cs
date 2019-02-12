using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API
{
    public class ComponentDomainDTO
    {
        public ComponentDomainDTO() { }
        public ComponentDomainDTO(ComponentDomain source)
        {
            ComponentID = source.ComponentID;
            ComponentDomainID = source.ComponentDomainID;
            DomainID = source.DomainID;
        }
        public int ComponentDomainID { get; set; }

        public int ComponentID { get; set; }

        public int DomainID { get; set; }        

    }
}