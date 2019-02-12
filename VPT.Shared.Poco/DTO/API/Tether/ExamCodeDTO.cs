namespace VPT.Shared.Poco.DTO.API.Tether
{
    public class ExamCodeDTO
    {
        public ExamCodeDTO() { }

        public ExamCodeDTO(string code)
        {
            Code = code;
        }

        public string Code { get; set; }
    }
}
