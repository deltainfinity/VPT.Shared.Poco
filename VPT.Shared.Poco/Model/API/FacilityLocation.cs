﻿using NPoco;
using VPT.Shared.Poco.DTO.API;

namespace VPT.Shared.Poco.Model.API
{
    [TableName("FacilityLocation")]
    [PrimaryKey("FacilityLocationId")]
    /// <summary>
    /// Class for representing a entity's physical location
    /// </summary>
    public class FacilityLocation
    {
        public FacilityLocation()
        { }

        public FacilityLocation(FacilityLocationDTO source)
        {
            FacilityLocationId = source.FacilityLocationId;
            FacilityID = source.FacilityID;
            Address1 = source.Address1;
            Address2 = source.Address2;
            City = source.City;
            State = source.State;
            PostalCode = source.PostalCode;
            Phone = source.Phone;
            SecurityLevel = source.SecurityLevel;
        }

        public int FacilityLocationId { get; set; }
        public int FacilityID { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public string SecurityLevel { get; set; }
    }

}
