using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using VPT.Shared.Poco.Enum.API;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API
{
    public class ParentProgramDTO : BaseDTO
    {
        public ParentProgramDTO()
        { }

        public ParentProgramDTO(ParentProgram source)
            : base(source)
        {
            ParentProgramId = source.ParentProgramId;
            //LocationId = source.LocationId;
            //ProviderId = source.ProviderId;
            //ProviderName = source.ProviderName;
            //ContactUserID = source.ContactUserID;
            Title = source.Title;
            Description = source.Description;
            SubTypeID = source.SubType;
            PlatformID = source.Platform;
            //Modality = source.Modality;
            //DeliveredBy = source.DeliveredBy;
            MaxClassSize = source.MaxClassSize;
            MinClassSize = source.MinClassSize;
            AppliesToGender = source.AppliesToGender;
            Required = source.Required;
            //ProgramDeveloper = source.ProgramDeveloper;
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
            DosageSpanID = source.DosageSpan;
            NumberOfSessions = source.NumberOfSessions;
            SessionLength = source.SessionLength;
            //SessionStartTime = source.SessionStartTime;
            //SessionEndTime = source.SessionEndTime;
            //ClassroomCode = source.ClassroomCode;
            ClassroomId = source.ClassroomId;
            MilestoneCredit = source.MilestoneCredit;
            MilestoneValue = source.MilestoneValue;
            MilestoneTypeID = source.MilestoneType;
            SourceOrganizationID = source.SourceOrganizationID;
            IsPublic = source.IsPublic;
            GoalID = source.GoalID;
            //NumberofSeats = source.NumberofSeats;
            IsActive = source.IsActive;
            RequireNewAssessment = source.RequireNewAssessment;
            AgencySettingsID = source.AgencySettings;
            ProgramDuration = source.ProgramDuration;
            DomainID = source.DomainID;
            Credit = source.Credit;
            IsIncentiveProgram = source.IsIncentiveProgram;
            StateProgramName = source.StateProgramName;
            StateProgramID = source.StateProgramID;
            IsPerpetual = source.IsPerpetual;
            ReasonRequired = source.ReasonRequired;
            MaxNumberOfSessions = source.MaxNumberOfSessions;
            HourlyPayRate = source.HourlyPayRate;
            IsOpen = source.IsOpen;
            IsSORProgram = source.IsSORProgram;
            IsApproved = source.IsApproved;
            ProgramProfileAccepted = source.ProgramProfileAccepted;
            ProgramExternalID = source.ProgramExternalID;
            ClassType = source.ClassType;
            Duration = source.Duration;
            PayRateEffectiveDate = source.PayRateEffectiveDate;
            CertificateType = source.CertificateType;
        }

        public int ParentProgramId { get; set; }

        //public int LocationId { get; set; }

        //public int ProviderId { get; set; }

        //public string ProviderName { get; set; }

        //public string ContactUserID { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int TypeID { get; set; }

        public string TypeName { get; set; }

        public int SubTypeID { get; set; }

        public string SubTypeName { get; set; }

        public int PlatformID { get; set; }

        public string PlatformName => PlatformTypeConstants.GetByEnum(PlatformID);

        //public string Modality { get; set; }

        //public string DeliveredBy { get; set; }

        public int MaxClassSize { get; set; }

        public int MinClassSize { get; set; }

        public string AppliesToGender { get; set; }

        public bool Required { get; set; }

        //public string ProgramDeveloper { get; set; }

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

        public int DosageSpanID { get; set; }

        public string DosageSpanName => DosageSpanConstants.GetByEnum(DosageSpanID);

        public int NumberOfSessions { get; set; }

        public string SessionLength { get; set; }

        //public string SessionStartTime { get; set; }

        //public string SessionEndTime { get; set; }

        public List<string> PrimaryTags { get; set; }

        public List<string> SecondaryTags { get; set; }

        public List<string> PrimaryRiskTags { get; set; }

        public List<string> FacilityIds { get; set; }

        //public string ClassroomCode { get; set; }

        public int ClassroomId { get; set; }

        public int SubjectsAssigned { get; set; }

        public bool MilestoneCredit { get; set; }

        public int MilestoneValue { get; set; }

        public int MilestoneTypeID { get; set; }

        public string MilestoneTypeName => MilestoneTypeConstants.GetByEnum(MilestoneTypeID);
        public int SourceOrganizationID { get; set; }
        public bool IsPublic { get; set; }
        public int GoalID { get; set; }
        public List<Tag> ProgramDomains { get; set; }
        public string DomainName { get; set; }
        public int DomainID { get; set; }
        public string GoalName {get;set;}
        public bool IsSurveyed { get; set; }
        public bool IsActive { get; set; }

        //public int NumberofSeats { get; set; }
        public bool RequireNewAssessment { get; set; }

        public List<ProgramComponentDTO> assignedComponent { get; set; }
        public List<int> PathwayIDs { get; set; }
        public List<TreatmentPathwayDTO> PathwayData { get; set; }

        public string ActionStep { get; set; }
        public int AgencySettingsID { get; set; }
        public string AgencySettingsName => AgencySettingsConstants.GetByEnum(AgencySettingsID);

        public decimal ProgramDuration { get; set; }  

        public int Credit { get; set; }

        public string CreditName => ProgramCreditsConstants.GetByEnum(Credit);

        public bool IsIncentiveProgram { get; set; }
        public string StateProgramName { get; set; }

        public string StateProgramID { get; set; }
        public bool IsPerpetual { get; set; }
        public List<AutoCompleteSelectListItem> methodOfTreatments { get; set; }
        public string MethodOfTreatmentsString { get; set; }
        public string ReasonRequired { get; set; }
        public int ProgramOwnerID { get; set; }
        public string ProgramOwnerName { get; set; }
        public int MaxNumberOfSessions { get; set; }
        public decimal HourlyPayRate { get; set; }

        public bool IsSORProgram { get; set; }

        public bool IsApproved { get; set; } = true;

        public int? ProgramExternalID { get; set; }

        /// <summary>
        /// The GoalTypeID
        /// </summary>
        [JsonProperty("programTypeID")]
        public int ProgramTypeID { get; set; }

        /// <summary>
        /// The programPriority
        /// </summary>
        [JsonProperty("priority")]
        public int Priority { get; set; }

        //for priority name setting
        [JsonProperty("programTypeName")]
        public string ProgramTypeName { get; set; }

        /// <summary>
        /// ProgramRecurringOption
        /// Now replacing Isperpetual flag
        /// </summary>
        [JsonProperty("isOpen")]
        public bool IsOpen { get; set; }

        public string ProgramProfileAccepted { get; set; }

        public int ClassType { get; set; }

        public string CertificateType { get; set; }

        public string Duration { get; set; }

        public string PayRateEffectiveDate { get; set; }
    }
}
