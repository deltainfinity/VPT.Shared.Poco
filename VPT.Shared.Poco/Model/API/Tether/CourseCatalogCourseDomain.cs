using NPoco;
using VPT.Shared.Poco.DTO.API.Tether;

namespace VPT.Shared.Poco.Model.API.Tether
{
    [TableName("CourseCatalogCourseDomain")]
    [PrimaryKey("ElementDomainID")]
    public class CourseCatalogCourseDomain
    {
        public int ElementDomainID { get; set; }
        public int CourseID { get; set; }
        public int DomainID { get; set; }

        public CourseCatalogCourseDomain(CourseCatalogCourseDomainDTO source)
        {
            ElementDomainID = source.ElementDomainID;
            CourseID = source.CourseID;
            DomainID = source.DomainID;
        }
        public CourseCatalogCourseDomain() { }
    }
}
