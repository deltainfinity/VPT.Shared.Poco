using NPoco;
using System;

namespace VPT.Shared.Poco.Model.API
{
    [TableName("SORProgram")]
    [PrimaryKey("SORProgramID")]
    public class SORClassSection
    {
        public SORClassSection()
        { }

        public SORClassSection(SORProgram source)
        {
            AccountExternalId = source.AccountExternalId;
            StateProgramId = source.StateProgramId;
            SiteID = source.SiteID;
            SectionID = source.PositionId;
            EffectiveDateFrom = source.EffectiveDateFrom;
            HighestCustodyLevel = source.HighestCustodyLevel;
            IncentivePayFlag = source.IncentivePayFlag;
            Schedule1 = source.Monday;
            Schedule2 = source.Tuesday;
            Schedule3 = source.Wednesday;
            Schedule4 = source.Thursday;
            Schedule5 = source.Friday;
            Schedule6 = source.Saturday;
            Schedule7 = source.Sunday;
            Supervisor = source.Supervisor;
            StartTime = source.StartTime;
            EndTime = source.EndTime;
            StartTime2 = source.StartTime2;
            EndTime2 = source.EndTime2;
            EffectiveDateTo = source.EffectiveDateTo;
            ClassLocation = source.JobLocation;
            ClassSize = source.ClassSize;
            OrganizationID = source.OrganizationID;
            DateCreated = source.DateCreated;
        }

        public string AccountExternalId { get; set; }
        public int SORProgramID { get; set; }
        public string StateProgramId { get; set; }
        public string SiteID { get; set; }
        public string SectionID { get; set; }
        public int ClassSize { get; set; }
        public string EffectiveDateFrom { get; set; }
        public string HighestCustodyLevel { get; set; }
        public string IncentivePayFlag { get; set; }
        public string Schedule1 { get; set; }
        public string Schedule2 { get; set; }
        public string Schedule3 { get; set; }
        public string Schedule4 { get; set; }
        public string Schedule5 { get; set; }
        public string Schedule6 { get; set; }
        public string Schedule7 { get; set; }
        public string Supervisor { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string StartTime2 { get; set; }
        public string EndTime2 { get; set; }
        public string EffectiveDateTo { get; set; }
        public string ClassLocation { get; set; }
        public int OrganizationID { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
