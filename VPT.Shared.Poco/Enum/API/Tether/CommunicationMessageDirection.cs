namespace VPT.Shared.Poco.Enum.API.Tether
{

    /// <summary>
    /// Enum to indicate if a message was sent or received by a person
    /// </summary>
    public enum CommunicationMessageDirection
    {
        Sent = 0,
        Received = 1
    }

    public static class CommunicationMessageDirectionConstant
    {
        public const string Sent = "Sent";
        public const string Received = "Received";
        public static string GetByEnum(int value)
        {
            switch (value)
            {
                case (int)CommunicationMessageDirection.Sent:
                    return Sent;

                case (int)CommunicationMessageDirection.Received:
                    return Received;
               
                default:
                    return Sent;
            }
        }

        /// <summary>
        /// Get the display string for an enum by it's value in enum form
        /// </summary>
        /// <param name="value">The enum value in enum form</param>
        /// <returns>The display string for the value or the default if one cannot be found</returns>
        public static string GetByEnum(CommunicationMessageDirection value)
        {
            return GetByEnum((int)value);
        }
    }
}
