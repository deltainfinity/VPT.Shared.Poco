namespace VPT.Shared.Poco.Model.API
{
    public class OverrideReason : BaseModel
    {
        public OverrideReason()
        { }

        /// <summary>
        /// The ID of the OverrideReason
        /// </summary>
        public int OverrideReasonID { get; set; }
        
        /// <summary>
        /// The Override Reason
        /// </summary>
        public string Name { get; set; }
    }
}
