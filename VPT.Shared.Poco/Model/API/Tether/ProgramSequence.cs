using NPoco;
using VPT.Shared.Poco.DTO.API.Tether;

namespace VPT.Shared.Poco.Model.API.Tether
{
    /// <summary>
    /// Program catalog component sequence information
    /// </summary>
    [TableName("ProgramSequence")]
    [PrimaryKey("ProgramSequenceID")]
    public class ProgramSequence : BaseModel
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public ProgramSequence()
        { }

        public ProgramSequence(ProgramSequenceDTO source)
        {
            ProgramSequenceId = source.ProgramSequenceId;
            Id = source.Id;
            Type = source.Type;
            Sequence = source.Sequence;
        }
        /// <summary>
        /// Unique identifier
        /// </summary>
        public int ProgramSequenceId { get; set; }
        /// <summary>
        /// The program assessment or program course ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The type of program catalog component (0 = ProgramAssessment, 1 = ProgramCourse)
        /// </summary>
        public byte Type { get; set; }
        /// <summary>
        /// Order of component execution
        /// </summary>
        public int Sequence { get; set; }
    }
}
