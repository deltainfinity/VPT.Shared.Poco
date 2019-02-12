using NPoco;
using VPT.Shared.Poco.DTO.API;

namespace VPT.Shared.Poco.Model.API
{
    [TableName("Goal")]
    [PrimaryKey("GoalID")]
    public class Goal : BaseModel
    {
        public Goal()
        { }

        public Goal(GoalDTO source)
            : base(source)
        {
            GoalID = source.GoalID;
            Name = source.Name;
            Description = source.Description;
            DomainID = source.DomainID;
            IsCustom = source.IsCustom;
            AutoAssign = source.AutoAssign;
            OrganizationID = source.OrganizationID;
            IsPrison = source.IsPrison;
        }

        /// <summary>
        /// The ID of the Goal
        /// </summary>
        public int GoalID { get; set; }
        
        /// <summary>
        /// The name of Goal
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The description of Goal
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The ID of the Domain
        /// </summary>
        public int DomainID { get; set; }
        ///<summary>
        ///Custom Goal
        /// </summary>
        public bool IsCustom { get; set; }
        ///<summary>
        ///Auto Assign Goal
        /// </summary>
        public bool AutoAssign { get; set; }
        ///<summary>
        ///Organization ID
        /// </summary>
        public int OrganizationID { get; set; }

        public bool IsPrison { get; set; }

    }
}
