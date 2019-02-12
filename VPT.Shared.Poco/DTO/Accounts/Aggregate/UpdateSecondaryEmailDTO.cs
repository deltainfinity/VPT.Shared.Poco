namespace VPT.Shared.Poco.DTO.Accounts.Aggregate
{
    public class UpdateSecondaryEmailDTO
    {

        /// <summary>
        /// Public Constructor
        /// </summary>
        public UpdateSecondaryEmailDTO()
        { }

        public int userID { get; set; }

        public int organizationID { get; set; }

        public int secondaryEmailType { get; set; }

        public string  secondaryEmail { get; set; }
      
    }
}
