namespace VPT.Shared.Poco.Enum.Accounts
{
    /// <summary>
    /// The person genders we support
    /// </summary>
    public enum Gender
    {
        /// <summary>
        /// No answer was given (0)
        /// </summary>
        Unspecified = 0,

        /// <summary>
        /// They are a male or identify closely with one (1)
        /// </summary>
        Male = 1,

        /// <summary>
        /// They are a female or identify closely with one (2)
        /// </summary>
        Female = 2,
    }

    public static class GenderConstants
    {
        /// <summary>
        /// No answer was given (0)
        /// </summary>
        public const string Unspecified = "Not Specified";

        /// <summary>
        /// They are a male or identify closely with one (1)
        /// </summary>
        public const string Male = "Male";

        /// <summary>
        /// They are a female or identify closely with one (2)
        /// </summary>
        public const string Female = "Female";

        /// <summary>
        /// Get the display string for an enum by it's value in integer form
        /// </summary>
        /// <param name="value">The enum value in integer form</param>
        /// <returns>The display string for the value or the default if one cannot be found</returns>
        public static string GetByEnum(int value)
        {
            switch (value)
            {
                case (int)Gender.Unspecified:
                    return Unspecified;

                case (int)Gender.Male:
                    return Male;

                case (int)Gender.Female:
                    return Female;

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
