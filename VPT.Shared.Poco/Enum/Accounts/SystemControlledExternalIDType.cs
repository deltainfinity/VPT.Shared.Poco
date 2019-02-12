namespace VPT.Shared.Poco.Enum.Accounts
{
    public static class SystemControlledExternalIDType
    {
        public const string Auth0 = "AUTH0";
        public const string SystemOfRecord = "SOR";

        // TODO: This is the AEA Logon ID not an Offender ID
        public const string OffenderID = "AEAID";
        public const string FbiID = "FBI";
        public const string SID = "SID";
        public const string PrevID = "PREVID";
        public const string DateReceived = "Date Received";
        public const string GTLID = "GTLID";
    }
}
