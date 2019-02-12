using VPT.Shared.Poco.Model.API.Tether;

namespace VPT.Shared.Poco.DTO.API.Tether
{
    public class OnlineCourseLookupDTO : BaseDTO
    {
        public int OnlineProgramProviderID { get; set; }
        public int CourseID { get; set; }
        public string LMSCourseID { get; set; }

        public OnlineCourseLookupDTO() { }

        public OnlineCourseLookupDTO(OnlineCourseLookup source)
        {
            OnlineProgramProviderID = source.OnlineProgramProviderID;
            CourseID = source.CourseID;
            LMSCourseID = source.LMSCourseID;
        }
    }
}
