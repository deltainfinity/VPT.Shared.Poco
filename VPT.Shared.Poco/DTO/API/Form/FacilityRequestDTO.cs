using Newtonsoft.Json;
using System;

namespace VPT.Shared.Poco.DTO.API.Form
{
    public class FacilityRequestDTO
    {
        /// <summary>
        /// The id of facility table
        /// </summary>
        [JsonProperty("facilityID")]
        public int FacilityID { get; set; }

        /// <summary>
        /// The id of facility location table
        /// </summary>
        [JsonProperty("facilityLocationID")]
        public int FacilityLocationID { get; set; }

        /// <summary>
        /// The name of facility
        /// </summary>
        [JsonProperty("facilityName")]
        public string FacilityName { get; set; }

        /// <summary>
        /// The Address of facility
        /// </summary>
        [JsonProperty("address1")]
        public string Address1 { get; set; }

        /// <summary>
        /// The Address of facility
        /// </summary>
        [JsonProperty("address2")]
        public string Address2 { get; set; }

        /// <summary>
        /// The City where facility is located.
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// description
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// The facility code of facility
        /// </summary>
        [JsonProperty("facilityCode")]
        public string FacilityCode { get; set; }

        /// <summary>
        /// The State
        /// </summary>
        [JsonProperty("stateCode")]
        public string StateCode { get; set; }
       
        /// <summary>
        /// The zip
        /// </summary>
        [JsonProperty("zip")]
        public string Zip { get; set; }

        /// <summary>
        /// Phone
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// SecurityLevel
        /// </summary>
        [JsonProperty("securityLevel")]
        public string SecurityLevel { get; set; }

        /// <summary>
        /// Date and Time the object was created.
        /// </summary>
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// The person ID of the user that created
        /// </summary>
        public string CreatedByUserID { get; set; }
    }
}
