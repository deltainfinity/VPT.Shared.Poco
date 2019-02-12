namespace VPT.Shared.Poco.Model.API
{
    public class SubjectProgramEnrollment
    {
        public string SubjectExternalId { get; set; }
        public string ProgramInstanceExternalID { get; set; }
        public string ProgramExternalID { get; set; }
        public string SubjectEnrollmentStatus { get; set; }
        public string SubjectEnrollmentStatusDate { get; set; }
        public string PositionDescription { get; set; }
        public string OffenderSkillLevel { get; set; }
        public string OffenderStartDate { get; set; }
        public string OffenderEndDate { get; set; }
        public string OffenderEndStatus { get; set; }
        public string OffenderEndReason { get; set; }
        public string SubjectProgramStatus { get; set; }
    }
}
