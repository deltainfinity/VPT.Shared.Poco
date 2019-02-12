using NPoco;
using System;

namespace VPT.Shared.Poco.Model.API
{
    [TableName("SubjectGoalAction")]
    [PrimaryKey("SubjectGoalActionID")]
    public class SubjectGoalAction : BaseModel
    {
        public int SubjectGoalActionID { get; set; }

        public int SubjectGoalID { get; set; }

        public int ActionStepID { get; set; }

        public int ResponsiblePersonUserID { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public int Status { get; set; }

        public string TerminatedReason { get; set; }

        public string OnHoldReason { get; set; }

        public int? SubjectProgramID { get; set; }

        public int? ProgramWaitListID { get; set; }

        public int? RequestInstanceID { get; set; }
    }
}
