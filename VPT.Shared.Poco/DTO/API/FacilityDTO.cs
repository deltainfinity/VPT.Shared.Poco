using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API
{
    public class FacilityDTO : BaseDTO
    {
        public FacilityDTO()
        { }


        public FacilityDTO(Facility source)
        {
            FacilityID = source.FacilityID;
            FacilityCode = source.FacilityCode;
            FacilityName = source.FacilityName;
            Description = source.Description;
            OrganizationID = source.OrganizationID;
        }

        public int FacilityID { get; set; }

        public string FacilityName { get; set; }

        public string FacilityCode { get; set; }

        public string Description { get; set; }

        public int OrganizationID { get; set; }
    }
}
