using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPT.Shared.Poco.Model.Accounts.Database
{
    public class OrganizationConfigurationDetail
    {
        public bool AssessmentAlert { get; set; }
        public bool DisableLMS { get; set; }
        public bool DisableMatchingProfileAndProgram { get; set; }
        public bool EnableBOP { get; set; }
        public bool EnableCasePlan { get; set; }
        public bool ShowSubjectProgramRecommendation { get; set; }
        public bool ShowVIDSRecommendedPrograms { get; set; }
        public bool EnableSubjectDataRefresh { get; set; }
        public int SubjectDataRefreshInterval { get; set; }
        public string Token { get; set; }
        public string LogicServerBaseUrl { get; set; }
        public string BIDashboardAccountEmail { get; set; }
        public string BIDashboardAutoToken { get; set; }
        public string BIDashboardBaseURL { get; set; }
        public string BIDashboardSSOEndPoint { get; set; }
        public string DummyEmailProvider { get; set; }
        public bool IntegratedOrganization { get; set; }
        public string IntegrationAPIUrl { get; set; }
        public string CCROffensesUrl { get; set; }
        public string DrugTestResultsUrl { get; set; }
        public string ExternalSubjectDetailsUrl { get; set; }
        public string ExternalUserDetailsUrl { get; set; }
        public string SORAuthTokenUrl { get; set; }
        public string STRONGRAuthoriztionHeader { get; set; }
        public string STRONGRSubjectCreationURL { get; set; }
        public string STRONGRUserCreationURL { get; set; }
        public bool ShowVerifyCCRButton { get; set; }
        public int IntegratedClient { get; set; }
        public bool EnableBIPlatform { get; set; }
        public bool EnableVPTReport { get; set; }
        public bool ProgramSettingsShowCredit { get; set; }
        public bool ShowMyAccount { get; set; }
        public bool ProgramSettingsShowIncentive { get; set; }
        public bool ProgramSettingsShowStateID { get; set; }
        public bool ProgramSettingsShowStateName { get; set; }
        public bool ProgramSettingsAllowMultipleReasons { get; set; }
        public string ExternalSubjectPropertiesUrl { get; set; }
        public bool MatchingLogicEnabled { get; set; }
        public bool PopulateCaseNumber { get; set; }
        public string CCRSentencesUrl { get; set; }
        public string ExternalProgramSubmitUrl { get; set; }
        public bool SendProgramToSOR { get; set; }
        public string CompanyName { get; set; }
        public string AccountControlSeverity { get; set; }
        public bool DisableCareGroup { get; set; }
        public bool DisableFacilityRequirement { get; set; }
        public bool EnableAttendanceReport { get; set; }
        public bool EnableMinPayRate { get; set; }
        public bool EnableProgramDuration { get; set; }
        public bool EnableNextGenNeedsModelReport { get; set; }
        public string LegalCodeLabel { get; set; }
        public string SystemOfRecordName { get; set; }
        public int LoginSystem { get; set; }
        public int TokensExpireInMinutes { get; set; }
        public bool ReasonForAssessment { get; set; }
    }
}
