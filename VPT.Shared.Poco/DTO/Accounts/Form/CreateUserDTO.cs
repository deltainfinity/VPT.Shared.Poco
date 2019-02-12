using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using VPT.Shared.Poco.DTO.Accounts.Aggregate;
using VPT.Shared.Poco.DTO.Accounts.Database;
using VPT.Shared.Poco.Enum.Accounts;
using VPT.Shared.Poco.Model.Accounts.Database;

namespace VPT.Shared.Poco.DTO.Accounts.Form
{
    public class CreateUserDTO
    {

        public CreateUserDTO()
        {
            PersonAddress = new List<AddressDTO>();
        }

        public CreateUserDTO(ExternalUserDetailsDTO externalUserDetails, ExternalID externalUser, Group group)
            : this(externalUserDetails, externalUser.OrganizationID, externalUser.Value, group)
        { }

        public CreateUserDTO(ExternalUserDetailsDTO externalUserDetails, int organizationID, string externalUserID, Group group)
        {
            if (externalUserDetails == null)
            {
                throw new ArgumentNullException("externalUserDetails");
            }

            if (organizationID <= 0)
            {
                throw new IndexOutOfRangeException("Organization ID must be a positive non-zero integer.");
            }

            if (string.IsNullOrWhiteSpace(externalUserID))
            {
                throw new ArgumentNullException("externalUserID");
            }

            if (group == null)
            {
                throw new ArgumentNullException("group");
            }

            SorID = externalUserID.Trim();
            SourceOrganizationID = organizationID;

            FirstName = !string.IsNullOrWhiteSpace(externalUserDetails.FirstName) ? externalUserDetails.FirstName.Trim() : string.Empty;
            MiddleName = !string.IsNullOrWhiteSpace(externalUserDetails.MiddleName) ? externalUserDetails.MiddleName.Trim() : string.Empty;
            LastName = !string.IsNullOrWhiteSpace(externalUserDetails.LastName) ? externalUserDetails.LastName.Trim() : string.Empty;
            Phone = !string.IsNullOrWhiteSpace(externalUserDetails.Phone) ? externalUserDetails.Phone.Trim() : string.Empty;
            Email = !string.IsNullOrWhiteSpace(externalUserDetails.EmailAddress) ? externalUserDetails.EmailAddress.Trim() : string.Empty;
            Title = !string.IsNullOrWhiteSpace(externalUserDetails.PositionTitle) ? externalUserDetails.PositionTitle.Trim() : string.Empty;
            BirthDate = externalUserDetails.BirthDate;
            Cell = !string.IsNullOrWhiteSpace(externalUserDetails.CellPhoneNumber) ? externalUserDetails.CellPhoneNumber.Trim() : string.Empty;

            GroupID = group.GroupID;
            GroupName = group.Name;

            FacilityCode = !string.IsNullOrWhiteSpace(externalUserDetails.UserSiteId) ? externalUserDetails.UserSiteId.Trim() : string.Empty;
        }

        public CreateUserDTO(ExternalSubjectDetailsDTO externalSubjectDetails, ExternalID externalSubject, Group group)
            : this(externalSubjectDetails, externalSubject.OrganizationID, externalSubject.Value, group)
        { }

        public CreateUserDTO(ExternalSubjectDetailsDTO externalSubjectDetails, int organizationID, string externalSubjectID, Group group)
        {
            if (externalSubjectDetails == null)
            {
                throw new ArgumentNullException("externalSubjectDetails");
            }

            if (organizationID <= 0)
            {
                throw new IndexOutOfRangeException("Organization ID must be a positive non-zero integer.");
            }

            if (string.IsNullOrWhiteSpace(externalSubjectID))
            {
                throw new ArgumentNullException("externalUserID");
            }

            if (group == null)
            {
                throw new ArgumentNullException("group");
            }

            SorID = externalSubjectID.Trim();
            SourceOrganizationID = organizationID;

            FirstName = !string.IsNullOrWhiteSpace(externalSubjectDetails.FirstName) ? externalSubjectDetails.FirstName.Trim() : string.Empty;
            MiddleName = !string.IsNullOrWhiteSpace(externalSubjectDetails.MiddleName) ? externalSubjectDetails.MiddleName.Trim() : string.Empty;
            LastName = !string.IsNullOrWhiteSpace(externalSubjectDetails.LastName) ? externalSubjectDetails.LastName.Trim() : string.Empty;
            Phone = !string.IsNullOrWhiteSpace(externalSubjectDetails.Phone) ? externalSubjectDetails.Phone.Trim() : string.Empty;
            Email = !string.IsNullOrWhiteSpace(externalSubjectDetails.Email) ? externalSubjectDetails.Email.Trim() : string.Empty;
            BirthDate = externalSubjectDetails.DOB;

            GenderID = (int)Gender.Unspecified;
            if (externalSubjectDetails.Gender.ToUpper() == "M" || externalSubjectDetails.Gender.ToUpper() == "MALE")
            {
                GenderID = (int)Gender.Male;
            }
            else if (externalSubjectDetails.Gender.ToUpper() == "F" || externalSubjectDetails.Gender.ToUpper() == "FEMALE")
            {
                GenderID = (int)Gender.Female;
            }

            RaceID = externalSubjectDetails.Ethnicity;
            GroupName = group.Name;
            GroupID = group.GroupID;
        }

