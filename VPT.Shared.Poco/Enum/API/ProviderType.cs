namespace VPT.Shared.Poco.Enum.API
{
    /// <summary>
    /// The Key Types we support
    /// </summary>
    public enum ProviderType
    {
        /// <summary>
        /// Provider Type was not specified (0)
        /// </summary>
        Unspecified = 0,

        /// <summary>
        /// This is a correctional institution/agency (1)
        /// </summary>
        CorrectionsAgency = 1,

        /// <summary>
        /// This is a community facility (2)
        /// </summary>
        CommunityFacility = 2,

        /// <summary>
        /// This is a Mental Health provider (3)
        /// </summary>
        MentalHealth = 3,

        /// <summary>
        /// This is a Substance Abuse provider/treatment center (4)
        /// </summary>
        SubstanceAbuse = 4
    }

    /// <summary>
    /// Display names for the various Key Type's we support
    /// </summary>
    public class ProviderTypeConstants
    {
        /// <summary>
        /// Provider Type was not specified (0)
        /// </summary>
        public const string Unspecified = "Unspecified";

        /// <summary>
        /// This is a correctional institution/agency (1)
        /// </summary>
        public const string CorrectionsAgency = "Corrections Agency";

        /// <summary>
        /// This is a community facility (2)
        /// </summary>
        public const string CommunityFacility = "Community Facility";

        /// <summary>
        /// This is a Mental Health provider (3)
        /// </summary>
        public const string MentalHealth = "Mental Health";

        /// <summary>
        /// This is a Substance Abuse provider/treatment center (4)
        /// </summary>
        public const string SubstanceAbuse = "Substance Abuse";

        /// <summary>
        /// Get the display string for an enum by it's value in integer form
        /// </summary>
        /// <param name="value">The enum value in integer form</param>
        /// <returns>The display string for the value or the default if one cannot be found</returns>
        public static string GetByEnum(int value)
        {
            switch (value)
            {
                case (int)ProviderType.Unspecified:
                    return Unspecified;

                case (int)ProviderType.CorrectionsAgency:
                    return CorrectionsAgency;

                case (int)ProviderType.CommunityFacility:
                    return CommunityFacility;

                case (int)ProviderType.MentalHealth:
                    return MentalHealth;

                case (int)ProviderType.SubstanceAbuse:
                    return SubstanceAbuse;

                default:
                    return Unspecified;
            }
        }

        /// <summary>
        /// Get the display string for an enum by it's value in enum form
        /// </summary>
        /// <param name="value">The enum value in enum form</param>
        /// <returns>The display string for the value or the default if one cannot be found</returns>
        public static string GetByEnum(ProviderType value)
        {
            return GetByEnum((int)value);
        }
    }
}
