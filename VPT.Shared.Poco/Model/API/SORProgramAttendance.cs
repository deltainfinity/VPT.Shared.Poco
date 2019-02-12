using NPoco;
using System;
using VPT.Shared.Poco.DTO.API;

namespace VPT.Shared.Poco.Model.API
{
    [TableName("SORProgramAttendance")]
    [PrimaryKey("SORProgramAttendanceID")]
    public class SORProgramAttendance
    {

        public SORProgramAttendance()
        { }

        public SORProgramAttendance(SORProgramAttendanceDTO source)
        {
            AccountExternalId = source.AccountExternalId;
            SiteId = source.SiteId;
            StateProgramId = source.StateProgramId;
            PositionId = source.PositionId;
            DateAttended = source.DateAttended;
            SubjectExternalId = source.SubjectExternalId;
            NumberHoursAttended = source.NumberHoursAttended;
            NumberHoursExcused = source.NumberHoursExcused;
            OrganizationId = source.OrganizationId;
        }

        public SORProgramAttendance(SubjectSORAttendance item, int organizationID)
        {
            SiteId = item.SiteID;
            DateAttended = item.DateAttended;
            NumberHoursAttended = item.NumberHoursAttended;
            NumberHoursExcused = item.NumberHoursExcused;
            DateCreated = DateTime.Now;
            OrganizationId = organizationID;
            SubjectExternalId = item.SubjectExternalId;
            InstanceNote = item.InstanceNote;
        }

        public int SORProgramAttendanceID { get; set; }

        public string AccountExternalId { get; set; }

        public string SiteId { get; set; }

        public string StateProgramId { get; set; }

        public string PositionId { get; set; }

        public string DateAttended { get; set; }

        public string SubjectExternalId { get; set; }

        public string NumberHoursAttended { get; set; }

        public string NumberHoursExcused { get; set; }

        public DateTime? DateCreated { get; set; }

        public string CreatedByUserID { get; set; }

        [ResultColumn]
        public int OrganizationId { get; set; }

        [ResultColumn]
        public string InstanceNote { get; set; }
    }
}
