using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace VPT.Shared.Poco.DTO.API.Tether.Communication
{
    public class PersonDTO
    {
        public PersonDTO() { }
        public PersonDTO(PersonDetailsDTO source)
        {
            PersonGuid = source.PersonGUID.ToString();
            FirstName = source.FirstName;
            LastName = source.LastName;
            Email= source.Contacts.FirstOrDefault(x => x.TypeID == (int)ContactType.Email) != null ? source.Contacts.FirstOrDefault(x => x.TypeID == (int)ContactType.Email).Value : "";
            MobileNumber= source.Contacts.FirstOrDefault(x => x.TypeID == (int)ContactType.Mobile) != null ? source.Contacts.FirstOrDefault(x => x.TypeID == (int)ContactType.Mobile).Value : "";
        }

        [Required]
        public string PersonGuid { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        private string _emailAddress;
        [EmailAddress]
        public string Email
        {
            get => _emailAddress;
            set => _emailAddress = value == string.Empty ? null : value;
        }

        private string _phoneNumber;
        [Phone]
        public string MobileNumber
        {
            get => _phoneNumber;
            set => _phoneNumber = value == string.Empty ? null : value;
        }

        public string AppId { get; set; }
    }
}
