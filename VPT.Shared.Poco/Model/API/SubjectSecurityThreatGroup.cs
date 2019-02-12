using NPoco;

namespace VPT.Shared.Poco.Model.API
{
    [TableName("SubjectSecurityThreatGroup")]
    [PrimaryKey("SubjectSecurityThreatGroupID")]
    public class SubjectSecurityThreatGroup : OverrideTreatmentPathwayGoalActionStepBaseModel
    {
        public SubjectSecurityThreatGroup()
        { }

        /// <summary>
        /// The ID of the Subject Security Threat GroupID
        /// </summary>
        public int SubjectSecurityThreatGroupID { get; set; }

        /// <summary>
        /// The SubjectUserID
        /// </summary>
        public int SubjectUserID { get; set; }

        /// <summary>
        /// The Security Threat GroupId
        /// </summary>
        public string SecurityThreatGroupId { get; set; }

        /// <summary>
        /// The Staff Security Threat Group Name
        /// </summary>
        public string SecurityThreatGroupName { get; set; }

        /// <summary>
        /// The Security Threat Group Assessment
        /// </summary>
        public string SecurityThreatGroupAssessment { get; set; }

        public string SecurityThreatGroupRank { get; set; }

        public string SecurityThreatGroupStatus { get; set; }

        public string SecurityThreatGroupStatusDate { get; set; }
    }
}
