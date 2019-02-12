using System;

namespace VPT.Shared.Poco.DTO.API.Tether.Communication
{
    public class MessageCountDTO
    {
        public int OrganizationId { get; set; }

        public int State { get; set; }

        public int Direction { get; set; }

        public string For { get; set; }

        public int Status { get; set; }

        public int ApplicationType { get; set; }

        public DateTime? DateStart { get; set; }

        public DateTime? DateEnd { get; set; }
    }
}
