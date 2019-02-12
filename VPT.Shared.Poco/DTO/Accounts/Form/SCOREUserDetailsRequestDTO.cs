using System;
using Newtonsoft.Json;

namespace VPT.Shared.Poco.DTO.Accounts.Form
{
    public class SCOREUserDetailsRequestDTO
    {
        // Required by GTL
        // ReSharper disable once InconsistentNaming
        public string booking_id { get; set; }

        // Required by GTL
        // ReSharper disable once InconsistentNaming
        public string site_id { get; set; }
    }
}
