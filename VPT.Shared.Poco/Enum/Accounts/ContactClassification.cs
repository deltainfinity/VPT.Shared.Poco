namespace VPT.Shared.Poco.Enum.Accounts
{
    /// <summary>
    /// The person Classifications we support
    /// </summary>
    public enum ContactClassification
    {
        /// <summary>
        /// No answer was given (0)
        /// </summary>
        Unspecified = 0,

        /// <summary>
        /// The contact is for home (1)
        /// </summary>
        Home = 1,

        /// <summary>
        /// The contact is for work (2)
        /// </summary>
        Work = 2,

        /// <summary>
        /// The contact is for school (3)
        /// </summary>
        School = 3,

        /// <summary>
        /// The contact is for some other type (4)
        /// </summary>
        Other = 4
    }
    
    public static class ContactClassificationConstants
    {
        /// <summary>
        /// No answer was given (0)
        /// </summary>
        public const string Unspecified = "Not Specified";

        /// <summary>
        /// The contact is for home (1)
        /// </summary>
        public const string Home = "Home";

        /// <summary>
        /// The contact is for work (2)
        /// </summary>
        public const string Work = "Work";

        /// <summary>
        /// The contact is for school (3)
        /// </summary>
        public const string School = "School";

        /// <summary>
        /// The contact is for some other type (4)
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
                case (int)ContactClassification.Unspecified:
                    return Unspecified;

                case (int)ContactClassification.Home:
                    return Home;

                case (int)ContactClassification.Work:
                    return Work;

                case (int)ContactClassification.School:
                    return School;

                case (int)ContactClassification.Other:
                    return Other;

                default:
                    return Unspecified;
            }
        }

        /// <summary>
        /// Get the display string for an enum by it's value in enum form
        /// </summary>
        /// <param name="value">The enum value in enum form</param>
        /// <returns>The display string for the value or the default if one cannot be found</returns>
        public static string GetByEnum(ContactClassification value)
        {
            return GetByEnum((int)value);
        }
    }
}
