using NPoco;
using System;

namespace VPT.Shared.Poco.Model.API.Tether
{
    [TableName("RecentlyViewedSubject")]
    [PrimaryKey("SubjectUserID, AgentUserID")]
    public class RecentlyViewedSubject
    {

        public int SubjectUserID { get; set; }
        public int AgentUserID { get; set; }
        /// <summary>
        /// The Date Last Viewed
        /// </summary>
        public DateTime DateLastViewed { get; set; }
    }
}
