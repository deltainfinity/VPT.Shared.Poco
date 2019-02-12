using System;
using System.Collections.Generic;
using System.Linq;
using VPT.Shared.Poco.Enum.API;
using VPT.Shared.Poco.Enum.Accounts;

namespace VPT.Shared.Poco.DTO.API
{
    public class ProgramDetailsMessageDTO
    {
        public ProgramDetailsMessageDTO()
        { }

        public ProgramDetailsMessageDTO(ParentProgramDTO source)
        {
            Vant4geProgramID = source.ParentProgramId;
            StateProgramID = source.StateProgramID;
            ProgramStatus = source.IsActive ? "A" : "I";
            VantageTitle = source.Title;
            StateProgramName = source.StateProgramName;
            TotalDosage = source.NumberOfSessions;
            ProgramDuration = source.ProgramDuration;
            Description = source.Description;
            Platform = source.PlatformName.ToCharArray()[0].ToString();
            PrisonSupervision = AgencySettingsConstants.GetByEnum(source.AgencySettingsID).ToCharArray()[0].ToString();
            NumberofSession = source.NumberOfSessions;
            MaxClassSize = source.MaxClassSize;
            MinClassSize = source.MinClassSize;
            IncentiveProgram = source.IsIncentiveProgram ? "Y" : "N";
            Credits = source.CreditName;
            Gender = GenderConstants.GetByEnum(Convert.ToInt32(source.AppliesToGender)).ToCharArray()[0].ToString();
            RequiredProgram = source.Required ? "Y" : "N";
            RequireApprovalToJoin = source.RequireApproval ? "Y" : "N";
            ProvidesCertificateOnCompletion = source.Certificate ? "Y" : "N";
            TestRequiredForCompletion = source.HasTest ? "Y" : "N";
            CostPerPerson = source.CostPerPerson;
            CostToSubject = source.CostToSubject;
            RequireNewSTRONGR = source.RequireNewAssessment ? "Y" : "N";
            LastUpdateUserID = source.UpdatedByUserID;
            HourlyPayRate = source.HourlyPayRate;
            if (source.methodOfTreatments.Any())
            {
                List<string> methodOfTreatmentsNameList= source.methodOfTreatments.Select(x => x.Name).ToList();
                MethodofTreatment= methodOfTreatmentsNameList != null ? string.Join(",", methodOfTreatmentsNameList) : "";
            }
        }

        public int Vant4geProgramID { get; set; }
        public string StateProgramID { get; set; }
        public string ProgramStatus { get; set; }
        public string VantageTitle { get; set; }
        public string StateProgramName { get; set; }
        public decimal TotalDosage { get; set; }
        public decimal ProgramDuration { get; set; }
        public string Description { get; set; }
        public List<string> TreatmentPathway { get; set; }
        public string MethodofTreatment { get; set; }
        public string Platform { get; set; }
        public string PrisonSupervision { get; set; }
        public int NumberofSession { get; set; }
        public int MaxClassSize { get; set; }
        public int MinClassSize { get; set; }
        public string IncentiveProgram { get; set; }
        public string Credits { get; set; }
        public string Gender { get; set; }
        public string RequiredProgram { get; set; }
        public string RequireApprovalToJoin { get; set; }
        public string ProvidesCertificateOnCompletion { get; set; }
        public string TestRequiredForCompletion { get; set; }
        public decimal CostPerPerson { get; set; }
        public decimal CostToSubject { get; set; }
        public string RequireNewSTRONGR { get; set; }
        public DateTime? ProgramCreateDate { get; set; }
        public string LastUpdateUserID { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public decimal HourlyPayRate { get; set; }
    }
}
