using System;
using System.Globalization;
using Newtonsoft.Json;
using VPT.Shared.Poco.Enum.API;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API
{
    public class CompletedCaseplanMessageDTO
    {
        public CompletedCaseplanMessageDTO()
        {
        }

        public string SubjectExternalID { get; set; }

        public int CasePlanID { get; set; }

        public DateTime DateCompleted { get; set; }
    }
}
