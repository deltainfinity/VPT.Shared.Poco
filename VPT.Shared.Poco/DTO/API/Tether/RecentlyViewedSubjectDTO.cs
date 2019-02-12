using System;
using VPT.Shared.Poco.Model.API.Tether;

namespace VPT.Shared.Poco.DTO.API.Tether
{
    public class RecentlyViewedSubjectDTO : BaseDTO
    {
        public RecentlyViewedSubjectDTO()
        { }

        public RecentlyViewedSubjectDTO(RecentlyViewedSubject source)
        {
            SubjectUserID = source.SubjectUserID;
            AgentUserID = source.AgentUserID;
            DateLastViewed = source.DateLastViewed;
        }

        /// <summary>
        /// The Subject User ID
        /// </summary>
        public int SubjectUserID { get; set; }
        /// <summary>
        /// The AgentUser ID
        /// </summary>
        public int AgentUserID { get; set; }
        /// <summary>
        /// The Date Last Viewed
        /// </summary>
        public DateTime DateLastViewed { get; set; }
    }
}
