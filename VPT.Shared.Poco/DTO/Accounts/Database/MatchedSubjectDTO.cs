using Newtonsoft.Json;

namespace VPT.Shared.Poco.Model.Accounts.Database
{
    public class MatchedSubjectDTO
    {

        public MatchedSubjectDTO()
        { }

        public MatchedSubjectDTO(MatchedSubject subject)
        {
            PersonID = subject.PersonID;
            OrganizationID = subject.OrganizationID;
            Auth0UserID = subject.Auth0UserID;
            FirstName = subject.FirstName;
            LastName = subject.LastName;
            PrevID = subject.PrevID;
            FBI = subject.FBI;
            SID = subject.SID;
            SORID = subject.SORID;
            DateReceived = subject.DateReceived;
        }

        [JsonProperty("personID")]
        public int PersonID { get; set; }

        [JsonProperty("organizationID")]
        public int OrganizationID { get; set; }

        [JsonProperty("auth0UserID")]
        public string Auth0UserID { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("prevID")]
        public string PrevID { get; set; }

        [JsonProperty("fbi")]
        public string FBI { get; set; }

        [JsonProperty("sid")]
        public string SID { get; set; }

        [JsonProperty("sorid")]
        public string SORID { get; set; }

        [JsonProperty("DateReceived")]
        public string DateReceived { get; set; }


    }
}
