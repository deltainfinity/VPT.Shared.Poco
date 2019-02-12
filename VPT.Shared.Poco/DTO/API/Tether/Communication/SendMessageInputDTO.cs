using System;
using System.Collections.Generic;

namespace VPT.Shared.Poco.DTO.API.Tether.Communication
{
    public class SendMessageInputDTO
    {
        public int OrganizationId { get; set; }

        public List<ExternalMessageDTO> ExternalMessages { get; set; }

        public int ApplicationType { get; set; }

        public int ToPersonId { get; set; }

        public PersonDTO To { get; set; }

        public int FromPersonId { get; set; }

        public PersonDTO From { get; set; }

        public string MessageSubject { get; set; }

        public string MessageBody { get; set; }

        public string TypeOption { get; set; }

        public DateTime? SendOnDate { get; set; }
    }
}
