namespace VPT.Shared.Poco.Enum.API
{
    public enum ProgramCredits
    {
        /// <summary>
        /// Full-time
        /// </summary>
        Fulltime = 1,

        /// <summary>
        /// Part-time
        /// </summary>
        Parttime = 2,

        /// <summary>
        /// None
        /// </summary>
        None = 3
    }
    public class ProgramCreditsConstants
    {
        /// <summary>
        /// Not Specified (0)
        /// </summary>
        public const string NotSpecified = "Not Specified";

        /// <summary>
        /// Full-time (1)
        /// </summary>
        public const string Fulltime = "Full-Time Pay";

        /// <summary>
        /// Part-time (2)
        /// </summary>
        public const string Parttime = "Part-Time Pay";

        /// <summary>
        /// None (3)
        /// </summary>
        public const string None = "Voluntary";

        /// <summary>
        /// Get the display string for an enum by it's value in integer form
        /// </summary>
        /// <param name="value">The enum value in integer form</param>
        /// <returns>The display string for the value or the default if one cannot be found</returns>
        public static string GetByEnum(int value)
        {
            switch (value)
            {
                case (int)ProgramCredits.Fulltime:
                    return Fulltime;

                case (int)ProgramCredits.Parttime:
                    return Parttime;

                case (int)ProgramCredits.None:
                    return None;

                default:
                    return NotSpecified;
            }
        }

        /// <summary>
        /// Get the display string for an enum by it's value in enum form
        /// </summary>
        /// <param name="value">The enum value in enum form</param>
        /// <returns>The display string for the value or the default if one cannot be found</returns>
        public static string GetByEnum(ProgramCredits value)
        {
            return GetByEnum((int)value);
        }
    }
}
