using System;

namespace VPT.Shared.Poco.Model.API
{
    public class ProgramRecommendationDetails
    {
        public ProgramRecommendationDetails()
        { }

        public ProgramRecommendationDetails(ProgramRecommendation source, string title, int platform)
        {
            ParentProgramId = source.ParentProgramId;
            Title = title;
            ProgramRecommendationID = source.ProgramRecommendationId;
            OffenderID = source.OffenderId;
            Status = source.Status;
            OverriddenReason = source.OverriddenReason;
            OverriddenDate = source.OverriddenDate.HasValue ? source.OverriddenDate.Value : (DateTime?)null;
            OverriddenByUserID = source.OverriddenByUserID;
            AssignedDate = source.AssignedDate.HasValue ? source.AssignedDate.Value : (DateTime?)null;
            AssignedByUserID = source.AssignedByUserID;
            PlatformType = platform;
        }

        public int ParentProgramId { get; set; }

        public string Title { get; set; }

        public int ProgramRecommendationID { get; set; }

        public string OffenderID { get; set; }

        public int Status { get; set; }

        public string OverriddenReason { get; set; }

        public DateTime? OverriddenDate { get; set; }

        public string OverriddenByUserID { get; set; }

        public DateTime? AssignedDate { get; set; }

        public string AssignedByUserID { get; set; }

        public int PlatformType { get; set; }
    }
}
