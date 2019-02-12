namespace VPT.Shared.Poco.Enum.Accounts
{
    public enum AddressType
    {
        /// <summary>
        /// No answer was given (0)
        /// </summary>
        Unspecified = 0,

        /// <summary>
        /// Physical Address (1)
        /// </summary>
        PhysicalAddress = 1,

        /// <summary>
        /// Mailing Address (2)
        /// </summary>
        MailingAddress = 2,
    }
    public static class AddressTypeConstants
    {
        /// <summary>
        /// No answer was given (0)
        /// </summary>
        public const string Unspecified = "Not Specified";

        /// <summary>
        /// Physical Address (1)
        /// </summary>
        public const string PhysicalAddress = "Physical Address";

        /// <summary>
        /// Mailing address (2)
        /// </summary>
        public const string MailingAddress = "Mailing Address";

        /// <summary>
        /// Get the display string for an enum by it's value in integer form
        /// </summary>
        /// <param name="value">The enum value in integer form</param>
        /// <returns>The display string for the value or the default if one cannot be found</returns>
        public static string GetByEnum(int value)
        {
            switch (value)
            {
                case (int)AddressType.Unspecified:
                    return Unspecified;

                case (int)AddressType.PhysicalAddress:
                    return PhysicalAddress;

                case (int)AddressType.MailingAddress:
                    return MailingAddress;

                default:
                    return Unspecified;
            }
        }

        /// <summary>
        /// Get the display string for an enum by it's value in enum form
        /// </summary>
        /// <param name="value">The enum value in enum form</param>
        /// <returns>The display string for the value or the default if one cannot be found</returns>
        public static string GetByEnum(Gender value)
        {
            return GetByEnum((int)value);
        }
    }
}