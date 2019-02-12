using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using VPT.Shared.Poco.DTO.Accounts.Database;
using VPT.Shared.Poco.Model.Accounts.Database;

namespace VPT.Shared.Poco.DTO.Accounts.Aggregate
{
    /// <summary>
    /// Aggregate object containing all data related to a person
    /// </summary>
    public class PersonDetailsDTO : PersonDTO
    {
        /// <summary>
        /// Public Constructor
        /// </summary>
        public PersonDetailsDTO()
        { }

        /// <summary>
        /// Copy constructor used to populate the object
        /// </summary>
        /// <param name="source">The source Person entity for the DTO</param>
        /// <param name="contacts">The list of contacts for the Person</param>
        /// <param name="externalIDs">The list of external IDs for the person</param>
        /// <param name="groups">The list of Groups the person belongs too</param>        
        public PersonDetailsDTO(Person source, IList<Contact> contacts, IList<ExternalID> externalIDs, IList<Group> groups, IList<Permission> permissions, IList<OrganizationGroup> organizationgroups,IList<int> trustedorganizationsIDs, GroupDashboard groupDashboard, List<GroupProperty> groupProperties, string externalUserID, string image, IList<UserCustomProperty> userCustomProperties, Address personAddress = null, string companyName = null, Address mailingAddress =null)
            : base(source, image)
        {
            Contacts = new List<ContactDTO>();
            if (contacts != null && contacts.Any())
            {
                foreach (var contact in contacts)
                {
                    Contacts.Add(new ContactDTO(contact));
                }
            }

            ExternalIDs = new List<ExternalIDDTO>();
            if (externalIDs != null && externalIDs.Any())
            {
                foreach (var externalID in externalIDs)
                {
                    ExternalIDs.Add(new ExternalIDDTO(externalID));
                }
            }

            UserCustomProperties = new List<UserCustomPropertyDTO>();
            if (userCustomProperties != null && userCustomProperties.Any())
            {
                foreach (var customProperty in userCustomProperties)
                {
                    UserCustomProperties.Add(new UserCustomPropertyDTO(customProperty));
                }
            }

            Groups = new List<GroupDTO>();
            if (groups != null && groups.Any())
            {
                foreach (var group in groups)
                {
                    var organizationGroup = organizationgroups.Where(x => x.GroupID == group.GroupID && x.OrganizationID == source.SourceOrganizationID);
                    var groupDisplayName = organizationGroup.Count() > 0 ? organizationGroup.SingleOrDefault().DisplayName : null;
                    Groups.Add(new GroupDTO(group, groupDisplayName));                    
                }
            }

            Permissions = new List<PermissionDTO>();
            if (permissions != null && permissions.Any())
            {
                foreach (var permission in permissions)
                {
                    Permissions.Add(new PermissionDTO(permission));
                }
            }
            TrustedOrganizationsIDs = trustedorganizationsIDs;

            PersonAddress = new AddressDTO();
            if (personAddress != null)
            {
               PersonAddress = new AddressDTO(personAddress);  
            }

            MailingAddress = new AddressDTO();
            if (mailingAddress != null)
            {
                MailingAddress = new AddressDTO(mailingAddress);
            }

            GroupDashboard = new GroupDashboardDTO();
            if (groupDashboard != null)
            {
                GroupDashboard = new GroupDashboardDTO(groupDashboard);
            }

            GroupProperties = new List<GroupPropertyDTO>();
            if (groupProperties != null && groupProperties.Any())
            {
                foreach (var groupProperty in groupProperties)
                {
                    GroupProperties.Add(new GroupPropertyDTO(groupProperty));
                }
            }

            ExternalUserID = externalUserID;
            CompanyName = companyName;
        }

        /// <summary>
        /// List of contact records for the person
        /// </summary>
        [JsonProperty("contacts")]
        public IList<ContactDTO> Contacts { get; set; }

        /// <summary>
        /// List of external IDs for the person
        /// </summary>
        [JsonProperty("externalIDs")]
        public IList<ExternalIDDTO> ExternalIDs { get; set; }

        /// <summary>
        /// List of user custom properties for the person
        /// </summary>
        [JsonProperty("userCustomProperties")]
        public IList<UserCustomPropertyDTO> UserCustomProperties { get; set; }

        /// <summary>
        /// List of groups for the person
        /// </summary>
        [JsonProperty("groups")]
        public IList<GroupDTO> Groups { get; set; }

        /// <summary>
        /// List of permissions for the person
        /// </summary>
        [JsonProperty("permissions")]
        public IList<PermissionDTO> Permissions { get; set; }
        /// <summary>
        /// List of trusted organizations
        /// </summary>
        [JsonProperty("trustedOrgnaizationsID")]
        public IList<int> TrustedOrganizationsIDs { get; set; }

        public string Path { get; set; }
        public string OrganizationName { get; set; }

        public AddressDTO PersonAddress { get; set; }

        /// <summary>
        /// groupDashboard
        /// </summary>
        [JsonProperty("groupDashboard")]
        public GroupDashboardDTO GroupDashboard { get; set; }

        [JsonProperty("groupProperties")]
        public List<GroupPropertyDTO> GroupProperties { get; set; }

        [JsonProperty("externalUserID")]
        public string ExternalUserID { get; set; }

        [JsonProperty("companyName")]
        public string CompanyName { get; set; }

        [JsonProperty("mailingAddress")]
        public AddressDTO MailingAddress { get; set; }

        public string GetExternalIDValue(PersonDetailsDTO personDetails, string type)
        {
            string externalIDValue = personDetails.ExternalIDs.Where(x => x.Type == type).Count() > 0 ? personDetails.ExternalIDs.Where(x => x.Type == type).FirstOrDefault().Value : null;
            return externalIDValue;
        }
    }
}
