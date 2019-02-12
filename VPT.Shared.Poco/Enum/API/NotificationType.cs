namespace VPT.Shared.Poco.Enum.API
{
    public enum NotificationType
    {
        /// <summary>
        /// The notification type is UI (1)
        /// </summary>
        UINotification = 1,

        /// <summary>
        /// The notification type is Email  (2)
        /// </summary>
        Email = 2,

        /// <summary>
        /// The notification type is SMS  (3)
        /// </summary>
        SMS = 3,
    }

    public class NotificationTypeConstants
    {
        /// <summary>
        /// The notification type is UI (1)
        /// </summary>
        public const string UINotification = "UINotification";

        /// <summary>
        /// The notification type is Email  (2)
        /// </summary>
        public const string Email = "Email";

        /// <summary>
        /// The notification type is SMS  (3)
        /// </summary>
        public const string SMS = "SMS";

        /// <summary>
        /// Get the display string for an enum by it's value in integer form
        /// </summary>
        /// <param name="value">The enum value in integer form</param>
        /// <returns>The display string for the value or the default if one cannot be found</returns>
        public static string GetByEnum(int value)
        {
            switch (value)
            {
                case (int)NotificationType.UINotification:
                    return UINotification;

                case (int)NotificationType.Email:
                    return Email;

                case (int)NotificationType.SMS:
                    return SMS;

                default:
                    return UINotification;
            }
        }

        public static NotificationType GetByString(string type)
        {
            switch (type)
            {
                case UINotification:
                    return NotificationType.UINotification;

                case Email:
                    return NotificationType.Email;

                case SMS:
                    return NotificationType.SMS;

                default:
                    return NotificationType.UINotification;
            }
        }

        /// <summary>
        /// Get the display string for an enum by it's value in enum form
        /// </summary>
        /// <param name="value">The enum value in enum form</param>
        /// <returns>The display string for the value or the default if one cannot be found</returns>
        public static string GetByEnum(NotificationType value)
        {
            return GetByEnum((int)value);
        }
    }
}
