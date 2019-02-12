using System.Collections.Generic;

namespace VPT.Shared.Poco.DTO.API.Integration
{
    public class Answer
    {
        public Answer()
        {

        }

        public int AnswerId;
        public int DisplayOrder;
        public List<CustomField> ExtendedFields;
        public string groupingTag;
        public string initialState;
        public string InputRegEx;
        public string InputType;
        public bool isSelected;
        public string Label;
        public string maxLength;
        public string parentAnswerId;
        public string Text;
        public List<AnswerAction> toDeselect;
        public List<int> toDisable;
        public List<AnswerAction> toEnable;
        public List<int> toHide;
        public List<AnswerAction> toSelect;
        public List<int> toShow;
    }
}