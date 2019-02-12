using NPoco;
using System;
using VPT.Shared.Poco.Enum.API;
using VPT.Shared.Poco.DTO.API;

namespace VPT.Shared.Poco.Model.API
{
    /// <summary>
    /// Class for defining a ParentProgram
    /// </summary>
    [TableName("ParentProgram")]
    [PrimaryKey("ParentProgramId")]
    public class ParentProgram : BaseModel
    {
        public ParentProgram()
        { }

        public ParentProgram(ParentProgramDTO source)
             : base(source)
        {
            ParentProgramId = source.ParentProgramId;
            Title = source.Title;
            Description = source.Description;
            SubType = source.SubTypeID;
            Platform = source.PlatformID;
            MaxClassSize = source.MaxClassSize;
            MinClassSize = source.MinClassSize;
            AppliesToGender = source.AppliesToGender;
            Required = source.Required;
            CostPerPerson = source.CostPerPerson;
            CostToSubject = source.CostToSubject;
            Certificate = source.Certificate;
            RequireApproval = source.RequireApproval;
            HasTest = source.HasTest;
            MockInterviewExperience = source.MockInterviewExperience;
            DrugorAlcoholTreatment = source.DrugorAlcoholTreatment;
            StartDate = source.StartDate;
            EndDate = source.EndDate;
            Dosage = source.Dosage;
            DosageSpan = source.DosageSpanID;
            NumberOfSessions = source.NumberOfSessions;
            MaxNumberOfSessions = source.MaxNumberOfSessions;
            SessionLength = source.SessionLength;
            HourlyPayRate = source.HourlyPayRate;
            ClassroomId = source.ClassroomId;
            MilestoneCredit = source.MilestoneCredit;
            MilestoneValue = source.MilestoneValue;
            MilestoneType = source.MilestoneTypeID;
            SourceOrganizationID = source.SourceOrganizationID;
            IsPublic = source.IsPublic;
            GoalID = source.GoalID;
            IsActive = source.IsActive;
            RequireNewAssessment = source.RequireNewAssessment;
            AgencySettings = source.AgencySettingsID;
            ProgramDuration = source.ProgramDuration;
            Credit = source.Credit;
            IsIncentiveProgram = source.IsIncentiveProgram;
            StateProgramName = source.StateProgramName;
            StateProgramID = source.StateProgramID;
            IsPerpetual = source.IsPerpetual;
            ReasonRequired = source.ReasonRequired;
            IsOpen = source.IsOpen;
            IsApproved = source.IsApproved;
            ProgramProfileAccepted = source.ProgramProfileAccepted;
            ProgramExternalID = source.ProgramExternalID;
            ClassType = source.ClassType;
            CertificateType = source.CertificateType;
            //TODO:Temporarily seting value as 'NA' until the confirmation on this field
            Duration = "NA";
            PayRateEffectiveDate = source.PayRateEffectiveDate;
        }

        public int ParentProgramId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int SubType { get; set; }

        public int Platform { get; set; }

        public int MaxClassSize { get; set; }

        public int MinClassSize { get; set; }

        public string AppliesToGender { get; set; }

        public bool Required { get; set; }

        public decimal CostPerPerson { get; set; }

        public decimal CostToSubject { get; set; }

        public bool Certificate { get; set; }

        public bool RequireApproval { get; set; }

        public bool HasTest { get; set; }

        public string MockInterviewExperience { get; set; }

        public bool DrugorAlcoholTreatment { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public decimal Dosage { get; set; }

        public int DosageSpan { get; set; }

        public int NumberOfSessions { get; set; }

        public int MaxNumberOfSessions { get; set; }

        public string SessionLength { get; set; }

        public decimal HourlyPayRate { get; set; }

        [ResultColumn]
        public int ClassroomId { get; set; }

        public bool MilestoneCredit { get; set; }

        public int MilestoneValue { get; set; }

        public int MilestoneType { get; set; }

        public int SourceOrganizationID { get; set; }

        public bool IsPublic { get; set; }

        public int GoalID { get; set; }

        public bool IsActive { get; set; }

        public bool RequireNewAssessment { get; set; }

        public int AgencySettings { get; set; }

        public decimal ProgramDuration { get; set; }

        [ResultColumn]
        public int DomainID { get; set; }

        public int Credit { get; set; }

        public bool IsIncentiveProgram { get; set; }
        public string StateProgramName { get; set; }

        public string StateProgramID { get; set; }

        public int? ProgramExternalID { get; set; }

        [ResultColumn]
        public bool IsPerpetual
        {
            get { return IsOpen; }
            set { }
        }

        [ResultColumn]
        public int ProgramTypeID { get; set; }

        [ResultColumn]
        public int Priority { get; set; }

        public string ReasonRequired { get; set; }

        public bool IsOpen { get; set; }

        [ResultColumn]
        public bool IsSORProgram { get; set; }

        public bool IsApproved { get; set; }

        public string ProgramProfileAccepted { get; set; }

        [ResultColumn]
        public string AgencySettingsName
        {
            get { return AgencySettingsConstants.GetByEnum(AgencySettings); }
        }

        public int ClassType { get; set; }

        public string CertificateType { get; set; }

        public string Duration { get; set; }

        public string PayRateEffectiveDate { get; set; }
    }
}

