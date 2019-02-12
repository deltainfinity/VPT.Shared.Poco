namespace VPT.Shared.Poco.Model.API
{
    public class SubjectStaffAssignments : BaseModel
    {

        public SubjectStaffAssignments()
        { }

        /// <summary>
        /// The ID of the Subject Staff Assignments ID 
        /// </summary>
        public int SubjectStaffAssignmentsID { get; set; }

        /// <summary>
        /// The SubjectUserID
        /// </summary>
        public string SubjectUserID { get; set; }

        /// <summary>
        /// The Staff ID
        /// </summary>
        public string StaffID { get; set; }

        /// <summary>
        /// The Staff First Name
        /// </summary>
        public string StaffFirstName { get; set; }

        /// <summary>
        /// The Staff Last Name
        /// </summary>
        public string StaffLastName { get; set; }

        /// <summary>
        /// The Staff Site ID
        /// </summary>
        public string StaffSiteID { get; set; }

        /// <summary>
        /// The Staff Title Code
        /// </summary>
        public string StaffTitleCode { get; set; }

        /// <summary>
        /// The Staff Title 
        /// </summary>
        public string StaffTitle { get; set; }

        /// <summary>
        /// The Staff Assignment Type Code 
        /// </summary>
        public string AssignmentTypeCode { get; set; }

        /// <summary>
        /// The Staff Assignment Type  
        /// </summary>
        public string AssignmentType { get; set; }

        /// <summary>
        /// The Staff Assignment Start Date   
        /// </summary>
        public string AssignmentStartDate { get; set; }

    }
}
