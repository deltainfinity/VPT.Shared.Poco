namespace VPT.Shared.Poco.Enum.API
{
    /// <summary>
    /// The tag types we support
    /// </summary>
    public enum TagType
    {
        /// <summary>
        /// Not specified this should not ever be used (0)
        /// </summary>
        None = 0,

        /// <summary>
        /// This is a primary domain from evidence based practices (1)
        /// </summary>
        PrimaryNeed = 1,

        /// <summary>
        /// This is a secondary tag for loosely related to evidence based practices (2)
        /// </summary>
        Secondary = 2,

        /// <summary>
        /// Custom tag to be applied manually only (3)
        /// </summary>
        Custom = 3,

        /// <summary>
        /// This is a primary risk for recidivism (4)
        /// </summary>
        PrimaryRisk = 4,

        /// <summary>
        /// Tag to be applied for general type(Not linked with any assessments)
        /// </summary>
        SexOffenderSpecific = 5,

        /// <summary>
        /// Tag to be applied for Supervision Only (6)
        /// </summary>
        SupervisionOnly = 6,
    }

    /// <summary>
    /// Display names for the various tag types we support
    /// </summary>
    public class TagTypeConstants
    {
        /// <summary>
        /// Not specified this should not ever be used (0)
        /// </summary>
        public const string None = "N/A";

        /// <summary>
        /// This is a primary domain from evidence based practices (1)
        /// </summary>
        public const string PrimaryNeed = "PrimaryNeed";

        /// <summary>
        /// This is a secondary tag for loosely related to evidence based practices (2)
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string Secondary = "Secondary";

        /// <summary>
        /// Custom tag to be applied manually only (3)
        /// </summary>
        public const string Custom = "Custom";

        /// <summary>
        /// This is a primary risk for recidivism (4)
        /// </summary>
        public const string PrimaryRisk = "PrimaryRisk";

        /// <summary>
        /// Tag to be applied for general type(Not linked with any assessments)
        /// </summary>
        public const string SexOffenderSpecific = "SexOffenderSpecific";

        /// <summary>
        /// Tag to be applied for Supervision Only (6)
        /// </summary>
        public const string SupervisionOnly = "SupervisionOnly";

        /// <summary>
        /// Get the display string for an enum by it's value in integer form
        /// </summary>
        /// <param name="value">The enum value in integer form</param>
        /// <returns>The display string for the value or the default if one cannot be found</returns>
        public static string GetByEnum(int value)
        {
            switch (value)
            {
                case (int)TagType.None:
                    return None;

                case (int)TagType.PrimaryNeed:
                    return PrimaryNeed;

                case (int)TagType.Secondary:
                    return Secondary;

                case (int)TagType.Custom:
                    return Custom;

                case (int)TagType.SexOffenderSpecific:
                    return SexOffenderSpecific;

                case (int)TagType.SupervisionOnly:
                    return SupervisionOnly;

                default:
                    return None;
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
