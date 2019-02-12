using Newtonsoft.Json;

namespace VPT.Shared.Poco.DTO.API.Aggregate
{
    public class PersonDetailsAggregateDTO :PersonDetailsDTO
    {
        public PersonDetailsAggregateDTO(string facilityCode,PersonDetailsDTO persondetails)
        {
            FullNameFirstNameFirstFormat = persondetails.FullNameFirstNameFirstFormat;
            ImageSrc = persondetails.ImageSrc;
            PersonID = persondetails.PersonID;
            Groups = persondetails.Groups;
            ExternalIDs = persondetails.ExternalIDs;
            Auth0UserID = persondetails.Auth0UserID;
            FacilityCode = facilityCode;
            

        }

        /// <summary>
        /// The facility ID of subject
        /// </summary>
        [JsonProperty("facilityCode")]
        public string FacilityCode { get; set; }
        /// <summary>
        /// The full name of person
        /// </summary>
        [JsonProperty("fullNameFirstNameFirstFormat")]
        public string FullNameFirstNameFirstFormat { get; set; }




    }
}
