using VPT.Shared.Poco.Model.API.Tether;

namespace VPT.Shared.Poco.DTO.API.Tether
{
    /// <summary>
    /// Program catalog sequence 
    /// </summary>
    public class ProgramSequenceDTO : BaseDTO
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public ProgramSequenceDTO()
        { }

        /// <summary>
        /// Copy constructor from ProgramSequenceElement model
        /// </summary>
        /// <param name="programSequenceElement">ProgramSequenceElement model</param>
        public ProgramSequenceDTO(ProgramSequenceElement programSequenceElement)
        {
            ProgramSequenceId = programSequenceElement.ProgramSequenceId;
            Id = programSequenceElement.Id;
            Type = programSequenceElement.Type;
            Sequence = programSequenceElement.Sequence;
        }

        public ProgramSequenceDTO(ProgramSequence source)
        {
            ProgramSequenceId = source.ProgramSequenceId;
            Id = source.Id;
            Type = source.Type;
            Sequence = source.Sequence;
        }

        /// <summary>
        ///The program sequence ID
        /// </summary>
        public int ProgramSequenceId { get; set; }
        /// <summary>
        /// The program assessment ID (SKU) or program course ID
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
