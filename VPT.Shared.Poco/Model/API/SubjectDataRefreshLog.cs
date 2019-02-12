using NPoco;
using System;

namespace VPT.Shared.Poco.Model.API
{
    [TableName("SubjectDataRefreshLog")]
    [PrimaryKey("SubjectDataRefreshLogID")]
    public class SubjectDataRefreshLog
    {
        public int SubjectDataRefreshLogID { get; set; }

        public int SubjectUserID { get; set; }

        public DateTime LastCheckedDate { get; set; }
    }
}
