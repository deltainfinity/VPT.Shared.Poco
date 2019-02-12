namespace VPT.Shared.Poco.Enum.API
{
    /// <summary>
    /// The Dosage Spans we support
    /// </summary>
    public enum MilestoneType
    {
        /// <summary>
        /// Not specified (0)
        /// </summary>
        Unspecified = 0,

        /// <summary>
        /// Dosage is in credits (1)
        /// </summary>
        Credits = 1,

        /// <summary>
        /// Dosage is in hours (2)
        /// </summary>
        Hours = 2,

        /// <summary>
        /// Dosage is in days (3)
        /// </summary>
        Days = 3,

        /// <summary>
        /// Dosage is in weeks (4)
        /// </summary>
        Weeks = 4
    }


    /// <summary>
    /// Display names for the various dosage spans we support
    /// </summary>
    public class MilestoneTypeConstants
    {
        /// <summary>
        /// Not specified (0)
        /// </summary>
        public const string Unspecified = "N/A";

        /// <summary>
        /// Dosage is in credits (1)
        /// </summary>
        public const string Credits = "Credits";

        /// <summary>
        /// Dosage is in hours (2)
        /// </summary>
        public const string Hours = "Hours";

        /// <summary>
        /// Dosage is in days (3)
        /// </summary>
        public const string Days = "Days";

        /// <summary>
        /// Dosage is in weeks (4)
        /// </summary>
        public const string Weeks = "Weeks";

        /// <summary>
        /// Get the display string for an enum by it's value in integer form
        /// </summary>
        /// <param name="value">The enum value in integer form</param>
        /// <returns>The display string for the value or the default if one cannot be found</returns>
        public static string GetByEnum(int value)
        {
            switch (value)
            {
                case (int)MilestoneType.Unspecified:
                    return Unspecified;

                case (int)MilestoneType.Credits:
                    return Credits;

                case (int)MilestoneType.Hours:
                    return Hours;

                case (int)MilestoneType.Days:
                    return Days;

                case (int)MilestoneType.Weeks:
                    return Weeks;

                default:
                    return Unspecified;
            }
        }

        /// <summary>
        /// Get the display string for an enum by it's value in enum form
        /// </summary>
        /// <param name="value">The enum value in enum form</param>
        /// <returns>The display string for the value or the default if one cannot be found</returns>
        public static string GetByEnum(MilestoneType value)
        {
            return GetByEnum((int)value);
        }
    }

}
