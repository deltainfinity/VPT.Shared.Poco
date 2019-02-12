using System;
using VPT.Shared.Poco.Model.API.Tether;

namespace VPT.Shared.Poco.DTO.API.Tether
{
    /// <summary>
    /// ProgramCatalog program instance information
    /// </summary>
    public class ProgramCatalogProgramDTO
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public ProgramCatalogProgramDTO()
        { }

        /// <summary>
        /// Copy constructor
        /// </summary>
        /// <param name="source">ProgramCatalogProgram model</param>
        public ProgramCatalogProgramDTO(ProgramCatalogProgram source) {
            ProgramCatalogId = source.ProgramCatalogId;
            Name = source.Name;
            Description = source.Description;
            Status = source.Status;
            SubjectProgramId = source.SubjectProgramId;
            CreatedByUserId = source.CreatedByUserId;
        }

        public ProgramCatalogProgramDTO(ProgramCatalog source)
        {
            ProgramCatalogId = source.ProgramCatalogId;
            Name = source.Name;
            Description = source.Description;
            Dosage = source.Dosage;
        }

        public int ProgramCatalogId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Status{ get; set; }
        public int SubjectProgramId { get; set; }
        public string CreatedByUserId { get; set; }
        public int Dosage { get; set; }
    }
}
