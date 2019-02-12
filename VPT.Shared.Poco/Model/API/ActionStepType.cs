namespace VPT.Shared.Poco.Model.API
{
    public class ActionStepType 
    {
        public ActionStepType()
        { }
        
        /// <summary>
        /// The ID of the ActionStep
        /// </summary>
        public int ActionStepTypeID { get; set; }

        /// <summary>
        /// The name of Domain
        /// </summary>
        public string ActionStepTypeName { get; set; }
      
        ///<summary>
        ///Custom ActionStep
        /// </summary>
        public bool IsDeleted { get; set; }
    }
}
