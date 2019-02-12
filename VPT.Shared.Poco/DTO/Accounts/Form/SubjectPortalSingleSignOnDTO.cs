

namespace VPT.Shared.Poco.DTO.Accounts.Form
{
    /// <summary>
    /// The single sign on data used to access the subject portal
    /// </summary>
    public class SubjectPortalSingleSignOnDTO
    {
        /// <summary>
        /// The token used to access the subject portal
        /// </summary>
        public string Token { get; set; }
        /// <summary>
        /// The URL of the subject portal
        /// </summary>
        public string Url { get; set; }
    }
}
