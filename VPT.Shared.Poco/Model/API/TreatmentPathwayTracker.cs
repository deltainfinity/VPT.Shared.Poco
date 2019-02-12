using NPoco;
using System;

namespace VPT.Shared.Poco.Model.API
{
    /// <summary>
    /// Class for defining a TreatmentPathwayTracker
    /// </summary>
    [TableName("TreatmentPathwayTracker")]
    [PrimaryKey("TreatmentPathwayTrackerID")]
    public class TreatmentPathwayTracker
    {
        public TreatmentPathwayTracker()
        { }

        public int TreatmentPathwayTrackerID { get; set; }

        public string OffenderID { get; set; }

        public int AssessmentID { get; set; }

        public string AssessmentCompletedByExternalId { get; set; }

        public bool Deleted { get; set; }

        public DateTime DateCreated { get; set; }

        public string CreatedByUserID { get; set; }

        public bool DisplayAll { get; set; }
    }
}
