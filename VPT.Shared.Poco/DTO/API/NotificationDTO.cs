using VPT.Shared.Poco.Enum.API;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API
{
    public class NotificationDTO : BaseDTO
    {
        public NotificationDTO()
        { }

        public NotificationDTO(Notification source, int count = 0)
            : base(source)
        {
            NotificationID = source.NotificationID;
            TargetUserID = source.TargetUserID;
            Subject = source.Subject;
            Body = source.Body;
            DateSent = source.DateSent.ToString();
            Viewed = source.Viewed;
            DateViewed = source.DateViewed.HasValue ? source.DateViewed.ToString() : string.Empty;
            RequiresAcknowledgement = source.RequiresAcknowledgement;
            AcknowledgedID = source.Acknowledged;
            DateAcknowledged = source.DateAcknowledged.HasValue ? source.DateAcknowledged.ToString() : string.Empty;
            NotificationTypeID = source.NotificationTypeID;
            SubNotificationTypeID = source.SubNotificationTypeID;
            TotalNotificationCount = count;
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
        public string DateSent { get; set; }

        /// <summary>
        /// Has the message been viewed?
        /// </summary>
        public bool Viewed { get; set; }

        /// <summary>
        /// The date and time the message was viewed
        /// </summary>
        public string DateViewed { get; set; }

        /// <summary>
        /// The message requires acknowledgement
        /// </summary>
        public bool RequiresAcknowledgement { get; set; }

        /// <summary>
        /// The acknowledgement state <see cref="AcknowledgementState"/>
        /// </summary>
        public int AcknowledgedID { get; set; }

        /// <summary>
        /// The acknowledgement state <see cref="AcknowledgementState"/>
        /// </summary>
        public string AcknowledgedName => AcknowledgementStateConstants.GetByEnum(AcknowledgedID);

        /// <summary>
        /// The date and time the message was acknowledged or rejected
        /// </summary>
        public string DateAcknowledged { get; set; }

        /// <summary>
        /// The profile picture of created user
        /// </summary>
        public string ImageSrc { get; set; }

        /// <summary>
        /// NotificationType ID
        /// </summary>
        public int? NotificationTypeID { get; set; }

        /// <summary>
        ///SubNotificationType ID
        /// </summary>
        public int? SubNotificationTypeID { get; set; }

        /// <summary>
        /// Total count of notification for target user
        /// </summary>
        public int TotalNotificationCount { get; set; }
        /// <summary>
        /// Facilitator ID to whom notification corresponds
        /// </summary>
        //public int FacilitatorID { get; set; }
    }

    public class NotificationAcknowledge
    {
        /// <summary>
        /// The notificationId
        /// </summary>
        public int NotificationId { get; set; }

        /// <summary>
        /// Notification Status
        /// </summary>
        public string NotificationAcknowledgement { get; set; }
    }
}
