using NPoco;

namespace VPT.Shared.Poco.Model.API
{
    [TableName("ActionStepPrograms")]
    [PrimaryKey("ActionStepProgramID")]
    public class ActionStepProgram 
    {
        public ActionStepProgram()
        { }

        /// <summary>
        /// The ID of the ActionStepProgramID
        /// </summary>
        public int ActionStepProgramID { get; set; }

        /// <summary>
        /// The ID of the ActionStep
        /// </summary>
        public int ActionStepID { get; set; }

        /// <summary>
        /// The ID of the Program
        /// </summary>
        public int ProgramID { get; set; }
    }
}
