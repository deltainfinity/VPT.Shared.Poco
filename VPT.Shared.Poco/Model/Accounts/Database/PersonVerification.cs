using NPoco;

namespace VPT.Shared.Poco.Model.Accounts.Database
{
    [TableName("PersonVerification")]
    [PrimaryKey("VerificationQuestionID")]
    public class PersonVerification
    {
        public  PersonVerification()
        { }

        public int VerificationQuestionId { get; set; }
        public int OrganizationId { get; set; }
        public string Question { get; set; }
        public string AnswerSQL { get; set; }
    }
}
