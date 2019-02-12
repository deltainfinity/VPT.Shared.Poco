
namespace VPT.Shared.Poco.Enum.Accounts
{
    /// <summary>
    /// The feature flag for authentication
    /// </summary>
    public enum LoginSystem
    {
        /// <summary>
        /// Disabled Organization (0)
        /// </summary>
        Disabled = 0,

        /// <summary>
        /// StandardLoginAuth0-Direct Login  (1)
        /// </summary>
        StandardLoginAuth0 = 1,

        /// <summary>
        /// IntegratedLoginFormPost-Integrated Login (2)
        /// </summary>
        IntegratedLoginFormPost = 2,

        /// <summary>
        /// Special Login Module for handling System User (3)
        /// </summary>
        SystemUserLogin  = 3,

        /// <summary>
        /// Tablet Login Module for handling Subject Portal Tablet (4)
        /// </summary>
        SubjectPortalTabletLogin = 4,
    }

    public static class LoginSystemConstants
    {
        /// <summary>
        ///  For Disabled Organization (0)
        /// </summary>
        public const string Disabled = "Disabled";

        /// <summary>
        /// StandardLoginAuth0-Direct Login (1)
        /// </summary>
        public const string StandardLoginAuth0 = "StandardLoginAuth0";

        /// <summary>
        /// IntegratedLoginFormPost-Integrated Login (2)
        /// </summary>
        public const string IntegratedLoginFormPost = "IntegratedLoginFormPost";

        /// <summary>
        /// Special Login Module for handling System User (3)
        /// </summary>
        public const string SystemUserLogin = "SystemUserLogin";

        /// <summary>
        /// Tablet Login Module for handling Subject Portal Tablet Login (4)
        /// </summary>
        public const string SubjectPortalTabletLogin = "SubjectPortalTabletLogin";

        /// <summary>
        /// Get the display string for an enum by it's value in integer form
        /// </summary>
        /// <param name="value">The enum value in integer form</param>
        /// <returns>The display string for the value or the default if one cannot be found</returns>
        public static string GetByEnum(int value)
        {
            switch (value)
            {
                case (int)LoginSystem.Disabled:
                    return Disabled;

                case (int)LoginSystem.StandardLoginAuth0:
                    return StandardLoginAuth0;

                case (int)LoginSystem.IntegratedLoginFormPost:
                    return IntegratedLoginFormPost;

                case (int)LoginSystem.SystemUserLogin:
                    return SystemUserLogin;

                case (int)LoginSystem.SubjectPortalTabletLogin:
                    return SubjectPortalTabletLogin;

                default:
                    return StandardLoginAuth0;
            }
        }

        /// <summary>
        /// Get the display string for an enum by it's value in enum form
        /// </summary>
        /// <param name="value">The enum value in enum form</param>
        /// <returns>The display string for the value or the default if one cannot be found</returns>
        public static string GetByEnum(LoginSystem value)
        {
            return GetByEnum((int)value);
        }
    }
}
