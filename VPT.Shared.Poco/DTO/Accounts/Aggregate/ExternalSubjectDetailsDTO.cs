using System;
using System.Collections.Generic;
using VPT.Shared.Poco.DTO.Accounts.Form;
using VPT.Shared.Poco.Enum.Accounts;

namespace VPT.Shared.Poco.DTO.Accounts.Aggregate
{
    /// <summary>
    /// Aggregate object containing all data related to a person
    /// </summary>
    public class ExternalSubjectDetailsDTO
    {
        /// <summary>
        /// Public Constructor
        /// </summary>
        public ExternalSubjectDetailsDTO()
        { }

        public ExternalSubjectDetailsDTO(ExternalSubjectDetailsDTO externalSubjectDetails)
        {
            Email = externalSubjectDetails.Email;
            HairColor = externalSubjectDetails.HairColor;
            EyeColor = externalSubjectDetails.EyeColor;
            HeightFeet = externalSubjectDetails.HeightFeet;
            HeightInches = externalSubjectDetails.HeightInches;
            Weight = externalSubjectDetails.Weight;
            DMVNumber = externalSubjectDetails.DMVNumber;
            DMVState = externalSubjectDetails.DMVState;
            Citizenship = externalSubjectDetails.Citizenship;
            SSN = externalSubjectDetails.SSN;
            Address1 = externalSubjectDetails.Address1;
            Address2 = externalSubjectDetails.Address2;
            City = externalSubjectDetails.City;
            State = externalSubjectDetails.State;
            Zip = externalSubjectDetails.Zip;
            County = externalSubjectDetails.County;
            Phone = externalSubjectDetails.Phone;
            Ethnicity = externalSubjectDetails.Ethnicity;
            FirstName = externalSubjectDetails.FirstName;
            LastName = externalSubjectDetails.LastName;
            MiddleName = externalSubjectDetails.MiddleName;
            DOB = externalSubjectDetails.DOB;
            Gender = externalSubjectDetails.Gender;
            SubjectStatusId = externalSubjectDetails.SubjectStatusId;
            //OffenderStatus = externalSubjectDetails.OffenderStatus;
            //OffenderStatusDesc = externalSubjectDetails.OffenderStatusDesc;
            Caseload = externalSubjectDetails.Caseload;
            OffenderSite = externalSubjectDetails.OffenderSite;
            SiteName = externalSubjectDetails.SiteName;
            SiteType = externalSubjectDetails.SiteType;
            SiteID= externalSubjectDetails.SiteID;
            SiteAddressLine1 = externalSubjectDetails.SiteAddressLine1;
            SiteAddressLine2 = externalSubjectDetails.SiteAddressLine2;
            SiteCity = externalSubjectDetails.SiteCity;
            SiteState = externalSubjectDetails.SiteState;
            SiteZip = externalSubjectDetails.SiteZip;
            ReleaseEligibilityDate = externalSubjectDetails.ReleaseEligibilityDate;
            ExpirationDate = externalSubjectDetails.ExpirationDate;
            EmergencyContactName = externalSubjectDetails.EmergencyContactName;
            EmergencyContactAddressLine1 = externalSubjectDetails.EmergencyContactAddressLine1;
            EmergencyContactAddressLine2 = externalSubjectDetails.EmergencyContactAddressLine2;
            EmergencyContactCity = externalSubjectDetails.EmergencyContactCity;
            EmergencyContactState = externalSubjectDetails.EmergencyContactState;
            EmergencyContactZip = externalSubjectDetails.EmergencyContactZip;
            EmergencyContactPhone = externalSubjectDetails.EmergencyContactPhone;
            SexOffenderType = externalSubjectDetails.SexOffenderType;
            PendingCharges = externalSubjectDetails.PendingCharges;
            StaffAssignments = externalSubjectDetails.StaffAssignments;
            Incompatibles = externalSubjectDetails.Incompatibles;
            SecurityThreatGroupId = externalSubjectDetails.SecurityThreatGroupAssessment;
            SecurityThreatGroupName = externalSubjectDetails.SecurityThreatGroupName;
            SecurityThreatGroupAssessment = externalSubjectDetails.SecurityThreatGroupAssessment;
            if (SecurityThreatGroup != null)
            {
                SecurityThreatGroup.SecurityThreatGroupRank = externalSubjectDetails.SecurityThreatGroup != null ? externalSubjectDetails.SecurityThreatGroup.SecurityThreatGroupRank : null;
                SecurityThreatGroup.SecurityThreatGroupStatus = externalSubjectDetails.SecurityThreatGroup != null ? externalSubjectDetails.SecurityThreatGroup.SecurityThreatGroupStatus : null;
                SecurityThreatGroup.SecurityThreatGroupStatusDate = externalSubjectDetails.SecurityThreatGroup != null ? externalSubjectDetails.SecurityThreatGroup.SecurityThreatGroupStatusDate : null;
            }
            Detainers = externalSubjectDetails.Detainers;
            Warrants = externalSubjectDetails.Warrants;
            ISCSentences = externalSubjectDetails.ISCSentences;
            CaseType = externalSubjectDetails.CaseType;
            SupervisionLevel = externalSubjectDetails.SupervisionLevel;
            Custody = externalSubjectDetails.Custody;
            SecurityThreatGroup = externalSubjectDetails.SecurityThreatGroup;
            GED = externalSubjectDetails.GED;
            SentenceMax = externalSubjectDetails.SentenceMax;
            SentenceMin = externalSubjectDetails.SentenceMin;
            MilitaryStatus = externalSubjectDetails.MilitaryStatus;
            VeteranStatus = externalSubjectDetails.VeteranStatus;
            Aliases = externalSubjectDetails.Aliases;
            Jobs = externalSubjectDetails.Jobs;
            Employment = externalSubjectDetails.Employment;
            Courses = externalSubjectDetails.Courses;
            Hearings = externalSubjectDetails.Hearings;
            Disciplinaries = externalSubjectDetails.Disciplinaries;
            MentalHealthLevelofCare = externalSubjectDetails.MentalHealthLevelofCare;
            HealthLevelofCare = externalSubjectDetails.HealthLevelofCare;
            CustodyLevelHistory = externalSubjectDetails.CustodyLevelHistory;
            SubjectOffenses = externalSubjectDetails.SubjectOffenses;
            SubjectLogonID = externalSubjectDetails.SubjectLogonID;

        }

