using VPT.Shared.Poco.Model.API.Tether;

namespace VPT.Shared.Poco.DTO.API.Tether
{
    /// <summary>
    /// Information about the state of a ProgramCatalog program element
    /// </summary>
    public class SubjectProgramElementStateDTO
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public SubjectProgramElementStateDTO()
        { }

        /// <summary>
        /// Copy constructor
        /// </summary>
        /// <param name="subjectProgramElementState">SubjectProgramElementState model</param>
        public SubjectProgramElementStateDTO(SubjectProgramElementState subjectProgramElementState)
        {
            ProgramSequenceId = subjectProgramElementState.ProgramSequenceId;
            SubjectProgramId = subjectProgramElementState.SubjectProgramId;
            Type = subjectProgramElementState.Type;
            Id = subjectProgramElementState.Id;
            InstanceId = subjectProgramElementState.InstanceId;
            Sequence = subjectProgramElementState.Sequence;
            Status = subjectProgramElementState.Status;
        }
        /// <summary>
        /// The program element sequence ID
        /// </summary>
        public int ProgramSequenceId { get; set; }
        /// <summary>
        /// The subject program ID
        /// </summary>
        public int SubjectProgramId { get; set; }
        /// <summary>
        /// The type of the element: 0 = Assessment, 1 = Course
        /// </summary>
        public byte Type { get; set; }
        /// <summary>
        /// The ID of the element: AssessmentID (SKU) or CourseID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The program sequence element instance ID (assessment PIN)
        /// </summary>
        public  string InstanceId { get; set; }
        /// <summary>
        /// The sequence of the program element in the program
        /// </summary>
        public int Sequence { get; set; }
        /// <summary>
        /// The state of the program sequence element
        /// 0 = assigned, 1 = in progress, 2 
        /// </summary>
        public byte Status { get; set; }
    }
}
