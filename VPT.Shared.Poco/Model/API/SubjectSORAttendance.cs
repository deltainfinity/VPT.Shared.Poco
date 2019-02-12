namespace VPT.Shared.Poco.Model.API
{
    public class SubjectSORAttendance
    {
        /// <summary>
        /// ID of attendance site
        /// </summary>
        public string SiteID { get; set; }

        /// <summary>
        /// ID of program’s instance
        /// </summary>
        public string ProgramInstanceExternalID { get; set; }

        /// <summary>
        /// Date offender attended class
        /// </summary>
        public string DateAttended { get; set; }

        /// <summary>
        /// Subject’s external ID
        /// </summary>
        public string SubjectExternalId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string NumberHoursAttended { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string NumberHoursExcused { get; set; }

        /// <summary>
        /// Participation level -- 1 = showed up, 2 = some interaction 3 = full interaction
        /// </summary>
        public int LevelOfParticipation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string SubjectInAttendance { get; set; }

        /// <summary>
        /// Note for offender participation, if available
        /// </summary>
        public string InstanceNote { get; set; }
    }
}
