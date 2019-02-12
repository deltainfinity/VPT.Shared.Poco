namespace VPT.Shared.Poco.Enum.Accounts
{
    /// <summary>
    /// The person races we support per white house guidelines (https://www.whitehouse.gov/sites/default/files/omb/assets/information_and_regulatory_affairs/re_app-a-update.pdf)
    /// </summary>
    public enum Race
    {
        /// <summary>
        /// No answer was given (0)
        /// </summary>
        Unspecified = 0,

        /// <summary>
        /// No answer was given (0)
        /// </summary>
        Other = 1,

        /// <summary>
        /// A person having origins in any of the original peoples of
        /// Europe, the Middle East, or North Africa (1)
        /// </summary>
        White = 2,

        /// <summary>
        /// A person having origins in any of the black racial groups of Africa.
        /// Terms such as "Haitian" or "Negro" can be used in addition to "Black
        /// or African American." (4)
        /// </summary>
        BlackOrAfricanAmerican = 3,

        /// <summary>
        /// A person having origins in any of the original peoples of North
        /// and South America (including Central America), and who maintains
        /// tribal affiliation or community attachment. (2)
        /// </summary>
        AmericanIndianOrAlaskanNative = 4,

        /// <summary>
        /// A person having origins in any of the original peoples of the Far
        /// East, Southeast Asia, or the Indian subcontinent including, for
        /// example, Cambodia, China, India, Japan, Korea, Malaysia, Pakistan,
        /// the Philippine Islands, Thailand, and Vietnam. (3)
        /// </summary>
        Asian = 5,

        /// <summary>
        /// A person having origins in any of the original peoples of Hawaii,
        /// Guam, Samoa, or other Pacific Islands.
        /// </summary>
        NativeHawaiianOrPacificIslander = 6,

        /// <summary>
        /// A person of Cuban, Mexican, Puerto Rican, South or Central American,
        /// or other Spanish culture or origin, regardless of race. The term,
        /// "Spanish origin", can be used in addition to "Hispanic or Latino."
        /// </summary>
        HispanicOrLatino = 7
                
    }

    public static class RaceConstants
    {
        /// <summary>
        /// No answer was given (0)
        /// </summary>
        public const string Unspecified = "Not Specified";

        /// <summary>
        /// No answer was given (1)
        /// </summary>
        public const string Other = "Other";

        /// <summary>
        /// A person having origins in any of the original peoples of
        /// Europe, the Middle East, or North Africa (2)
        /// </summary>
        public const string White = "White";

        /// <summary>
        /// A person having origins in any of the original peoples of North
        /// and South America (including Central America), and who maintains
        /// tribal affiliation or community attachment. (3)
        /// </summary>
        public const string AmericanIndianOrAlaskanNative = "American Indian or Alaskan Native";

        /// <summary>
        /// A person having origins in any of the original peoples of the Far
        /// East, Southeast Asia, or the Indian subcontinent including, for
        /// example, Cambodia, China, India, Japan, Korea, Malaysia, Pakistan,
        /// the Philippine Islands, Thailand, and Vietnam. (4)
        /// </summary>
        public const string Asian = "Asian";

        /// <summary>
        /// A person having origins in any of the black racial groups of Africa.
        /// Terms such as "Haitian" or "Negro" can be used in addition to "Black
        /// or African American." (5)
        /// </summary>
        public const string BlackOrAfricanAmerican = "Black or African American";

        /// <summary>
        /// A person of Cuban, Mexican, Puerto Rican, South or Central American,
        /// or other Spanish culture or origin, regardless of race. The term,
        /// "Spanish origin", can be used in addition to "Hispanic or Latino."
        /// </summary>
        public const string HispanicOrLatino = "Hispanic or Latino";

        /// <summary>
        /// A person having origins in any of the original peoples of Hawaii,
        /// Guam, Samoa, or other Pacific Islands.
        /// </summary>
        public const string NativeHawaiianOrPacificIslander = "Native Hawaiian or Pacific Islander";

        /// <summary>
        /// Get the display string for an enum by it's value in integer form
        /// </summary>
        /// <param name="value">The enum value in integer form</param>
        /// <returns>The display string for the value or the default if one cannot be found</returns>
        public static string GetByEnum(int value)
        {
            switch (value)
            {
                case (int)Race.Unspecified:
                    return Unspecified;

                case (int)Race.Other:
                    return Other;

                case (int)Race.White:
                    return White;

                case (int)Race.AmericanIndianOrAlaskanNative:
                    return AmericanIndianOrAlaskanNative;

                case (int)Race.Asian:
                    return Asian;

                case (int)Race.BlackOrAfricanAmerican:
                    return BlackOrAfricanAmerican;

                case (int)Race.HispanicOrLatino:
                    return HispanicOrLatino;

                case (int)Race.NativeHawaiianOrPacificIslander:
                    return NativeHawaiianOrPacificIslander;

                default:
                    return Unspecified;
            }
        }

        /// <summary>
        /// Get the display string for an enum by it's value in enum form
        /// </summary>
        /// <param name="value">The enum value in enum form</param>
        /// <returns>The display string for the value or the default if one cannot be found</returns>
        public static string GetByEnum(Race value)
        {
            return GetByEnum((int)value);
        }
    }
}
