using System;
using VPT.Shared.Poco.Enum.API;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API
{
    public class VIDSProgramRecommendationDTO
    {
        public VIDSProgramRecommendationDTO()
        { }

        public VIDSProgramRecommendationDTO(VIDSProgramRecommendation source)
        {
            VIDSProgramRecommendationID = source.VIDSProgramRecommendationID;
            UserName = source.UserName;
            Name = source.Name;
            SortOrder = source.SortOrder;
            CourseID = source.CourseID;
            CourseStatus = source.Status;
            DateCompleted = source.DateCompleted == null ? (DateTime?)null : source.DateCompleted; 
            DateCreated = source.DateCreated ; 
        }

        public int VIDSProgramRecommendationID { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public int SortOrder { get; set; }
        public int CourseID { get; set; }
        public int CourseStatus { get; set; }
        public string CourseStatusText => CourseStatusConstants.GetByEnum(CourseStatus);
        public DateTime? DateCompleted { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
