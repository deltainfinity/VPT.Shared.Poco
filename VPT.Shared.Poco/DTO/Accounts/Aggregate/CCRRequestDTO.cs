namespace VPT.Shared.Poco.DTO.Accounts.Aggregate
{
    public class CCRRequestDTO
    {
        public CCRRequestDTO()
        { }

        public CCRRequestDTO(string subjectExternalID, string token, string version, int organizationId)
        {

            SubjectExternalID = subjectExternalID;
            SORAuthToken = token;
            Version = version;
            OrganizationId = organizationId;
        }

        public string SubjectExternalID { get; set; }
        public string SORAuthToken { get; set; }
        public string Version { get; set; }
        public int OrganizationId { get; set; }

    }
}
