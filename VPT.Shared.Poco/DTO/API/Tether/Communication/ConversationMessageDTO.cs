using System;

namespace VPT.Shared.Poco.DTO.API.Tether.Communication
{
    public class ConversationMessageDTO
    {
        public int OrganizationID { get; set; }
        public int State { get; set; }
        public string Person1GUID { get; set; }
        public string Person2GUID { get; set; }
        public int Status { get; set; }
        public int Order { get; set; }
        public int Page { get; set; }
        public int ItemsPerPage { get; set; }
        public int ApplicationType { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
    }
}
