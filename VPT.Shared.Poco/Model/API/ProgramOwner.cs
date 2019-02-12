using NPoco;

namespace VPT.Shared.Poco.Model.API
{
    [TableName("ProgramOwner")]
    [PrimaryKey("ProgramOwnerID")]

    public class ProgramOwner
    {
        public ProgramOwner()
        { }

        /// <summary>
        /// The ID of the ProgramOwner
        /// </summary>
        public int ProgramOwnerID { get; set; }

        /// <summary>
        /// The ID of the ParentProgram
        /// </summary>
        public int ParentProgramID { get; set; }

        /// <summary>
        /// The ID of the Owner
        /// </summary>
        public int OwnerID { get; set; }
    }
}
