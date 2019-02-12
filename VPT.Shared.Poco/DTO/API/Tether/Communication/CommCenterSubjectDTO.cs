using System;
using System.Linq;
using VPT.Accounts.Shared.DTO.Aggregate;
using VPT.Accounts.Shared.Enum;

namespace VPT.Shared.Poco.DTO.API.Tether.Communication
{
    public class CommCenterSubjectDTO
    {
        public CommCenterSubjectDTO() { }
        public CommCenterSubjectDTO(PersonDetailsDTO source)
        {
            SubjectUserId = source.PersonID;
            FirstName = source.FirstName;
            LastName = source.LastName;
            Email = source.Contacts.FirstOrDefault(x => x.TypeID == (int)ContactType.Email) != null ? source.Contacts.FirstOrDefault(x => x.TypeID == (int)ContactType.Email).Value : "";
            MobileNumber = source.Contacts.FirstOrDefault(x => x.TypeID == (int)ContactType.Mobile) != null ? source.Contacts.FirstOrDefault(x => x.TypeID == (int)ContactType.Mobile).Value : "";
            SorId = source.ExternalIDs.FirstOrDefault(ex => ex.Type == SystemControlledExternalIDType.SystemOfRecord) != null ? source.ExternalIDs.FirstOrDefault(ex => ex.Type == SystemControlledExternalIDType.SystemOfRecord).Value : "";
            PersonGuid = source.PersonGUID;
        }

        public int SubjectUserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string MobileNumber { get; set; }
        public DateTime DateLastViewed { get; set; }
        public string SorId { get; set; }
        public int UnreadMessageCount { get; set; }
        public Guid PersonGuid { get; set; }
    }
}
