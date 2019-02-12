using VPT.Shared.Poco.Model.API.Tether;

namespace VPT.Shared.Poco.DTO.API.Tether
{
    public class CourseDTO : BaseDTO
    {
        public CourseDTO(Course cource)
        {
            CourseId = cource.CourseID;
            Name = cource.Name;
            Description = cource.Description;
        }
        public int CourseId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
