namespace VPT.Shared.Poco.Enum.API
{
    public enum ProgramRecommendationStatusType
    {
        /// <summary>
        /// UnAssigned
        /// </summary>
        UnAssigned = 0,

        /// <summary>
        /// Assigned
        /// </summary>
        Assigned = 1,

        /// <summary>
        /// Overriden
        /// </summary>
        Override = 2
    }
    public class ProgramRecommendationStatusTypeConstants
    {
        /// <summary>
        /// UnAssigned (0)
        /// </summary>
        public const string UnAssigned = "UnAssigned";

        /// <summary>
        /// Assigned (1)
        /// </summary>
        public const string Assigned = "Assigned";

        /// <summary>
        /// Override (2)
        /// </summary>
        public const string Override = "Override";

        /// <summary>
        /// Get the display string for an enum by it's value in integer form
        /// </summary>
        /// <param name="value">The enum value in integer form</param>
        /// <returns>The display string for the value or the default if one cannot be found</returns>
        public static string GetByEnum(int value)
        {
            switch (value)
            {
                case (int)ProgramRecommendationStatusType.UnAssigned:
                    return UnAssigned;

                case (int)ProgramRecommendationStatusType.Assigned:
                    return Assigned;

                case (int)ProgramRecommendationStatusType.Override:
                    return Override;

                default:
                    return UnAssigned;
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
