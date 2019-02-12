namespace VPT.Shared.Poco.Enum.API
{
    public enum AcknowledgementState
    {
        /// <summary>
        /// The notification is in an unknown state (0)
        /// </summary>
        Unknown = 0,

        /// <summary>
        /// The notification has been viewed (1)
        /// </summary>
        Viewed = 1,

        /// <summary>
        /// The notification has been rejected (2)
        /// </summary>
        Rejected = 2,

        /// <summary>
        /// The notification has been acknowledged (3)
        /// </summary>
        Acknowledged = 3
    }

    public class AcknowledgementStateConstants
    {
        /// <summary>
        /// The notification is in an unknown state (0)
        /// </summary>
        public const string Unknown = "Unknown";

        /// <summary>
        /// The notification has been viewed (1)
        /// </summary>
        public const string Viewed = "Viewed";

        /// <summary>
        /// The notification has been rejected (2)
        /// </summary>
        public const string Rejected = "Rejected";

        /// <summary>
        /// The notification has been acknowledged (3)
        /// </summary>
        public const string Acknowledged = "Acknowledged";

        /// <summary>
        /// Get the display string for an enum by it's value in integer form
        /// </summary>
        /// <param name="value">The enum value in integer form</param>
        /// <returns>The display string for the value or the default if one cannot be found</returns>
        public static string GetByEnum(int value)
        {
            switch (value)
            {
                case (int)AcknowledgementState.Unknown:
                    return Unknown;

                case (int)AcknowledgementState.Viewed:
                    return Viewed;

                case (int)AcknowledgementState.Rejected:
                    return Rejected;

                case (int)AcknowledgementState.Acknowledged:
                    return Acknowledged;

                default:
                    return Unknown;
            }
        }

        public static AcknowledgementState GetByString(string state)
        {
            switch (state)
            {
                case Viewed:
                    return AcknowledgementState.Viewed;

                case Rejected:
                    return AcknowledgementState.Rejected;

                case Acknowledged:
                    return AcknowledgementState.Acknowledged;

                default:
                    return AcknowledgementState.Unknown;
            }
        }

        /// <summary>
        /// Get the display string for an enum by it's value in enum form
        /// </summary>
        /// <param name="value">The enum value in enum form</param>
        /// <returns>The display string for the value or the default if one cannot be found</returns>
        public static string GetByEnum(AcknowledgementState value)
        {
            return GetByEnum((int)value);
        }
    }
}
