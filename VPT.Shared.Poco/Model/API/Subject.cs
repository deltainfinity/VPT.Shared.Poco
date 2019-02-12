using NPoco;
using System;
using VPT.Shared.Poco.DTO.API;

namespace VPT.Shared.Poco.Model.API
{
    [TableName("Subject")]
    [PrimaryKey("SubjectUserID", AutoIncrement = false)]
    public class Subject : BaseModel
    {
        public Subject()
        { }

        public Subject(SubjectDTO source)
            : base(source)
        {
            DateTime releaseDate;
            SubjectUserID = source.SubjectUserID;
            FacilityID = source.FacilityID;
            EstimatedReleaseDate = !string.IsNullOrEmpty(source.EstimatedReleaseDate) && DateTime.TryParse(source.EstimatedReleaseDate, out releaseDate)? releaseDate : (DateTime?)null;           
            CaseManagerID = source.CaseManagerID;
            PendingCharges = source.PendingCharges;
            SexOffenderType = source.SexOffenderType;
            CaseType = source.CaseType;
            FacilityCode = source.FacilityCode;
            CustodyLevel = source.CustodyLevel;
            SupervisionLevel = source.SupervisionLevel;
            OffenderSiteType = source.OffenderSiteType;
            OverallRisk = source.OverallRisk;
            GTLSiteID = source.GTLSiteID;
        }

        /// <summary>
        /// The person ID for the subject
        /// </summary>
        public int SubjectUserID { get; set; }

        /// <summary>
        /// The subject validation pin for new program/job linkages
        /// </summary>
        public int FacilityID { get; set; }

        /// <summary>
        /// The estimated release date for the subject
        /// </summary>
        public DateTime? EstimatedReleaseDate { get; set; }
        /// <summary>
        /// The primary case manager id
        /// </summary>
        public string CaseManagerID { get; set; }

        /// <summary>
        /// The CustodyLevel
        /// </summary>
        public string CustodyLevel { get; set; }

        /// <summary>
        /// The SupervisionLevel
        /// </summary>
        public string SupervisionLevel { get; set; }

        /// <summary>
        /// The PendingCharges
        /// </summary>
        public string PendingCharges { get; set; }

        /// <summary>
        /// The SexOffenderType
        /// </summary>
        public string SexOffenderType { get; set; }

        /// <summary>
        /// The CaseType
        /// </summary>
        public string CaseType { get; set; }

        /// <summary>
        /// The FacilityCode
        /// </summary>
        public string FacilityCode { get; set; }

        /// <summary>
        /// The OffenderSiteType
        /// </summary>
        public string OffenderSiteType { get; set; }

        /// <summary>
        /// The Overall Risk
        /// </summary>
        public string OverallRisk { get; set; }

        /// <summary>
        /// GTL Site ID
        /// </summary>
        public string GTLSiteID { get; set; }
    }
}
