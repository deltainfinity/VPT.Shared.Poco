using NPoco;

namespace VPT.Shared.Poco.Model.API.Tether
{
    [TableName("CourseCatalog")]
    public class Course
    {
        public int CourseID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Dosage { get; set; }
        public int ProgramCourseID { get; set; }
    }
}
