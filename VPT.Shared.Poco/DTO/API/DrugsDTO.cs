using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPT.Shared.Poco.DTO.API
{
    public class DrugsDTO
    {
        /// <summary>
        /// The unique ID for the drug in the system of record
        /// </summary>
        public string DrugID { get; set; }

        /// <summary>
        /// The unique ID for the drug test results in the system of record
        /// </summary>
        public string DrugTestID { get; set; }

        /// <summary>
        /// The medical/legal class of the drug
        /// </summary>
        public string DrugClass { get; set; }

        /// <summary>
        /// The name of the drug
        /// </summary>
        public string Drug { get; set; }

        /// <summary>
        /// The result of the test
        /// </summary>
        public string TestResult { get; set; }
    }
}
