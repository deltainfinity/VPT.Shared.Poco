using System;
using System.Collections.Generic;

namespace VPT.Shared.Poco.DTO.API.Integration
{

    public class AssessmentResultsDTO
    {
        public AssessmentResultsDTO()
        {

        }

        public DateTime Completed { get; set; }
        public string CompletedBy { get; set; }
        public List<CustomField> ExtendedFields { get; set; }
        public List<Need> IdentifiedNeeds { get; set; }
        public string Name { get; set; }
        public int OffenderAssessmentId { get; set; }
        public int OffenderId { get; set; }
        public Dictionary<string, List<QuestionResponse>> QuestionResponses { get; set; }
        public List<ReportSection> ReportMeasurements { get; set; }
        public Dictionary<string, List<QuestionResponse>> RequiredQuestionsUnanswered { get; set; }
        public string riskLevel { get; set; }
        public Dictionary<string, List<Range>> ScoreRanges { get; set; }
        public Dictionary<string, double> Scores { get; set; }
        public Dictionary<int, string> SectionNotes { get; set; }
        public string Status { get; set; }
    }
}
