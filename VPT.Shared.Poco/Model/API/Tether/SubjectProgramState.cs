using NPoco;
using VPT.Shared.Poco.DTO.API.Tether;

namespace VPT.Shared.Poco.Model.API.Tether
{
    /// <summary>
    /// SubjectProgramState model
    /// </summary>
    [TableName("SubjectProgramState")]
    [PrimaryKey("SubjectProgramId, ProgramSequenceId")]
    public class SubjectProgramState : BaseModel
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public SubjectProgramState()
        { }

        /// <summary>
        /// Copy constructor
        /// </summary>
        /// <param name="subjectProgramElementState">SubjectProgramElementStateDTO</param>
        public SubjectProgramState(SubjectProgramElementStateDTO subjectProgramElementState)
        {
            SubjectProgramId = subjectProgramElementState.SubjectProgramId;
            ProgramSequenceId = subjectProgramElementState.ProgramSequenceId;
            InstanceID = subjectProgramElementState.InstanceId;
            Status = subjectProgramElementState.Status;
        }

        /// <summary>
        /// The SubjectProgramID from SubjectProgram
        /// </summary>
        public int SubjectProgramId { get; set; }
        /// <summary>
        /// The ProgramSequenceID from ProgramSequence
        /// </summary>
        public int ProgramSequenceId { get; set; }
        /// <summary>
        /// The individual program sequence element ID
        /// </summary>
        public string InstanceID { get; set; }
        /// <summary>
        /// The status of the individual program sequence element
        /// 0 = assigned, 1 = in progress, 2 = complete
        /// </summary>
        public byte Status { get; set; }
    }
}
