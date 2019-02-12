using NPoco;
using VPT.Shared.Poco.DTO.API;

namespace VPT.Shared.Poco.Model.API
{
    [TableName("NotificationTemplate")]
    [PrimaryKey("NotificationTemplateID")]
    public class NotificationTemplate
    {
        public NotificationTemplate()
        { }

        public NotificationTemplate(NotificationTemplateDTO source)
        {
            NotificationTemplateID = source.NotificationTemplateID;
            OrganizationID = source.OrganizationID;
            NotificationTypeID = source.NotificationTypeID;
            SubNotificationTypeID = source.SubNotificationTypeID;
            SubjectTemplate = source.SubjectTemplate;
            BodyTemplate = source.BodyTemplate;
        }

        /// <summary>
        /// The ID of the Notification Template 
        /// </summary>
        public int NotificationTemplateID { get; set; }
        /// <summary>
        /// The ID of Organization
        /// </summary>
        public int OrganizationID { get; set; }
        /// <summary>
        /// The ID of notification type
        /// </summary>
        public int NotificationTypeID { get; set; }
        ///<summary>
        ///The ID of subnotification type
        /// </summary>
        public bool SubNotificationTypeID { get; set; }
        ///<summary>
        ///Template of subject
        /// </summary>
        public string SubjectTemplate { get; set; }
        ///<summary>
        ///Template of body
        /// </summary>
        public string BodyTemplate { get; set; }
    }
}
