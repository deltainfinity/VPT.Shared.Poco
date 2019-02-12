using System.Collections.Generic;
using VPT.Shared.Poco.Model.API;
using VPT.Shared.Poco.Model.API.Tether;

namespace VPT.Shared.Poco.DTO.API.Tether
{
    public class CourseCatalogDTO : BaseDTO
    {
        public CourseCatalogDTO()
        { }
        public CourseCatalogDTO(CourseCatalog cource)
        {
            CourseId = cource.CourseId;
            Name = cource.Name;
            Description = cource.Description;
            CreatedByUserId = cource.CreatedByUserID;
        }
        public int CourseId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CreatedByUserId { get; set; }
        public List<Tag> DomainList { get; set; }
        public int Dosage { get; set; }
        public int ProgramCourseID { get; set; }

    }
}
