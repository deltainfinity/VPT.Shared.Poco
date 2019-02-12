using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPT.Shared.Poco.DTO.API
{
    public class DrugTestResultDTO
    {
            /// <summary>
            /// The organization Id of the subject
            /// </summary>
            public int SourceOrganizationID { get; set; }

            /// <summary>
            /// The subject external id
            /// </summary>
            public string subjectExternalID { get; set; }

            /// <summary>
            /// The unique ID for the drug test results in the system of record
            /// </summary>
            public string DrugTestID { get; set; }

            /// <summary>
            /// The date and time the drug test was conducted
            /// </summary>
            public string TestDate { get; set; }

            /// <summary>
            /// The name of the site the drug test was conducted at
            /// </summary>
            public string TestSite { get; set; }

            /// <summary>
            /// The list of drugs found in the subject's system
            /// </summary>
            public List<DrugsDTO> Drugs { get; set; }
    }
}
