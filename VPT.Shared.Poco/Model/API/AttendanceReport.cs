using System;

namespace VPT.Shared.Poco.Model.API
{
    /// <summary>
    /// Class defining a CapacityUtilizationReport in VPT
    /// </summary>
    public class AttendanceReport
    {
        public AttendanceReport()
        { }

        /// <summary>
        /// id of district  
        /// </summary>
        public string DistrictID { get; set; }

        /// <summary>
        /// id of site
        /// </summary>
        public string SiteID { get; set; }

        /// <summary>
        /// name of subject
        /// </summary>
        public string SubjectName { get; set; }

        /// <summary>
        /// id of subject
        /// </summary>
        public string SubjectID { get; set; }

        /// <summary>
        /// date of refferal to program
        /// </summary>
        public DateTime DateofReferraltoProgram { get; set; }

        /// <summary>
        /// name of  instance
        /// </summary>
        public string InstanceName { get; set; }

        /// <summary>
        /// program name for instance
        /// </summary>
        public string ProgramName { get; set; }

        /// <summary>
        /// start date of instance
        /// </summary>
        public DateTime? InstanceStartDate { get; set; }

        /// <summary>
        ///  end date of instance
        /// </summary>
        public DateTime? InstanceEndDate { get; set; }

        /// <summary>
        /// show count of instances that subject was marked 'Not Present' for days within report date range
        /// </summary>
        public int NumberOfClassesAttendedNotPresent { get; set; }

        /// <summary>
        /// show count of instances that subject was marked 'Not Present' for days within report date range
        /// </summary>
        public int NumberOfClassesAttendedExcusedAbsence { get; set; }

        /// <summary>
        /// show count of instances that subject was marked 'Present' for days within report date range
        /// </summary>
        public int NumberOfClassesPresent { get; set; }

        /// <summary>
        /// should be In Progress, Completion, or Termination values
        /// </summary>
        public int CurrentStatus { get; set; }

        /// <summary>
        /// If a subject has "Termination" value for program, display the termination reasons * Term Reason 1
        /// </summary>
        public int? TerminationReason1 { get; set; }

        /// <summary>
        ///  If a subject has "Termination" value for program, display the termination reasons * Term Reason 2
        /// </summary>
        public int? TerminationReason2 { get; set; }

        /// <summary>
        /// If a subject has "Termination" value for program, display the termination reasons * Term Reason 3
        /// </summary>
        public int? TerminationReason3 { get; set; }

        /// <summary>
        /// id of subject user
        /// </summary>
        public int SubjectUserID { get; set; }

        /// <summary>
        /// id of program 
        /// </summary>
        public int ProgramID { get; set; }

        /// <summary>
        /// flag to indicate open or closed program
        /// </summary>
        public bool IsPerpetual { get; set; }
    }
}
