using System;
using System.Collections.Generic;

namespace VPT.Shared.Poco.DTO.API.Tether.Communication
{
    public class MessageHeaderDTO
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public MessageHeaderDTO()
        { }

        public string MessageGuid { get; set; }
        public PersonDTO To { get; set; }
        public PersonDTO From { get; set; }
        public List<MessageHeaderDTO> ExternalMessages { get; set; }
        public int DeliveryType { get; set; }
        public string DeliveryTypeDescription { get; set; }
        public int ApplicationType { get; set; }
        public string ApplicationTypeDescription { get; set; }
        public int MessageStatus { get; set; }
        public string MessageStatusDescription { get; set; }
        public DateTime? DateSent { get; set; }
        public DateTime? DateReceived { get; set; }
        public DateTime? DateRead { get; set; }
        public DateTime? DateArchived { get; set; }
        public string MessageSubject { get; set; }
        public string MessageBrief { get; set; }
    }
}
