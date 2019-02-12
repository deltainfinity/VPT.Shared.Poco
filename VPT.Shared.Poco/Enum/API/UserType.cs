namespace VPT.Shared.Poco.Enum.API
{
    /// <summary>
    /// The various user types we support
    /// </summary>
    public enum UserType
    {
        /// <summary>
        /// User type is unknown (0)
        /// </summary>
        Unknown = 0,

        /// <summary>
        /// User is a subject (1)
        /// </summary>
        Subject = 1,

        /// <summary>
        /// User is a provider agent (2)
        /// </summary>
        Agent = 2,
    }

    /// <summary>
    /// Display names for the various user types we support
    /// </summary>
    public class UserTypeConstants
    {
        /// <summary>
        /// User type is unknown (0)
        /// </summary>
        public const string Unknown = "Unknown";

        /// <summary>
        /// User is a subject (1)
        /// </summary>
        public const string Subject = "subject";

        /// <summary>
        /// User is a provider agent (2)
        /// </summary>
        public const string Agent = "agent";

        /// <summary>
        /// Get the display string for an enum by it's value in integer form
        /// </summary>
        /// <param name="value">The enum value in integer form</param>
        /// <returns>The display string for the value or the default if one cannot be found</returns>
        public static string GetByEnum(int value)
        {
            switch (value)
            {
                case (int)UserType.Unknown:
                    return Unknown;

                case (int)UserType.Subject:
                    return Subject;

                case (int)UserType.Agent:
                    return Agent;

                default:
                    return Unknown;
            }
        }

        /// <summary>
        /// Get the display string for an enum by it's value in enum form
        /// </summary>
        /// <param name="value">The enum value in enum form</param>
        /// <returns>The display string for the value or the default if one cannot be found</returns>
        public static string GetByEnum(TagType value)
        {
            return GetByEnum((int)value);
        }
    }
}
