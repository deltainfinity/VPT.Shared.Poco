using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API
{
    public class ComponentDTO 
    {
        public ComponentDTO() { }
        public ComponentDTO(Component source)
        {
            ComponentID = source.ComponentID;
            ComponentName = source.ComponentName;
            SessionNumber = source.SessionNumber;
            SessionLength = source.SessionLength;           
            Deleted = source.Deleted;
            MinGroupSize = source.MinGroupSize;
            MaxGroupSize = source.MaxGroupSize;
            IsOpen = source.IsOpen;
            StartDate = source.StartDate;
            EndDate = source.EndDate;
            IsReusable = source.IsReusable;
            IsOptional = source.IsOptional;
        }


        public int ComponentID { get; set; }

        public string ComponentName { get; set; }

        public int SessionNumber { get; set; }

        public decimal SessionLength { get; set; }        

        public bool Deleted { get; set; }

        public int MinGroupSize { get; set; }

        public int MaxGroupSize { get; set; }

        public int IsOpen { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public List<Tag> DomainList { get; set; }

        public string DomainNames { get; set; }

        public bool IsReusable { get; set; }

        public bool IsOptional { get; set; }

    }
}
