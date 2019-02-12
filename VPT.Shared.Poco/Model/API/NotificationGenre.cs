using NPoco;
using VPT.Shared.Poco.Enum.API;
using VPT.Shared.Poco.DTO.API;

namespace VPT.Shared.Poco.Model.API
{
    [TableName("NotificationType")]
    /// <summary>
    /// Class for representing an end user notificationType
    /// </summary>
    public class NotificationGenre 
    {
        public NotificationGenre()
        { }

        public NotificationGenre(NotificationGenreDTO source)
        {
            NotificationID = source.NotificationID;
            TypeID = source.TypeID;
            Primarykey = source.Primarykey;
        }
        public NotificationGenre(Notification source, int subjectGoalActionID)
        {
            NotificationID = source.NotificationID;
            TypeID = (int)NotificationGenreEnum.ActionStepDueDate;
            Primarykey = subjectGoalActionID;
        }

        /// <summary>
        /// ID of Notification
        /// </summary>
        public int NotificationID { get; set; }

        /// <summary>
        /// ID of Notification Type
        /// </summary>
        public int TypeID { get; set; }

        /// <summary>
        /// Subject Action Step ID
        /// </summary>
        public int Primarykey { get; set; }
    }
}
