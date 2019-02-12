namespace VPT.Shared.Poco.Enum.API
{
    /// <summary>
    /// The Key Types we support
    /// </summary>
    public enum NotificationGenreEnum
    {
        /// <summary>
        /// This is General Token
        /// </summary>
        General = 1,

        /// <summary>
        /// This is Action Step Due Date Token
        /// </summary>
        ActionStepDueDate = 2,
    }

    /// <summary>
    /// Display names for the various Key Type's we support
    /// </summary>
    public class NotificationGenreEnumConstants
    {
        /// <summary>
        /// This is General Token (1)
        /// </summary>
        public const string General = "General";

        /// <summary>
        /// This is Action Step Due Date Token (2)
        /// </summary>
        public const string ActionStepDueDate = "API Key";
        
        public static string GetByEnum(int value)
        {
            switch (value)
            {
                case (int)NotificationGenreEnum.General:
                    return General;

                case (int)NotificationGenreEnum.ActionStepDueDate:
                    return ActionStepDueDate;

                default:
                    return General;
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
