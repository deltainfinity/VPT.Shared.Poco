using System;
using System.Globalization;
using Newtonsoft.Json;
using VPT.Shared.Poco.Enum.API;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API
{
    public class ProgramProfileCompleteDTO
    {
        public ProgramProfileCompleteDTO()
        {
        }

        public string ProgramExternalID { get; set; }

        public string ProgramProfileAccepted { get; set; }

        public DateTime ProgramProfileAcceptedDate { get; set; }
    }
}
