namespace VPT.Shared.Poco.Enum.API
{
    public enum ProgramJobSubType
    {
        /// <summary>
        /// Program/Job Description
        /// </summary>
        Description = 0,
        /// <summary>
        /// Program/Job Opening 
        /// </summary>
        Opening = 1,

    }

    /// <summary>
    /// Display names for the various tag types we support
    /// </summary>
    public class ProgramJobSubTypeContants
    {
        /// <summary>
        /// Not specified this should not ever be used (0)
        /// </summary>
        public const string Description = "Description";

        /// <summary>
        /// This is a primary domain from evidence based practices (1)
        /// </summary>
        public const string Opening = "Opening";

        /// <summary>
        /// Get the display string for an enum by it's value in integer form
        /// </summary>
        /// <param name="value">The enum value in integer form</param>
        /// <returns>The display string for the value or the default if one cannot be found</returns>
        public static string GetByEnum(int value)
        {
            switch (value)
            {
                case (int)ProgramJobSubType.Description:
                    return Description;

                case (int)ProgramJobSubType.Opening:
                    return Opening;

                default:
                    return Description;
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
