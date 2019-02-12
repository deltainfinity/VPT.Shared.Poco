using System;
using System.Linq;
using VPT.Accounts.Shared.DTO.Aggregate;

namespace VPT.Shared.Poco.DTO.API.Tether
{
    /// <summary>
    /// Details about a member of a subject's caregroup
    /// </summary>
    public class CaregroupMemberDTO
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public CaregroupMemberDTO()
        {}

        /// <summary>
        /// Copy constructor.
        /// IsActive is not set using this constructor.
        /// </summary>
        /// <param name="careGroupMemberDetails">Person details for the care group member</param>
        public CaregroupMemberDTO(PersonDetailsDTO careGroupMemberDetails)
        {
            PersonId = careGroupMemberDetails.PersonID;
            OrganizationId = careGroupMemberDetails.SourceOrganizationID;
            PersonGuid = careGroupMemberDetails.PersonGUID;
            FirstName = careGroupMemberDetails.FirstName;
            LastName = careGroupMemberDetails.LastName;
            var group = careGroupMemberDetails.Groups.FirstOrDefault();
            if (group != null)
            {
                GroupName = group.DisplayName;
            }
        }

        /// <summary>
        /// The person ID of the caregroup member (userID)
        /// </summary>
        public int PersonId { get; set; }

        /// <summary>
        /// The organization ID of the organization that the user is associated with
        /// </summary>
        public int OrganizationId { get; set; }

        /// <summary>
        /// The person GUID of the caregroup member
        /// </summary>
        public Guid PersonGuid { get; set; }

        /// <summary>
        /// The first name of the caregroup member
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of the caregroup member
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The group name of the caregroup member's group
        /// </summary>
        public string GroupName { get; set; }

        /// <summary>
        /// Is the user an active part of the subject's caregroup?
        /// </summary>
        public bool IsActive { get; set; }
    }
}
