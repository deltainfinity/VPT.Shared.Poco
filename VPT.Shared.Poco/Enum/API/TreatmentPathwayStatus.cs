namespace VPT.Shared.Poco.Enum.API
{
    /// <summary>
    /// Treatment pathway status we support
    /// </summary>
    public enum TreatmentPathwayStatus
    {
        /// <summary>
        /// Not specified (0)
        /// </summary>
        Unknown = 0,

        /// <summary>
        /// Subject is attending the treatment pathway (1)
        /// </summary>
        InProgress = 1,

        /// <summary>
        /// Subject has completed the treatment pathway successfully (2)
        /// </summary>
        Completed = 2,

        /// <summary>
        /// Subject was terminated from the treatment pathway (3)
        /// </summary>
        Terminated = 3,

        /// <summary>
        /// Pathway was overrided by user (4)
        /// </summary>
        Override = 4,

        /// <summary>
        /// Subject is moved to waitlist (5)
        /// </summary>
        WaitList = 5
    }

    /// <summary>
    /// Display names for the various dosage spans we support
    /// </summary>
    public class TreatmentPathwayStatusConstants
    {
        /// <summary>
        /// Not specified (0)
        /// </summary>
        public const string Unknown = "Unknown";

        /// <summary>
        /// Subject is attending the program (1)
        /// </summary>
        public const string InProgress = "In Progress";

        /// <summary>
        /// Subject has completed the program successfully (2)
        /// </summary>
        public const string Completed = "Completed";

        /// <summary>
        /// Subject was terminated from the program (3)
        /// </summary>
        public const string Terminated = "Terminated";

        /// <summary>
        /// Pathway was overrided by user (4)
        /// </summary>

        public const string Override = "Override";

        /// <summary>
        /// Subject is moved to waitlist (5)
        /// </summary>

        public const string WaitList = "Waiting List";

        /// <summary>
        /// Get the display string for an enum by it's value in integer form
        /// </summary>
        /// <param name="value">The enum value in integer form</param>
        /// <returns>The display string for the value or the default if one cannot be found</returns>
        public static string GetByEnum(int value)
        {
            switch (value)
            {
                case (int)TreatmentPathwayStatus.Unknown:
                    return Unknown;

                case (int)TreatmentPathwayStatus.InProgress:
                    return InProgress;

                case (int)TreatmentPathwayStatus.Completed:
                    return Completed;

                case (int)TreatmentPathwayStatus.Terminated:
                    return Terminated;

                case (int)TreatmentPathwayStatus.Override:
                    return Override;

                case (int)TreatmentPathwayStatus.WaitList:
                    return WaitList;

                default:
                    return Unknown;
            }
        }

        /// <summary>
        /// Get the display string for an enum by it's value in enum form
        /// </summary>
        /// <param name="value">The enum value in enum form</param>
        /// <returns>The display string for the value or the default if one cannot be found</returns>
        public static string GetByEnum(TreatmentPathwayStatus value)
        {
            return GetByEnum((int)value);
        }
    }

}
