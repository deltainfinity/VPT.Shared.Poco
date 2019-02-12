namespace VPT.Shared.Poco.Enum.API.Tether
{
    public enum CommunicationDeliveryType
    {
        App = 0,
        Email = 1,
        SMS = 2
    }

    public class CommunicationDeliveryTypeConstant
    {
        public const string App = "App";
        public const string Email = "Email";
        public const string SMS = "SMS";

        public static string GetByEnum(int value)
        {
            switch (value)
            {
                case (int)CommunicationDeliveryType.App:
                    return App;

                case (int)CommunicationDeliveryType.Email:
                    return Email;

                case (int)CommunicationDeliveryType.SMS:
                    return SMS;

                default:
                    return App;
            }
        }


    }
}
