using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API
{
    public class ProgramStatusDTO : BaseDTO
    {
        public ProgramStatusDTO(SubjectProgramStatus source)
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
        /// The ProgramStatus is IsActive
        /// </summary>
        public bool IsActive { get; set; }

        ///<summary>
        /// The ProgramStatus is Deleted
        /// </summary>
        public bool IsHidden { get; set; }

        ///<summary>
        /// The ProgramStatus is Is Unsuccessful
        /// </summary>
        public bool IsUnsuccessful { get; set; }
    }
}
