using System;
using System.Collections.Generic;
using System.Text;

namespace VPT.Shared.Poco.DTO.Audit
{
    /// <summary>
    /// DTO to represent an audit record
    /// </summary>
    public class AuditLogDTO
    {
        public AuditLogDTO()
        {
            ChangedData = new List<ChangeRecordDTO>();
        }

        /// <summary>
        /// The unique ID for the audit log record
        /// </summary>
        public int AuditLogID { get; set; }

        /// <summary>
        /// The module the action occurred in
        /// </summary>
        public string Module { get; set; }

        /// <summary>
        /// The auditable event that happened from the action
        /// </summary>
        public string Event { get; set; }

        /// <summary>
        /// The auditable action that occurred
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// The audited result of the action
        /// </summary>
        public string Result { get; set; }

        /// <summary>
        /// The date and time the action occurred
        /// </summary>
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// The username of the user that performed the action
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// The ID of the user that performed the action. This should be a Auth0UserID, PersonID, or LogonID not a external ID.
        /// </summary>
        public string UserID { get; set; }

        /// <summary>
        /// The IP address of the client device that performed the action.
        /// </summary>
        public string ClientIPAddress { get; set; }

        /// <summary>
        /// All data changed by the action
        /// </summary>
        public IList<ChangeRecordDTO> ChangedData { get; set; }
    }
}
