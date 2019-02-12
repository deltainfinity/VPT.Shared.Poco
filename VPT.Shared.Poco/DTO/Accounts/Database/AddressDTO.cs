using Newtonsoft.Json;
using VPT.Shared.Poco.Model.Accounts.Database;

namespace VPT.Shared.Poco.DTO.Accounts.Database
{
    public class AddressDTO : BaseDatabaseDTO
    {
        public AddressDTO()
        { }

        public AddressDTO(Address source)
            : base(source)
        {
            AddressID = source.AddressID;
            Address1 = source.Address1;
            Address2 = source.Address2;
            City = source.City;
            State = source.State;
            ZipCode = source.ZipCode;
            County = source.County;
            Country = source.Country;
            IsOutsideUSAddress = source.IsOutsideUSAddress;
        }

        /// <summary>
        /// AddressID
        /// </summary>
        [JsonProperty("addressID")]
        public int AddressID { get; set; }

        /// <summary>
        /// Address1
        /// </summary>
        [JsonProperty("address1")]
        public string Address1 { get; set; }

        /// <summary>
        /// Address2
        /// </summary>
        [JsonProperty("address2")]
        public string Address2 { get; set; }

        /// <summary>
        /// City
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// State
        /// </summary>
        [JsonProperty("state")]
        public string State { get; set; }

        /// <summary>
        /// ZipCode
        /// </summary>
        [JsonProperty("zipCode")]
        public string ZipCode { get; set; }

        /// <summary>
        /// County
        /// </summary>
        [JsonProperty("county")]
        public string County { get; set; }

        /// <summary>
        /// Country
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// Type
        /// </summary>
        [JsonProperty("type")]
        public int Type { get; set; }

        /// <summary>
        /// IsOutsideUSAddress
        /// </summary>
        [JsonProperty("IsOutsideUSAddress")]
        public bool IsOutsideUSAddress { get; set; }
    }
}
