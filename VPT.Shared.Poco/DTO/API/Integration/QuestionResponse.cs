using System.Collections.Generic;

namespace VPT.Shared.Poco.DTO.API.Integration
{
    public class QuestionResponse
    {
        public QuestionResponse()
        {

        }

        public string Question { get; set; }
        public int QuestionId { get; set; }
        public List<ResponseAnswer> Responses { get; set; }
        public string SubTopic { get; set; }
        public string Topic { get; set; }
    }
}