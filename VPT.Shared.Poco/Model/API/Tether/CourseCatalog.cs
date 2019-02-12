using NPoco;

namespace VPT.Shared.Poco.Model.API.Tether
{
    /// <summary>
    /// CourseCatalog model
    /// </summary>
    [TableName("CourseCatalog")]
    [PrimaryKey("CourseId")]
    public class CourseCatalog : BaseModel
    {
        /// <summary>
        /// The unique identifier for the course
        /// </summary>
        public int CourseId { get; set; }
        /// <summary>
        /// The name of the course
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The description of the course
        /// </summary>
        public string Description { get; set; }
    }
}
