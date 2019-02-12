using NPoco;
using VPT.Shared.Poco.DTO.API;

namespace VPT.Shared.Poco.Model.API
{
    /// <summary>
    /// Class for representing a entity's physical location
    /// </summary>
    [TableName("Location")]
    [PrimaryKey("LocationId")]
    public class Location : BaseModel
    {
        public Location()
        { }

        public Location(LocationDTO source)
            : base(source)
        {
            LocationId = source.LocationId;
            Name = source.Name;
            Type = source.Type;
            Address1 = source.Address1;
            Address2 = source.Address2;
            City = source.City;
            State = source.State;
            PostalCode = source.PostalCode;
            County = source.County;
            Country = source.Country;
            Email = source.Email;
            Fax = source.Fax;
            Phone = source.Phone;
            ExternalId = source.ExternalId;
            Description = source.Description;
            Website = source.Website;
            SupervisorUserID = source.SupervisorUserID;
        }

        public int LocationId { get; set; }

        public string Name { get; set; }

        public int Type { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string PostalCode { get; set; }

        public string County { get; set; }

        public string Country { get; set; }

        public string Email { get; set; }

        public string Fax { get; set; }

        public string Phone { get; set; }

        public string ExternalId { get; set; }

        public string Description { get; set; }

        public string Website { get; set; }

        public string SupervisorUserID { get; set; }
    }
}
