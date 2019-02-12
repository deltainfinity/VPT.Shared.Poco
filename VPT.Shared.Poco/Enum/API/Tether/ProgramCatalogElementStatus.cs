namespace VPT.Shared.Poco.Enum.API.Tether
{
    /// <summary>
    /// Status of a subject's ProgramCatalog elements
    /// </summary>
    public enum ProgramCatalogElementStatus : byte
    {
        /// <summary>
        /// The ProgramCatalog element has been Assigned (0)
        /// </summary>
        Assigned = 0,
        /// <summary>
        /// The ProgramCatalog element is InProgress (1)
        /// </summary>
        InProgess = 1,
        /// <summary>
        /// The ProgramCatalog element is Complete (2)
        /// </summary>
        Complete = 2
    }
}
