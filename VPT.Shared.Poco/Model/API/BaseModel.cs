using System;
using System.Collections.Generic;
using System.Text;
using VPT.Shared.Poco.DTO.API;

namespace VPT.Shared.Poco.Model.API
{
    public class BaseModel
    {
        public BaseModel()
        {
            DateCreated = DateTime.Now;
        }

        public BaseModel(BaseDTO source) : this()
        {

            DateCreated = (!string.IsNullOrEmpty(source.DateCreated) && !string.IsNullOrEmpty(source.TimeCreated)) ? DateTime.Parse(source.DateCreated + ' ' + source.TimeCreated) : DateCreated;
            CreatedByUserID = source.CreatedByUserID;
            DateUpdated = !string.IsNullOrEmpty(source.DateUpdated) && !string.IsNullOrEmpty(source.TimeUpdated) ? DateTime.Parse(source.DateUpdated + ' ' + source.TimeUpdated) : (DateTime?)null;
            UpdatedByUserID = source.UpdatedByUserID;
            Deleted = source.Deleted;
            DateDeleted = !string.IsNullOrEmpty(source.DateDeleted) && !string.IsNullOrEmpty(source.TimeDeleted) ? DateTime.Parse(source.DateDeleted + ' ' + source.TimeDeleted) : (DateTime?)null;
            DeletedByUserID = source.DeletedByUserID;
        }

        /// <summary>
        /// Date and Time the object was created.
        /// </summary>
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// The person ID of the user that created
        /// </summary>
        public string CreatedByUserID { get; set; }

        /// <summary>
        /// The date and time the record was last created
        /// </summary>
        public DateTime? DateUpdated { get; set; }

        /// <summary>
        /// The person ID of the user that updated the record
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
        /// The person ID of the user that deleted the record
        /// </summary>
        public string DeletedByUserID { get; set; }
    }
}
