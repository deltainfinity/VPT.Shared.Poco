namespace VPT.Shared.Poco.Enum.API
{
    /// <summary>
    /// Agency settings we support
    /// </summary>
    public enum AgencySettings
    {
        /// <summary>
        /// Agency settings is CommunitySupervision (0)
        /// </summary>
        CommunitySupervision = 0,

        /// <summary>
        /// Agency settings is Prison (1)
        /// </summary>
        Prison = 1,

        /// <summary>
        /// Agency settings is Transition (2)
        /// </summary>
        Transition = 2,

        /// <summary>
        /// Program will send to SOR while program creation for all agency settings (2)
        /// </summary>
        All = 3,

        /// <summary>
        /// Program will not send to SOR while program creation(2)
        /// </summary>
        None = 4
    }


    /// <summary>
    /// Display names for the various Agency settings we support
    /// </summary>
    public class AgencySettingsConstants
    {
        /// <summary>
        /// Agency settings is CommunitySupervision (0)
        /// </summary>
        public const string CommunitySupervision = "Community Supervision";

        /// <summary>
        /// Agency settings is Prison (1)
        /// </summary>
        public const string Prison = "Prison";       

        /// <summary>
        /// Agency settings is Transition (2)
        /// </summary>
        public const string Transition = "Transition";

        /// <summary>
        /// Agency settings is Prison (1)
        /// </summary>
        public const string All = "All";

        /// <summary>
        /// Agency settings is Transition (2)
        /// </summary>
        public const string None = "None";

        /// <summary>
        /// Get the display string for an enum by it's value in integer form
        /// </summary>
        /// <param name="value">The enum value in integer form</param>
        /// <returns>The display string for the value or the default if one cannot be found</returns>
        public static string GetByEnum(int value)
        {
            switch (value)
            {
                case (int)AgencySettings.CommunitySupervision:
                    return CommunitySupervision;

                case (int)AgencySettings.Prison:
                    return Prison;

                case (int)AgencySettings.Transition:
                    return Transition;

                case (int)AgencySettings.All:
                    return All;

                case (int)AgencySettings.None:
                    return None;

                default:
                    return CommunitySupervision;
            }
        }

        /// <summary>
        /// Get the display string for an enum by it's value in enum form
        /// </summary>
        /// <param name="value">The enum value in enum form</param>
        /// <returns>The display string for the value or the default if one cannot be found</returns>
        public static string GetByEnum(AgencySettings value)
        {
            return GetByEnum((int)value);
        }
    }

}
