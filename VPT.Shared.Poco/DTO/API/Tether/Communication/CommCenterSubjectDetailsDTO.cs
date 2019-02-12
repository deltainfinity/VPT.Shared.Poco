using VPT.Accounts.Shared.DTO.Aggregate;

namespace VPT.Shared.Poco.DTO.API.Tether.Communication
{
    public class CommCenterSubjectDetailsDTO
    {
        public CommCenterSubjectDetailsDTO() { }
        public CommCenterSubjectDetailsDTO(PersonDetailsDTO source)
        {
            FirstName = source.FirstName;
            LastName = source.LastName;
            SorId = source.ExternalUserID;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SorId { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        public string FacilityCode { get; set; }
    }
}
