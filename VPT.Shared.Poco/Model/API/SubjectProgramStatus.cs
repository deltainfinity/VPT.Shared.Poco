using NPoco;
using VPT.Shared.Poco.DTO.API;

namespace VPT.Shared.Poco.Model.API
{
    [TableName("SubjectProgramStatus")]
    [PrimaryKey("ProgramStatusID")]
    public class SubjectProgramStatus : BaseModel
    {
        public SubjectProgramStatus()
        { }

        public SubjectProgramStatus(ProgramStatusDTO source)
            : base(source)
        {
            ProgramStatusID = source.ProgramStatusID;
            Name = source.Name;
            SortOrderID = source.SortOrderID;
            OrganizationID = source.OrganizationID;
            IsActive = source.IsActive;
            IsHidden = source.IsHidden;
            IsUnsuccessful = source.IsUnsuccessful;
        }

        /// <summary>
        /// The ProgramStatusID of the SubjectProgramStatus
        /// </summary>
        public int ProgramStatusID { get; set; }

        /// <summary>
        /// The DisplayName
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The SortorderID
        /// </summary>
        public int SortOrderID { get; set; }

        /// <summary>
        /// The OrganizationID
        /// </summary>
        public int OrganizationID { get; set; }

        ///<summary>
        /// The SubjectProgramStatus is IsActive
        /// </summary>
        public bool IsActive { get; set; }

        ///<summary>
        /// The ProgramStatus is Hidden
        /// </summary>
        public bool IsHidden { get; set; }

        ///<summary>
        /// The ProgramStatus is Is Unsuccessful
        /// </summary>
        public bool IsUnsuccessful { get; set; }
        
    }
}
