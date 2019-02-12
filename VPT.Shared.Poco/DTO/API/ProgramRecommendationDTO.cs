using System;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API
{
    public class ProgramRecommendationDTO : BaseDTO
    {
        public ProgramRecommendationDTO()
        { }

        public ProgramRecommendationDTO(ProgramRecommendation source)
            : base(source)
        {
            ProgramRecommendationId = source.ProgramRecommendationId;
            ParentProgramId = source.ParentProgramId;
            OffenderId = source.OffenderId;
            Status = source.Status;
        }

        public int ProgramRecommendationId { get; set; }
        public int ParentProgramId { get; set; }
        public string OffenderId { get; set; }
        public int Status { get; set; }
    }
}
