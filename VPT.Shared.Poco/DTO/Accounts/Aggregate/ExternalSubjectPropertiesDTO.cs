using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using VPT.Shared.Poco.DTO.Accounts.Database;
using VPT.Shared.Poco.Model.Accounts.Database;
using System;
using VPT.Shared.Poco.Enum.Accounts;

namespace VPT.Shared.Poco.DTO.Accounts.Aggregate
{
    /// <summary>
    /// Aggregate object containing all data related to a subjects properties
    /// </summary>
    public class ExternalSubjectPropertiesDTO
    {
        /// <summary>
        /// Public Constructor
        /// </summary>
        public ExternalSubjectPropertiesDTO()
        { }

        public string Field1 { get; set; }
        public string Field2 { get; set; }
        public string Field3 { get; set; }
        public string Field4 { get; set; }
    }
}
