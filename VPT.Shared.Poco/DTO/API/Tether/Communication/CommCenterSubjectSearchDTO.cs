namespace VPT.Shared.Poco.DTO.API.Tether.Communication
{
    public class CommCenterSubjectSearchDTO
    {
        public int searchBy { get; set; }
        public string searchTerm { get; set; }
        public int userId { get; set; }
        public int organizationId { get; set; }
    }
}
