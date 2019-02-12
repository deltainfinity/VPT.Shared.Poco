using NPoco;
using VPT.Shared.Poco.DTO.API.Tether;

namespace VPT.Shared.Poco.Model.API.Tether
{
    [PrimaryKey("OnlineProgramProviderID,CourseID")]
    [TableName("OnlineCourseLookup")]
    public class OnlineCourseLookup : BaseModel
    {
        public int OnlineProgramProviderID { get; set; }
        public int CourseID { get; set; }
        public string LMSCourseID { get; set; }

        public OnlineCourseLookup() { }
        public OnlineCourseLookup(OnlineCourseLookupDTO source)
        {
            OnlineProgramProviderID = source.OnlineProgramProviderID;
            CourseID = source.CourseID;
            LMSCourseID = source.LMSCourseID;
        }
    }
}
