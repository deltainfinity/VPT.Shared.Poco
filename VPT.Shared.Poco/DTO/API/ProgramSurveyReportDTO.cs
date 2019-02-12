using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API
{
    public class ProgramSurveyReportDTO
    {
        public ProgramSurveyReportDTO()
        {

        }
        public ProgramSurveyReportDTO(ProgramSurveyReport source)
        {
            ParentProgramID = source.ParentProgramID;
            UserID = source.UserID;
            QuestionID = source.QuestionID.ToString();
            SubQuestionID = source.SubQuestionID.ToString();
            Answer = source.Answer;
            SurveyDate = source.SurveyDate;
        }

        [JsonProperty("parentProgramID")]
        public int ParentProgramID { get; set; }

        [JsonProperty("userID")]
        public string UserID { get; set; }

        [JsonProperty("questionID")]
        public string QuestionID { get; set; }

        [JsonProperty("subQuestionID")]
        public string SubQuestionID { get; set; }

        [JsonProperty("answer")]
        public string Answer { get; set; }

        [JsonProperty("surveyDate")]
        public DateTime SurveyDate { get; set; }



    }

    public class RootObject
    {
        public List<ProgramSurveyReportDTO> postData { get; set; }
       
    }
}
