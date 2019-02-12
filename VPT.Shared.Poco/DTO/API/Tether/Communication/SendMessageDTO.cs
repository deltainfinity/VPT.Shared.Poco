using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VPT.Shared.Poco.DTO.API.Tether.Communication
{
    public class SendMessageDTO
    {
        public SendMessageDTO() { }

        public SendMessageDTO(SendMessageInputDTO input)
        {
            To = input.To;
            From = input.From;
            OrganizationId = input.OrganizationId;
            ExternalMessages = input.ExternalMessages;
            ApplicationType = input.ApplicationType;
            MessageBody = input.MessageBody;
            TypeOption = input.TypeOption;
            MessageSubject = input.MessageSubject;
            SendOnDate = input.SendOnDate;
        }

        public SendMessageDTO(SendGroupMessageInputDTO input, SubjectDTO toSubject)
        {
            To = new PersonDTO()
            {
                AppId = input.From.AppId,
                Email = toSubject.PrimaryEmail,
                FirstName = toSubject.FirstName,
                LastName = toSubject.LastName,
                MobileNumber = toSubject.PrimaryMobile,
                PersonGuid = toSubject.PersonGUID.ToString()
            };
            From = input.From;
            OrganizationId = input.OrganizationId;
            ExternalMessages = input.ExternalMessages;
            ApplicationType = input.ApplicationType;
            MessageBody = input.MessageBody;
            TypeOption = input.TypeOption;
            MessageSubject = input.MessageSubject;
            SendOnDate = input.SendOnDate;
        }

        [Required]
        public int OrganizationId { get; set; }

        public List<ExternalMessageDTO> ExternalMessages { get; set; }

        [Required]
        public int ApplicationType { get; set; }

        [Required]
        public PersonDTO To { get; set; }

        [Required]
        public PersonDTO From { get; set; }

        [Required]
        public string MessageSubject { get; set; }

        [Required]
        public string MessageBody { get; set; }

        public string TypeOption { get; set; }

        public DateTime? SendOnDate { get; set; }
    }
}
