using System.Collections.Generic;

namespace VPT.Shared.Poco.DTO.API
{
    public class ClassroomAssignmentsDTO
    {

        public int ProgramID { get; set; }

        public string Title { get; set; }

        public int ClassroomID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<CourseAssignmentAssetDTO> Assignments { get; set; }

        public string ParentTitle { get; set; }

        public int ParentProgramId { get; set; } 

    }
}
