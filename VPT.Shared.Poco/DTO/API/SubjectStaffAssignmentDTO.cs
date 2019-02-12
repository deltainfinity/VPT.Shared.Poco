using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API
{
    public class SubjectStaffAssignmentDTO
    {
        public SubjectStaffAssignmentDTO()
        {

        }

        public SubjectStaffAssignmentDTO(SubjectStaffAssignment subjectStaffAssignment)
        {
            StaffID = subjectStaffAssignment.StaffID;
            StaffFirstName = subjectStaffAssignment.StaffFirstName;
            StaffLastName = subjectStaffAssignment.StaffLastName;
            StaffSiteID = subjectStaffAssignment.StaffSiteID;
            StaffTitleCode = subjectStaffAssignment.StaffTitleCode;
            StaffTitle = subjectStaffAssignment.StaffTitle;
            AssignmentTypeCode = subjectStaffAssignment.AssignmentTypeCode;
            AssignmentType = subjectStaffAssignment.AssignmentType;
            AssignmentStartDate = subjectStaffAssignment.AssignmentStartDate;
        }

        /// <summary>
        /// The SubjectStaffAssignmentsID
        /// </summary>
        public int SubjectStaffAssignmentsID { get; set; }
        
        /// <summary>
        /// The StaffID
        /// </summary>
        public string StaffID { get; set; }

        /// <summary>
        /// The StaffFirstName
        /// </summary>
        public string StaffFirstName { get; set; }

        /// <summary>
        /// The StaffLastName
        /// </summary>
        public string StaffLastName { get; set; }

        /// <summary>
        /// The StaffSiteID
        /// </summary>
        public string StaffSiteID { get; set; }

        /// <summary>
        /// The StaffTitleCode
        /// </summary>
        public string StaffTitleCode { get; set; }

        /// <summary>
        /// The StaffTitle
        /// </summary>
        public string StaffTitle { get; set; }

        /// <summary>
        /// The AssignmentTypeCode
        /// </summary>
        public string AssignmentTypeCode { get; set; }

        /// <summary>
        /// The AssignmentType
        /// </summary>
        public string AssignmentType { get; set; }

        /// <summary>
        /// The AssignmentStartDate
        /// </summary>
        public string AssignmentStartDate { get; set; }
    }
}
