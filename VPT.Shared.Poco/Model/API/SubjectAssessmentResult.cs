using NPoco;

namespace VPT.Shared.Poco.Model.API
{
    [PrimaryKey("AssessmentResultId")]
    [TableName("SubjectAssessmentResult")]
    public class SubjectAssessmentResult
    {
        public int AssessmentResultId { get; set; }

        public int SubjectAssessmentId { get; set; }

        public int AssessmentDomainID { get; set; }

        public float? Score { get; set; }

        public string LabelText { get; set; }
    }
}
