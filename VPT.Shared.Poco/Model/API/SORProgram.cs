using NPoco;
using System;
using VPT.Shared.Poco.DTO.API;

namespace VPT.Shared.Poco.Model.API
{
    [TableName("SORProgram")]
    [PrimaryKey("SORProgramID")]
    public class SORProgram
    {
        public SORProgram()
        { }

        public SORProgram(SORProgramDTO source)
        {
            AccountExternalId = source.AccountExternalId;
            StateProgramId = source.StateProgramId;
            SiteID = source.SiteID;
            SiteName = source.SiteName;
            SubjectExternalId = source.SubjectExternalId;
            PositionId = source.PositionId;
            PositionType = source.PositionType;
            EffectiveDateFrom = source.EffectiveDateFrom;
            BasePayRate = source.BasePayRate;
            HighestCustodyLevel = source.HighestCustodyLevel;
            PositionDescription1 = source.PositionDescription1;
            PositionDescription2 = source.PositionDescription2;
            PositionDescription3 = source.PositionDescription3;
            PositionDescription4 = source.PositionDescription4;
            PositionDescription5 = source.PositionDescription5;
            PositionDescription6 = source.PositionDescription6;
            PositionDescription7 = source.PositionDescription7;
            IncentivePayFlag = source.IncentivePayFlag;
            Monday = source.Monday;
            Tuesday = source.Tuesday;
            Wednesday = source.Wednesday;
            Thursday = source.Thursday;
            Friday = source.Friday;
            Saturday = source.Saturday;
            Sunday = source.Sunday;
            Supervisor = source.Supervisor;
            SupervisionName = source.SupervisionName;
            OffenderStartDate = source.OffenderStartDate;
            StartTime = source.StartTime;
            EndTime = source.EndTime;
            StartTime2 = source.StartTime2;
            EndTime2 = source.EndTime2;
            OffenderEndDate = source.OffenderEndDate;
            EffectiveDateTo = source.EffectiveDateTo;
            JobLocation = source.JobLocation;
            TerminationDecidedBy = source.TerminationDecidedBy;
            TerminationDate = source.TerminationDate;
            TerminationReason1 = source.TerminationReason1;
            TerminationReason2 = source.TerminationReason2;
            TerminationReason3 = source.TerminationReason3;
            ClassSize = source.ClassSize;
        }
        public SORProgram(SORClassRoster source)
        {
            StateProgramId = source.StateProgramId;
            AccountExternalId = source.AccountExternalId;
            OffenderEndDate = source.EndDate;
            OffenderStartDate = source.StartDate;
            TerminationDecidedBy = source.TerminationDecidedBy;
            TerminationReason1 = source.ReasonForTermination1;
            TerminationReason2 = source.ReasonForTermination2;
            TerminationReason3 = source.ReasonForTermination3;
            OrganizationID = source.OrganizationID;
            PositionId = source.SectionID;
            SubjectExternalId = source.OffenderID;
            DateCreated = source.DateCreated;
            SiteID = source.SiteID;
        }

        public SORProgram(SORClassSection source)
        {
            AccountExternalId = source.AccountExternalId;
            StateProgramId = source.StateProgramId;
            SiteID = source.SiteID;
            OrganizationID = source.OrganizationID;
            PositionId = source.SectionID;
            EffectiveDateFrom = source.EffectiveDateFrom;
            HighestCustodyLevel = source.HighestCustodyLevel;
            IncentivePayFlag = source.IncentivePayFlag;
            Monday = source.Schedule1;
            Tuesday = source.Schedule2;
            Wednesday = source.Schedule3;
            Thursday = source.Schedule4;
            Friday = source.Schedule5;
            Saturday = source.Schedule6;
            Sunday = source.Schedule7;
            Supervisor = source.Supervisor;
            StartTime = source.StartTime;
            EndTime = source.EndTime;
            StartTime2 = source.StartTime2;
            EndTime2 = source.EndTime2;
            EffectiveDateTo = source.EffectiveDateTo;
            JobLocation = source.ClassLocation;
            ClassSize = source.ClassSize;
            DateCreated = source.DateCreated;
        }

        public int SORProgramID { get; set; }
        public string AccountExternalId { get; set; }
        public string StateProgramId { get; set; }
        public string SiteID { get; set; }
        public string SiteName { get; set; }
        public string SubjectExternalId { get; set; }
        public string PositionId { get; set; }
        public string PositionType { get; set; }
        public string EffectiveDateFrom { get; set; }
        public string BasePayRate { get; set; }
        public string HighestCustodyLevel { get; set; }
        public string PositionDescription1 { get; set; }
        public string PositionDescription2 { get; set; }
        public string PositionDescription3 { get; set; }
        public string PositionDescription4 { get; set; }
        public string PositionDescription5 { get; set; }
        public string PositionDescription6 { get; set; }
        public string PositionDescription7 { get; set; }
        public string IncentivePayFlag { get; set; }
        public string Monday { get; set; }
        public string Tuesday { get; set; }
        public string Wednesday { get; set; }
        public string Thursday { get; set; }
        public string Friday { get; set; }
        public string Saturday { get; set; }
        public string Sunday { get; set; }
        public string Supervisor { get; set; }
        public string SupervisionName { get; set; }
        public string OffenderStartDate { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string StartTime2 { get; set; }
        public string EndTime2 { get; set; }
        public string OffenderEndDate { get; set; }
        public string EffectiveDateTo { get; set; }
        public string JobLocation { get; set; }
        public int OrganizationID { get; set; }
        public DateTime DateCreated { get; set; }
        public string TerminationDecidedBy { get; set; }
        public string TerminationDate { get; set; }
        public string TerminationReason1 { get; set; }
        public string TerminationReason2 { get; set; }
        public string TerminationReason3 { get; set; }
        public int ClassSize { get; set; }
    }
}
