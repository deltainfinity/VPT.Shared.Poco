using NPoco;
using System;
using VPT.Shared.Poco.DTO.API;

namespace VPT.Shared.Poco.Model.API
{
    [TableName("Notification")]
    [PrimaryKey("NotificationID")]
    /// <summary>
    /// Class for representing an end user notification message
    /// </summary>
    public class Notification : BaseModel
    {
        public Notification()
        { }

        public Notification(NotificationDTO source)
            : base(source)
        {
            NotificationID = source.NotificationID;
            TargetUserID = source.TargetUserID;
            Subject = source.Subject;
            Body = source.Body;
            DateSent = !string.IsNullOrEmpty(source.DateSent) ? DateTime.Parse(source.DateSent) : DateTime.Now;
            Viewed = source.Viewed;
            DateViewed = !string.IsNullOrEmpty(source.DateViewed) ? DateTime.Parse(source.DateViewed) : (DateTime?)null;
            RequiresAcknowledgement = source.RequiresAcknowledgement;
            Acknowledged = source.AcknowledgedID;
            DateAcknowledged = !string.IsNullOrEmpty(source.DateAcknowledged) ? DateTime.Parse(source.DateAcknowledged) : (DateTime?)null;
            NotificationTypeID = source.NotificationTypeID;
            SubNotificationTypeID = source.SubNotificationTypeID;

        }

        /// <summary>
        /// To create the notification for facilitators of Action Step that is Past Due.
        /// </summary>
        /// <param name="targetUserID"> User ID of the target</param>
        /// <param name="subject"> Subject of the notification</param>
        /// <param name="body"> The content of the Body</param>
        /// <param name="requiresAcknowledgement"> A bool value to know if Acknowledgement is requires or not.</param>
        /// <param name="notificationTypeID"></param>
        /// <param name="subNotificationTypeID"></param>
        public Notification(int targetUserID, string subject, string body, bool requiresAcknowledgement, int notificationTypeID, int subNotificationTypeID)
        {
            TargetUserID = targetUserID.ToString();
            Subject = subject;
            Body = body;
            DateSent = DateTime.Now;
            DateCreated = DateTime.Now;
            RequiresAcknowledgement = requiresAcknowledgement;
            NotificationTypeID = notificationTypeID;
            SubNotificationTypeID = subNotificationTypeID;
        }

        /// <summary>
        /// The identity for the record
        /// </summary>
        public int NotificationID { get; set; }

        /// <summary>
        /// The person ID of the user the message is targeted too.
        /// </summary>
        public string TargetUserID { get; set; }

        /// <summary>
        /// The Subject of the message
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// The Body of the message
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// The date and time the message was sent
        /// </summary>
        public DateTime DateSent { get; set; }

        /// <summary>
        /// Has the message been viewed?
        /// </summary>
        public bool Viewed { get; set; }

        /// <summary>
        /// The date and time the message was viewed
        /// </summary>
        public DateTime? DateViewed { get; set; }

        /// <summary>
        /// The message requires acknowledgement
        /// </summary>
        public bool RequiresAcknowledgement { get; set; }

        /// <summary>
        /// The acknowledgement state AcknowledgementState/>
        /// </summary>
        public int Acknowledged { get; set; }

        /// <summary>
        /// The date and time the message was acknowledged or rejected
        /// </summary>
        public DateTime? DateAcknowledged { get; set; }

        /// <summary>
        /// NotificationType ID
        /// </summary>
        public int? NotificationTypeID { get; set; }

        /// <summary>
        /// SubNotificationType ID
        /// </summary>
        public int? SubNotificationTypeID { get; set; }
    }
}
