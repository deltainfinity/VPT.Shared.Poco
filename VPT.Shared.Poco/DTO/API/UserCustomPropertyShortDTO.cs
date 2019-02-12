using Newtonsoft.Json;
using System.Collections.Generic;

namespace VPT.Shared.Poco.Model.API
{
    public class UserCustomPropertyShortDTO
    {
        public UserCustomPropertyShortDTO()
        { }

        public UserCustomPropertyShortDTO(IList<UserCustomPropertyDTO> customProperty)
        {
            foreach(var property in customProperty)
            {
                if (property.Type.Equals(UserCustomPropertyFields.Facility))
                    Facility = property.Value;
                if (property.Type.Equals(UserCustomPropertyFields.HousingUnit))
                    HousingUnit= property.Value;
                if (property.Type.Equals(UserCustomPropertyFields.DateReceived))
                    DateReceived = property.Value;

            }
        }

        /// <summary>
        /// Facility from NDCS field 4
        /// </summary>
        [JsonProperty("facility")]
        public string Facility { get; set; }

        /// <summary>
        /// Housing unit from NDCS field 5
        /// </summary>
        [JsonProperty("housingUnit")]
        public string HousingUnit { get; set; }

        /// <summary>
        /// Date Received from NDCS field 6
        /// </summary>
        [JsonProperty("dateReceived")]
        public string DateReceived { get; set; }


    }

}
