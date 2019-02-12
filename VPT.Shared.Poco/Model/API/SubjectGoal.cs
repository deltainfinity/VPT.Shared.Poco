using NPoco;
using System;
using VPT.Shared.Poco.DTO.API;

namespace VPT.Shared.Poco.Model.API
{
    [TableName("SubjectGoal")]
    [PrimaryKey("SubjectGoalID")]
    public class SubjectGoal : BaseModel
    {
        public SubjectGoal()
        { }

        public SubjectGoal(SubjectGoalDTO source)
            : base(source)
        {
            SubjectGoalID = source.SubjectGoalID;
            SubjectUserID = source.SubjectUserID;
            GoalID = source.GoalID;
            CompletedDate = source.CompletedDate;
        }

        /// <summary>
        /// The ID of the SubjectGoal
        /// </summary>
        public int SubjectGoalID { get; set; }

        /// <summary>
        /// The ID of the Subject
        /// </summary>
        public int SubjectUserID { get; set; }

        /// <summary>
        /// The ID of the Goal
        /// </summary>
        public int GoalID { get; set; }

        /// <summary>
        /// The completed date of Goal
        /// </summary>
        public DateTime? CompletedDate { get; set; }

        /// <summary>
        /// ParentProgramID - Set when assigning recommended program
        /// </summary>
        public int? ParentProgramID { get; set; }
    }
}
