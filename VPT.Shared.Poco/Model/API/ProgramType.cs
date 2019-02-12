using VPT.Shared.Poco.DTO.API;

namespace VPT.Shared.Poco.Model.API
{
    public class ProgramType : BaseModel
    {
        public ProgramType()
        { }

        public ProgramType(ProgramTypeDTO source)
            : base(source)
        {
            ProgramTypeID = source.ProgramTypeID;
            Name = source.Name;
            Priority = source.Priority;
        }

        /// <summary>
        /// The ID of the ProgramType
        /// </summary>
        public int ProgramTypeID { get; set; }

        /// <summary>
        /// The name of ProgramType
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The rank of the Priority
        /// </summary>
        public int Priority { get; set; }
    }
}
