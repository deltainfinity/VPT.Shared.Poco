namespace VPT.Shared.Poco.Enum.Accounts
{
    /// <summary>
    /// The person ContactTypes we support
    /// </summary>
    public enum ContactType
    {
        /// <summary>
        /// No answer was given (0)
        /// </summary>
        Unspecified = 0,

        /// <summary>
        /// The contact is for an email address (1)
        /// </summary>
        Email = 1,

        /// <summary>
        /// The contact is for a phone number (2)
        /// </summary>
        Phone = 2,

        /// <summary>
        /// The contact is for a mobile/cell phone (3)
        /// </summary>
        Mobile = 3,

        /// <summary>
        /// The contact is for a SMS phone/pager (4)
        /// </summary>
        SMS = 4,

        /// <summary>
        /// The contact is for a pager (5)
        /// </summary>
        Pager = 5,

        /// <summary>
        /// The contact is for a fax machine (6)
        /// </summary>
        Fax = 6,

        /// <summary>
        /// The contact is for some other type (7)
        /// </summary>
        Other = 7,

        /// <summary>
        /// The contact is for secondary email address (8)
        /// </summary>
        SecondaryEmail = 8
    }

    public static class ContactTypeConstants
    {
        /// <summary>
        /// No answer was given (0)
        /// </summary>
        public const string Unspecified = "Not Specified";

        /// <summary>
        /// The contact is for an email address (1)
        /// </summary>
        public const string Email = "Email";

        /// <summary>
        /// The contact is for a phone number (2)
        /// </summary>
        public const string Phone = "Phone";

        /// <summary>
        /// The contact is for a mobile/cell phone (3)
        /// </summary>
        public const string Mobile = "Mobile Phone";

        /// <summary>
        /// The contact is for a SMS phone/pager (4)
        /// </summary>
        public const string SMS = "SMS";

        /// <summary>
        /// The contact is for a pager (5)
        /// </summary>
        public const string Pager = "Pager";

        /// <summary>
        /// The contact is for a fax machine (6)
        /// </summary>
        public const string Fax = "Fax";

        /// <summary>
        /// The contact is for some other type (7)
        /// </summary>
        public const string Other = "Other";

        /// <summary>
        /// The contact is for secondary email address (8)
        /// </summary>
        public const string SecondaryEmail = "SecondaryEmail";

        /// <summary>
        /// Get the display string for an enum by it's value in integer form
        /// </summary>
        /// <param name="value">The enum value in integer form</param>
        /// <returns>The display string for the value or the default if one cannot be found</returns>
        public static string GetByEnum(int value)
        {
            switch (value)
            {
                case (int)ContactType.Unspecified:
                    return Unspecified;

                case (int)ContactType.Email:
                    return Email;

                case (int)ContactType.Phone:
                    return Phone;

                case (int)ContactType.Mobile:
                    return Mobile;

                case (int)ContactType.SMS:
                    return SMS;

                case (int)ContactType.Pager:
                    return Pager;

                case (int)ContactType.Fax:
                    return Fax;

                case (int)ContactType.Other:
                    return Other;

                case (int)ContactType.SecondaryEmail:
                    return SecondaryEmail;

                default:
                    return Unspecified;
            }
        }

        /// <summary>
        /// Get the display string for an enum by it's value in enum form
        /// </summary>
        /// <param name="value">The enum value in enum form</param>
        /// <returns>The display string for the value or the default if one cannot be found</returns>
        public static string GetByEnum(ContactType value)
        {
            return GetByEnum((int)value);
        }
    }
}
