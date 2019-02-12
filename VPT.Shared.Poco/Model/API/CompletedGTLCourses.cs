using NPoco;
using System;
using VPT.Shared.Poco.DTO.API;

namespace VPT.Shared.Poco.Model.API
{
    [TableName("CompletedGTLCourses")]
    [PrimaryKey("CompletedGTLCoursesID")]
    /// <summary>
    /// Class for defining a CompletedGTLCourses
    /// </summary>
    public class CompletedGTLCourses 
    {
        public CompletedGTLCourses()
        { }

        public CompletedGTLCourses(CompletedGTLCoursesDTO source)
        {
            CompletedGTLCoursesID = source.CompletedGTLCoursesID;
            SORID = source.SORID;
            CompletionTime = source.CompletionTime;
            Grade = source.Grade;
            CourseID = source.CourseID;
        }

        /// <summary>
        /// The id of CompletedGTLCourses.
        /// </summary>
        public int CompletedGTLCoursesID { get; set; }

        /// <summary>
        /// The id of system of record.
        /// </summary>
        public string SORID { get; set; }

        /// <summary>
        /// The id of course
        /// </summary>
        public int CourseID { get; set; }

        /// <summary>
        /// Date and time when CompletedGTLCourse completed.
        /// </summary>
        public DateTime CompletionTime { get; set; }

        /// <summary>
        /// Grade of CompletedGTLCourse.
        /// </summary>
        public string Grade { get; set; }

        /// <summary>
        /// Date and Time the object was created.
        /// </summary>
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// The person ID of the user that created.
        /// </summary>
        public string CreatedByUserID { get; set; }

        /// <summary>
        /// The date and time the record was last created.
        /// </summary>
        public DateTime? DateUpdated { get; set; }

        /// <summary>
        /// The person ID of the user that updated the record.
        /// </summary>
        public string UpdatedByUserID { get; set; }

        /// <summary>
        /// The date and time the record was deleted.
        /// </summary>
        public DateTime? DateDeleted { get; set; }

        /// <summary>
        /// The person ID of the user that deleted the record.
        /// </summary>
        public string DeletedByUserID { get; set; }

        /// <summary>
        /// Has this record been deleted.
        /// </summary>
        public bool Deleted { get; set; }
    }
}
