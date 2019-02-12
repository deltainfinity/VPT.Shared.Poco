using System;
using System.Collections.Generic;
using System.Text;

namespace VPT.Shared.Poco.DTO.Audit
{
    /// <summary>
    /// DTO to represent the audited changes that happened from an action
    /// </summary>
    public class ChangeRecordDTO
    {
        /// <summary>
        /// The unique ID for this change record
        /// </summary>
        public int ChangeID { get; set; }

        /// <summary>
        /// The audit log entry this change is tied too
        /// </summary>
        public int AuditLogID { get; set; }

        /// <summary>
        /// The state of the data before the action. This should be a XML or JSON serialized representation of the object changed.
        /// </summary>
        public string OriginalValue { get; set; }

        /// <summary>
        /// The state of the data after the action. This should be a XML or JSON serialized representation of the object changed.
        /// </summary>
        public string NewValue { get; set; }
    }
}
