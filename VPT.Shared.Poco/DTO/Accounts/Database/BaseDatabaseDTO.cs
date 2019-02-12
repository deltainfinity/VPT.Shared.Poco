using Newtonsoft.Json;
using VPT.Shared.Poco.Model.Accounts.Database;

namespace VPT.Shared.Poco.DTO.Accounts.Database
{
    /// <summary>
    /// Base object for all database derived DTOs
    /// </summary>
    public class BaseDatabaseDTO
    {
        /// <summary>
        /// Public Constructor
        /// </summary>
        public BaseDatabaseDTO()
        { }

        /// <summary>
        /// Copy constructor to populate the object
        /// </summary>
        /// <param name="source">The source entity for the object</param>
        public BaseDatabaseDTO(BaseDatabaseModel source)
        {
            DateCreated = source.DateCreated.ToString("d");
            TimeCreated = source.DateCreated.ToString("t");
            CreatedByUserID = source.CreatedByUserID;

            DateUpdated = source.DateUpdated.HasValue ? source.DateUpdated.Value.ToString("d") : string.Empty;
            TimeUpdated = source.DateUpdated.HasValue ? source.DateUpdated.Value.ToString("t") : string.Empty;
            UpdatedByUserID = source.UpdatedByUserID;

            Deleted = source.Deleted;
            DateDeleted = source.DateDeleted.HasValue ? source.DateDeleted.Value.ToString("d") : string.Empty;
            TimeUpdated = source.DateDeleted.HasValue ? source.DateDeleted.Value.ToString("t") : string.Empty;
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
        /// The ID of the user that created this
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
        /// The ID of the user that updated the record
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
        /// The ID of the user that deleted the record
        /// </summary>
        [JsonProperty("deletedByUserID")]
        public string DeletedByUserID { get; set; }
    }
}
