using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPT.Shared.Poco.Model.API
{
    public class OverrideTreatmentPathwayGoalActionStepBaseModel:BaseModel
    {
        public OverrideTreatmentPathwayGoalActionStepBaseModel()
        {

        }

        /// <summary>
        /// Has this record been deleted
        /// </summary>
        [Ignore]
        public bool Deleted { get; set; }

        /// <summary>
        /// The date and time the record was last created
        /// </summary>
        [Ignore]
        public DateTime? DateDeleted  { get; set; }

        /// <summary>
        /// The person ID of the user that updated the record
        /// </summary>
        [Ignore]
        public string UpdatedByUserID { get; set; }
        /// <summary>
        /// The person ID of the user that updated the record
        /// </summary>
        [Ignore]
        public DateTime? DateUpdated { get; set; }
        /// <summary>
        /// The person ID of the user that deleted the record
        /// </summary>
        [Ignore]
        public string DeletedByUserID { get; set; }
    }
}
