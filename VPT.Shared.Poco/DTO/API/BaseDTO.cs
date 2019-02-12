using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API
{
    public class BaseDTO
    {
        public BaseDTO()
        { }

        public BaseDTO(BaseModel source)
        {
            DateCreated = source.DateCreated.ToShortDateString();
            TimeCreated = source.DateCreated.ToShortTimeString();
            CreatedByUserID = source.CreatedByUserID;

            DateUpdated = source.DateUpdated.HasValue ? source.DateUpdated.Value.ToShortDateString() : string.Empty;
            TimeUpdated = source.DateUpdated.HasValue ? source.DateUpdated.Value.ToShortTimeString() : string.Empty;
            UpdatedByUserID = source.UpdatedByUserID;

            Deleted = source.Deleted;
            DateDeleted = source.DateDeleted.HasValue ? source.DateDeleted.Value.ToShortDateString() : string.Empty;
            TimeUpdated = source.DateDeleted.HasValue ? source.DateDeleted.Value.ToShortTimeString() : string.Empty;
            DeletedByUserID = source.DeletedByUserID;
        }

        /// <summary>
        /// Date the object was created.
        /// </summary>
        [JsonProperty("dateCreated")]
        public string DateCreated { get; set; }

        /// <summary>
        /// Time the object was created.
        /// </summary>
        [JsonProperty("timeCreated")]
        public string TimeCreated { get; set; }

        /// <summary>
        /// The person ID of the user that created this
        /// </summary>
        [JsonProperty("createdByUserID")]
        public string CreatedByUserID { get; set; }

        /// <summary>
        /// The date the record was last updated
        /// </summary>
        [JsonProperty("dateUpdated")]
        public string DateUpdated { get; set; }

        /// <summary>
        /// The time the record was last updated
        /// </summary>
        [JsonProperty("timeUpdated")]
        public string TimeUpdated { get; set; }

        /// <summary>
        /// The person ID of the user that updated the record
        /// </summary>
        [JsonProperty("updatedByUserID")]
        public string UpdatedByUserID { get; set; }

        /// <summary>
        /// Has this record been deleted
        /// </summary>
        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        /// <summary>
        /// The date and time the record was deleted
        /// </summary>
        [JsonProperty("dateDeleted")]
        public string DateDeleted { get; set; }

        /// <summary>
        /// The date and time the record was deleted
        /// </summary>
        [JsonProperty("timeDeleted")]
        public string TimeDeleted { get; set; }

        /// <summary>
        /// The person ID of the user that deleted the record
        /// </summary>
        [JsonProperty("deletedByUserID")]
        public string DeletedByUserID { get; set; }
    }
}
