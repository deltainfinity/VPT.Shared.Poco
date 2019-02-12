using Newtonsoft.Json;

namespace VPT.Shared.Poco.DTO.Accounts.Form
{
    /// <summary>
    /// Contains the system user and subject delegation information
    /// </summary>
    public class SystemUserSubjectDelegateDTO
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public SystemUserSubjectDelegateDTO()
        {

        }

        /// <summary>
        /// Copy constructor for building a DTO from the system user ExternalSystemUserDetailsRequestDTO
        /// </summary>
        /// <param name="model">ExternalSystemUserDetailsRequestDTO containing system user details</param>
        public SystemUserSubjectDelegateDTO(ExternalSystemUserDetailsRequestDTO model)
        {
            if (model == null) return;

            AccountExternalId = model.ACCOUNT_EXTERNAL_ID.Trim();
            AuthenticationToken = model.AUTHENTICATION_TOKEN.Trim();
            SubjectExternalId = model.SUBJECT_EXTERNAL_ID.Trim();
            UserExternalId = model.USER_EXTERNAL_ID.Trim();
        }

        /// <summary>
        /// Constructor for building DTO using ExternalSystemUserDetailsRequestDTO containing system user details and subject delegate details
        /// </summary>
        /// <param name="model">ExternalSystemUserDetailsRequestDTO containing system user details</param>
        /// <param name="personId">The person ID of the subject delegate</param>
        /// <param name="organizationId">The organization ID that the subject delegate is associated with</param>
        public SystemUserSubjectDelegateDTO(ExternalSystemUserDetailsRequestDTO model, int personId, int organizationId)
        {
            if (model != null)
            {
                AccountExternalId = model.ACCOUNT_EXTERNAL_ID.Trim();
                AuthenticationToken = model.AUTHENTICATION_TOKEN.Trim();
                SubjectExternalId = model.SUBJECT_EXTERNAL_ID.Trim();
                UserExternalId = model.USER_EXTERNAL_ID.Trim();
            }

            PersonId = personId;
            OrganizationId = organizationId;
        }

        /// <summary>
        /// System user external account ID
        /// </summary>
        public string AccountExternalId { get; set; }

        /// <summary>
        /// System user external user ID
        /// </summary>
        public string UserExternalId { get; set; }

        /// <summary>
        /// External SOR ID of the subject delegate
        /// </summary>
        public string SubjectExternalId { get; set; }

        /// <summary>
        /// System user authentication token
        /// </summary>
        public string AuthenticationToken { get; set; }

        /// <summary>
        /// Person ID of the subject delegate
        /// </summary>
        public int PersonId { get; set; }

        /// <summary>
        /// Organization ID that the subject delegate is associated with
        /// </summary>
        public int OrganizationId { get; set; }
    }
}
