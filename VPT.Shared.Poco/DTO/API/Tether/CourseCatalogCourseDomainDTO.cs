using VPT.Shared.Poco.Model.API.Tether;

namespace VPT.Shared.Poco.DTO.API.Tether
{
    public class CourseCatalogCourseDomainDTO
    {
        public int ElementDomainID { get; set; }
        public int CourseID { get; set; }
        public int DomainID { get; set; }

        public CourseCatalogCourseDomainDTO(CourseCatalogCourseDomain source)
        {
            ElementDomainID = source.ElementDomainID;
            CourseID = source.CourseID;
            DomainID = source.DomainID;
        }
        public CourseCatalogCourseDomainDTO() { }
    }
}