        public ExternalSubjectDetailsDTO(CreateUserDTO externalSubjectDetails ,int OffenderID)
        {
            Email = externalSubjectDetails.Email;
            Phone = externalSubjectDetails.Phone;
            FirstName = externalSubjectDetails.FirstName;
            LastName = externalSubjectDetails.LastName;
            MiddleName = externalSubjectDetails.MiddleName;
            DOB = externalSubjectDetails.BirthDate.HasValue ? externalSubjectDetails.BirthDate.Value : Convert.ToDateTime(string.Empty);
            Gender = GenderConstants.GetByEnum(externalSubjectDetails.GenderID);
            ReleaseEligibilityDate = externalSubjectDetails.EstimatedReleaseDate.ToString();
            Ethnicity = externalSubjectDetails.RaceID;
            SubjectLogonID = OffenderID;
        }

        public string Email { get; set; }

        public string HairColor { get; set; }

        public string EyeColor { get; set; }

        public int? HeightFeet { get; set; }

        public int? HeightInches { get; set; }

        public int? Weight { get; set; }

        public string DMVNumber { get; set; }

        public string DMVState { get; set; }

        public string Citizenship { get; set; }

        public string SSN { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Zip { get; set; }

        public string County { get; set; }

        public string Phone { get; set; }
        public int SubjectLogonID { get; set; }

        //Ethnicity int Yes Must map to ADC list:
        //0 – N/A
        //1 – Other
        //2 – White
        //3 – Black or African American
        //4 – American Indian or Alaska Native
        //5 – Asian
        //6 – Native Hawaiian or Other Pacific
        //Islander
        //7 – Hispanic or Latino
        public int Ethnicity { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public DateTime? DOB { get; set; }

        /// <summary>
        /// The age of the person
        /// </summary>
        public int Age
        {
            get
            {
                if (!DOB.HasValue)
                {
                    return 0;
                }

                int age = DateTime.Now.Year - DOB.Value.Year;
                if (DateTime.Now.Month < DOB.Value.Month || (DateTime.Now.Month == DOB.Value.Month && DateTime.Now.Day < DOB.Value.Day))
                {
                    age--;
                }

                return age;
            }
        }

        //M or F
        public string Gender { get; set; }

        //1-Active 0-Inactive
        public int SubjectStatusId { get; set; }
        //public string Caseload { get; set; } //May be numeric or text

        //New fields added to show in VPT
        public string OffenderStatus { get; set; }
        public string OffenderStatusDesc { get; set; }
        public string Caseload { get; set; }
        public OffenderSite OffenderSite { get; set; }
        public string SiteID { get; set; }
        public string SiteName { get; set; }
        public string SiteType { get; set; }
        public string SiteAddressLine1 { get; set; }
        public string SiteAddressLine2 { get; set; }
        public string SiteCity { get; set; }
        public string SiteState { get; set; }
        public string SiteZip { get; set; }
        public string ReleaseEligibilityDate { get; set; }
        public string ExpirationDate { get; set; }
        public Custody Custody { get; set; }
        public string EmergencyContactName { get; set; }
        public string EmergencyContactAddressLine1 { get; set; }
        public string EmergencyContactAddressLine2 { get; set; }
        public string EmergencyContactCity { get; set; }
        public string EmergencyContactState { get; set; }
        public string EmergencyContactZip { get; set; }
        public string EmergencyContactPhone { get; set; }
        public string SexOffenderType { get; set; }
        public string PendingCharges { get; set; }
        public AssignedStaff StaffAssignments { get; set; }
        public List<SubjectIncompatible> Incompatibles { get; set; }
        public SecurityThreatGroup SecurityThreatGroup { get; set; }
        public string SecurityThreatGroupId { get; set; }
        public string SecurityThreatGroupName { get; set; }
        public string SecurityThreatGroupAssessment { get; set; }
        public string Detainers { get; set; }
        public List<SubjectWarrants> Warrants { get; set; }
        public List<ISCSentence> ISCSentences { get; set; }
        public string CaseType { get; set; }
        public SubjectSupervisionLevel SupervisionLevel { get; set; }
        public List<Alias> Aliases { get; set; }

        public string MilitaryStatus { get; set; }

        public string VeteranStatus { get; set; }

        public string ActiveDetainers { get; set; }

        public string GED { get; set; }

        public string SentenceMax { get; set; }
        public string SentenceMin { get; set; }

        public List<Hearing> Hearings { get; set; }

        public List<Disciplinaries> Disciplinaries { get; set; }

        public List<Employment> Employment { get; set; }

        public List<Jobs> Jobs { get; set; }

        public List<Courses> Courses { get; set; }

        public MentalHealthLevelofCare MentalHealthLevelofCare { get; set; }

        public HealthLevelofCare HealthLevelofCare { get; set; }

        public List<CustodyLevelHistory> CustodyLevelHistory { get; set; }

        public string EthnicityString => RaceConstants.GetByEnum(Ethnicity);

        public string SORID { get; set; }

        public List<SubjectOffenses> SubjectOffenses { get; set; }

        /// <summary>
        /// PREVISID
        /// </summary>
        public string Field1 { get; set; }

        /// <summary>
        /// FBI ID
        /// </summary>
        public string Field2 { get; set; }

        /// <summary>
        /// SID
        /// </summary>
        public string Field3 { get; set; }

        /// <summary>
        /// Facility
        /// </summary>
        public string Field4 { get; set; }

        /// <summary>
        /// Housing Unit 
        /// </summary>
        public string Field5 { get; set; }

        /// <summary>
        /// Date
        /// </summary>
        public string Field6 { get; set; }
    }

    public class AssignedStaff
    {
        public string StaffID { get; set; }
        public string StaffFirstName { get; set; }
        public string StaffLastName { get; set; }
        public string StaffSiteID { get; set; }
        public string StaffTitleCode { get; set; }
        public string StaffTitle { get; set; }
        public string AssignmentTypeCode { get; set; }
        public string AssignmentType { get; set; }
        public string AssignmentStartDate { get; set; }
    }

    public class SubjectIncompatible
    {
        public string IncompatibleFirstName { get; set; }
        public string IncompatibleLastName { get; set; }
        public string IncompatibleOffenderID { get; set; }
    }

    public class SubjectSupervisionLevel
    {
        public string SupervisionLevelCode { get; set; }
        public string SupervisionLevel { get; set; }
    }

    public class SubjectWarrants
    {
        public string WarrantIssueDate { get; set; }
        public string WarrantNumber { get; set; }
        public string WarrantType { get; set; }
        public string WarrantStatusCode { get; set; }
        public string WarrantStatus { get; set; }
        public string WarrantReason { get; set; }
    }

    public class OffenderSite
    {
        public string SiteAddressLine1 { get; set; }  //: "RONALD L. SEALS, SHERIFF",
        public string SiteAddressLine2 { get; set; }  //: "137 COMMERCE ST",
        public string SiteCity { get; set; }      //: "SEVIERVILLE",
        public string SiteID { get; set; }      //: "078  ",
        public string SiteName { get; set; }   //: "SEVIER COUNTY JAIL",
        public string SiteState { get; set; }  //: "TN",
        public string SiteType { get; set; }  //: "JA",
        public string SiteZip { get; set; }  //: "37862-3535"
    }

    public class SecurityThreatGroup
    {
        public string SecurityThreatGroupId { get; set; }//: "ARYB",
        public string SecurityThreatGroupName { get; set; }//": "ARYAN BROTHERHOOD",
        public string SecurityThreatGroupAssessment { get; set; }//": "Confirmed"
        public string SecurityThreatGroupRank { get; set; }
        public string SecurityThreatGroupStatus { get; set; }
        public string SecurityThreatGroupStatusDate { get; set; }
    }

    public class Custody
    {
        public string CustodyLevelSite { get; set; }
        public string CustodyLevelDate { get; set; }
        public string CustodyLevelCode { get; set; }
        public string CustodyLevel { get; set; }
    }
    public class Alias
    {
        public string AliasName { get; set; }
    }
    public class Hearing
    {
        public int HearingID { get; set; }
        public string HearingDate { get; set; }
        public string HearingType { get; set; }
        public string HearingTypeCode { get; set; }
        public string ParoleDecision { get; set; }
        public string FinalHearingDate { get; set; }
        public string HearingOfficerLastName { get; set; }
        public string HearingOfficerFirstName { get; set; }
        public string FutureAction { get; set; }
        public string FutureActionDate { get; set; }
        public string ParoleCondition { get; set; }
        public List<BoardVotes> BoardVotes { get; set; }
    }

    public class BoardVotes
    {
        public string BoardMember { get; set; }
        public string BoardVote { get; set; }
        public string BoardComments { get; set; }
    }
    public class Disciplinaries
    {
        public string DisciplinaryIncidentDate { get; set; }
        public string DisciplinaryCode { get; set; }
        public string DisciplinaryType { get; set; }
        public string Disposition { get; set; }
    }
    public class Employment
    {
        public string EmployerName { get; set; }
        public string Occupation { get; set; }
        public string EndReason { get; set; }
    }
    public class Jobs
    {
        public string JobName { get; set; }
        public string JobStartDate { get; set; }
        public string JobEndDate { get; set; }
        public string TerminationReason { get; set; }
        public string Comments { get; set; }
        public string JobProgramFlag { get; set; }
        public string Status { get; set; }
    }
    public class Courses
    {
        public string CourseName { get; set; }
        public string CourseStartDate { get; set; }
        public string CourseEndDate { get; set; }
        public string TerminationReason { get; set; }
        public string Comments { get; set; }
    }
    public class MentalHealthLevelofCare
    {
        public string LevelOfCareDate { get; set; }
        public string LevelOfCareTime { get; set; }
        public string LevelOfCare { get; set; }
    }
    public class HealthLevelofCare
    {
        public string ExamDate { get; set; }
        public string ExamSiteId { get; set; }
        public string HealthClassification { get; set; }
        public string Comments { get; set; }
    }
    public class CustodyLevelHistory
    {
        public string CustodyLevelSite { get; set; }
        public string CustodyLevelDate { get; set; }
        public string CustodyLevelCode { get; set; }
        public string CustodyLevel { get; set; }
    }
    public class ISCSentence
    {
        public string Jurisdiction { get; set; }
        public string ISCStatus { get; set; }
        public string CaseYear { get; set; }
        public string CaseNumber { get; set; }
        public string CountNumber { get; set; }
        public string ExpirationDate { get; set; }
    }

    public class SubjectOffenses
    {
        public string SentenceStatus { get; set; }
        public string OffenseName { get; set; }
        public string OffenseDate { get; set; }
        public string MaxSentence { get; set; }
        public string MinSentence { get; set; }
        public string SentenceImposedDate { get; set; }
        public string SentenceEffectiveDate { get; set; }
        public string SentenceExpirationDate { get; set; }
        public string ReleaseEligibilityDate { get; set; }
        public string OtherSentence { get; set; }
    }
}
