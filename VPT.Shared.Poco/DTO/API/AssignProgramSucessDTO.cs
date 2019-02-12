namespace VPT.Shared.Poco.DTO.API
{
    public class AssignProgramSucessDTO
    {
        public  AssignProgramSucessDTO()
            {}

        public AssignProgramSucessDTO(bool assignProgramSucess, int? subjectProgramID = null)
        {
            IsAssignedSuccessfully = assignProgramSucess;
            SubjectProgramID = subjectProgramID ?? null;
        }
        public bool IsAssignedSuccessfully { get; set; }
        public int? SubjectProgramID { get; set; }
    }
}
