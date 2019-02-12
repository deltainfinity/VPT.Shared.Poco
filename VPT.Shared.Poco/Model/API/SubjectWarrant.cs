using NPoco;

namespace VPT.Shared.Poco.Model.API
{
    [TableName("SubjectWarrants")]
    [PrimaryKey("SubjectWarrantsID")]
    public class SubjectWarrant : OverrideTreatmentPathwayGoalActionStepBaseModel
    {
        public SubjectWarrant()
        { }

        /// <summary>
        /// The ID of the Subject Warrants ID 
        /// </summary>
        public int SubjectWarrantsID { get; set; }

        /// <summary>
        /// The SubjectUserID
        /// </summary>
        public int SubjectUserID { get; set; }

        /// <summary>
        /// The Warrant Issue Date
        /// </summary>
        public string WarrantIssueDate { get; set; }

        /// <summary>
        /// The Warrant Number
        /// </summary>
        public string WarrantNumber { get; set; }

        /// <summary>
        /// The Warrant Type
        /// </summary>
        public string WarrantType { get; set; }

        /// <summary>
        /// The Warrant Status Code
        /// </summary>
        public string WarrantStatusCode { get; set; }

        /// <summary>
        /// The Warrant Status
        /// </summary>
        public string WarrantStatus { get; set; }
    }
}
