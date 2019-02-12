namespace VPT.Shared.Poco.DTO.Accounts.Aggregate
{
    /// <summary>
    /// Aggregate object containing all data related to a person
    /// </summary>
    public class ExternalUserDetailsForMessageBusDTO : ExternalUserDetailsDTO
    {
        /// <summary>
        /// Public Constructor
        /// </summary>
        public ExternalUserDetailsForMessageBusDTO()
        { }

        public ExternalUserDetailsForMessageBusDTO(ExternalUserDetailsDTO externalUser, string Auth0UserID, string userUniqueId, int organizationID) :base(externalUser)
        {
            VPTUserID = Auth0UserID;
            EmailAddress = externalUser.EmailAddress;
            UserUniqueId = userUniqueId;
            AccountID = organizationID;
        }             
        public string VPTUserID { get; set; }
        public string UserUniqueId { get; set; }
        public int AccountID { get; set; }

    }
}
