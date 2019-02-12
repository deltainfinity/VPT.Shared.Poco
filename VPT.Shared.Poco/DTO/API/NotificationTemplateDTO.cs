using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API
{
    public class NotificationTemplateDTO 
    {
        public NotificationTemplateDTO(NotificationTemplate source)
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
        [JsonProperty("notificationTemplateID")]
        public int NotificationTemplateID { get; set; }
        /// <summary>
        /// The ID of Organization
        /// </summary>
        [JsonProperty("organizationID")]
        public int OrganizationID { get; set; }
        /// <summary>
        /// The ID of notification type
        /// </summary>
        [JsonProperty("notificationTypeID")]
        public int NotificationTypeID { get; set; }
        ///<summary>
        ///The ID of subnotification type
        /// </summary>
        [JsonProperty("subNotificationTypeID")]
        public bool SubNotificationTypeID { get; set; }
        ///<summary>
        ///Template of subject
        /// </summary>
        [JsonProperty("subjectTemplate")]
        public string SubjectTemplate { get; set; }
        ///<summary>
        ///Template of body
        /// </summary>
        [JsonProperty("bodyTemplate")]
        public string BodyTemplate { get; set; }
    }
}