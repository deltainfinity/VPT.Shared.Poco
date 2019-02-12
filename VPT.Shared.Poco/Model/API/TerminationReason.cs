using NPoco;
using VPT.Shared.Poco.DTO.API;

namespace VPT.Shared.Poco.Model.API
{
    [TableName("TerminationReason")]
    [PrimaryKey("TerminationReasonID")]
    public class TerminationReason : BaseModel
    {
        public TerminationReason()
        { }

        public TerminationReason(TerminationReasonDTO source)
            : base(source)
        {
            TerminationReasonID = source.TerminationReasonID;
            OrganizationID = source.OrganizationID;
            Code = source.Code;
            DisplayName = source.DisplayName;
            Description = source.Description;
            IsActive = source.IsActive;
            StatusType = source.StatusType;
        }

        /// <summary>
        /// The TerminationReasonID of the TerminationReason
        /// </summary>
        public int TerminationReasonID { get; set; }

        /// <summary>
        /// The OrganizationID
        /// </summary>
        public int OrganizationID { get; set; }

        /// <summary>
        /// The Termination Reason Code
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// The DisplayName
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// The description of TerminationReason
        /// </summary>
        public string Description { get; set; }

        ///<summary>
        /// The TerminationReason is IsActive
        /// </summary>
        public bool IsActive { get; set; }

        ///<summary>
        /// The status type of TerminationReason
        /// </summary>
        public string StatusType { get; set; }
    }
}
