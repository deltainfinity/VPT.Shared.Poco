namespace VPT.Shared.Poco.Enum.API
{
    public enum PlatformType
    {
        /// <summary>
        /// Tradtional type program
        /// </summary>
        Traditional = 0,

        /// <summary>
        /// Online type program
        /// </summary>
        Online = 1
    }
    public class PlatformTypeConstants
    {
        /// <summary>
        /// Traditional program (0)
        /// </summary>
        public const string Traditional = "Traditional";

        /// <summary>
        /// Online program (1)
        /// </summary>
        public const string Online = "Online";

        /// <summary>
        /// Get the display string for an enum by it's value in integer form
        /// </summary>
        /// <param name="value">The enum value in integer form</param>
        /// <returns>The display string for the value or the default if one cannot be found</returns>
        public static string GetByEnum(int value)
        {
            switch (value)
            {
                case (int)PlatformType.Traditional:
                    return Traditional;

                case (int)PlatformType.Online:
                    return Online;

                default:
                    return Traditional;
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
