using NPoco;
using System;

namespace VPT.Shared.Poco.Model.API
{
    [TableName("ProgramWaitList")]
    [PrimaryKey("ProgramWaitListID")]
    public class ProgramWaitList
    {
        public ProgramWaitList()
        { }

        public int ProgramWaitListID { get; set; }

        public int SubjectUserID { get; set; }

        public int ProgramID { get; set; }

        public bool IsRecommendedProgram { get; set; }

        public string CreatedByUserID { get; set; }

        public bool Deleted { get; set; }

        public DateTime DateCreated { get; set; }
        public int? AssignedBy { get; set; }
    }
}
