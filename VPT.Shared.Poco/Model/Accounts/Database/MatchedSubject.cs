namespace VPT.Shared.Poco.Model.Accounts.Database
{
    public class MatchedSubject
    {

        public MatchedSubject()
        { }
            
        public int PersonID { get; set; }

        public int OrganizationID { get; set; }

        public string Auth0UserID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PrevID { get; set; }

        public string FBI { get; set; }

        public string SID { get; set; }

        public string SORID { get; set; }
        public string DateReceived { get; set; }

    }

}
