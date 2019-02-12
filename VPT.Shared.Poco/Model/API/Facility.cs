using NPoco;
using System;
using VPT.Shared.Poco.DTO.API;

namespace VPT.Shared.Poco.Model.API
{
    [TableName("facility")]
    [PrimaryKey("FacilityID")]
    public class Facility 
    {
        public Facility()
        { }

        public Facility(FacilityDTO source)
        {
            FacilityID = source.FacilityID;
            FacilityCode = source.FacilityCode;
            FacilityName = source.FacilityName;
            Description = source.Description;
            OrganizationID = source.OrganizationID;
        }

        /// <summary>
        /// The id of facility.
        /// </summary>
        public int FacilityID { get; set; }

        /// <summary>
        /// The name of facility.
        /// </summary>
        public string FacilityName { get; set; }

        /// <summary>
        /// The facility Code
        /// </summary>
        public string FacilityCode { get; set; }

        /// <summary>
        /// The Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The id of  organization
        /// </summary>
        public int OrganizationID { get; set; }

        /// <summary>
        /// The security level
        /// </summary>
        [ResultColumn]
        public string SecurityLevel { get; internal set; }

        /// <summary>
        /// The flag to indicate prison or not
        /// </summary>
        public bool IsPrison { get; internal set; }

        /// <summary>
        /// Has this record been deleted.
        /// </summary>
        public bool Deleted { get; set; }

        /// <summary>
        /// Date and Time the object was created.
        /// </summary>
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// The person ID of the user that created.
        /// </summary>
        public string CreatedByUserID { get; set; }

        /// <summary>
        /// The date and time the record was last created.
        /// </summary>
        public DateTime? DateUpdated { get; set; }

        /// <summary>
        /// The person ID of the user that updated the record.
        /// </summary>
        public string UpdatedByUserID { get; set; }

        /// <summary>
        /// The date and time the record was deleted.
        /// </summary>
        public DateTime? DateDeleted { get; set; }

        /// <summary>
        /// The person ID of the user that deleted the record.
        /// </summary>
        public string DeletedByUserID { get; set; }
    }
}
