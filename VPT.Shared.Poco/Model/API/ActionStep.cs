using NPoco;
using VPT.Shared.Poco.DTO.API;

namespace VPT.Shared.Poco.Model.API
{
    [TableName("ActionStep")]
    [PrimaryKey("ActionStepID")]
    public class ActionStep : BaseModel
    {
        public ActionStep()
        { }

        public ActionStep(ActionStepDTO source)
            : base(source)
        {
            ActionStepID = source.ActionStepID;
            Name = source.Name;
            Description = source.Description;
            IsCustom = source.IsCustom;
            GoalID = source.GoalID;
            ParentProgramID = source.ParentProgramID;
            ActionStepTypeID = source.ActionStepTypeID;
            ActionStepType = source.ActionStepType;
        }

        /// <summary>
        /// The ID of the ActionStep
        /// </summary>
        public int ActionStepID { get; set; }

        /// <summary>
        /// The name of Domain
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The description of ActionStep
        /// </summary>
        public string Description { get; set; }

        ///<summary>
        ///Custom ActionStep
        /// </summary>
        public bool IsCustom { get; set; }

        ///<summary>
        ///Goal ID
        /// </summary>
        public int GoalID { get; set; }

        ///<summary>
        /// The flag to indicate OffenderResponsible or not.
        /// </summary>
        public bool IsOffenderResponsible { get; set; }

        ///<summary>
        /// The id of parentprogram. 
        /// </summary>
        public int ParentProgramID { get; set; }

        ///<summary>
        /// The id of ActionStepType. 
        /// </summary>
        public int ActionStepTypeID { get; set; }

        ///<summary>
        /// The type of actionstep. 
        /// </summary>
        [ResultColumn]
        public string ActionStepType { get; set; }
    }
}
