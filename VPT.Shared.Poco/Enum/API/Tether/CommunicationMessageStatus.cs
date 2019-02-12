namespace VPT.Shared.Poco.Enum.API.Tether
{
    public enum  CommunicationMessageStatus
    {
        Read = 0,
        Unread = 1,
        Archived = 2,
        All = 3
    }

    public class CommunicationMessageStatusConstant
    {
        public const string Read = "Read";
        public const string Unread = "Unread";
        public const string Archived = "Archived";
        public const string All = "All";

        public static string GetByEnum(int value)
        {
            switch (value)
            {
                case (int)CommunicationMessageStatus.Read:
                    return Read;

                case (int)CommunicationMessageStatus.Unread:
                    return Unread;

                case (int)CommunicationMessageStatus.Archived:
                    return Archived;

                case (int)CommunicationMessageStatus.All:
                    return All;

                default:
                    return Read;
            }
        }

    }
}
