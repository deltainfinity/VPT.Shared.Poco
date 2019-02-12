using System;
using System.Collections.Generic;
using System.Linq;
using VPT.Shared.Poco.Enum.API;
using VPT.Shared.Poco.Model.API;
using VPT.Shared.Poco.DTO.Accounts.Aggregate;
using VPT.Shared.Poco.Enum.Accounts;

namespace VPT.Shared.Poco.DTO.API
{
    public class AttendanceReportDTO : BaseDTO
    {
        public AttendanceReportDTO(AttendanceReport source, IList<PersonDetailsDTO> person, IList<AutoCompleteSelectListItem> terminationLookup,IEnumerable<SubjectProgramStatus> programStatuses)
        //: base(source)
        {
            DistrictID = source.DistrictID;
            SiteID = source.SiteID;
            SubjectName = person.Where(x => x.PersonID.Equals(source.SubjectUserID)).FirstOrDefault().FullNameLastNameFirstFormat;
            SubjectID = person.Where(x => x.PersonID.Equals(source.SubjectUserID)).FirstOrDefault().ExternalIDs.Where(x => x.Type == SystemControlledExternalIDType.SystemOfRecord).Count() > 0 ? person.Where(x => x.PersonID.Equals(source.SubjectUserID)).FirstOrDefault().ExternalIDs.Where(x => x.Type == SystemControlledExternalIDType.SystemOfRecord).FirstOrDefault().Value : null;
            DateofReferraltoProgram = source.DateofReferraltoProgram.ToString("MM/dd/yyyy");
            InstanceName = source.InstanceName;
            ProgramName = source.ProgramName;
            InstanceStartDate = source.IsPerpetual ? null : source.InstanceStartDate.HasValue ? source.InstanceStartDate.GetValueOrDefault().ToString("MM/dd/yyyy") : "TBD";
            InstanceEndDate = source.IsPerpetual ? null : source.InstanceEndDate.HasValue ? source.InstanceEndDate.GetValueOrDefault().ToString("MM/dd/yyyy") : "TBD"; 
            NumberOfClassesAttendedNotPresent = source.NumberOfClassesAttendedNotPresent;
            NumberOfClassesAttendedExcusedAbsence = source.NumberOfClassesAttendedExcusedAbsence;
            NumberOfClassesPresent = source.NumberOfClassesPresent;
            CurrentStatusName= programStatuses.Where(y => y.ProgramStatusID == source.CurrentStatus).Select(y => y.Name).SingleOrDefault();
            CurrentStatus = source.CurrentStatus;
            TerminationReason1 = source.TerminationReason1 != null ? terminationLookup.Where(x=>x.Id == source.TerminationReason1).FirstOrDefault().Name : null;
            TerminationReason2 = source.TerminationReason2 !=null ? terminationLookup.Where(x => x.Id == source.TerminationReason2).FirstOrDefault().Name : null;
            TerminationReason3 = source.TerminationReason3 != null ? terminationLookup.Where(x => x.Id == source.TerminationReason3).FirstOrDefault().Name : null;
            SubjectUserID = source.SubjectUserID;
            ProgramID = source.ProgramID;
            IsPerpetual = source.IsPerpetual;
        }

        public string DistrictID { get; set; }
        public string SiteID { get; set; }
        public string SubjectName { get; set; }
        public string SubjectID { get; set; }
        /// <summary>
        /// date that subject was assigned to instance
        /// </summary>
        public string DateofReferraltoProgram { get; set; }
        public string InstanceName { get; set; }
        /// <summary>
        /// program name for instance
        /// </summary>
        public string ProgramName { get; set; }
        public string InstanceStartDate { get; set; }
        public string InstanceEndDate { get; set; }
        /// <summary>
        /// show count of instances that subject was marked 'Not Present' for days within report date range
        /// </summary>
        public int NumberOfClassesAttendedNotPresent { get; set; }
        /// <summary>
        /// show count of instances that subject was marked 'Not Present' for days within report date range
        /// </summary>
        public int NumberOfClassesAttendedExcusedAbsence { get; set; }
        /// <summary>
        /// show count of instances that subject was marked 'Not Present' for days within report date range
        /// </summary>
        public int NumberOfClassesPresent { get; set; }
        /// <summary>
        /// should be In Progress, Completion, or Termination values
        /// </summary>
        public int CurrentStatus { get; set; }
        public string CurrentStatusName { get; set; }
        /// <summary>
        /// If a subject has "Termination" value for program, display the termination reasons * Term Reason 1
        /// </summary>
        public string TerminationReason1 { get; set; }
        public string TerminationReason2 { get; set; }
        public string TerminationReason3 { get; set; }
        public int SubjectUserID { get; set; }
        public int ProgramID { get; set; }
        public bool IsPerpetual { get; set; }
    }
}
