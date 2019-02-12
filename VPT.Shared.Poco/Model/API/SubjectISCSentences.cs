using NPoco;

namespace VPT.Shared.Poco.Model.API
{
    [TableName("SubjectISCSentences")]
    [PrimaryKey("SubjectISCSentencesID")]
    public class SubjectISCSentences : OverrideTreatmentPathwayGoalActionStepBaseModel
    {
        public SubjectISCSentences()
        { }

        public int SubjectISCSentencesID { get; set; }

        public int SubjectUserID { get; set; }

        public string ExpirationDate { get; set; }

        public string Jurisdiction { get; set; }

        public string ISCStatus { get; set; }

        public string CaseYear { get; set; }

        public string CaseNumber { get; set; }

        public string CountNumber { get; set; }
    }
}
