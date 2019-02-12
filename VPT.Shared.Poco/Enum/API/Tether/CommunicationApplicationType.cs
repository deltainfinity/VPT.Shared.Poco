namespace VPT.Shared.Poco.Enum.API.Tether
{
    public enum CommunicationApplicationType
    {
        Notification = 0,
        AdHoc = 1,
        Alert = 2,
        All = 3
    }

    public class CommunicationApplicationTypeConstant
    {
        public const string Notification = "Notification";
        public const string AdHoc = "AdHoc";
        public const string Alert = "Alert";
        public const string All = "All";

        public static string GetByEnum(int value)
        {
            switch (value)
            {
                case (int)CommunicationApplicationType.Notification:
                    return Notification;

                case (int)CommunicationApplicationType.AdHoc:
                    return AdHoc;

                case (int)CommunicationApplicationType.Alert:
                    return Alert;

                case (int)CommunicationApplicationType.All:
                    return All;

                default:
                    return Notification;
            }
        }

    }
}
