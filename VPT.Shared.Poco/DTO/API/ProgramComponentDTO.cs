using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API
{
    public class ProgramComponentDTO
    {
        public ProgramComponentDTO() { }
        public ProgramComponentDTO(ProgramComponent source)
        {
            ComponentID = source.ComponentID;
            ProgramComponentID = source.ProgramComponentID;
            ParentProgramId = source.ParentProgramId;
        }

        public int OrganizationID { get; set; }
        public int ProgramComponentID { get; set; }

        public int ComponentID { get; set; }

        public int ParentProgramId { get; set; }

        public string ComponentName { get; set; }

        public int SessionNumber { get; set; }

        public decimal SessionLength { get; set; }

        public int IsOpen { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public int MaxGroupSize { get; set; }

        public int MinGroupSize { get; set; }

        public int MinimumDosageRequired { get; set; }

        public string DomainNames { get; set; }
    }
}
