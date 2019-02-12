using NPoco;

namespace VPT.Shared.Poco.Model.API.Tether
{
    /// <summary>
    /// The model for the ProgramCourse structure
    /// </summary>
    [TableName("ProgramCourses")]
    [PrimaryKey("ProgramCourseID")]
    public class ProgramCourse : BaseModel
    {
        /// <summary>
        /// The unique identifier for the program course
        /// </summary>
        public int ProgramCourseId { get; set; }
        /// <summary>
        /// The program catalog ID
        /// </summary>
        public int ProgramCatalogId { get; set; }
        /// <summary>
        /// The Course ID
        /// </summary>
        public int CourseId { get; set; }

        /// <summary>
        /// Course dosage
        /// </summary>
        public int Dosage { get; set; }
    }
}
