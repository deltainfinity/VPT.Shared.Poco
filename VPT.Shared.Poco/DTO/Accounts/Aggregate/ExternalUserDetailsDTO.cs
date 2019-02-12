using System;
using VPT.Shared.Poco.DTO.Accounts.Form;

namespace VPT.Shared.Poco.DTO.Accounts.Aggregate
{
    /// <summary>
    /// Aggregate object containing all data related to a person
    /// </summary>
    public class ExternalUserDetailsDTO //: PersonDTO
    {
        /// <summary>
        /// Public Constructor
        /// </summary>
        public ExternalUserDetailsDTO()
        { }

        public ExternalUserDetailsDTO(ExternalUserDetailsDTO externalUser)
        {
            UserPermissionsGroup = externalUser.UserPermissionsGroup;
            FirstName = externalUser.FirstName;
            MiddleName=externalUser.MiddleName;
            LastName = externalUser.LastName;
            StatusId = externalUser.StatusId;
            PositionTitle = externalUser.PositionTitle;
            EmailAddress = externalUser.EmailAddress;
            Address1 = externalUser.Address1;
            Address2 = externalUser.Address2;
            City = externalUser.City;
            State = externalUser.State;
            Zip = externalUser.Zip;
            County = externalUser.County;
            Phone = externalUser.Phone;
            CellPhoneNumber = externalUser.CellPhoneNumber;
            Fax = externalUser.Fax;
            BirthDate = externalUser.BirthDate;
            UserAuthLevel = externalUser.UserAuthLevel < 1 ? 1 : externalUser.UserAuthLevel;

        }

        public ExternalUserDetailsDTO(CreateUserDTO externalUser)
        {
            UserPermissionsGroup = externalUser.GroupName;
            FirstName = externalUser.FirstName;
            LastName = externalUser.LastName;
            MiddleName = externalUser.MiddleName;
            EmailAddress = externalUser.Email;
            Phone = externalUser.Phone;
            BirthDate = externalUser.BirthDate;
            UserAuthLevel = 1;
        }
      
        public string UserPermissionsGroup { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public int StatusId { get; set; }
        public string PositionTitle { get; set; }
        public string EmailAddress { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string County { get; set; }
        public string Phone { get; set; }
        public string CellPhoneNumber { get; set; }
        public string Fax { get; set; }
        public string UserSiteId { get; set; }
        public int UserAuthLevel { get; set; }
        public DateTime? BirthDate { get; set; }

    }
}
