namespace VPT.Shared.Poco.Enum.Accounts
{
    /// <summary>
    /// The Integrated client authentication header
    /// </summary>
    public enum IntegratedClient
    {
        /// <summary>
        /// Not an integrated organization
        /// </summary>
        NoIntegration = 0,

        /// <summary>
        /// Integrated Client with V1 Authorization
        /// </summary>
        IntegratedV1 = 1,

        /// <summary>
        /// Integrated Client with v3 basic authorization
        /// </summary>
        IntegratedV3Basic = 2,

        /// <summary>
        /// Integrated Client with v3 jwt authorization
        /// </summary>
        IntegratedV3JWT = 3,

        /// <summary>
        /// Integrated Client with Soap
        /// </summary>
        SOAP = 4,
    }

    public static class IntegratedClientConstants
    {
        /// <summary>
        /// Not integrated organization
        /// </summary>
        public const string NoIntegration = "No Integration";

        /// <summary>
        /// Integrated Client with V1 Authorization
        /// </summary>
        public const string IntegratedV1 = "Integrated V1";

        /// <summary>
        /// Integrated Client with v3 basic authorization
        /// </summary>
        public const string IntegratedV3Basic = "Integrated V3 Basic";

        /// <summary>
        /// Integrated Client with v3 jwt authorization
        /// </summary>
        public const string IntegratedV3JWT = "Integrated V3 JWT";

        /// <summary>
        /// Integrated Client with Soap
        /// </summary>
        public const string SOAP = "SOAP";

        /// <summary>
        /// Get the display string for an enum by it's value in integer form
        /// </summary>
        /// <param name="value">The enum value in integer form</param>
        /// <returns>The display string for the value or the default if one cannot be found</returns>
        public static string GetByEnum(int value)
        {
            switch (value)
            {
                case (int)IntegratedClient.NoIntegration:
                    return NoIntegration;

                case (int)IntegratedClient.IntegratedV1:
                    return IntegratedV1;

                case (int)IntegratedClient.IntegratedV3Basic:
                    return IntegratedV3Basic;

                case (int)IntegratedClient.IntegratedV3JWT:
                    return IntegratedV3JWT;

                case (int)IntegratedClient.SOAP:
                    return SOAP;               

                default:
                    return NoIntegration;
            }
        }

        /// <summary>
        /// Get the display string for an enum by it's value in enum form
        /// </summary>
        /// <param name="value">The enum value in enum form</param>
        /// <returns>The display string for the value or the default if one cannot be found</returns>
        public static string GetByEnum(IntegratedClient value)
        {
            return GetByEnum((int)value);
        }
    }
}
