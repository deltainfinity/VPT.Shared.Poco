namespace VPT.Shared.Poco.Enum.API
{
    public enum OverrideReasonType
    {
        /// <summary>
        /// Already Successfully Completed (1)
        /// </summary>
        AlreadySuccessfullyCompleted = 1,

        /// <summary>
        /// Parole Board Mandated (2)
        /// </summary>
        ParoleBoardMandated = 2,

        /// <summary>
        /// Court Ordered (3)
        /// </summary>
        CourtOrdered = 3,

        /// <summary>
        /// Other (4)
        /// </summary>
        Other = 4
    }

    public class OverrideReasonTypeConstants
    {
        /// <summary>
        /// Already Successfully Completed (1)
        /// </summary>
        public const string AlreadySuccessfullyCompleted = "Already Successfully Completed";

        /// <summary>
        /// Parole Board Mandated (2)
        /// </summary>
        public const string ParoleBoardMandated = "Parole Board Mandated";

        /// <summary>
        /// Court Ordered (3)
        /// </summary>
        public const string CourtOrdered = "Court Ordered";

        /// <summary>
        /// Other (4)
        /// </summary>
        public const string Other = "Other";

        /// <summary>
        /// Get the display string for an enum by it's value in integer form
        /// </summary>
        /// <param name="value">The enum value in integer form</param>
        /// <returns>The display string for the value or the default if one cannot be found</returns>
        public static string GetByEnum(int value)
        {
            switch (value)
            {
                case (int)OverrideReasonType.AlreadySuccessfullyCompleted:
                    return AlreadySuccessfullyCompleted;

                case (int)OverrideReasonType.ParoleBoardMandated:
                    return ParoleBoardMandated;

                case (int)OverrideReasonType.CourtOrdered:
                    return CourtOrdered;

                case (int)OverrideReasonType.Other:
                    return Other;

                default:
                    return AlreadySuccessfullyCompleted;
            }
        }

        public static OverrideReasonType GetByString(string state)
        {
            switch (state)
            {
                case AlreadySuccessfullyCompleted:
                    return OverrideReasonType.AlreadySuccessfullyCompleted;

                case ParoleBoardMandated:
                    return OverrideReasonType.ParoleBoardMandated;

                case CourtOrdered:
                    return OverrideReasonType.CourtOrdered;

                case Other:
                    return OverrideReasonType.Other;

                default:
                    return OverrideReasonType.AlreadySuccessfullyCompleted;
            }
        }

        /// <summary>
        /// Get the display string for an enum by it's value in enum form
        /// </summary>
        /// <param name="value">The enum value in enum form</param>
        /// <returns>The display string for the value or the default if one cannot be found</returns>
        public static string GetByEnum(OverrideReasonType value)
        {
            return GetByEnum((int)value);
        }
    }
}
