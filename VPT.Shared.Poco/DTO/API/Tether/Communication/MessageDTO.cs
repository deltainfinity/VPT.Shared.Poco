using System;
using VPT.Shared.Poco.Enum.API.Tether;

namespace VPT.Shared.Poco.DTO.API.Tether.Communication
{
    public class MessageDTO
    {  
        public string MessageGuid { get; set; }
        public PersonDTO To { get; set; }
        public PersonDTO From { get; set; }
        public int DeliveryType { get; set; }
        public string DeliveryTypeDescription => CommunicationDeliveryTypeConstant.GetByEnum(DeliveryType);
        public int ApplicationType { get; set; }
        public string ApplicationTypeDescription => CommunicationApplicationTypeConstant.GetByEnum(ApplicationType);
        public int MessageStatus { get; set; }
        public string MessageStatusDescription => CommunicationMessageStatusConstant.GetByEnum(MessageStatus);
        public int MessageDirection { get; set; }
        public string MessageDirectionDescription => CommunicationMessageDirectionConstant.GetByEnum(MessageDirection);
        public DateTime? DateSent { get; set; }
        public DateTime? DateReceived { get; set; }
        public DateTime? DateRead { get; set; }
        public DateTime? DateArchived { get; set; }
        public string MessageSubject { get; set; }
        public string MessageBody { get; set; }
        public string CallToAction { get; set; }
    }
}
