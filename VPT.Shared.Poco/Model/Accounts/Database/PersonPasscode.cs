using NPoco;
using System;
using VPT.Shared.Poco.DTO.Accounts.Database;

namespace VPT.Shared.Poco.Model.Accounts.Database
{
    [TableName("PersonPasscode")]
    [PrimaryKey("PersonID,OrganizationID")]
    public class PersonPasscode : BaseDatabaseModel
    {
        public PersonPasscode()
        { }

        public PersonPasscode(PersonPasscodeDTO personPasscodeDto) : base(personPasscodeDto)
        {
            PersonId = personPasscodeDto.PersonId;
            OrganizationId = personPasscodeDto.OrganizationId;
            Passcode = personPasscodeDto.PasscodeHash;
            Salt = personPasscodeDto.Salt;
            UnsuccessfulAttempts = personPasscodeDto.UnsuccessfulAttempts;
            DateLocked = personPasscodeDto.DateLocked;
        }

        public int PersonId { get; set; }
        public int OrganizationId { get; set; }
        public string Passcode { get; set; }
        public string Salt { get; set; }
        public int UnsuccessfulAttempts { get; set; }
        public DateTime? DateLocked { get; set; }
    }
}
