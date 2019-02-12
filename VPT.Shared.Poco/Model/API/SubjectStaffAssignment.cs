using NPoco;

namespace VPT.Shared.Poco.Model.API
{
    [TableName("SubjectStaffAssignments")]
    [PrimaryKey("SubjectStaffAssignmentsID")]
    public class SubjectStaffAssignment : OverrideTreatmentPathwayGoalActionStepBaseModel
    {
        public SubjectStaffAssignment()
        { }

        public SubjectStaffAssignment(AssignedStaff assignedStaff, int subjectUserID)
        {
            StaffID = assignedStaff.StaffID;
            SubjectUserID = subjectUserID;
            StaffFirstName = assignedStaff.StaffFirstName;
            StaffLastName = assignedStaff.StaffLastName;
            StaffSiteID = assignedStaff.StaffSiteID;
            StaffTitleCode = assignedStaff.StaffTitleCode;
            StaffTitle = assignedStaff.StaffTitle;
            AssignmentTypeCode = assignedStaff.AssignmentTypeCode;
            AssignmentType = assignedStaff.AssignmentType;
            AssignmentStartDate = assignedStaff.AssignmentStartDate;
        }

        /// <summary>
        /// The SubjectStaffAssignmentsID
        /// </summary>
        public int SubjectStaffAssignmentsID { get; set; }

        /// <summary>
        /// The SubjectUserID
        /// </summary>
        public int SubjectUserID { get; set; }

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

