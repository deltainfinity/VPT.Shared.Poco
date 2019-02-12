namespace VPT.Shared.Poco.Model.API.Tether
{
    /// <summary>
    /// Composite model of subject program state element for rules engine
    /// </summary>
    public class SubjectProgramElementState
    {
        /// <summary>
        /// The program element sequence ID
        /// </summary>
        public int ProgramSequenceId { get; set; }
        /// <summary>
        /// The subject program ID
        /// </summary>
        public int SubjectProgramId { get; set; }
        /// <summary>
        /// The ID of the program sequence element
        /// AssessmentID (SKU) or CourseID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The type of the program sequence element
        /// 0 = assessment, 1 = course
        /// </summary>
        public byte Type { get; set; }
        /// <summary>
        /// The sequence of the program element
        /// </summary>
        public int Sequence { get; set; }
        /// <summary>
        /// The status of the subject program sequence element
        /// 0 = assigned, 1 = in progress, 2 =  complete
        /// </summary>
        public byte Status { get; set; }
        /// <summary>
        /// The instance ID of the subject program element sequence
        /// </summary>
        public string InstanceId { get; set; }
        /// <summary>
        /// The program Catalog ID
        /// </summary>
        public int ProgramCatalogId { get; set; }
    }
}
