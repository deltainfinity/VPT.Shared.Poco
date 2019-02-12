using System;
using System.Collections.Generic;
using System.Linq;
using VPT.Shared.Poco.Enum.API;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API
{
   public class ProfileLabelDTO
    {
        public ProfileLabelDTO()
        {

        }

        public int ProfileLabelID { get; set; }

        public string Name { get; set; }

        public string Label { get; set; }

        public bool IsHidden { get; set; }

        public bool IsDefault { get; set; }

    }
}
