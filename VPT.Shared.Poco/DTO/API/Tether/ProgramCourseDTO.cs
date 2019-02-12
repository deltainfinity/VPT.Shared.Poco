using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VPT.Shared.Poco.Model.API.Tether;

namespace VPT.Shared.Poco.DTO.API.Tether
{
    public class ProgramCourseDTO : BaseDTO
    {
        public ProgramCourseDTO()
        { }
        public ProgramCourseDTO(ProgramCourse source)
        {
            CourseId = source.CourseId;
            ProgramCourseId = source.ProgramCourseId;
            ProgramCatalogId = source.ProgramCatalogId;
            CreatedByUserId = source.CreatedByUserID;
            Dosage = source.Dosage;
        }
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
        public string CreatedByUserId { get; set; }
        public int Dosage { get; set; }
    }
}
