using NPoco;

namespace VPT.Shared.Poco.Model.API
{
    [TableName("DrugTestResult")]
    [PrimaryKey("DrugTestResultID")]
    public class DrugTestResult
    {
        public DrugTestResult()
        { }

        /// <summary>
        /// The Drug Test Result Id 
        /// </summary>
        public int DrugTestResultID { get; set; }

        /// <summary>
        /// Drug Test Id of Subjects
        /// </summary>
        public int SubjectDrugtestID { get; set; }

        /// <summary>
        /// The unique ID for the drug in the system of record
        /// </summary>
        public string DrugID { get; set; }

        /// <summary>
        /// The medical/legal class of the drug
        /// </summary>
        public string DrugClass { get; set; }

        /// <summary>
        /// The name of the drug
        /// </summary>
        public string Drug { get; set; }

        /// <summary>
        /// The Result of Drug Test
        /// </summary>
        public string  TestResult { get; set;}
    }
}
