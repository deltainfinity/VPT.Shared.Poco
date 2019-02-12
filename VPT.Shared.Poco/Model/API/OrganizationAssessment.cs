using NPoco;
using VPT.Shared.Poco.DTO.API;

namespace VPT.Shared.Poco.Model.API
{
    [TableName("OrganizationAssessment")]
    [PrimaryKey("OrganizationAssessmentID")]
    public class OrganizationAssessment:BaseModel
    {
        public OrganizationAssessment()
        { }

        public OrganizationAssessment(OrganizationAssessmentDTO source)
            : base(source)
        {
            OrganizationAssessmentID = source.OrganizationAssessmentID;
            OrganizationID = source.OrganizationID;
            AssessmentID = source.AssessmentID;
        }

        /// <summary>
        /// The ID of the Orgnanization Assessment
        /// </summary>
        public int OrganizationAssessmentID { get; set; }

        /// <summary>
        /// The id of Organization
        /// </summary>
        public int OrganizationID { get; set; }

        /// <summary>
        /// The id of Assessment
        /// </summary>
        public int AssessmentID { get; set; }

        /// <summary>
        /// The assessment is primary or not
        /// </summary>
        public bool IsPrimary { get; set; }
    }
}
