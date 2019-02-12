using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using VPT.Shared.Poco.DTO.API.Form;
using VPT.Accounts.Shared.DTO.Aggregate;
using VPT.Accounts.Shared.Enum;
using VPT.Accounts.Shared.DTO.Form;
using System;
using VPT.Accounts.Shared.DTO.Database;

namespace VPT.Shared.Poco.DTO.API
{
    public class AgentDTO
    {
        public CreateUserDTO updatedUser;

        public AgentDTO()
        { }

        public AgentDTO(PersonDetailsDTO person)
        {
            /*
             * Sourced from VPT Accounts person data
             */
            SourceOrganizationID = person.SourceOrganizationID;
            AgentUserID = person.PersonID;
            Auth0UserID = person.Auth0UserID;
            AgentPersonID = person.PersonID;
            FirstName = person.FirstName;
            MiddleName = person.MiddleName;
            LastName = person.LastName;
            Title = person.Title;
            BirthDate = person.BirthDate.HasValue ? person.BirthDate.Value : (DateTime?)null;
            GenderID = person.GenderID;
            RaceID = person.RaceID;
            ImageURL = person.ImageURL;
            ImageSrc = person.ImageSrc;
            OrganizationName = person.OrganizationName;
            ExternalUserID = person.ExternalUserID;
            CompanyName = person.CompanyName;
            PhysicalAddress = person.PersonAddress;
            MailingAddress = person.MailingAddress;
            if (person.Contacts.Any())
            {
                var primaryEmail = person.Contacts.FirstOrDefault(c => c.Primary && c.TypeID == (int)ContactType.Email);
                PrimaryEmail = primaryEmail != null ? primaryEmail.Value : string.Empty;

                var phone = person.Contacts.FirstOrDefault(c => c.TypeID == (int)ContactType.Phone);
                Phone = phone != null ? phone.Value : string.Empty;

                var cell = person.Contacts.FirstOrDefault(c => c.TypeID == (int)ContactType.Mobile);
                Cell = cell != null ? cell.Value : string.Empty;

                var secondaryEmail = person.Contacts.FirstOrDefault(c => c.TypeID == (int)ContactType.SecondaryEmail); 
                SecondaryEmail = secondaryEmail != null ? secondaryEmail.Value : string.Empty;
            }
            else
            {
                PrimaryEmail = string.Empty;
            }

            if (person.ExternalIDs.Any())
            {
                var sorExternalID = person.ExternalIDs.FirstOrDefault(e => e.Type == SystemControlledExternalIDType.SystemOfRecord);
                SORExternalID = sorExternalID != null ? sorExternalID.Value : string.Empty;
            }
            else
            {
                SORExternalID = string.Empty;
            }

            Groups = new List<string>();
            foreach (var group in person.Groups)
            {
                Groups.Add(group.DisplayName);
            }


        }

        public AgentDTO(CreateUserDTO updatedUser)
        {
            this.updatedUser = updatedUser;
        }

        /**********************************************************************
         ** Sourced from VPT Accounts Person
         */
        /// <summary>
        /// The agent person id.
        /// </summary>
        [JsonProperty("AgentPersonID")]
        public int AgentPersonID { get; set; }

        /// <summary>
        /// The original organization that created the person.
        /// </summary>
        [JsonProperty("sourceOrganizationID")]
        public int SourceOrganizationID { get; set; }

        /// <summary>
        /// The Auth0 User ID for the agent.
        /// </summary>
        [JsonProperty("agentUserID")]
        public int AgentUserID { get; set; }

        /// <summary>
        /// The Auth0 User ID for the person.
        /// </summary>
        [JsonProperty("auth0UserID")]
        public string Auth0UserID { get; set; }

        /// <summary>
        /// The first name of the person
        /// </summary>
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// The middle name of the person
        /// </summary>
        [JsonProperty("middleName")]
        public string MiddleName { get; set; }

        /// <summary>
        /// The last name of the person
        /// </summary>
        [JsonProperty("lastName")]
        public string LastName { get; set; }

        /// <summary>
        /// The full name of the person in first name first format
        /// </summary>
        [JsonProperty("fullNameFirstNameFirstFormat")]
        public string FullNameFirstNameFirstFormat => FirstName + " " + LastName;


        /// <summary>
        /// The full name of the person in last name first format
        /// </summary>
        [JsonProperty("fullNameLastNameFirstFormat")]
        public string FullNameLastNameFirstFormat => LastName + ", " + FirstName;

        /// <summary>
        /// The Title for the person
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// The optional Birth Date of the person
        /// </summary>
        [JsonProperty("birthDate")]
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// The ID of the gender for this person <see cref="Gender"/> for valid settings
        /// </summary>
        [JsonProperty("genderID")]
        public int GenderID { get; set; }

        /// <summary>
        /// The Name of the gender for this person <see cref="Gender"/> for valid settings
        /// </summary>
        [JsonProperty("genderName")]
        public string GenderName => GenderConstants.GetByEnum(GenderID);

        /// <summary>
        /// The ID of the Race for this person <see cref="Race"/> for valid settings
        /// </summary>
        [JsonProperty("raceID")]
        public int RaceID { get; set; }

        /// <summary>
        /// The Name of the Race for this person <see cref="Race"/> for valid settings
        /// </summary>
        [JsonProperty("raceName")]
        public string RaceName => RaceConstants.GetByEnum(RaceID);

        /// <summary>
        /// The URL to access for the person's picture or avatar image
        /// </summary>
        [JsonProperty("imageURL")]
        public string ImageURL { get; set; }

        /// <summary>
        /// The primary email from the VTP Account Contacts entries
        /// </summary>
        [JsonProperty("email")]
        public string PrimaryEmail { get; set; }

        /// <summary>
        /// The primary SOR External ID from VPT External IDs entries
        /// </summary>
        [JsonProperty("externalID")]
        public string SORExternalID { get; set; }

        /// <summary>
        /// The groups the agent is a member of
        /// </summary>
        [JsonProperty("groups")]
        public IList<string> Groups { get; set; }


        /**********************************************************************
         ** Sourced from VPT Case Mgmt Provider by Service Layer
         */

        [JsonProperty("companyName")]
        public string CompanyName { get; set; }



        /**********************************************************************
         ** Sourced from VPT Case Mgmt by Service Layer
         */

        [JsonProperty("caseloadCount")]
        public int CaseloadCount { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("cell")]
        public string Cell { get; set; }

        [JsonProperty("secondaryEmail")]
        public string SecondaryEmail { get; set; }

        public string password { get; set; }

        [JsonProperty("imageSrc")]
        public string ImageSrc { get; set; }

        [JsonProperty("organizationName")]
        public string OrganizationName { get; set; }

        [JsonProperty("facility")]
        public FacilityRequestDTO Facility { get; set; }
        
        [JsonProperty("externalUserID")]
        public string ExternalUserID { get; set; }

        [JsonProperty("estimatedReleaseDate")]
        public DateTime EstimatedReleaseDate { get; set; }

        [JsonProperty("physicalAddress")]
        public AddressDTO PhysicalAddress { get; set; }

        [JsonProperty("mailingAddress")]
        public AddressDTO MailingAddress { get; set; }


        [JsonProperty("careGroupType")]
        public int CareGroupType { get; set; }

        [JsonProperty("expireDate")]
        public DateTime? ExpireDate { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

    }
}

