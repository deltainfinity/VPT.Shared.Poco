using System;
using System.Collections.Generic;

namespace VPT.Shared.Poco.DTO.API.Tether.Communication
{
    /// <summary>
    /// Group Message data
    /// </summary>
    public class SendGroupMessageInputDTO
    {
        /// <summary>
        /// Organization ID of the organization that the message is being sent within
        /// </summary>
        public int OrganizationId { get; set; }

        /// <summary>
        /// List of external messages associated with the in-app message
        /// </summary>
        public List<ExternalMessageDTO> ExternalMessages { get; set; }

        /// <summary>
        /// The type of message being sent, from application type enum
        /// </summary>
        public int ApplicationType { get; set; }

        /// <summary>
        /// The person ID of the user sending the message
        /// </summary>
        public int FromPersonId { get; set; }

        /// <summary>
        /// The person details of the person sending the message
        /// </summary>
        public PersonDTO From { get; set; }

        /// <summary>
        /// The message subject
        /// </summary>
        public string MessageSubject { get; set; }

        /// <summary>
        /// Message
        /// </summary>
        public string MessageBody { get; set; }

        /// <summary>
        /// Type option
        /// </summary>
        public string TypeOption { get; set; }

        /// <summary>
        /// Optional date in the future to schedule the message to be sent on
        /// </summary>
        public DateTime? SendOnDate { get; set; }
    }
}
