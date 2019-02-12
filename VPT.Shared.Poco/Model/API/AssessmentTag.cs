using NPoco;

namespace VPT.Shared.Poco.Model.API
{
    [TableName("AssessmentDomainId")]
    [PrimaryKey("AssessmentDomainId")]
    public class AssessmentDomain
    {
        /// <summary>
        /// id of assessment domain  
        /// </summary>
        public int AssessmentDomainId { get; set; }

        /// <summary>
        /// id of assessment  
        /// </summary>
        public int AssessmentId { get; set; }

        /// <summary>
        /// name of assessment
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// minimum score of assesment
        /// </summary>
        public int ScoreMinimum { get; set; }

        /// <summary>
        /// maximum score of assesment
        /// </summary>
        public int ScoreMaximum { get; set; }
    }
}
