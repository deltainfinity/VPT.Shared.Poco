namespace VPT.Shared.Poco.Enum.API
{
    /// <summary>
    /// The Dosage Spans we support
    /// </summary>
    public enum DosageSpan
    {
        /// <summary>
        /// Not specified (0)
        /// </summary>
        Unspecified = 0,

        /// <summary>
        /// Dosage is in hours (1)
        /// </summary>
        Hours = 1,

        /// <summary>
        /// Dosage is in days (2)
        /// </summary>
        Days = 2,

        /// <summary>
        /// Dosage is in weeks (3)
        /// </summary>
        Weeks = 3,

        /// <summary>
        /// Dosage is in Months(4)
        /// </summary>
        Months= 4
    }


    /// <summary>
    /// Display names for the various dosage spans we support
    /// </summary>
    public class DosageSpanConstants
    {
        /// <summary>
        /// Not specified (0)
        /// </summary>
        public const string Unspecified = "N/A";

        /// <summary>
        /// Dosage is in hours (1)
        /// </summary>
        public const string Hours = "Hours";

        /// <summary>
        /// Dosage is in days (2)
        /// </summary>
        public const string Days = "Days";

        /// <summary>
        /// Dosage is in weeks (3)
        /// </summary>
        public const string Weeks = "Weeks";

        /// <summary>
        /// Dosage is in Months (4)
        /// </summary>
        public const string Months = "Months";

        /// <summary>
        /// Get the display string for an enum by it's value in integer form
        /// </summary>
        /// <param name="value">The enum value in integer form</param>
        /// <returns>The display string for the value or the default if one cannot be found</returns>
        public static string GetByEnum(int value)
        {
            switch (value)
            {
                case (int)DosageSpan.Unspecified:
                    return Unspecified;

                case (int)DosageSpan.Hours:
                    return Hours;

                case (int)DosageSpan.Days:
                    return Days;

                case (int)DosageSpan.Weeks:
                    return Weeks;

                case (int)DosageSpan.Months:
                    return Months;

                default:
                    return Unspecified;
            }
        }

        /// <summary>
        /// Get the display string for an enum by it's value in enum form
        /// </summary>
        /// <param name="value">The enum value in enum form</param>
        /// <returns>The display string for the value or the default if one cannot be found</returns>
        public static string GetByEnum(DosageSpan value)
        {
            return GetByEnum((int)value);
        }
    }

}
