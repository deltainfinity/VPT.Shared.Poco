using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using VPT.Shared.Poco.DTO.Accounts.Database;
using VPT.Shared.Poco.Model.Accounts.Database;
using System;

namespace VPT.Shared.Poco.DTO.Accounts.Aggregate
{
    public class UpdateSecondaryEmailDTO
    {

        /// <summary>
        /// Public Constructor
        /// </summary>
        public UpdateSecondaryEmailDTO()
        { }

        public int userID { get; set; }

        public int organizationID { get; set; }

        public int secondaryEmailType { get; set; }

        public string  secondaryEmail { get; set; }
      
    }
}
