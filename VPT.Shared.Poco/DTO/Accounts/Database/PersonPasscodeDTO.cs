using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using VPT.Shared.Poco.Model.Accounts.Database;

namespace VPT.Shared.Poco.DTO.Accounts.Database
{
    /// <summary>
    /// Contains all passcode related detail for a person
    /// </summary>
    public class PersonPasscodeDTO : BaseDatabaseDTO
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public PersonPasscodeDTO()
        { }

        /// <summary>
        /// Copy constructor
        /// </summary>
        /// <param name="personPasscode"></param>
        public PersonPasscodeDTO(PersonPasscode personPasscode) : base(personPasscode)
        {
            PersonId = personPasscode.PersonId;
            OrganizationId = personPasscode.OrganizationId;
            PasscodeHash = personPasscode.Passcode;
            Salt = personPasscode.Salt;
            UnsuccessfulAttempts = personPasscode.UnsuccessfulAttempts;
            DateLocked = personPasscode.DateLocked;
        }

        [JsonProperty("personID")]
        public int PersonId { get; set; }
        [JsonProperty("organizationID")]
        public int OrganizationId { get; set; }
        [JsonProperty("passcode")]
        public string Passcode { get; set; }
        [JsonProperty("passcodeHash")]
        public string PasscodeHash { get; set; }
        [JsonProperty("salt")]
        public string Salt { get; set; }
        [JsonProperty("unsuccessfulAttempts")]
        public int UnsuccessfulAttempts { get; set; }
        [JsonProperty("dateLocked")]
        public DateTime? DateLocked { get; set; }
    }
}
