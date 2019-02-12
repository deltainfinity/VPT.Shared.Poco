using System.Collections.Generic;

namespace VPT.Shared.Poco.DTO.API.Integration
{
    public class Question
    {
        public Question()
        {

        }

        public List<Answer> answers;
        public string Comments;
        public string CommentsMarkdown;
        public int DisplayOrder;
        public List<CustomField> ExtendedFields;
        public string field_type;
        public string field_value;
        public List<Answer> field_values;
        public string HelpText;
        public string HelpTextMarkdown;
        public string initialState;
        public bool isAutoAnswered;
        public bool isRequired;
        public string Markdown;
        public int QuestionId;
        public string SectionName;
        public string SubTopic;
        public string Text;
        public string Topic;
    }
}