        public CreateUserDTO(string username, string password, string firstName, string lastName, int organizationID, string email, string middleName = "")
        {
            Username = username;
            Password = password;
            FirstName = firstName.Trim();
            LastName = lastName.Trim();
            MiddleName = middleName.Trim();
            SourceOrganizationID = organizationID;
            Email = email;
        }

        public CreateUserDTO(PersonDetailsDTO person)
        {
            if (person.Contacts.Any())
            {
                var primaryEmail = person.Contacts.FirstOrDefault(c => c.Primary && c.TypeID == (int)ContactType.Email);
                Email = primaryEmail != null ? primaryEmail.Value : string.Empty;

                var phone = person.Contacts.FirstOrDefault(c => c.TypeID == (int)ContactType.Phone);
                Phone = phone != null ? phone.Value.Replace("-", string.Empty) : string.Empty;

                var cell = person.Contacts.FirstOrDefault(c => c.TypeID == (int)ContactType.Mobile);
                Cell = cell != null ? cell.Value.Replace("-", string.Empty) : string.Empty;

                var secondaryEmail = person.Contacts.FirstOrDefault(c => c.TypeID == (int)ContactType.SecondaryEmail);
                SecondaryEmail = secondaryEmail != null ? secondaryEmail.Value : string.Empty;
            }

            SourceOrganizationID = person.SourceOrganizationID;

            FirstName = person.FirstName;
            MiddleName = person.MiddleName;
            LastName = person.LastName;
            Title = person.Title;
            BirthDate = person.BirthDate;
            GenderID = person.GenderID;
            RaceID = person.RaceID;
            ImageSrc = person.ImageSrc;
            GroupID = person.Groups.FirstOrDefault().GroupID;
            GroupName = person.Groups.FirstOrDefault().DisplayName;
            Auth0UserID = person.Auth0UserID;
            PhysicalAddress = person.PersonAddress;
            MailingAddress = person.MailingAddress;
            PersonID = person.PersonID;
        }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("sourceOrganizationID")]
        public int SourceOrganizationID { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("middleName")]
        public string MiddleName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("birthDate")]
        public DateTime? BirthDate { get; set; }

        [JsonProperty("genderID")]
        public int GenderID { get; set; }

        [JsonProperty("raceID")]
        public int RaceID { get; set; }

        [JsonProperty("personID")]
        public int PersonID { get; set; }

        [JsonProperty("groupID")]
        public int GroupID { get; set; }

        //for Group Name
        [JsonProperty("groupName")]
        public string GroupName { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("cell")]
        public string Cell { get; set; }

        [JsonProperty("secondaryEmail")]
        public string SecondaryEmail { get; set; }

        [JsonProperty("imageURL")]
        public string ImageURL { get; set; }

        [JsonProperty("estimatedReleaseDate")]
        public DateTime EstimatedReleaseDate { get; set; }

        [JsonProperty("facilityID")]
        public int FacilityID { get; set; }

        [JsonProperty("imageSrc")]
        public string ImageSrc { get; set; }

        [JsonProperty("auth0UserID")]
        public string Auth0UserID { get; set; }

        [JsonProperty("raceName")]
        public string RaceName => RaceConstants.GetByEnum(RaceID);

        [JsonProperty("facilityCode")]
        public string FacilityCode { get; set; }

        [JsonProperty("sorID")]
        public string SorID { get; set; }

        /// <summary>
        /// When new Events API users are created they need this to add information to ExternalSystemUserBridge table
        /// </summary>
        [JsonProperty("addToSystemBridgeOnCreate")]
        public bool AddToSystemBridgeOnCreate { get; set; }

        /// <summary>
        /// CurrentPhysicalAddress
        /// </summary>
        [JsonProperty("currentPhysicalAddress")]
        public bool CurrentPhysicalAddress;

        /// <summary>
        /// CurrentMailingAddress
        /// </summary>
        [JsonProperty("currentMailingAddress")]
        public bool CurrentMailingAddress;

        /// <summary>
        /// HasDifferentMailingAddress
        /// </summary>
        [JsonProperty("hasDifferentMailingAddress")]
        public bool HasDifferentMailingAddress;

        /// <summary>
        /// PersonAddress
        /// </summary>
        [JsonProperty("personAddress")]
        public List<AddressDTO> PersonAddress { get; set; }

        /// <summary>
        /// PhysicalAddress
        /// </summary>
        [JsonProperty("physicalAddress")]
        public AddressDTO PhysicalAddress { get; set; }

        /// <summary>
        /// MailingAddress
        /// </summary>
        [JsonProperty("mailingAddress")]
        public AddressDTO MailingAddress { get; set; }

        /// <summary>
        /// CurrentMailingAddress
        /// </summary>
        [JsonProperty("hasMailingAddress")]
        public bool HasMailingAddress;

        /// <summary>
        /// EmailReasonChanged
        /// </summary>
        [JsonProperty("emailReasonChanged")]
        public string EmailReasonChanged;

        /// <summary>
        /// SecondaryEmailReasonChanged
        /// </summary>
        [JsonProperty("secondaryEmailReasonChanged")]
        public string SecondaryEmailReasonChanged;

        /// <summary>
        /// PhoneReasonChanged
        /// </summary>
        [JsonProperty("phoneReasonChanged")]
        public string PhoneReasonChanged;

        /// <summary>
        /// CellReasonChanged
        /// </summary>
        [JsonProperty("cellReasonChanged")]
        public string CellReasonChanged;
    }
}
