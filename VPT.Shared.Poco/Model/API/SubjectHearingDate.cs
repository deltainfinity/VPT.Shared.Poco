
using NPoco;
using System;

namespace VPT.Shared.Poco.Model.API
{
    [TableName("SubjectHearingDate")]
    [PrimaryKey("SubjectHearingDateID")]
    public class SubjectHearingDate
    {
        public SubjectHearingDate()
        { }

        /// <summary>
        /// The unique id of hearing Dates by Each Subject
        /// </summary>
        public int SubjectHearingDateID { get; set; }

        /// <summary>
        /// The subject ExternalID
        /// </summary>
        public string SubjectExternalID { get; set; }

        /// <summary>
        /// The Date Created
        /// </summary>
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// The Hearing Date
        /// </summary>
        public DateTime HearingDate { get; set; }

        /// <summary>
        /// The Hearing Date added date
        /// </summary>
        public DateTime? DateHearingDateAdded { get; set; }
    }
}

