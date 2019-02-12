using NPoco;

namespace VPT.Shared.Poco.Model.API.Tether
{
    /// <summary>
    /// ProgramCatalogToParentProgram mapping table model
    /// </summary>
    [TableName("ProgramCatalogToParentProgram")]
    [PrimaryKey("ProgramCatalogID,ParentProgramID")]
    public class ProgramCatalogToParentProgram : BaseModel
    {
        /// <summary>
        /// The ProgramCatalog program ID
        /// </summary>
        public int ProgramCatalogId { get; set; }
        /// <summary>
        /// The ParentProgram that is being mapped to the ProgramCatalog program for an organization
        /// </summary>
        public int ParentProgramId { get; set; }
    }
}
