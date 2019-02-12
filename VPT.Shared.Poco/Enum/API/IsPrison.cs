

namespace VPT.Shared.Poco.Enum.API
{
    /// <summary>
    /// Is the subject is prison or supervison
    /// </summary>
    public enum IsPrison
    {
        /// <summary>
        ///This subject is prison
        /// </summary>
        IsPrison = 1,

        /// <summary>
        /// This subject is supervision
        /// </summary>
        Supervison = 2,

        /// <summary>
        /// This subject contains common properties. 
        /// </summary>
        Both = 3
    }


    /// <summary>
    /// Display names for the subjects
    /// </summary>
    public class IsPrisonOrSuperVision 
    {
        /// <summary>
        ///This subject is prison
        /// </summary>
        public const string Prison = "Prison";

        /// <summary>
        /// This subject is supervision
        /// </summary>
        public const string Supervison = "Supervison";

        /// <summary>
        /// This subject contains common properties. 
        /// </summary>
        public const string Both = "Both";

        /// <summary>
        /// Get the display string for an enum by it's value in integer form
        /// </summary>
        /// <param name="value">The enum value in integer form</param>
        /// <returns>The display string for the value or the default if one cannot be found</returns>
        public static string GetByEnum(int value)
        {
            switch (value)
            {
                case (int)IsPrison.IsPrison:
                    return Prison;

                case (int)IsPrison.Supervison:
                    return Supervison;

                case (int)IsPrison.Both:
                    return Both;

                default:
                    return Both;
            }
        }

        /// <summary>
        /// Get the display string for an enum by it's value in enum form
        /// </summary>
        /// <param name="value">The enum value in enum form</param>
        /// <returns>The display string for the value or the default if one cannot be found</returns>
        public static string GetByEnum(IsPrison value)
        {
            return GetByEnum((int)value);
        }
    }
}
