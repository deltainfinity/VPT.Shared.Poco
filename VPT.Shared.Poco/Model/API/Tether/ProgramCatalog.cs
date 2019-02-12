using NPoco;

namespace VPT.Shared.Poco.Model.API.Tether
{
    /// <summary>
    /// Program Catalog model
    /// </summary>
    [TableName("ProgramCatalog")]
    [PrimaryKey("ProgramCatalogId")]
    public class ProgramCatalog : BaseModel
    {
        /// <summary>
        /// Unique identifier for the ProgramCatalog program
        /// </summary>
        public int ProgramCatalogId { get; set; }
        /// <summary>
        /// The Name of the ProgramCatalog program
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// A description of the ProgramCatalog program
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Program Dosage
        /// </summary>
        public int Dosage { get; set; }

    }
}
