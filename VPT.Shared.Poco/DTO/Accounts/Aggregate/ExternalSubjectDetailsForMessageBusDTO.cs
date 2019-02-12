using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using VPT.Shared.Poco.DTO.Accounts.Database;
using VPT.Shared.Poco.Model.Accounts.Database;
using System;

namespace VPT.Shared.Poco.DTO.Accounts.Aggregate
{
    /// <summary>
    /// Aggregate object containing all data related to a person
    /// </summary>
    public class ExternalSubjectDetailsForMessageBusDTO: ExternalSubjectDetailsDTO
    {
        /// <summary>
        /// Public Constructor
        /// </summary>
        public ExternalSubjectDetailsForMessageBusDTO()
        { }

        public ExternalSubjectDetailsForMessageBusDTO(ExternalSubjectDetailsDTO externalSubject, string Auth0UserID, string userUniqueId, int organizationID) : base(externalSubject)
        {
            VPTSubjectID = Auth0UserID;            
            Email = externalSubject.Email;
            UserUniqueId = userUniqueId;
            AccountID = organizationID;
        }

        public string VPTSubjectID { get; set; }
        public string UserUniqueId { get; set; }
        public int AccountID { get; set; }

    }

    
}
