namespace VPT.Shared.Poco.Enum.API
{
    /// <summary>
    /// The program days we support
    /// </summary>
    public enum ProgramDays
    {
        /// <summary>
        /// This is Sunday (0)
        /// </summary>
        Sunday = 0,

        /// <summary>
        /// This is Monday (1)
        /// </summary>
        Monday = 1,

        /// <summary>
        /// This is Tuesday (2)
        /// </summary>
        Tuesday = 2,

        /// <summary>
        /// This is Wednesday (3)
        /// </summary>
        Wednesday = 3,

        /// <summary>
        /// This is Thursday (4)
        /// </summary>
        Thursday = 4,

        /// <summary>
        /// This is Friday (5)
        /// </summary>
        Friday = 5,

        /// <summary>
        /// This is Saturday (6)
        /// </summary>
        Saturday = 6,

        /// <summary>
        /// Not specified this should not ever be used (0)
        /// </summary>
        None = 7

    }

    /// <summary>
    /// Display names for the program days we support
    /// </summary>
    public class ProgramDayConstants
    {
        /// <summary>
        /// This is Sunday (0)
        /// </summary>
        public const string Sunday = "Sun";

        /// <summary>
        /// This is Monday (1)
        /// </summary>
        public const string Monday = "Mon";

        /// <summary>
        /// This is Tuesday (2)
        /// </summary>
        public const string Tuesday = "Tue";

        /// <summary>
        /// This is Wednesday (3)
        /// </summary>
        public const string Wednesday = "Wed";

        /// <summary>
        /// This is Thursday (4)
        /// </summary>
        public const string Thursday = "Thu";

        /// <summary>
        /// This is Friday (5)
        /// </summary>
        public const string Friday = "Fri";

        /// <summary>
        /// This is Saturday (6)
        /// </summary>
        public const string Saturday = "Sat";

        /// <summary>
        /// Not specified this should not ever be used (0)
        /// </summary>
        public const string None = "N/A";

        /// <summary>
        /// Get the display string for an enum by it's value in integer form
        /// </summary>
        /// <param name="value">The enum value in integer form</param>
        /// <returns>The display string for the value or the default if one cannot be found</returns>
        public static string GetByEnum(int value)
        {
            switch (value)
            {
                case (int)ProgramDays.Sunday:
                    return Sunday;

                case (int)ProgramDays.Monday:
                    return Monday;

                case (int)ProgramDays.Tuesday:
                    return Tuesday;

                case (int)ProgramDays.Wednesday:
                    return Wednesday;

                case (int)ProgramDays.Thursday:
                    return Thursday;

                case (int)ProgramDays.Friday:
                    return Friday;

                case (int)ProgramDays.Saturday:
                    return Saturday;

                default:
                    return None;
            }
        }

        /// <summary>
        /// Get the display string for an enum by it's value in enum form
        /// </summary>
        /// <param name="value">The enum value in enum form</param>
        /// <returns>The display string for the value or the default if one cannot be found</returns>
        public static string GetByEnum(ObjectType value)
        {
            return GetByEnum((int)value);
        }
    }
}
