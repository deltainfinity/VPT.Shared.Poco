using NPoco;
using System;

namespace VPT.Shared.Poco.Model.API
{
    [TableName("SubjectDrugTest")]
    [PrimaryKey("SubjectDrugTestID")]
    public class SubjectDrugTest
    {
        public SubjectDrugTest()
        { }

        /// <summary>
        /// The unique id of Drug Test by Each Subject
        /// </summary>
        public int SubjectDrugTestID { get; set; }

        /// <summary>
        /// The unique ID for the drug test results in the system of record
        /// </summary>
        public int DrugTestID { get; set; }

        /// <summary>
        /// The subjectId
        /// </summary>
        public int SubjectExternalID { get; set; }

        /// <summary>
        /// The Drug Test Date
        /// </summary>
        public string TestDate { get; set; }

        /// <summary>
        /// The Drug test Created Date 
        /// </summary>
        public DateTime DateCreated { get; set; }
    }
}

