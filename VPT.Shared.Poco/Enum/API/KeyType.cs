namespace VPT.Shared.Poco.Enum.API
{
    /// <summary>
    /// The Key Types we support
    /// </summary>
    public enum KeyType
    {
        /// <summary>
        /// Not specified this should not ever be used (0)
        /// </summary>
        None = 0,

        /// <summary>
        /// This is an API Key (1)
        /// </summary>
        APIKey = 1,

        /// <summary>
        /// This is a VAnt4ge Point OAuth token
        /// </summary>
        // ReSharper disable once InconsistentNaming
        Vant4geOAuth = 2,

        /// <summary>
        /// This is a Google OAuth token
        /// </summary>
        GoogleOAuth = 3,

        /// <summary>
        /// This is a Facebook OAuth token
        /// </summary>
        FacebookOAuth = 4
    }

    /// <summary>
    /// Display names for the various Key Type's we support
    /// </summary>
    public class KeyTypeConstants
    {
        /// <summary>
        /// Not specified this should not ever be used (0)
        /// </summary>
        public const string None = "N/A";

        /// <summary>
        /// This is an API Key (1)
        /// </summary>
        public const string APIKey = "API Key";

        /// <summary>
        /// This is a VAnt4ge Point OAuth token
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string Vant4geOAuth = "OAuth - Vant4ge Point";

        /// <summary>
        /// This is a Google OAuth token
        /// </summary>
        public const string GoogleOAuth = "OAuth - Google";

        /// <summary>
        /// This is a Facebook OAuth token
        /// </summary>
        public const string FacebookOAuth = "OAuth - Facebook";

        /// <summary>
        /// Get the display string for an enum by it's value in integer form
        /// </summary>
        /// <param name="value">The enum value in integer form</param>
        /// <returns>The display string for the value or the default if one cannot be found</returns>
        public static string GetByEnum(int value)
        {
            switch (value)
            {
                case (int)KeyType.None:
                    return None;

                case (int)KeyType.APIKey:
                    return APIKey;

                case (int)KeyType.Vant4geOAuth:
                    return Vant4geOAuth;

                case (int)KeyType.GoogleOAuth:
                    return GoogleOAuth;

                case (int)KeyType.FacebookOAuth:
                    return FacebookOAuth;

                default:
                    return None;
            }
        }

        /// <summary>
        /// Get the display string for an enum by it's value in enum form
        /// </summary>
        /// <param name="value">The enum value in enum form</param>
        /// <returns>The display string for the value or the default if one cannot be found</returns>
        public static string GetByEnum(KeyType value)
        {
            return GetByEnum((int)value);
        }
    }
}
