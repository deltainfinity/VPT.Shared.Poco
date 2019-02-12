using System;
using VPT.Shared.Poco.DTO.Accounts.Database;

namespace VPT.Shared.Poco.Model.Accounts.Database
{
    public class BaseDatabaseModel
    {
        public BaseDatabaseModel()
        {
            DateCreated = DateTime.Now;
        }

        public BaseDatabaseModel(BaseDatabaseDTO source)
        {
            DateCreated = DateTime.Parse(source.DateCreated + ' ' + source.TimeCreated);
            CreatedByUserID = source.CreatedByUserID;
            DateUpdated = !string.IsNullOrEmpty(source.DateUpdated) && !string.IsNullOrEmpty(source.TimeUpdated) ? DateTime.Parse(source.DateUpdated + ' ' + source.TimeUpdated) : (DateTime?)null;
            UpdatedByUserID = source.UpdatedByUserID;
            Deleted = source.Deleted;
            DateDeleted = !string.IsNullOrEmpty(source.DateDeleted) && !string.IsNullOrEmpty(source.TimeDeleted) ? DateTime.Parse(source.DateDeleted + ' ' + source.TimeDeleted) : (DateTime?)null;
            DeletedByUserID = source.DeletedByUserID;
        }

        /// <summary>
        /// Date and Time the object was created. This is a required field.
        /// </summary>
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// The ID of the user that created this required
        /// </summary>
        public string CreatedByUserID { get; set; }

        /// <summary>
        /// The date and time the record was last created
        /// </summary>
        public DateTime? DateUpdated { get; set; }

        /// <summary>
        /// The ID of the user that updated the record
        /// </summary>
        public string UpdatedByUserID { get; set; }

        /// <summary>
        /// Has this record been deleted
        /// </summary>
        public bool Deleted { get; set; }

        /// <summary>
        /// The date and time the record was deleted
        /// </summary>
        public DateTime? DateDeleted { get; set; }

        /// <summary>
        /// The ID of the user that deleted the record
        /// </summary>
        public string DeletedByUserID { get; set; }
    }

    /*
     * Due to the way Dapper-Extenstions ClassMapper works mapping has to
     * happen in the implentation of this class
     */
}
