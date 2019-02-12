namespace VPT.Shared.Poco.Model.API.Tether
{
    /// <summary>
    /// A composite model for a ProgramCatalog sequence element
    /// </summary>
    public class ProgramSequenceElement
    {
        /// <summary>
        /// The ProgramSequenceID
        /// </summary>
        public int ProgramSequenceId { get; set; }
        /// <summary>
        /// The ID of the ProgramCatalog element
        /// AssessmentID (SKU) or CourseID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The type of the element
        /// ProgramCatalogElementType value for Assessment or Course
        /// </summary>
        public byte Type { get; set; }
        /// <summary>
        /// The sequence of the ProgramCatalog element
        /// </summary>
        public int Sequence { get; set; }
    }
}
