
namespace VPT.Shared.Poco.DTO.Accounts.Form
{
    /// <summary>
    /// The subject portal single sign on information for a subject
    /// </summary>
    public class SubjectPortalSingleSignOnSubjectDataDTO
    {
        /// <summary>
        /// The external ID of the single sign on subject
        /// </summary>
        public string BookingID { get; set; }
        /// <summary>
        /// The site ID of the facility where the subject is located
        /// </summary>
        public string SiteID { get; set; }
        /// <summary>
        /// The Vant4gePoint organization ID of the organization which the subject is affiliated with
        /// </summary>
        public int VpOrganizationID { get; set; }
    }
}
