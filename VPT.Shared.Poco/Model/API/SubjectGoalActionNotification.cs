using NPoco;

namespace VPT.Shared.Poco.Model.API
{
    [TableName("SubjectActionStepNotification")]
    [PrimaryKey("SubjectActionStepNotificationID")]
    public class SubjectGoalActionNotification
    {
        public int SubjectActionStepNotificationID { get; set; }

        public int SubjectGoalActionID { get; set; }

        public int NotificationID { get; set; }
    }
}

