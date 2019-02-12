using NPoco;
using System;
using VPT.Shared.Poco.DTO.API;

namespace VPT.Shared.Poco.Model.API
{
    /// <summary>
    /// Class for defining a ProgramRecommendation
    /// </summary>
    [TableName("VIDSProgramRecommendation")]
    [PrimaryKey("VIDSProgramRecommendationID")]
    public class VIDSProgramRecommendation 
    {
        public VIDSProgramRecommendation()
        { }

        public VIDSProgramRecommendation(VIDSProgramRecommendationDTO source)
        {
            VIDSProgramRecommendationID = source.VIDSProgramRecommendationID;
            UserName = source.UserName;
            Name = source.Name;
            SortOrder = source.SortOrder;
            CourseID = source.CourseID;
            Status = source.CourseStatus;
        }

        public int VIDSProgramRecommendationID { get; set; }

        public string UserName { get; set; }

        public string Name { get; set; }

        public int SortOrder { get; set; }

        public int CourseID { get; set; }

        public int Status { get; set; }

        public DateTime? DateCompleted { get; set; }

        public DateTime DateCreated { get; set; }

        public string CreatedByUserID { get; set; }

        public bool Deleted { get; set; }
    }
}
