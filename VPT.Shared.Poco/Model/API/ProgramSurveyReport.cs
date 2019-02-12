using NPoco;
using System;
using VPT.Shared.Poco.DTO.API;

namespace VPT.Shared.Poco.Model.API
{
    [TableName("ProgramSurveyReport")]
    [PrimaryKey("SurveyReportID")]
    public class ProgramSurveyReport
    {
        public ProgramSurveyReport()
        { }

        public ProgramSurveyReport(ProgramSurveyReportDTO source)
        {
            ParentProgramID = source.ParentProgramID;
            UserID = source.UserID;
            QuestionID = Convert.ToInt32(source.QuestionID);
            SubQuestionID = Convert.ToInt32(source.SubQuestionID);
            Answer = source.Answer;
            SurveyDate = source.SurveyDate;
        }

        public int SurveyReportID { get; set; }

        public int ParentProgramID { get; set; }

        public string UserID { get; set; }

        public int QuestionID { get; set; }

        public int SubQuestionID { get; set; }

        public string Answer { get; set; }

        public DateTime SurveyDate { get; set; }
    }
}
